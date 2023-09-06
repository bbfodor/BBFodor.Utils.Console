namespace BBFodor.Utils.Console;


public static class Console
{
    public static void PrintLn<T>(IEnumerable<T> enumerable, string? postfix = default)
    {
        Print(enumerable);
        if (postfix != default)
            System.Console.WriteLine(FormatPostfix(postfix));
        else
            PrintLn();
    }
    public static void PrintLn<T>(string prefix, IEnumerable<T> enumerable, string? postfix = default)
    {
        Print(FormatPrefix(prefix));
        Print(enumerable);
        if (postfix != default)
            System.Console.WriteLine(FormatPostfix(postfix));
        else
            PrintLn();
    }

    public static void PrintLn<T>(T[] arr, string? postfix = default)
    {
        Print(arr);
        if (postfix != default)
            System.Console.WriteLine(FormatPostfix(postfix));
        else
            PrintLn();
    }
    public static void PrintLn<T>(string prefix, T[] arr, string? postfix = default)
    {
        Print(FormatPrefix(prefix));
        Print(arr);
        if (postfix != default)
            System.Console.WriteLine(FormatPostfix(postfix));
        else
            PrintLn();
    }

    public static void PrintLn(Array arr, string? postfix = default)
    {
        Print(arr);
        if (postfix != default)
            System.Console.WriteLine(FormatPostfix(postfix));
        else
            PrintLn();
    }
    public static void PrintLn(string prefix, Array arr, string? postfix = default)
    {
        Print(FormatPrefix(prefix));
        Print(arr);
        if (postfix != default)
            System.Console.WriteLine(FormatPostfix(postfix));
        else
            PrintLn();
    }

    public static void PrintLn<T>(List<T> ls, string? postfix = default)
    {
        Print(ls);
        if (postfix != default)
            System.Console.WriteLine(FormatPostfix(postfix));
        else
            PrintLn();
    }
    public static void PrintLn<T>(string prefix, List<T> ls, string? postfix = default)
    {
        Print(FormatPrefix(prefix));
        Print(ls);
        if (postfix != default)
            System.Console.WriteLine(FormatPostfix(postfix));
        else
            PrintLn();
    }

    public static void PrintLn<T>(HashSet<T> hs, string? postfix = default)
    {
        Print(hs);
        if (postfix != default)
            System.Console.WriteLine(FormatPostfix(postfix));
        else
            PrintLn();
    }
    public static void PrintLn<T>(string prefix, HashSet<T> hs, string? postfix = default)
    {
        Print(FormatPrefix(prefix));
        Print(hs);
        if (postfix != default)
            System.Console.WriteLine(FormatPostfix(postfix));
        else
            PrintLn();
    }

    public static void PrintLn<T, K>(Dictionary<T, K> dt, string? postfix = default) where T : notnull
    {
        Print(dt);
        if (postfix != default)
            System.Console.WriteLine(FormatPostfix(postfix));
        else
            PrintLn();
    }
    public static void PrintLn<T, K>(string prefix, Dictionary<T, K> dt, string? postfix = default) where T : notnull
    {
        Print(FormatPrefix(prefix));
        Print(dt);
        if (postfix != default)
            System.Console.WriteLine(FormatPostfix(postfix));
        else
            PrintLn();
    }

    public static void PrintLn<T>(T value, string? postfix = default)
    {
        Print(value);
        if (postfix != default)
            System.Console.WriteLine(FormatPostfix(postfix));
        else
            PrintLn();
    }
    public static void PrintLn<T>(string prefix, T value, string? postfix = default)
    {
        Print(FormatPrefix(prefix));
        Print(value);
        if (postfix != default)
            System.Console.WriteLine(FormatPostfix(postfix));
        else
            PrintLn();
    }

    public static void PrintLn()
    {
        System.Console.WriteLine();
    }

    public static void Print<T>(IEnumerable<T> enumerable, string? postfix = default)
    {
        System.Console.Write(Join(enumerable));
        if (postfix != default)
            Print(FormatPostfix(postfix));
    }
    public static void Print<T>(string prefix, IEnumerable<T> enumerable, string? postfix = default)
    {
        Print(FormatPrefix(prefix));
        System.Console.Write(Join(enumerable));
        if (postfix != default)
            Print(FormatPostfix(postfix));
    }

    public static void Print<T>(T[] arr, string? postfix = default)
    {
        System.Console.Write(Join(arr));
        if (postfix != default)
            Print(FormatPostfix(postfix));
    }
    public static void Print<T>(string prefix, T[] arr, string? postfix = default)
    {
        Print(FormatPrefix(prefix));
        System.Console.Write(Join(arr));
        if (postfix != default)
            Print(FormatPostfix(postfix));
    }

    public static void Print(Array arr, string? postfix = default)
    {
        System.Console.Write(Join(arr));
        if (postfix != default)
            Print(FormatPostfix(postfix));
    }
    public static void Print(string prefix, Array arr, string? postfix = default)
    {
        Print(FormatPrefix(prefix));
        System.Console.Write(Join(arr));
        if (postfix != default)
            Print(FormatPostfix(postfix));
    }

    public static void Print<T>(List<T> ls, string? postfix = default)
    {
        System.Console.Write(Join(ls));
        if (postfix != default)
            Print(FormatPostfix(postfix));
    }
    public static void Print<T>(string prefix, List<T> ls, string? postfix = default)
    {
        Print(FormatPrefix(prefix));
        System.Console.Write(Join(ls));
        if (postfix != default)
            Print(FormatPostfix(postfix));
    }

    public static void Print<T>(HashSet<T> hs, string? postfix = default)
    {
        System.Console.Write(Join(hs));
        if (postfix != default)
            Print(FormatPostfix(postfix));
    }
    public static void Print<T>(string prefix, HashSet<T> hs, string? postfix = default)
    {
        Print(FormatPrefix(prefix));
        System.Console.Write(Join(hs));
        if (postfix != default)
            Print(FormatPostfix(postfix));
    }

    public static void Print<T, K>(Dictionary<T, K> dt, string? postfix = default) where T : notnull
    {
        System.Console.Write(Join(dt));
        if (postfix != default)
            Print(FormatPostfix(postfix));
    }
    public static void Print<T, K>(string prefix, Dictionary<T, K> dt, string? postfix = default) where T : notnull
    {
        Print(FormatPrefix(prefix));
        System.Console.Write(Join(dt));
        if (postfix != default)
            Print(FormatPostfix(postfix));
    }

    public static void Print<T>(T value, string? postfix = default)
    {
        System.Console.Write(value);
        if (postfix != default)
            Print(FormatPostfix(postfix));
    }
    public static void Print<T>(string prefix, T value, string? postfix = default)
    {
        Print(FormatPrefix(prefix));
        System.Console.Write(value);
        if (postfix != default)
            Print(FormatPostfix(postfix));
    }

    public static void Print()
    {
        System.Console.WriteLine();
    }

    public static string Join<T>(IEnumerable<T> enumerable)
    {
        return $"({string.Join(", ", enumerable)})";
    }
    public static string Join<T>(T[] arr)
    {
        return $"[{string.Join(", ", arr)}]";
    }
    public static string Join(Array arr)
    {
        return $"[{string.Join(", ", arr.OfType<object>())}]";
    }
    public static string Join<T>(List<T> ls)
    {
        return $"[{string.Join(", ", ls)}]";
    }
    public static string Join<T>(HashSet<T> hs)
    {
        return $"{{{string.Join(", ", hs)}}}";
    }
    public static string Join<T, K>(Dictionary<T, K> dt) where T : notnull
    {
        return $"{{{string.Join(", ", dt.Select(kvp => $"{kvp.Key}: {kvp.Value}"))}}}";
    }


    private static string FormatPrefix(string prefix)
    {
        string trimEnd = prefix.TrimEnd();
        if (
            prefix.EndsWith("\n") ||
            prefix.EndsWith(Environment.NewLine) ||
            prefix.EndsWith("\t") ||
            trimEnd.EndsWith("\n") ||
            trimEnd.EndsWith(Environment.NewLine) ||
            trimEnd.EndsWith("\t"))
            return prefix;

        return $"{prefix} ";
    }
    private static string FormatPostfix(string postfix)
    {
        // NOTE: Should TrimEnd() ?
        if (postfix.StartsWith("\n") || postfix.StartsWith(Environment.NewLine) || postfix.StartsWith("\t"))
            return postfix;

        return $" {postfix}";
    }
}

