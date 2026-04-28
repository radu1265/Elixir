static class LogLine
{
    public static string Message(string logLine)
    {
        return logLine.Substring(logLine.Trim().IndexOf(':') + 2).Trim();
    }

    public static string LogLevel(string logLine)
    {
        return logLine[(logLine.IndexOf('[') + 1)..logLine.IndexOf(']')].ToLower();
    }

    public static string Reformat(string logLine)
    {
        return Message(logLine) + " (" + LogLevel(logLine) + ')';
    }
}
