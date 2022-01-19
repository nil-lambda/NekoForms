namespace NekoForms
{
    using System.Windows.Forms;
    using System.Linq;
    public static class LogsWindow
    {
        private static readonly Form _logWindow = Menu.logWindow;

        public static void InitializeWindow()
        {
            _logWindow.Text = "NekoForms Logs";
            _logWindow.Width = 400;
            _logWindow.Height = 300;
            _logWindow.Opacity = 0;
            _logWindow.ShowIcon = false;
            _logWindow.MaximizeBox = false;
            _logWindow.MinimizeBox = false;
            _logWindow.ControlBox = false;
            _logWindow.Enabled = false;
            _logWindow.AutoSize = true;
            _logWindow.ShowInTaskbar = false;

            _logWindow.Controls.Add(new ListBox()
            {
                Name = "EventBox",
                Size = new System.Drawing.Size(_logWindow.Width, _logWindow.Height - 50),
                Location = new System.Drawing.Point(0, 0)
            });

            _logWindow.Show();

            SendLog("[+] Log window created");
        }

        public static void ShowWindow(bool state)
        {
            switch (state)
            {
                case true:
                    _logWindow.Opacity = 100;
                    _logWindow.Enabled = true;
                    _logWindow.ShowInTaskbar = true;
                    break;

                case false:
                    _logWindow.Opacity = 0;
                    _logWindow.Enabled = false;
                    _logWindow.ShowInTaskbar = false;
                    break;
            }
        }

        public static void SendLog(string message)
        {
            foreach (ListBox listBoxControl in _logWindow.Controls.Find("EventBox", false))
            {
                listBoxControl.Items.Add(message);
            }
        }
    }
}