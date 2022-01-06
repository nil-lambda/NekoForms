
namespace NekoForms
{
    partial class Menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.nekosEndpointSelection = new ReaLTaiizor.Controls.MaterialComboBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.imageTypeSelection = new ReaLTaiizor.Controls.MaterialComboBox();
            this.stopButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.startButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.assetCleanerBox = new MaterialSkin.Controls.MaterialCheckBox();
            this.panel1 = new ReaLTaiizor.Controls.Panel();
            this.materialTabSelector1 = new ReaLTaiizor.Controls.MaterialTabSelector();
            this.tabControl = new ReaLTaiizor.Controls.MaterialTabControl();
            this.mainPage = new System.Windows.Forms.TabPage();
            this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.secondsLabel = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.secondsTrackBar = new ReaLTaiizor.Controls.DungeonTrackBar();
            this.settingsPage = new System.Windows.Forms.TabPage();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.heightTextBox = new ReaLTaiizor.Controls.MaterialSingleTextBox();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.widthTextBox = new ReaLTaiizor.Controls.MaterialSingleTextBox();
            this.fixedSizeBox = new MaterialSkin.Controls.MaterialCheckBox();
            this.dynamicSizeBox = new MaterialSkin.Controls.MaterialCheckBox();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.tabControl.SuspendLayout();
            this.mainPage.SuspendLayout();
            this.settingsPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // nekosEndpointSelection
            // 
            this.nekosEndpointSelection.AutoResize = false;
            this.nekosEndpointSelection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.nekosEndpointSelection.Depth = 0;
            this.nekosEndpointSelection.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.nekosEndpointSelection.DropDownHeight = 174;
            this.nekosEndpointSelection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.nekosEndpointSelection.DropDownWidth = 121;
            this.nekosEndpointSelection.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.nekosEndpointSelection.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.nekosEndpointSelection.FormattingEnabled = true;
            this.nekosEndpointSelection.IntegralHeight = false;
            this.nekosEndpointSelection.ItemHeight = 43;
            this.nekosEndpointSelection.Items.AddRange(new object[] {
            "",
            "neko",
            "avatar",
            "tickle",
            "slap",
            "poke",
            "pat",
            "kiss",
            "hug",
            "cuddle"});
            this.nekosEndpointSelection.Location = new System.Drawing.Point(139, 74);
            this.nekosEndpointSelection.MaxDropDownItems = 4;
            this.nekosEndpointSelection.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.nekosEndpointSelection.Name = "nekosEndpointSelection";
            this.nekosEndpointSelection.Size = new System.Drawing.Size(155, 49);
            this.nekosEndpointSelection.StartIndex = 0;
            this.nekosEndpointSelection.TabIndex = 0;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(6, 20);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(127, 18);
            this.materialLabel1.TabIndex = 4;
            this.materialLabel1.Text = "Select image type";
            // 
            // imageTypeSelection
            // 
            this.imageTypeSelection.AutoResize = false;
            this.imageTypeSelection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.imageTypeSelection.Depth = 0;
            this.imageTypeSelection.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.imageTypeSelection.DropDownHeight = 174;
            this.imageTypeSelection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.imageTypeSelection.DropDownWidth = 121;
            this.imageTypeSelection.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.imageTypeSelection.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.imageTypeSelection.FormattingEnabled = true;
            this.imageTypeSelection.IntegralHeight = false;
            this.imageTypeSelection.ItemHeight = 43;
            this.imageTypeSelection.Items.AddRange(new object[] {
            "Nekos - SFW",
            "Nekos - NSFW",
            "Cats",
            "Dogs"});
            this.imageTypeSelection.Location = new System.Drawing.Point(139, 6);
            this.imageTypeSelection.MaxDropDownItems = 4;
            this.imageTypeSelection.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.imageTypeSelection.Name = "imageTypeSelection";
            this.imageTypeSelection.Size = new System.Drawing.Size(155, 49);
            this.imageTypeSelection.StartIndex = 0;
            this.imageTypeSelection.TabIndex = 3;
            this.imageTypeSelection.SelectedIndexChanged += new System.EventHandler(this.ImageTypeSelection_SelectedIndexChanged);
            // 
            // stopButton
            // 
            this.stopButton.AutoSize = true;
            this.stopButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.stopButton.Depth = 0;
            this.stopButton.Icon = null;
            this.stopButton.Location = new System.Drawing.Point(116, 208);
            this.stopButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.stopButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.stopButton.Name = "stopButton";
            this.stopButton.Primary = false;
            this.stopButton.Size = new System.Drawing.Size(56, 36);
            this.stopButton.TabIndex = 2;
            this.stopButton.Text = "Stop";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // startButton
            // 
            this.startButton.AutoSize = true;
            this.startButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.startButton.Depth = 0;
            this.startButton.Icon = null;
            this.startButton.Location = new System.Drawing.Point(26, 208);
            this.startButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.startButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.startButton.Name = "startButton";
            this.startButton.Primary = false;
            this.startButton.Size = new System.Drawing.Size(64, 36);
            this.startButton.TabIndex = 1;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // assetCleanerBox
            // 
            this.assetCleanerBox.AutoSize = true;
            this.assetCleanerBox.Depth = 0;
            this.assetCleanerBox.Font = new System.Drawing.Font("Roboto", 10F);
            this.assetCleanerBox.Location = new System.Drawing.Point(2, 39);
            this.assetCleanerBox.Margin = new System.Windows.Forms.Padding(0);
            this.assetCleanerBox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.assetCleanerBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.assetCleanerBox.Name = "assetCleanerBox";
            this.assetCleanerBox.Ripple = true;
            this.assetCleanerBox.Size = new System.Drawing.Size(337, 30);
            this.assetCleanerBox.TabIndex = 0;
            this.assetCleanerBox.Text = "Delete assets on exit - Elevation might be required";
            this.assetCleanerBox.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.panel1.EdgeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.panel1.Location = new System.Drawing.Point(0, 63);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5);
            this.panel1.Size = new System.Drawing.Size(58, 42);
            this.panel1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.panel1.TabIndex = 5;
            this.panel1.Text = "panel1";
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.BaseTabControl = this.tabControl;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTabSelector1.HeadAlignment = ReaLTaiizor.Controls.MaterialTabSelector.Alignment.Left;
            this.materialTabSelector1.Location = new System.Drawing.Point(55, 63);
            this.materialTabSelector1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.SelectorHideTabName = new string[0];
            this.materialTabSelector1.SelectorNonClickTabPage = new System.Windows.Forms.TabPage[0];
            this.materialTabSelector1.Size = new System.Drawing.Size(307, 42);
            this.materialTabSelector1.TabIndex = 6;
            this.materialTabSelector1.Text = "materialTabSelector1";
            this.materialTabSelector1.TitleTextState = ReaLTaiizor.Controls.MaterialTabSelector.TextStateType.Normal;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.mainPage);
            this.tabControl.Controls.Add(this.settingsPage);
            this.tabControl.Depth = 0;
            this.tabControl.Location = new System.Drawing.Point(0, 107);
            this.tabControl.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.tabControl.Multiline = true;
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(355, 257);
            this.tabControl.TabIndex = 7;
            // 
            // mainPage
            // 
            this.mainPage.BackColor = System.Drawing.Color.White;
            this.mainPage.Controls.Add(this.materialFlatButton1);
            this.mainPage.Controls.Add(this.materialLabel3);
            this.mainPage.Controls.Add(this.secondsLabel);
            this.mainPage.Controls.Add(this.materialLabel2);
            this.mainPage.Controls.Add(this.secondsTrackBar);
            this.mainPage.Controls.Add(this.materialLabel1);
            this.mainPage.Controls.Add(this.nekosEndpointSelection);
            this.mainPage.Controls.Add(this.imageTypeSelection);
            this.mainPage.Controls.Add(this.startButton);
            this.mainPage.Controls.Add(this.stopButton);
            this.mainPage.Location = new System.Drawing.Point(4, 22);
            this.mainPage.Name = "mainPage";
            this.mainPage.Padding = new System.Windows.Forms.Padding(3);
            this.mainPage.Size = new System.Drawing.Size(347, 231);
            this.mainPage.TabIndex = 0;
            this.mainPage.Text = "Main tab";
            // 
            // materialFlatButton1
            // 
            this.materialFlatButton1.AutoSize = true;
            this.materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton1.Depth = 0;
            this.materialFlatButton1.Icon = null;
            this.materialFlatButton1.Location = new System.Drawing.Point(184, 208);
            this.materialFlatButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton1.Name = "materialFlatButton1";
            this.materialFlatButton1.Primary = false;
            this.materialFlatButton1.Size = new System.Drawing.Size(158, 36);
            this.materialFlatButton1.TabIndex = 9;
            this.materialFlatButton1.Text = "close all windows";
            this.materialFlatButton1.UseVisualStyleBackColor = true;
            this.materialFlatButton1.Click += new System.EventHandler(this.materialFlatButton1_Click);
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(6, 90);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(112, 18);
            this.materialLabel3.TabIndex = 8;
            this.materialLabel3.Text = "Select endpoint";
            // 
            // secondsLabel
            // 
            this.secondsLabel.AutoSize = true;
            this.secondsLabel.Depth = 0;
            this.secondsLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.secondsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.secondsLabel.Location = new System.Drawing.Point(317, 162);
            this.secondsLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.secondsLabel.Name = "secondsLabel";
            this.secondsLabel.Size = new System.Drawing.Size(32, 18);
            this.secondsLabel.TabIndex = 7;
            this.secondsLabel.Text = "null";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(6, 162);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(176, 18);
            this.materialLabel2.TabIndex = 6;
            this.materialLabel2.Text = "Seconds until next image";
            // 
            // secondsTrackBar
            // 
            this.secondsTrackBar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.secondsTrackBar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.secondsTrackBar.DrawValueString = false;
            this.secondsTrackBar.EmptyBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.secondsTrackBar.FillBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.secondsTrackBar.JumpToMouse = false;
            this.secondsTrackBar.Location = new System.Drawing.Point(187, 161);
            this.secondsTrackBar.Maximum = 200;
            this.secondsTrackBar.Minimum = 10;
            this.secondsTrackBar.MinimumSize = new System.Drawing.Size(47, 22);
            this.secondsTrackBar.Name = "secondsTrackBar";
            this.secondsTrackBar.Size = new System.Drawing.Size(120, 22);
            this.secondsTrackBar.TabIndex = 5;
            this.secondsTrackBar.Text = "dungeonTrackBar1";
            this.secondsTrackBar.ThumbBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.secondsTrackBar.ThumbBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.secondsTrackBar.Value = 10;
            this.secondsTrackBar.ValueDivison = ReaLTaiizor.Controls.DungeonTrackBar.ValueDivisor.By10;
            this.secondsTrackBar.ValueToSet = 1F;
            this.secondsTrackBar.ValueChanged += new ReaLTaiizor.Controls.DungeonTrackBar.ValueChangedEventHandler(this.SecondsTrackBar_ValueChanged);
            // 
            // settingsPage
            // 
            this.settingsPage.BackColor = System.Drawing.Color.White;
            this.settingsPage.Controls.Add(this.materialLabel7);
            this.settingsPage.Controls.Add(this.materialLabel6);
            this.settingsPage.Controls.Add(this.heightTextBox);
            this.settingsPage.Controls.Add(this.materialLabel5);
            this.settingsPage.Controls.Add(this.widthTextBox);
            this.settingsPage.Controls.Add(this.fixedSizeBox);
            this.settingsPage.Controls.Add(this.dynamicSizeBox);
            this.settingsPage.Controls.Add(this.materialLabel4);
            this.settingsPage.Controls.Add(this.materialDivider1);
            this.settingsPage.Controls.Add(this.assetCleanerBox);
            this.settingsPage.Location = new System.Drawing.Point(4, 22);
            this.settingsPage.Name = "settingsPage";
            this.settingsPage.Padding = new System.Windows.Forms.Padding(3);
            this.settingsPage.Size = new System.Drawing.Size(347, 306);
            this.settingsPage.TabIndex = 1;
            this.settingsPage.Text = "Settings";
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel7.Location = new System.Drawing.Point(102, 14);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(142, 18);
            this.materialLabel7.TabIndex = 10;
            this.materialLabel7.Text = "Application settings";
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(6, 221);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(52, 18);
            this.materialLabel6.TabIndex = 9;
            this.materialLabel6.Text = "Height";
            // 
            // heightTextBox
            // 
            this.heightTextBox.Depth = 0;
            this.heightTextBox.Location = new System.Drawing.Point(64, 217);
            this.heightTextBox.MaxLength = 32767;
            this.heightTextBox.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.heightTextBox.Name = "heightTextBox";
            this.heightTextBox.PasswordChar = '\0';
            this.heightTextBox.SelectedText = "";
            this.heightTextBox.SelectionLength = 0;
            this.heightTextBox.SelectionStart = 0;
            this.heightTextBox.Size = new System.Drawing.Size(82, 25);
            this.heightTextBox.TabIndex = 8;
            this.heightTextBox.TabStop = false;
            this.heightTextBox.Text = "500";
            this.heightTextBox.UseAccentColor = false;
            this.heightTextBox.UseSystemPasswordChar = false;
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(6, 190);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(46, 18);
            this.materialLabel5.TabIndex = 7;
            this.materialLabel5.Text = "Width";
            // 
            // widthTextBox
            // 
            this.widthTextBox.Depth = 0;
            this.widthTextBox.Location = new System.Drawing.Point(64, 186);
            this.widthTextBox.MaxLength = 32767;
            this.widthTextBox.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.widthTextBox.Name = "widthTextBox";
            this.widthTextBox.PasswordChar = '\0';
            this.widthTextBox.SelectedText = "";
            this.widthTextBox.SelectionLength = 0;
            this.widthTextBox.SelectionStart = 0;
            this.widthTextBox.Size = new System.Drawing.Size(82, 25);
            this.widthTextBox.TabIndex = 6;
            this.widthTextBox.TabStop = false;
            this.widthTextBox.Text = "500";
            this.widthTextBox.UseAccentColor = false;
            this.widthTextBox.UseSystemPasswordChar = false;
            // 
            // fixedSizeBox
            // 
            this.fixedSizeBox.AutoSize = true;
            this.fixedSizeBox.Checked = true;
            this.fixedSizeBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.fixedSizeBox.Depth = 0;
            this.fixedSizeBox.Font = new System.Drawing.Font("Roboto", 10F);
            this.fixedSizeBox.Location = new System.Drawing.Point(2, 153);
            this.fixedSizeBox.Margin = new System.Windows.Forms.Padding(0);
            this.fixedSizeBox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.fixedSizeBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.fixedSizeBox.Name = "fixedSizeBox";
            this.fixedSizeBox.Ripple = true;
            this.fixedSizeBox.Size = new System.Drawing.Size(168, 30);
            this.fixedSizeBox.TabIndex = 5;
            this.fixedSizeBox.Text = "Fixed width and height";
            this.fixedSizeBox.UseVisualStyleBackColor = true;
            this.fixedSizeBox.CheckedChanged += new System.EventHandler(this.fixedSizeBox_CheckedChanged);
            // 
            // dynamicSizeBox
            // 
            this.dynamicSizeBox.AutoSize = true;
            this.dynamicSizeBox.Depth = 0;
            this.dynamicSizeBox.Enabled = false;
            this.dynamicSizeBox.Font = new System.Drawing.Font("Roboto", 10F);
            this.dynamicSizeBox.Location = new System.Drawing.Point(2, 125);
            this.dynamicSizeBox.Margin = new System.Windows.Forms.Padding(0);
            this.dynamicSizeBox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.dynamicSizeBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.dynamicSizeBox.Name = "dynamicSizeBox";
            this.dynamicSizeBox.Ripple = true;
            this.dynamicSizeBox.Size = new System.Drawing.Size(189, 30);
            this.dynamicSizeBox.TabIndex = 4;
            this.dynamicSizeBox.Text = "Dynamic width and height";
            this.dynamicSizeBox.UseVisualStyleBackColor = true;
            this.dynamicSizeBox.CheckedChanged += new System.EventHandler(this.dynamicSizeBox_CheckedChanged);
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(112, 91);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(107, 18);
            this.materialLabel4.TabIndex = 2;
            this.materialLabel4.Text = "Image settings";
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(53, 78);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(239, 1);
            this.materialDivider1.TabIndex = 1;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 366);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.materialTabSelector1);
            this.Controls.Add(this.panel1);
            this.Name = "Menu";
            this.ShowIcon = false;
            this.Text = "NekoForms";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl.ResumeLayout(false);
            this.mainPage.ResumeLayout(false);
            this.mainPage.PerformLayout();
            this.settingsPage.ResumeLayout(false);
            this.settingsPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ReaLTaiizor.Controls.MaterialComboBox nekosEndpointSelection;
        private MaterialSkin.Controls.MaterialFlatButton stopButton;
        private MaterialSkin.Controls.MaterialFlatButton startButton;
        private ReaLTaiizor.Controls.Panel panel1;
        private MaterialSkin.Controls.MaterialCheckBox assetCleanerBox;
        private ReaLTaiizor.Controls.MaterialComboBox imageTypeSelection;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private ReaLTaiizor.Controls.MaterialTabSelector materialTabSelector1;
        private ReaLTaiizor.Controls.MaterialTabControl tabControl;
        private System.Windows.Forms.TabPage mainPage;
        private System.Windows.Forms.TabPage settingsPage;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private ReaLTaiizor.Controls.DungeonTrackBar secondsTrackBar;
        private MaterialSkin.Controls.MaterialLabel secondsLabel;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
        private ReaLTaiizor.Controls.MaterialSingleTextBox heightTextBox;
        private ReaLTaiizor.Controls.MaterialSingleTextBox widthTextBox;
        private MaterialSkin.Controls.MaterialCheckBox fixedSizeBox;
        private MaterialSkin.Controls.MaterialCheckBox dynamicSizeBox;
    }
}