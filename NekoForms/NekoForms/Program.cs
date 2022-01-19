namespace NekoForms
{
    using System;
    using System.IO;
    using System.Windows.Forms;
    using System.Collections.Generic;

    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            const string parentDirectory = @"C:\NekoForms_Assets";

            Dictionary<string, string> childDirectories = new Dictionary<string, string>()
            {
                { "childDirectory_NekosSFW", @"C:\NekoForms_Assets\Nekos - SFW" },
                { "childDirectory_NekosNSFW", @"C:\NekoForms_Assets\Nekos - NSFW" },
                { "childDirectory_Cats", @"C:\NekoForms_Assets\Cats" },
                { "childDirectory_Dogs", @"C:\NekoForms_Assets\Dogs" },
            };

            if (!Directory.Exists(parentDirectory))
            {
                try
                {
                    Directory.CreateDirectory(parentDirectory);
                    Directory.CreateDirectory(childDirectories["childDirectory_NekosSFW"]);
                    Directory.CreateDirectory(childDirectories["childDirectory_NekosNSFW"]);
                    Directory.CreateDirectory(childDirectories["childDirectory_Cats"]);
                    Directory.CreateDirectory(childDirectories["childDirectory_Dogs"]);
                }
                catch
                {
                    MessageBox.Show(
                        "Failed to create one or more directories. Try creating them manually. \n" +
                        "\"C:\\NekoForms_Assets\"\n" +
                        "\"C:\\NekoForms_Assets\\Nekos - SFW\"\n" +
                        "\"C:\\NekoForms_Assets\\Nekos - NSFW\"\n" +
                        "\"C:\\NekoForms_Assets\\Cats\"\n" +
                        "\"C:\\NekoForms_Assets\\Dogs\"\n", 
                        "Error");
                }
            }
            else if (Directory.Exists(parentDirectory))
            {
                foreach(KeyValuePair<string, string> dictionaryValues in childDirectories)
                {
                    if (Directory.Exists(dictionaryValues.Value))
                    {
                        continue;
                    }
                    Directory.CreateDirectory(dictionaryValues.Value);
                }
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Menu());
        }
    }
}