using System.Text;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using Debug = UnityEngine.Debug;

public class D
{
    private const string Flag = "USE_LOG";

    private static StringBuilder _stringBuilder = new StringBuilder();

    [Conditional(Flag)]
    public static void Log(object message)
    {
        Debug.Log(message);
    }

    [Conditional(Flag)]
    public static void Log(object message, Object context)
    {
        Debug.Log(message, context);
    }

    // Don't use this method in production. Use only in test.
    [Conditional(Flag)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void LogCallMethodName(params object[] args)
    {
        var st = new StackTrace();
        var sf = st.GetFrame(1);

        LogPack(sf.GetMethod().Name, LogConcat(args));
    }

    // Don't use this method in production. Use only in test.
    [Conditional(Flag)]
    public static void LogMethod(object message = null)
    {
        if (message == null)
        {
            message = string.Empty;
        }

        var st = new StackTrace();
        var sf = st.GetFrame(1);
        var declaringType = sf.GetMethod().DeclaringType;
        if (declaringType != null)
        {
            Debug.Log($"[{declaringType.Name}::{sf.GetMethod().Name}] {message}");
        }
        else
        {
            LogPack($"[{sf.GetMethod().Name}] {message}");
        }
    }

    [Conditional(Flag)]
    public static void LogPack(params object[] args)
    {
        Debug.Log(LogConcat(args));
    }

    [Conditional(Flag)]
    public static void LogPackContext(Object context, params object[] args)
    {
        Log(LogConcat(args), context);
    }

    [Conditional(Flag)]
    public static void LogFormat(string format, params object[] args)
    {
        Debug.LogFormat(format, args);
    }

    [Conditional(Flag)]
    public static void Warning(object message)
    {
        Debug.LogWarning(message);
    }

    [Conditional(Flag)]
    public static void Warning(object message, Object context)
    {
        Debug.LogWarning(message, context);
    }

    [Conditional(Flag)]
    public static void WarningPack(params object[] args)
    {
        Debug.LogWarning(LogConcat(args));
    }

    [Conditional(Flag)]
    public static void WarningFormat(string format, params object[] args)
    {
        Debug.LogWarningFormat(format, args);
    }

    [Conditional(Flag)]
    public static void Error(object message)
    {
        Debug.LogError(message);
    }

    [Conditional(Flag)]
    public static void Error(object message, Object context)
    {
        Debug.LogError(message, context);
    }

    [Conditional(Flag)]
    public static void ErrorPack(params object[] args)
    {
        Debug.LogError(LogConcat(args));
    }

    [Conditional(Flag)]
    public static void ErrorFormat(string format, params object[] args)
    {
        Debug.LogErrorFormat(format, args);
    }

    [Conditional(Flag)]
    public static void Assert(bool condition)
    {
        Debug.Assert(condition);
    }

    private static string LogConcat(params object[] args)
    {
        lock (_stringBuilder)
        {
            if (args == null || args.Length == 0)
            {
                return string.Empty;
            }

            if (args.Length == 1)
            {
                return args[0].ToString();
            }

            _stringBuilder.Length = 0;
            _stringBuilder.Append("[");
            for (int i = 0; i < args.Length; i++)
            {
                if (i != 0)
                {
                    _stringBuilder.Append(", ");
                }

                if (args[i] is string)
                {
                    _stringBuilder.Append($"\"{args[i]}\"");
                }
                else
                {
                    _stringBuilder.Append($"{args[i]}");
                }
            }
            _stringBuilder.Append("]");
            return _stringBuilder.ToString();
        }
    }
}
