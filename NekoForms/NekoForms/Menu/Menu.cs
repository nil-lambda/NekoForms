namespace NekoForms
{
    using System;
    using System.IO;
    using System.Linq;
    using System.Diagnostics;
    using System.Threading;
    using System.Windows.Forms;
    using System.Collections.Generic;

    using ReaLTaiizor.Forms;

    public partial class Menu : MaterialForm
    {
        public static Form logWindow = new Form();
        public static ImageProfile[] imageProfileArray = new ImageProfile[1];
        private readonly HashSet<Form> currentlyExistingForms = new HashSet<Form>();
        public static HashSet<PictureBox> formImageCollection = new HashSet<PictureBox>();

        private bool hasNotRequestedCycleCancellation;

        public Menu() => InitializeComponent();

        private void Form1_Load(object sender, EventArgs e)
        {
            LogsWindow.InitializeWindow();

            CheckForIllegalCrossThreadCalls = false;
            Thread cycleHandler = new Thread(Cycle);

            secondsLabel.Text = (secondsTrackBar.Value / 10).ToString();
            this.FormClosing += Form1_FormClosing;
            cycleHandler.Start();

            LogsWindow.SendLog(LogsMessage.ThreadStarted());
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (assetCleanerBox.Checked)
            {
                hasNotRequestedCycleCancellation = false;

                Thread.Sleep(1000);

                if (Directory.Exists("C:\\NekoForms_Assets"))
                {
                    if (currentlyExistingForms.Any())
                    {
                        foreach (Form formToClose in currentlyExistingForms)
                        {
                            formToClose.Close();
                        }
                        currentlyExistingForms.Clear();
                    }

                    Thread.Sleep(2000);

                    DirectoryInfo mainDirectoryInfo = new DirectoryInfo("C:\\NekoForms_Assets");
                    DirectoryInfo[] subDirectoriesInfo = mainDirectoryInfo.GetDirectories();
                    mainDirectoryInfo.Attributes = FileAttributes.Normal;

                    for (int dirIteration = 0; dirIteration < subDirectoriesInfo.Length; dirIteration++)
                    {
                        subDirectoriesInfo[dirIteration].Attributes = FileAttributes.Normal;
                        string[] subDirFiles = Directory.GetFiles(subDirectoriesInfo[dirIteration].FullName);
                        foreach (string filePath in subDirFiles)
                        {
                            GC.Collect();
                            GC.WaitForPendingFinalizers();
                            File.Delete(filePath);
                            Thread.Sleep(100);
                        }
                        subDirectoriesInfo[dirIteration].Delete(true);
                        LogsWindow.SendLog($"Deleted child directory {dirIteration + 1}/{subDirectoriesInfo.Length}");
                    }
                    mainDirectoryInfo.Delete(true);
                    LogsWindow.SendLog("Deleted main directory");
                }
                else
                {
                    MessageBox.Show("Assets directory doesn't exist. The program will now quit.", "Error");
                }
            }
            Environment.Exit(0);
        }

        private void Cycle()
        {
            Stopwatch timer = new Stopwatch();
            timer.Start();

            while (true)
            {
                Thread.Sleep(25);
                if (hasNotRequestedCycleCancellation == true)
                {
                    int seconds = int.Parse($"{timer.Elapsed.TotalSeconds:F0}");
                    if (seconds > 0 && seconds % (secondsTrackBar.Value / 10) == 0)
                    {
                        FormCreation formCreationObj = new FormCreation();
                        Form _newForm = new Form();

                        if (imageTypeSelection.SelectedIndex == 0)
                        {
                            var currentEndpoint = (Endpoints.Nekopoints_SFW)nekosEndpointSelection.SelectedIndex - 1;
                            formCreationObj.ParseEndpoint(currentEndpoint.ToString());
                            formCreationObj.CreateFormProperties(ref _newForm, "Nekos - SFW", int.Parse(widthTextBox.Text.ToString()), int.Parse(heightTextBox.Text.ToString()), dynamicSizeBox.Checked, fixedSizeBox.Checked);
                        }

                        else if (imageTypeSelection.SelectedIndex == 1)
                        {
                            var currentEndpoint = (Endpoints.Nekopoints_NSFW)nekosEndpointSelection.SelectedIndex - 1;
                            formCreationObj.ParseEndpoint(currentEndpoint.ToString());
                            formCreationObj.CreateFormProperties(ref _newForm, "Nekos - NSFW", int.Parse(widthTextBox.Text.ToString()), int.Parse(heightTextBox.Text.ToString()), dynamicSizeBox.Checked, fixedSizeBox.Checked);
                        }

                        else if (imageTypeSelection.SelectedIndex == 2)
                        {
                            formCreationObj.ParseEndpoint("meow");
                            formCreationObj.CreateFormProperties(ref _newForm, "Cats", int.Parse(widthTextBox.Text.ToString()), int.Parse(heightTextBox.Text.ToString()), dynamicSizeBox.Checked, fixedSizeBox.Checked);
                        }

                        else if (imageTypeSelection.SelectedIndex == 3)
                        {
                            formCreationObj.ParseEndpoint("woof");
                            formCreationObj.CreateFormProperties(ref _newForm, "Dogs", int.Parse(widthTextBox.Text.ToString()), int.Parse(heightTextBox.Text.ToString()), dynamicSizeBox.Checked, fixedSizeBox.Checked);
                        }

                        currentlyExistingForms.Add(_newForm);
                        this.BeginInvoke((MethodInvoker)_newForm.Show);

                        var anonymousCollection = imageProfileArray.Select(x => new { x.Name, x.Width, x.Height, x.CreationDate });
                        foreach (var anonymousItem in anonymousCollection)
                        {
                            imageListView.Items.Add(anonymousItem.Name).SubItems.AddRange(new string[] { $"{anonymousItem.Width}", $"{anonymousItem.Height}", anonymousItem.CreationDate.ToString("HH:mm:ss tt") });
                        }

                        LogsWindow.SendLog(LogsMessage.GeneratedImage());
                        Thread.Sleep(500);
                    }
                }
            }
        }

        private void ImageTypeSelection_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (imageTypeSelection.SelectedIndex == 0)
            {
                nekosEndpointSelection.Items.Clear();

                nekosEndpointSelection.Items.Add("");
                nekosEndpointSelection.Items.Add("Nekos (Image)");
                nekosEndpointSelection.Items.Add("Avatar (Image)");
                nekosEndpointSelection.Items.Add("Tickle (GIF)");
                nekosEndpointSelection.Items.Add("Slap (GIF)");
                nekosEndpointSelection.Items.Add("Poke (GIF)");
                nekosEndpointSelection.Items.Add("Pat (GIF)");
                nekosEndpointSelection.Items.Add("Kiss (GIF)");
                nekosEndpointSelection.Items.Add("Hug (GIF)");
                nekosEndpointSelection.Items.Add("Cuddle (GIF)");

                materialLabel3.Visible = true;
                nekosEndpointSelection.Visible = true;
            }

            else if (imageTypeSelection.SelectedIndex == 1)
            {
                nekosEndpointSelection.Items.Clear();

                nekosEndpointSelection.Items.Add("");
                nekosEndpointSelection.Items.Add("Lewd (Image)");
                nekosEndpointSelection.Items.Add("Blowjob (Image)");
                nekosEndpointSelection.Items.Add("Yuri (Image)");
                nekosEndpointSelection.Items.Add("Trap (Image)");
                nekosEndpointSelection.Items.Add("Tits (Image)");
                nekosEndpointSelection.Items.Add("Solo (Image)");
                nekosEndpointSelection.Items.Add("Pussy (Image)");
                nekosEndpointSelection.Items.Add("Cum (GIF)");
                nekosEndpointSelection.Items.Add("Hentai (Image)");
                nekosEndpointSelection.Items.Add("Keta (Image)");
                nekosEndpointSelection.Items.Add("Feet (Image)");
                nekosEndpointSelection.Items.Add("Holo Lewd (Image)");
                nekosEndpointSelection.Items.Add("Holo Ero (Image)");
                nekosEndpointSelection.Items.Add("Ero Feet (Image)");
                nekosEndpointSelection.Items.Add("Ero Kemo (Image)");
                nekosEndpointSelection.Items.Add("Ero (Image)");
                nekosEndpointSelection.Items.Add("Erok (Image)");
                nekosEndpointSelection.Items.Add("Eron (Image)");
                nekosEndpointSelection.Items.Add("Pussy (GIF)");
                nekosEndpointSelection.Items.Add("Lesbian (GIF)");
                nekosEndpointSelection.Items.Add("Cum (GIF)");
                nekosEndpointSelection.Items.Add("Classic (GIF)");
                nekosEndpointSelection.Items.Add("Boobs (GIF)");
                nekosEndpointSelection.Items.Add("Blowjob (GIF)");
                nekosEndpointSelection.Items.Add("Anal (GIF)");
                nekosEndpointSelection.Items.Add("Solo (GIF)");
                nekosEndpointSelection.Items.Add("Pwank (GIF)");
                nekosEndpointSelection.Items.Add("Feet (GIF)");

                materialLabel3.Visible = true;
                nekosEndpointSelection.Visible = true;
            }

            else if (imageTypeSelection.SelectedIndex == 2)
            {
                nekosEndpointSelection.Items.Clear();

                materialLabel3.Visible = false;
                nekosEndpointSelection.Visible = false;
            }

            else if (imageTypeSelection.SelectedIndex == 3)
            {
                nekosEndpointSelection.Items.Clear();

                materialLabel3.Visible = false;
                nekosEndpointSelection.Visible = false;
            }
        }

        private void SecondsTrackBar_ValueChanged()
        {
            secondsLabel.Text = (secondsTrackBar.Value / 10).ToString();
        }

        private void FixedSizeBox_CheckedChanged(object sender, EventArgs e)
        {
            if (fixedSizeBox.Checked)
            {
                dynamicSizeBox.Enabled = false;
                return;
            }
            dynamicSizeBox.Enabled = true;
        }

        private void DynamicSizeBox_CheckedChanged(object sender, EventArgs e)
        {
            if (dynamicSizeBox.Checked)
            {
                fixedSizeBox.Enabled = false;
                widthTextBox.Enabled = false;
                heightTextBox.Enabled = false;
                return;
            }
            fixedSizeBox.Enabled = true;
            widthTextBox.Enabled = true;
            heightTextBox.Enabled = true;
        }

        private void ImageListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            previewPictureBox.ImageLocation = null;
            previewPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            try
            {
                previewPictureBox.ImageLocation = formImageCollection.ElementAt(imageListView.FocusedItem.Index).ImageLocation.ToString();
            }
            catch { }
        }

        private void PreviewPictureBox_Click(object sender, EventArgs e)
        {
            if (previewPictureBox.ImageLocation != null)
            {
                Form previewForm = new Form
                {
                    Width = 450,
                    Height = 450,
                    ShowIcon = false,
                    MaximizeBox = false,
                    Text = "PreviewBox",
                    FormBorderStyle = FormBorderStyle.FixedSingle,
                    StartPosition = FormStartPosition.CenterScreen
                };
                previewForm.Controls.Add(new PictureBox
                {
                    Name = "PreviewPictureBox",
                    Size = new System.Drawing.Size(previewForm.Width, previewForm.Height),
                    Location = new System.Drawing.Point(0, 0),
                    SizeMode = PictureBoxSizeMode.StretchImage,
                    ImageLocation = previewPictureBox.ImageLocation,
                });

                previewForm.Show();
            }
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            if (nekosEndpointSelection.SelectedIndex != 0)
            {
                if (fixedSizeBox.Checked)
                {
                    if (int.Parse(widthTextBox.Text.ToString()) > 8000 || int.Parse(heightTextBox.Text.ToString()) > 8000)
                    {
                        MessageBox.Show("Exceeding width/height limit!\n" +
                            "Max width: 8000 \n" +
                            "Max height: 8000",
                            "Error");

                        return;
                    }

                    foreach (char currentChar in widthTextBox.Text)
                    {
                        if (!char.IsDigit(currentChar))
                        {
                            MessageBox.Show("Only digits are allowed in the width field!", "Error");
                            return;
                        }
                    }

                    foreach (char currentChar in heightTextBox.Text)
                    {
                        if (!char.IsDigit(currentChar))
                        {
                            MessageBox.Show("Only digits are allowed in the height field!", "Error");
                            return;
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Endpoint cannot be NULL", "Error");
                return;
            }

            if (!fixedSizeBox.Checked && !dynamicSizeBox.Checked)
            {
                MessageBox.Show("Please select image size from \"Options\" tab", "Error");
                return;
            }

            hasNotRequestedCycleCancellation = true;
            LogsWindow.SendLog(LogsMessage.StartMessage());
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            hasNotRequestedCycleCancellation = false;
            LogsWindow.SendLog(LogsMessage.StopMessage());
        }

        private void CloseAllButton_Click(object sender, EventArgs e)
        {
            if (currentlyExistingForms.Any())
            {
                foreach (Form formToClose in currentlyExistingForms)
                {
                    formToClose.Close();
                }
                currentlyExistingForms.Clear();
                LogsWindow.SendLog(LogsMessage.CloseWindowsMessage());
                return;
            }
            MessageBox.Show("No windows are opened at the moment. Nothing to close.", "Error");
        }

        private void ConsoleToggleButton_Click(object sender, EventArgs e)
        {
            LogsWindow.ShowWindow(logWindow.Opacity == 0);
        }
    }
}