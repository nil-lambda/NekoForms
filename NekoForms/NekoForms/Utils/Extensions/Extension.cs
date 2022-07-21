using NekoForms.Utils.Announcer;

namespace NekoForms.Utils.Extensions
{
    internal static class Extension
    {
        public static void PrintCurrentDebug(this DebugInfo debugInfo)
        {
            Console.WriteLine(debugInfo);
        }
    }
}
