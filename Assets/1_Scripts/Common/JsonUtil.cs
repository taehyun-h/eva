﻿using UnityEngine;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using Newtonsoft.Json;

public class MasterJsonConverter : JsonConverter
{
    private static readonly Dictionary<Type, Func<object, string>> WriteFormatter = new Dictionary<Type, Func<object, string>>();

    public static void AddWriteFormatter(Type type, Func<object, string> formatter)
    {
        WriteFormatter[type] = formatter;
    }

    public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
    {
        if (value == null) return;

        var formatter = WriteFormatter[value.GetType()];
        writer.WriteRawValue(formatter(value));
    }

    public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
    {
        throw new NotImplementedException("Unnecessary because CanRead is false. The type will skip the converter.");
    }

    public override bool CanRead => false;

    public override bool CanConvert(Type objectType)
    {
        return WriteFormatter.ContainsKey(objectType);
    }
}

public static class JsonUtil
{
    private static readonly MasterJsonConverter MasterJsonConverter = new MasterJsonConverter();

    static JsonUtil()
    {
        MasterJsonConverter.AddWriteFormatter(typeof(Vector3), Vector3WriteFormatter);
    }

    private static string Vector3WriteFormatter(object value)
    {
        var vector3Value = (Vector3) value;
        return $"{{\"x\":{vector3Value.x}, \"y\":{vector3Value.y}, \"z\":{vector3Value.z}}}";
    }

    public static string SerializeObject(object value)
    {
        return JsonConvert.SerializeObject(value, MasterJsonConverter);
    }

    public static string SerializeObjectWithIndentation(object value)
    {
        var stringWriter = new StringWriter(new StringBuilder(256), CultureInfo.InvariantCulture);
        using (var jsonTextWriter = new JsonTextWriter(stringWriter))
        {
            jsonTextWriter.Formatting = Formatting.Indented;
            jsonTextWriter.IndentChar = ' ';
            jsonTextWriter.Indentation = 4;

            var serializer = new JsonSerializer();
            serializer.Converters.Add(MasterJsonConverter);
            serializer.Serialize(jsonTextWriter, value);
        }

        return stringWriter.ToString();
    }

    public static T DeserializeObject<T>(string value)
    {
        return JsonConvert.DeserializeObject<T>(value);
    }

    public static object DeserializeObject(string value)
    {
        return JsonConvert.DeserializeObject(value);
    }

    public static object DeserializeObject(string value, Type type)
    {
        return JsonConvert.DeserializeObject(value, type);
    }
}
