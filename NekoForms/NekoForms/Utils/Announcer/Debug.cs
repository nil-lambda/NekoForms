using NekoForms.Utils.Extensions;

namespace NekoForms.Utils.Announcer
{
    public enum LogSeverity
    {
        Success,
        Error,
        Fatal
    }

    internal class Debug
    {
        private static Stack<DebugInfo> Logs = new Stack<DebugInfo>();

        public static void Print(LogSeverity type, string obj)
        {
            Logs.Push(new DebugInfo(type, DateTime.Now, obj));
            Logs.Peek().PrintCurrentDebug();
        }

        public static async Task ExportLog()
        {
            using (FileStream logStream = new FileStream("C:\\NekoForms\\Neko.log", FileMode.Create, FileAccess.Write, FileShare.None))
            {
                using (StreamWriter logWriter = new StreamWriter(logStream))
                {
                    foreach (DebugInfo currentDebug in Logs.Reverse())
                    {
                        await logWriter.WriteLineAsync(currentDebug.ToString());
                    }
                }
            }
        }
    }
}
