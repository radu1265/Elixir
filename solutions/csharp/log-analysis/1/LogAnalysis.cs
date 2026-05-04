public static class LogAnalysis 
{
    public static string SubstringAfter(this string log, string separator)
    {
        return log.Substring(log.IndexOf(separator) + separator.Length);
    }

    public static string SubstringBetween(this string log, string start, string end)
    {
        return log.Substring(log.IndexOf(start) + start.Length, log.IndexOf(end) - log.IndexOf(start) - start.Length);
    }
        public static string Message(this string log)
    {
        return log.SubstringAfter(": ");
    }
    public static string LogLevel(this string log)
    {
        return log.SubstringBetween("[","]");
    }
}