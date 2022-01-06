using System;
using System.IO;
using System.Linq;
using System.Diagnostics;
using System.Threading;
using System.Windows.Forms;
using System.Collections.Generic;

using ReaLTaiizor.Forms;

namespace NekoForms
{
    public partial class Menu : MaterialForm
    {
        private bool hasNotRequestedWorkerCancellation;
        public List<Form> currentlyExistingForms = new List<Form>();

        public Menu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            Thread cycleHandler = new Thread(Cycle);
            cycleHandler.Start();

            secondsLabel.Text = (secondsTrackBar.Value / 10).ToString();
            this.FormClosing += Form1_FormClosing;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (assetCleanerBox.Checked)
            {
                if (Directory.Exists("C:\\NekoForms_Assets"))
                {
                    DirectoryInfo mainDirectoryInfo = new DirectoryInfo("C:\\NekoForms_Assets");
                    DirectoryInfo[] subDirectoriesInfo = mainDirectoryInfo.GetDirectories();
                    try
                    {
                        mainDirectoryInfo.Attributes = FileAttributes.Normal;
                        for (int dirIteration = 0; dirIteration < subDirectoriesInfo.Length; dirIteration++)
                        {
                            subDirectoriesInfo[dirIteration].Attributes = FileAttributes.Normal;
                            subDirectoriesInfo[dirIteration].Delete(true);
                        }
                        mainDirectoryInfo.Delete(true);
                    }
                    catch
                    {
                        MessageBox.Show("Couldn't delete assets directory, try lauching with elevation. The program will now quit.", "Error");
                    }
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
                if (hasNotRequestedWorkerCancellation == true)
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
                nekosEndpointSelection.Items.Add("neko");
                nekosEndpointSelection.Items.Add("avatar");
                nekosEndpointSelection.Items.Add("tickle");
                nekosEndpointSelection.Items.Add("slap");
                nekosEndpointSelection.Items.Add("poke");
                nekosEndpointSelection.Items.Add("pat");
                nekosEndpointSelection.Items.Add("kiss");
                nekosEndpointSelection.Items.Add("hug");
                nekosEndpointSelection.Items.Add("cuddle");

                materialLabel3.Visible = true;
                nekosEndpointSelection.Visible = true;
            }

            else if (imageTypeSelection.SelectedIndex == 1)
            {
                nekosEndpointSelection.Items.Clear();

                nekosEndpointSelection.Items.Add("");
                nekosEndpointSelection.Items.Add("lewd");
                nekosEndpointSelection.Items.Add("pussy");
                nekosEndpointSelection.Items.Add("les");
                nekosEndpointSelection.Items.Add("cum");
                nekosEndpointSelection.Items.Add("classic");
                nekosEndpointSelection.Items.Add("boobs");
                nekosEndpointSelection.Items.Add("bj");
                nekosEndpointSelection.Items.Add("anal");
                nekosEndpointSelection.Items.Add("yuri");
                nekosEndpointSelection.Items.Add("trap");
                nekosEndpointSelection.Items.Add("tits");
                nekosEndpointSelection.Items.Add("soloG");
                nekosEndpointSelection.Items.Add("solo");
                nekosEndpointSelection.Items.Add("pwankg");
                nekosEndpointSelection.Items.Add("pussy_jpg");
                nekosEndpointSelection.Items.Add("hentai");

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

        private void StartButton_Click(object sender, EventArgs e)
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

            if (!fixedSizeBox.Checked && !dynamicSizeBox.Checked)
            {
                MessageBox.Show("Please select image size from \"Options\" tab", "Error");
                return;
            }

            hasNotRequestedWorkerCancellation = true;
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            hasNotRequestedWorkerCancellation = false;
        }

        private void SecondsTrackBar_ValueChanged()
        {
            secondsLabel.Text = (secondsTrackBar.Value / 10).ToString();
        }

        private void fixedSizeBox_CheckedChanged(object sender, EventArgs e)
        {
            if (fixedSizeBox.Checked)
            {
                dynamicSizeBox.Enabled = false;
            }
            else
            {
                dynamicSizeBox.Enabled = true;
            }
        }

        private void dynamicSizeBox_CheckedChanged(object sender, EventArgs e)
        {
            if (dynamicSizeBox.Checked)
            {
                fixedSizeBox.Enabled = false;
                widthTextBox.Enabled = false;
                heightTextBox.Enabled = false;
            }
            else
            {
                fixedSizeBox.Enabled = true;
                widthTextBox.Enabled = true;
                heightTextBox.Enabled = true;
            }
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            if (currentlyExistingForms.Any())
            {
                foreach (Form formToClose in currentlyExistingForms)
                {
                    formToClose.Close();
                }
                currentlyExistingForms.Clear();
                return;
            }
            MessageBox.Show("No windows are opened at the moment. Nothing to close.", "Error");
        }
    }
}