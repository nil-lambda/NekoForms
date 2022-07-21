namespace NekoForms.Utils.Announcer
{
    public class DebugInfo
    {
        public LogSeverity LogSeverity { get; set; }

        public DateTime LogTime { get; set; }

        public object? LogMessage { get; set; }

        public DebugInfo(LogSeverity logSeverity, DateTime logTime, object? logMessage)
        {
            LogSeverity = logSeverity;
            LogTime = logTime;
            LogMessage = logMessage;
        }

        public override string ToString()
        {
            switch (LogSeverity)
            {
                case LogSeverity.Success:
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
                case LogSeverity.Error:
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    break;
                case LogSeverity.Fatal:
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
            }

            return $"[Log]({LogTime.ToString("HH:MM:ss")})<=>({LogSeverity}): {LogMessage}";
        }
    }
}
