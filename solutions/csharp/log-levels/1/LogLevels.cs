static class LogLine
{
    public static string Message(string logLine)
    {
         string[] parts = logLine.Split(':');
         return parts[1].Trim();
    
    }

    public static string LogLevel(string logLine)
    {
        string[] parts = logLine.Split(':');
        return parts[0].Trim('[',']').ToLower();
    }

    public static string Reformat(string logLine)
    {
       string message = Message(logLine);
       string loglevel = LogLevel(logLine);
       return $"{message} ({loglevel})";
        
    }
}
