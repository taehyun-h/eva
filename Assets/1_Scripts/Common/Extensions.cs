using System.Collections.Generic;

public static class KeyValuePairExtensions
{
    public static void Deconstruct<T1, T2>(this KeyValuePair<T1, T2> tuple, out T1 key, out T2 value)
    {
        key = tuple.Key;
        value = tuple.Value;
    }
}

public static class DictionaryExtensions
{
    public static TValue TryGetValueOrDefaultValue<TKey, TValue>(this Dictionary<TKey, TValue> thiz, TKey key)
    {
        return thiz.TryGetValue(key, out var value) ? value : default(TValue);
    }
}
