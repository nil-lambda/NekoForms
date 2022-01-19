
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
            this.assetCleanerBox = new MaterialSkin.Controls.MaterialCheckBox();
            this.materialTabSelector1 = new ReaLTaiizor.Controls.MaterialTabSelector();
            this.tabControl = new ReaLTaiizor.Controls.MaterialTabControl();
            this.mainPage = new System.Windows.Forms.TabPage();
            this.logWindowToggleButton = new ReaLTaiizor.Controls.MaterialButton();
            this.closeAllButton = new ReaLTaiizor.Controls.MaterialButton();
            this.stopButton = new ReaLTaiizor.Controls.MaterialButton();
            this.startButton = new ReaLTaiizor.Controls.MaterialButton();
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
            this.imageProfilePage = new System.Windows.Forms.TabPage();
            this.materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            this.previewPictureBox = new System.Windows.Forms.PictureBox();
            this.imageListView = new ReaLTaiizor.Controls.MaterialListView();
            this.nameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.widthColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.heightColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.creationDateColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.materialCheckBox1 = new ReaLTaiizor.Controls.MaterialCheckBox();
            this.materialCheckBox2 = new ReaLTaiizor.Controls.MaterialCheckBox();
            this.materialCheckBox3 = new ReaLTaiizor.Controls.MaterialCheckBox();
            this.materialCheckBox4 = new ReaLTaiizor.Controls.MaterialCheckBox();
            this.tabControl.SuspendLayout();
            this.mainPage.SuspendLayout();
            this.settingsPage.SuspendLayout();
            this.imageProfilePage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.previewPictureBox)).BeginInit();
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
            "Nekos (Image)",
            "Avatar (Image)",
            "Tickle (GIF)",
            "Slap (GIF)",
            "Poke (GIF)",
            "Pat (GIF)",
            "Kiss (GIF)",
            "Hug (GIF)",
            "Cuddle (GIF)"});
            this.nekosEndpointSelection.Location = new System.Drawing.Point(139, 93);
            this.nekosEndpointSelection.MaxDropDownItems = 4;
            this.nekosEndpointSelection.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.nekosEndpointSelection.Name = "nekosEndpointSelection";
            this.nekosEndpointSelection.Size = new System.Drawing.Size(187, 49);
            this.nekosEndpointSelection.StartIndex = 0;
            this.nekosEndpointSelection.TabIndex = 0;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(6, 39);
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
            this.imageTypeSelection.Location = new System.Drawing.Point(139, 25);
            this.imageTypeSelection.MaxDropDownItems = 4;
            this.imageTypeSelection.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.imageTypeSelection.Name = "imageTypeSelection";
            this.imageTypeSelection.Size = new System.Drawing.Size(187, 49);
            this.imageTypeSelection.StartIndex = 0;
            this.imageTypeSelection.TabIndex = 3;
            this.imageTypeSelection.SelectedIndexChanged += new System.EventHandler(this.ImageTypeSelection_SelectedIndexChanged);
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
            // materialTabSelector1
            // 
            this.materialTabSelector1.BaseTabControl = this.tabControl;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTabSelector1.HeadAlignment = ReaLTaiizor.Controls.MaterialTabSelector.Alignment.Left;
            this.materialTabSelector1.Location = new System.Drawing.Point(-13, 63);
            this.materialTabSelector1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.SelectorHideTabName = new string[0];
            this.materialTabSelector1.SelectorNonClickTabPage = new System.Windows.Forms.TabPage[0];
            this.materialTabSelector1.Size = new System.Drawing.Size(368, 42);
            this.materialTabSelector1.TabIndex = 6;
            this.materialTabSelector1.Text = "materialTabSelector1";
            this.materialTabSelector1.TitleTextState = ReaLTaiizor.Controls.MaterialTabSelector.TextStateType.Normal;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.mainPage);
            this.tabControl.Controls.Add(this.settingsPage);
            this.tabControl.Controls.Add(this.imageProfilePage);
            this.tabControl.Depth = 0;
            this.tabControl.Location = new System.Drawing.Point(0, 107);
            this.tabControl.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.tabControl.Multiline = true;
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(355, 317);
            this.tabControl.TabIndex = 7;
            // 
            // mainPage
            // 
            this.mainPage.BackColor = System.Drawing.Color.White;
            this.mainPage.Controls.Add(this.logWindowToggleButton);
            this.mainPage.Controls.Add(this.closeAllButton);
            this.mainPage.Controls.Add(this.stopButton);
            this.mainPage.Controls.Add(this.startButton);
            this.mainPage.Controls.Add(this.materialLabel3);
            this.mainPage.Controls.Add(this.secondsLabel);
            this.mainPage.Controls.Add(this.materialLabel2);
            this.mainPage.Controls.Add(this.secondsTrackBar);
            this.mainPage.Controls.Add(this.materialLabel1);
            this.mainPage.Controls.Add(this.nekosEndpointSelection);
            this.mainPage.Controls.Add(this.imageTypeSelection);
            this.mainPage.Location = new System.Drawing.Point(4, 22);
            this.mainPage.Name = "mainPage";
            this.mainPage.Padding = new System.Windows.Forms.Padding(3);
            this.mainPage.Size = new System.Drawing.Size(347, 291);
            this.mainPage.TabIndex = 0;
            this.mainPage.Text = "Main tab";
            // 
            // logWindowToggleButton
            // 
            this.logWindowToggleButton.AutoSize = false;
            this.logWindowToggleButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.logWindowToggleButton.Depth = 0;
            this.logWindowToggleButton.DrawShadows = true;
            this.logWindowToggleButton.HighEmphasis = true;
            this.logWindowToggleButton.Icon = null;
            this.logWindowToggleButton.Location = new System.Drawing.Point(20, 259);
            this.logWindowToggleButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.logWindowToggleButton.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.logWindowToggleButton.Name = "logWindowToggleButton";
            this.logWindowToggleButton.Size = new System.Drawing.Size(307, 36);
            this.logWindowToggleButton.TabIndex = 18;
            this.logWindowToggleButton.Text = "Toggle Log Window";
            this.logWindowToggleButton.TextState = ReaLTaiizor.Controls.MaterialButton.TextStateType.Normal;
            this.logWindowToggleButton.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.logWindowToggleButton.UseAccentColor = false;
            this.logWindowToggleButton.UseVisualStyleBackColor = true;
            this.logWindowToggleButton.Click += new System.EventHandler(this.ConsoleToggleButton_Click);
            // 
            // closeAllButton
            // 
            this.closeAllButton.AutoSize = false;
            this.closeAllButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.closeAllButton.Depth = 0;
            this.closeAllButton.DrawShadows = true;
            this.closeAllButton.HighEmphasis = true;
            this.closeAllButton.Icon = null;
            this.closeAllButton.Location = new System.Drawing.Point(179, 214);
            this.closeAllButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.closeAllButton.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.closeAllButton.Name = "closeAllButton";
            this.closeAllButton.Size = new System.Drawing.Size(148, 36);
            this.closeAllButton.TabIndex = 17;
            this.closeAllButton.Text = "Close All Windows";
            this.closeAllButton.TextState = ReaLTaiizor.Controls.MaterialButton.TextStateType.Normal;
            this.closeAllButton.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.closeAllButton.UseAccentColor = false;
            this.closeAllButton.UseVisualStyleBackColor = true;
            this.closeAllButton.Click += new System.EventHandler(this.CloseAllButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.AutoSize = false;
            this.stopButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.stopButton.Depth = 0;
            this.stopButton.DrawShadows = true;
            this.stopButton.HighEmphasis = true;
            this.stopButton.Icon = null;
            this.stopButton.Location = new System.Drawing.Point(100, 214);
            this.stopButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.stopButton.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(71, 36);
            this.stopButton.TabIndex = 16;
            this.stopButton.Text = "Stop";
            this.stopButton.TextState = ReaLTaiizor.Controls.MaterialButton.TextStateType.Normal;
            this.stopButton.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.stopButton.UseAccentColor = false;
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // startButton
            // 
            this.startButton.AutoSize = false;
            this.startButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.startButton.Depth = 0;
            this.startButton.DrawShadows = true;
            this.startButton.HighEmphasis = true;
            this.startButton.Icon = null;
            this.startButton.Location = new System.Drawing.Point(20, 214);
            this.startButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.startButton.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(71, 36);
            this.startButton.TabIndex = 15;
            this.startButton.Text = "Start";
            this.startButton.TextState = ReaLTaiizor.Controls.MaterialButton.TextStateType.Normal;
            this.startButton.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.startButton.UseAccentColor = false;
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(6, 109);
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
            this.secondsLabel.Location = new System.Drawing.Point(317, 174);
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
            this.materialLabel2.Location = new System.Drawing.Point(6, 174);
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
            this.secondsTrackBar.Location = new System.Drawing.Point(187, 173);
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
            this.settingsPage.Size = new System.Drawing.Size(347, 291);
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
            this.materialLabel6.Location = new System.Drawing.Point(6, 242);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(52, 18);
            this.materialLabel6.TabIndex = 9;
            this.materialLabel6.Text = "Height";
            // 
            // heightTextBox
            // 
            this.heightTextBox.Depth = 0;
            this.heightTextBox.Location = new System.Drawing.Point(64, 238);
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
            this.materialLabel5.Location = new System.Drawing.Point(6, 211);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(46, 18);
            this.materialLabel5.TabIndex = 7;
            this.materialLabel5.Text = "Width";
            // 
            // widthTextBox
            // 
            this.widthTextBox.Depth = 0;
            this.widthTextBox.Location = new System.Drawing.Point(64, 207);
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
            this.fixedSizeBox.Location = new System.Drawing.Point(2, 157);
            this.fixedSizeBox.Margin = new System.Windows.Forms.Padding(0);
            this.fixedSizeBox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.fixedSizeBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.fixedSizeBox.Name = "fixedSizeBox";
            this.fixedSizeBox.Ripple = true;
            this.fixedSizeBox.Size = new System.Drawing.Size(168, 30);
            this.fixedSizeBox.TabIndex = 5;
            this.fixedSizeBox.Text = "Fixed width and height";
            this.fixedSizeBox.UseVisualStyleBackColor = true;
            this.fixedSizeBox.CheckedChanged += new System.EventHandler(this.FixedSizeBox_CheckedChanged);
            // 
            // dynamicSizeBox
            // 
            this.dynamicSizeBox.AutoSize = true;
            this.dynamicSizeBox.Depth = 0;
            this.dynamicSizeBox.Enabled = false;
            this.dynamicSizeBox.Font = new System.Drawing.Font("Roboto", 10F);
            this.dynamicSizeBox.Location = new System.Drawing.Point(2, 129);
            this.dynamicSizeBox.Margin = new System.Windows.Forms.Padding(0);
            this.dynamicSizeBox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.dynamicSizeBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.dynamicSizeBox.Name = "dynamicSizeBox";
            this.dynamicSizeBox.Ripple = true;
            this.dynamicSizeBox.Size = new System.Drawing.Size(189, 30);
            this.dynamicSizeBox.TabIndex = 4;
            this.dynamicSizeBox.Text = "Dynamic width and height";
            this.dynamicSizeBox.UseVisualStyleBackColor = true;
            this.dynamicSizeBox.CheckedChanged += new System.EventHandler(this.DynamicSizeBox_CheckedChanged);
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(112, 93);
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
            // imageProfilePage
            // 
            this.imageProfilePage.BackColor = System.Drawing.Color.White;
            this.imageProfilePage.Controls.Add(this.materialLabel9);
            this.imageProfilePage.Controls.Add(this.previewPictureBox);
            this.imageProfilePage.Controls.Add(this.imageListView);
            this.imageProfilePage.Location = new System.Drawing.Point(4, 22);
            this.imageProfilePage.Name = "imageProfilePage";
            this.imageProfilePage.Size = new System.Drawing.Size(347, 291);
            this.imageProfilePage.TabIndex = 2;
            this.imageProfilePage.Text = "Image Profile";
            // 
            // materialLabel9
            // 
            this.materialLabel9.AutoSize = true;
            this.materialLabel9.Depth = 0;
            this.materialLabel9.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel9.Location = new System.Drawing.Point(24, 3);
            this.materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel9.Name = "materialLabel9";
            this.materialLabel9.Size = new System.Drawing.Size(303, 18);
            this.materialLabel9.TabIndex = 11;
            this.materialLabel9.Text = "Click on the preview image to see it full-size";
            // 
            // previewPictureBox
            // 
            this.previewPictureBox.BackColor = System.Drawing.Color.LightGray;
            this.previewPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.previewPictureBox.Location = new System.Drawing.Point(115, 200);
            this.previewPictureBox.Name = "previewPictureBox";
            this.previewPictureBox.Size = new System.Drawing.Size(114, 114);
            this.previewPictureBox.TabIndex = 10;
            this.previewPictureBox.TabStop = false;
            this.previewPictureBox.Click += new System.EventHandler(this.PreviewPictureBox_Click);
            // 
            // imageListView
            // 
            this.imageListView.AutoSizeTable = false;
            this.imageListView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.imageListView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imageListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nameColumn,
            this.widthColumn,
            this.heightColumn,
            this.creationDateColumn});
            this.imageListView.Depth = 0;
            this.imageListView.FullRowSelect = true;
            this.imageListView.GridLines = true;
            this.imageListView.HideSelection = false;
            this.imageListView.Location = new System.Drawing.Point(4, 24);
            this.imageListView.MinimumSize = new System.Drawing.Size(200, 100);
            this.imageListView.MouseLocation = new System.Drawing.Point(-1, -1);
            this.imageListView.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.imageListView.MultiSelect = false;
            this.imageListView.Name = "imageListView";
            this.imageListView.OwnerDraw = true;
            this.imageListView.Size = new System.Drawing.Size(343, 170);
            this.imageListView.TabIndex = 1;
            this.imageListView.UseCompatibleStateImageBehavior = false;
            this.imageListView.View = System.Windows.Forms.View.Details;
            this.imageListView.SelectedIndexChanged += new System.EventHandler(this.ImageListView_SelectedIndexChanged);
            // 
            // nameColumn
            // 
            this.nameColumn.Text = "Name";
            this.nameColumn.Width = 72;
            // 
            // widthColumn
            // 
            this.widthColumn.Text = "Width";
            this.widthColumn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.widthColumn.Width = 83;
            // 
            // heightColumn
            // 
            this.heightColumn.Text = "Height";
            this.heightColumn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.heightColumn.Width = 76;
            // 
            // creationDateColumn
            // 
            this.creationDateColumn.Text = "Creation";
            this.creationDateColumn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.creationDateColumn.Width = 110;
            // 
            // materialCheckBox1
            // 
            this.materialCheckBox1.Depth = 0;
            this.materialCheckBox1.Location = new System.Drawing.Point(0, 0);
            this.materialCheckBox1.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckBox1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckBox1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.materialCheckBox1.Name = "materialCheckBox1";
            this.materialCheckBox1.Ripple = true;
            this.materialCheckBox1.Size = new System.Drawing.Size(104, 37);
            this.materialCheckBox1.TabIndex = 0;
            this.materialCheckBox1.Text = "materialCheckBox1";
            this.materialCheckBox1.UseVisualStyleBackColor = true;
            // 
            // materialCheckBox2
            // 
            this.materialCheckBox2.Depth = 0;
            this.materialCheckBox2.Location = new System.Drawing.Point(0, 0);
            this.materialCheckBox2.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckBox2.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckBox2.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.materialCheckBox2.Name = "materialCheckBox2";
            this.materialCheckBox2.Ripple = true;
            this.materialCheckBox2.Size = new System.Drawing.Size(104, 37);
            this.materialCheckBox2.TabIndex = 0;
            this.materialCheckBox2.Text = "materialCheckBox2";
            this.materialCheckBox2.UseVisualStyleBackColor = true;
            // 
            // materialCheckBox3
            // 
            this.materialCheckBox3.Depth = 0;
            this.materialCheckBox3.Location = new System.Drawing.Point(0, 0);
            this.materialCheckBox3.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckBox3.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckBox3.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.materialCheckBox3.Name = "materialCheckBox3";
            this.materialCheckBox3.Ripple = true;
            this.materialCheckBox3.Size = new System.Drawing.Size(104, 37);
            this.materialCheckBox3.TabIndex = 0;
            this.materialCheckBox3.Text = "materialCheckBox3";
            this.materialCheckBox3.UseVisualStyleBackColor = true;
            // 
            // materialCheckBox4
            // 
            this.materialCheckBox4.Depth = 0;
            this.materialCheckBox4.Location = new System.Drawing.Point(0, 0);
            this.materialCheckBox4.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckBox4.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckBox4.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.materialCheckBox4.Name = "materialCheckBox4";
            this.materialCheckBox4.Ripple = true;
            this.materialCheckBox4.Size = new System.Drawing.Size(104, 37);
            this.materialCheckBox4.TabIndex = 0;
            this.materialCheckBox4.Text = "materialCheckBox4";
            this.materialCheckBox4.UseVisualStyleBackColor = true;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 425);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.materialTabSelector1);
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
            this.imageProfilePage.ResumeLayout(false);
            this.imageProfilePage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.previewPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ReaLTaiizor.Controls.MaterialComboBox nekosEndpointSelection;
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
        private ReaLTaiizor.Controls.MaterialSingleTextBox heightTextBox;
        private ReaLTaiizor.Controls.MaterialSingleTextBox widthTextBox;
        private MaterialSkin.Controls.MaterialCheckBox fixedSizeBox;
        private MaterialSkin.Controls.MaterialCheckBox dynamicSizeBox;
        private System.Windows.Forms.TabPage imageProfilePage;
        private ReaLTaiizor.Controls.MaterialCheckBox materialCheckBox1;
        private ReaLTaiizor.Controls.MaterialCheckBox materialCheckBox2;
        private ReaLTaiizor.Controls.MaterialCheckBox materialCheckBox3;
        private ReaLTaiizor.Controls.MaterialCheckBox materialCheckBox4;
        private ReaLTaiizor.Controls.MaterialListView imageListView;
        private System.Windows.Forms.ColumnHeader nameColumn;
        private System.Windows.Forms.ColumnHeader widthColumn;
        private System.Windows.Forms.ColumnHeader heightColumn;
        private System.Windows.Forms.ColumnHeader creationDateColumn;
        private System.Windows.Forms.PictureBox previewPictureBox;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private ReaLTaiizor.Controls.MaterialButton startButton;
        private ReaLTaiizor.Controls.MaterialButton stopButton;
        private ReaLTaiizor.Controls.MaterialButton logWindowToggleButton;
        private ReaLTaiizor.Controls.MaterialButton closeAllButton;
    }
}