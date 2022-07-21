using NekoForms.Utils;
using NekoForms.Utils.Sources;
using NekoForms.Utils.Announcer;
using System.Runtime.InteropServices;

namespace NekoForms
{
    public partial class Menu : Form
    {
        [DllImport("user32.dll")]
        static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

        [DllImport("Kernel32")]
        private static extern IntPtr GetConsoleWindow();

        public Menu()
        {
            InitializeComponent();
        }

        readonly string[] baseUrlsCollections = new string[]
        {
            "https://nekos.life/api/v2/img/",
            "http://api.nekos.fun:8080/api/",
            "https://hmtai.herokuapp.com/sfw/",
            "https://hmtai.herokuapp.com/nsfw/"
        };

        readonly Enum[] enumCollection = new Enum[]
        {
            new NekosLife(),
            new NekosFun(),
            new HMTaiSafe(),
            new HMTaiNotSafe()
        };

        public static List<Form> OpenedForms = new List<Form>();
        private string currentUrl = string.Empty;
        private string currentEndpoint = string.Empty;
        private bool isCancellationRequested = true;

        private void LoadEndpoints<T>()
        {
            endpointBox.Items.Clear();

            foreach (var endpoint in Enum.GetValues(typeof(T)).Cast<T>())
            {
                endpointBox.Items.Add(endpoint);
            }
        }

        private async void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            await Debug.ExportLog();
            Environment.Exit(0);
        }

        private void SourceBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (sourceBox.SelectedIndex)
            {
                case 0:
                    currentUrl = baseUrlsCollections[0];
                    LoadEndpoints<NekosLife>(); break;
                case 1:
                    currentUrl = baseUrlsCollections[1];
                    LoadEndpoints<NekosFun>(); break;
                case 2:
                    currentUrl = baseUrlsCollections[2];
                    LoadEndpoints<HMTaiSafe>(); break;
                case 3:
                    currentUrl = baseUrlsCollections[3];
                    LoadEndpoints<HMTaiNotSafe>(); break;
            }
        }

        private void EndpointBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (sourceBox.SelectedIndex)
            {
                case 0: enumCollection[0] = (NekosLife)endpointBox.SelectedIndex; break;
                case 1: enumCollection[1] = (NekosFun)endpointBox.SelectedIndex; break;
                case 2: enumCollection[2] = (HMTaiSafe)endpointBox.SelectedIndex; break;
                case 3: enumCollection[3] = (HMTaiNotSafe)endpointBox.SelectedIndex; break;
            }

            currentEndpoint = enumCollection[sourceBox.SelectedIndex].ToString();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            isCancellationRequested = false;
        }

        private void CloseAllButton_Click(object sender, EventArgs e)
        {
            if (!OpenedForms.Any())
                return;

            OpenedForms.ForEach(currentForm => currentForm.Close());
        }

        private void OnTopCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            this.TopMost = onTopCheckBox.Checked;
        }

        private async void ImageCycle()
        {
            while (true)
            {
                Thread.Sleep(50);

                if (!isCancellationRequested)
                {
                    int w = int.Parse(widthTextBox.Text);
                    int h = int.Parse(heightTextBox.Text);

                    await new Engine(currentUrl, currentEndpoint, w, h).Run();
                    await Task.Delay(100);
                }
            }
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            new Task(ImageCycle).Start();
            ShowWindow(GetConsoleWindow(), 0);

            try
            {
                Directory.CreateDirectory("C:\\NekoForms");
            }
            catch (IOException)
            {
                Debug.Print(LogSeverity.Error, "Couldn't create base directory \"C:\\NekoForms\". Try creating it manually!");
            }
            catch (UnauthorizedAccessException)
            {
                Debug.Print(LogSeverity.Error, "Couldn't create base directory \"C:\\NekoForms\". Try creating it manually!");
            }
        }

        private void WidthTextBox_TextChanged(object sender, EventArgs e)
        {
            foreach (char character in widthTextBox.Text)
            {
                if (!Char.IsDigit(character))
                {
                    MessageBox.Show("Only digits are allowed in that field!", "Only digits allowed!");
                    return;
                }
            }
        }

        private void HeightTextBox_TextChanged(object sender, EventArgs e)
        {
            foreach (char character in heightTextBox.Text)
            {
                if (!Char.IsDigit(character))
                {
                    MessageBox.Show("Only digits are allowed in that field!", "Only digits allowed!");
                    return;
                }
            }
        }

        private void FixedCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            widthTextBox.Enabled = fixedCheckBox.Checked;
            heightTextBox.Enabled = fixedCheckBox.Checked;
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            isCancellationRequested = true;
        }

        private void HideShowButton_Click(object sender, EventArgs e)
        {
            switch (hideShowButton.Text.Split()[0])
            {
                case "Show": 
                    ShowWindow(GetConsoleWindow(), 5);
                    hideShowButton.Text = "Hide log console";
                    break;

                case "Hide":
                    ShowWindow(GetConsoleWindow(), 0);
                    hideShowButton.Text = "Show log console";
                    break;
            }
        }
    }
}