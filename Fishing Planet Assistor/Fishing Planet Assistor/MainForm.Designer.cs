namespace Fishing_Planet_Assistor
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusKeys = new System.Windows.Forms.ToolStripStatusLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.radCasting = new System.Windows.Forms.RadioButton();
            this.radSpinning = new System.Windows.Forms.RadioButton();
            this.radFloating = new System.Windows.Forms.RadioButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileLoad = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileSave = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.updatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.retrieveTease = new System.Windows.Forms.RadioButton();
            this.label20 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.retrievePlain = new System.Windows.Forms.RadioButton();
            this.retrieveLiftDrop = new System.Windows.Forms.RadioButton();
            this.retrieveTwitch = new System.Windows.Forms.RadioButton();
            this.retrieveStopGo = new System.Windows.Forms.RadioButton();
            this.retrieveStraight = new System.Windows.Forms.RadioButton();
            this.retrieveSlowStraight = new System.Windows.Forms.RadioButton();
            this.numSpeed = new System.Windows.Forms.NumericUpDown();
            this.numJerking = new System.Windows.Forms.NumericUpDown();
            this.numReeling = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.timerReeling = new System.Windows.Forms.Timer(this.components);
            this.timerJerking = new System.Windows.Forms.Timer(this.components);
            this.settingsOpenDialog = new System.Windows.Forms.OpenFileDialog();
            this.settingsSaveDialog = new System.Windows.Forms.SaveFileDialog();
            this.tabRetrieve = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.numJerkPulse = new System.Windows.Forms.NumericUpDown();
            this.numReelPulse = new System.Windows.Forms.NumericUpDown();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnPounds = new System.Windows.Forms.Button();
            this.btnOunce = new System.Windows.Forms.Button();
            this.btnKilograms = new System.Windows.Forms.Button();
            this.btnGrams = new System.Windows.Forms.Button();
            this.btnFeet = new System.Windows.Forms.Button();
            this.btnInches = new System.Windows.Forms.Button();
            this.btnMeters = new System.Windows.Forms.Button();
            this.btnCentimeters = new System.Windows.Forms.Button();
            this.label36 = new System.Windows.Forms.Label();
            this.txtPounds = new System.Windows.Forms.TextBox();
            this.label37 = new System.Windows.Forms.Label();
            this.txtOunce = new System.Windows.Forms.TextBox();
            this.label38 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.txtKilograms = new System.Windows.Forms.TextBox();
            this.txtGrams = new System.Windows.Forms.TextBox();
            this.label35 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.txtFeet = new System.Windows.Forms.TextBox();
            this.label33 = new System.Windows.Forms.Label();
            this.txtInches = new System.Windows.Forms.TextBox();
            this.label32 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.txtMeters = new System.Windows.Forms.TextBox();
            this.txtCentimeters = new System.Windows.Forms.TextBox();
            this.btnReload = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.tJerk = new System.Windows.Forms.Timer(this.components);
            this.tReel = new System.Windows.Forms.Timer(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label29 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.tJerkTemp = new System.Windows.Forms.Timer(this.components);
            this.tabSettings = new System.Windows.Forms.TabControl();
            this.tabFloat = new System.Windows.Forms.TabPage();
            this.lvFloat = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabSpin = new System.Windows.Forms.TabPage();
            this.lvSpin = new System.Windows.Forms.ListView();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabCast = new System.Windows.Forms.TabPage();
            this.lvCast = new System.Windows.Forms.ListView();
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader16 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader17 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader18 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numJerking)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numReeling)).BeginInit();
            this.tabRetrieve.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numJerkPulse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numReelPulse)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabSettings.SuspendLayout();
            this.tabFloat.SuspendLayout();
            this.tabSpin.SuspendLayout();
            this.tabCast.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel,
            this.statusKeys});
            this.statusStrip1.Location = new System.Drawing.Point(0, 657);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(587, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(12, 17);
            this.statusLabel.Text = "-";
            // 
            // statusKeys
            // 
            this.statusKeys.Name = "statusKeys";
            this.statusKeys.Size = new System.Drawing.Size(12, 17);
            this.statusKeys.Text = "-";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(243, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "HOTKEY: F9";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label23);
            this.groupBox1.Controls.Add(this.label22);
            this.groupBox1.Controls.Add(this.label21);
            this.groupBox1.Controls.Add(this.radCasting);
            this.groupBox1.Controls.Add(this.radSpinning);
            this.groupBox1.Controls.Add(this.radFloating);
            this.groupBox1.ForeColor = System.Drawing.Color.Green;
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(225, 93);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Fishing Mode";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label23.Location = new System.Drawing.Point(158, 68);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(61, 14);
            this.label23.TabIndex = 34;
            this.label23.Text = "NUMPAD 8";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label22.Location = new System.Drawing.Point(158, 44);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(61, 14);
            this.label22.TabIndex = 33;
            this.label22.Text = "NUMPAD 8";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label21.Location = new System.Drawing.Point(158, 21);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(61, 14);
            this.label21.TabIndex = 32;
            this.label21.Text = "NUMPAD 7";
            // 
            // radCasting
            // 
            this.radCasting.AutoSize = true;
            this.radCasting.Checked = true;
            this.radCasting.ForeColor = System.Drawing.Color.Black;
            this.radCasting.Location = new System.Drawing.Point(6, 66);
            this.radCasting.Name = "radCasting";
            this.radCasting.Size = new System.Drawing.Size(128, 17);
            this.radCasting.TabIndex = 5;
            this.radCasting.TabStop = true;
            this.radCasting.Text = "Cast Fishing / Casting";
            this.radCasting.UseVisualStyleBackColor = true;
            this.radCasting.CheckedChanged += new System.EventHandler(this.radCasting_CheckedChanged);
            // 
            // radSpinning
            // 
            this.radSpinning.AutoSize = true;
            this.radSpinning.ForeColor = System.Drawing.Color.Black;
            this.radSpinning.Location = new System.Drawing.Point(6, 42);
            this.radSpinning.Name = "radSpinning";
            this.radSpinning.Size = new System.Drawing.Size(134, 17);
            this.radSpinning.TabIndex = 4;
            this.radSpinning.Text = "Spin Fishing / Spinning";
            this.radSpinning.UseVisualStyleBackColor = true;
            this.radSpinning.CheckedChanged += new System.EventHandler(this.radSpinning_CheckedChanged);
            // 
            // radFloating
            // 
            this.radFloating.AutoSize = true;
            this.radFloating.ForeColor = System.Drawing.Color.Black;
            this.radFloating.Location = new System.Drawing.Point(6, 19);
            this.radFloating.Name = "radFloating";
            this.radFloating.Size = new System.Drawing.Size(132, 17);
            this.radFloating.TabIndex = 0;
            this.radFloating.Text = "Float Fishing / Floating";
            this.radFloating.UseVisualStyleBackColor = true;
            this.radFloating.CheckedChanged += new System.EventHandler(this.radFloating_CheckedChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuAbout,
            this.updatesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(587, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFileLoad,
            this.mnuFileSave,
            this.toolStripMenuItem1,
            this.mnuFileExit});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(37, 20);
            this.mnuFile.Text = "&File";
            // 
            // mnuFileLoad
            // 
            this.mnuFileLoad.Name = "mnuFileLoad";
            this.mnuFileLoad.Size = new System.Drawing.Size(145, 22);
            this.mnuFileLoad.Text = "Load Settings";
            this.mnuFileLoad.Click += new System.EventHandler(this.mnuFileLoad_Click);
            // 
            // mnuFileSave
            // 
            this.mnuFileSave.Name = "mnuFileSave";
            this.mnuFileSave.Size = new System.Drawing.Size(145, 22);
            this.mnuFileSave.Text = "Save Settings";
            this.mnuFileSave.Click += new System.EventHandler(this.mnuFileSave_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(142, 6);
            // 
            // mnuFileExit
            // 
            this.mnuFileExit.Name = "mnuFileExit";
            this.mnuFileExit.Size = new System.Drawing.Size(145, 22);
            this.mnuFileExit.Text = "E&xit";
            this.mnuFileExit.Click += new System.EventHandler(this.mnuFileExit_Click);
            // 
            // mnuAbout
            // 
            this.mnuAbout.Name = "mnuAbout";
            this.mnuAbout.Size = new System.Drawing.Size(52, 20);
            this.mnuAbout.Text = "&About";
            this.mnuAbout.Click += new System.EventHandler(this.mnuAbout_Click);
            // 
            // updatesToolStripMenuItem
            // 
            this.updatesToolStripMenuItem.Name = "updatesToolStripMenuItem";
            this.updatesToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.updatesToolStripMenuItem.Text = "&Updates";
            this.updatesToolStripMenuItem.Click += new System.EventHandler(this.updatesToolStripMenuItem_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.retrieveTease);
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.retrievePlain);
            this.groupBox2.Controls.Add(this.retrieveLiftDrop);
            this.groupBox2.Controls.Add(this.retrieveTwitch);
            this.groupBox2.Controls.Add(this.retrieveStopGo);
            this.groupBox2.Controls.Add(this.retrieveStraight);
            this.groupBox2.Controls.Add(this.retrieveSlowStraight);
            this.groupBox2.ForeColor = System.Drawing.Color.Green;
            this.groupBox2.Location = new System.Drawing.Point(12, 126);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(225, 187);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Retrieve Method";
            // 
            // retrieveTease
            // 
            this.retrieveTease.AutoSize = true;
            this.retrieveTease.ForeColor = System.Drawing.Color.Black;
            this.retrieveTease.Location = new System.Drawing.Point(6, 160);
            this.retrieveTease.Name = "retrieveTease";
            this.retrieveTease.Size = new System.Drawing.Size(55, 17);
            this.retrieveTease.TabIndex = 31;
            this.retrieveTease.Text = "Tease";
            this.retrieveTease.UseVisualStyleBackColor = true;
            this.retrieveTease.CheckedChanged += new System.EventHandler(this.retrieveTease_CheckedChanged);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label20.Location = new System.Drawing.Point(158, 163);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(61, 14);
            this.label20.TabIndex = 30;
            this.label20.Text = "NUMPAD 6";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label15.Location = new System.Drawing.Point(158, 139);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(61, 14);
            this.label15.TabIndex = 25;
            this.label15.Text = "NUMPAD 5";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label14.Location = new System.Drawing.Point(158, 91);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(61, 14);
            this.label14.TabIndex = 24;
            this.label14.Text = "NUMPAD 3";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label13.Location = new System.Drawing.Point(158, 116);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(61, 14);
            this.label13.TabIndex = 23;
            this.label13.Text = "NUMPAD 4";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label12.Location = new System.Drawing.Point(158, 67);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(61, 14);
            this.label12.TabIndex = 22;
            this.label12.Text = "NUMPAD 2";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label11.Location = new System.Drawing.Point(158, 44);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 14);
            this.label11.TabIndex = 21;
            this.label11.Text = "NUMPAD 1";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label10.Location = new System.Drawing.Point(158, 21);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 14);
            this.label10.TabIndex = 20;
            this.label10.Text = "NUMPAD 0";
            // 
            // retrievePlain
            // 
            this.retrievePlain.AutoSize = true;
            this.retrievePlain.Checked = true;
            this.retrievePlain.ForeColor = System.Drawing.Color.Black;
            this.retrievePlain.Location = new System.Drawing.Point(6, 19);
            this.retrievePlain.Name = "retrievePlain";
            this.retrievePlain.Size = new System.Drawing.Size(48, 17);
            this.retrievePlain.TabIndex = 5;
            this.retrievePlain.TabStop = true;
            this.retrievePlain.Text = "Plain";
            this.retrievePlain.UseVisualStyleBackColor = true;
            this.retrievePlain.CheckedChanged += new System.EventHandler(this.retrievePlain_CheckedChanged);
            // 
            // retrieveLiftDrop
            // 
            this.retrieveLiftDrop.AutoSize = true;
            this.retrieveLiftDrop.ForeColor = System.Drawing.Color.Black;
            this.retrieveLiftDrop.Location = new System.Drawing.Point(6, 137);
            this.retrieveLiftDrop.Name = "retrieveLiftDrop";
            this.retrieveLiftDrop.Size = new System.Drawing.Size(65, 17);
            this.retrieveLiftDrop.TabIndex = 4;
            this.retrieveLiftDrop.Text = "Lift-Drop";
            this.retrieveLiftDrop.UseVisualStyleBackColor = true;
            this.retrieveLiftDrop.CheckedChanged += new System.EventHandler(this.retrieveLiftDrop_CheckedChanged);
            // 
            // retrieveTwitch
            // 
            this.retrieveTwitch.AutoSize = true;
            this.retrieveTwitch.ForeColor = System.Drawing.Color.Black;
            this.retrieveTwitch.Location = new System.Drawing.Point(6, 114);
            this.retrieveTwitch.Name = "retrieveTwitch";
            this.retrieveTwitch.Size = new System.Drawing.Size(57, 17);
            this.retrieveTwitch.TabIndex = 3;
            this.retrieveTwitch.Text = "Twitch";
            this.retrieveTwitch.UseVisualStyleBackColor = true;
            this.retrieveTwitch.CheckedChanged += new System.EventHandler(this.retrieveTwitch_CheckedChanged);
            // 
            // retrieveStopGo
            // 
            this.retrieveStopGo.AutoSize = true;
            this.retrieveStopGo.ForeColor = System.Drawing.Color.Black;
            this.retrieveStopGo.Location = new System.Drawing.Point(6, 89);
            this.retrieveStopGo.Name = "retrieveStopGo";
            this.retrieveStopGo.Size = new System.Drawing.Size(64, 17);
            this.retrieveStopGo.TabIndex = 2;
            this.retrieveStopGo.Text = "Stop-Go";
            this.retrieveStopGo.UseVisualStyleBackColor = true;
            this.retrieveStopGo.CheckedChanged += new System.EventHandler(this.retrieveStopGo_CheckedChanged);
            // 
            // retrieveStraight
            // 
            this.retrieveStraight.AutoSize = true;
            this.retrieveStraight.ForeColor = System.Drawing.Color.Black;
            this.retrieveStraight.Location = new System.Drawing.Point(6, 65);
            this.retrieveStraight.Name = "retrieveStraight";
            this.retrieveStraight.Size = new System.Drawing.Size(61, 17);
            this.retrieveStraight.TabIndex = 1;
            this.retrieveStraight.Text = "Straight";
            this.retrieveStraight.UseVisualStyleBackColor = true;
            this.retrieveStraight.CheckedChanged += new System.EventHandler(this.retrieveStraight_CheckedChanged);
            // 
            // retrieveSlowStraight
            // 
            this.retrieveSlowStraight.AutoSize = true;
            this.retrieveSlowStraight.ForeColor = System.Drawing.Color.Black;
            this.retrieveSlowStraight.Location = new System.Drawing.Point(6, 42);
            this.retrieveSlowStraight.Name = "retrieveSlowStraight";
            this.retrieveSlowStraight.Size = new System.Drawing.Size(87, 17);
            this.retrieveSlowStraight.TabIndex = 0;
            this.retrieveSlowStraight.Text = "Slow-Straight";
            this.retrieveSlowStraight.UseVisualStyleBackColor = true;
            this.retrieveSlowStraight.CheckedChanged += new System.EventHandler(this.retrieveSlowStraight_CheckedChanged);
            // 
            // numSpeed
            // 
            this.numSpeed.Location = new System.Drawing.Point(118, 80);
            this.numSpeed.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numSpeed.Name = "numSpeed";
            this.numSpeed.Size = new System.Drawing.Size(43, 20);
            this.numSpeed.TabIndex = 5;
            this.numSpeed.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numSpeed.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numSpeed.Click += new System.EventHandler(this.numSpeed_Click);
            this.numSpeed.Validating += new System.ComponentModel.CancelEventHandler(this.numSpeed_Validating);
            // 
            // numJerking
            // 
            this.numJerking.Location = new System.Drawing.Point(93, 47);
            this.numJerking.Maximum = new decimal(new int[] {
            3600000,
            0,
            0,
            0});
            this.numJerking.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numJerking.Name = "numJerking";
            this.numJerking.Size = new System.Drawing.Size(68, 20);
            this.numJerking.TabIndex = 6;
            this.numJerking.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numJerking.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numJerking.ValueChanged += new System.EventHandler(this.numJerking_ValueChanged);
            this.numJerking.Click += new System.EventHandler(this.numJerking_Click);
            this.numJerking.Validating += new System.ComponentModel.CancelEventHandler(this.numJerking_Validating);
            // 
            // numReeling
            // 
            this.numReeling.Location = new System.Drawing.Point(93, 17);
            this.numReeling.Maximum = new decimal(new int[] {
            3600000,
            0,
            0,
            0});
            this.numReeling.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numReeling.Name = "numReeling";
            this.numReeling.Size = new System.Drawing.Size(68, 20);
            this.numReeling.TabIndex = 7;
            this.numReeling.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numReeling.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numReeling.ValueChanged += new System.EventHandler(this.numReeling_ValueChanged);
            this.numReeling.Click += new System.EventHandler(this.numReeling_Click);
            this.numReeling.Validating += new System.ComponentModel.CancelEventHandler(this.numReeling_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(167, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "ms";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(167, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "ms";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Jerking Interval";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Reeling Interval";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Reeling Speed";
            // 
            // timerReeling
            // 
            this.timerReeling.Tick += new System.EventHandler(this.timerReeling_Tick);
            // 
            // timerJerking
            // 
            this.timerJerking.Tick += new System.EventHandler(this.timerJerking_Tick);
            // 
            // settingsOpenDialog
            // 
            this.settingsOpenDialog.Filter = "XML Settings|*.fpa";
            // 
            // settingsSaveDialog
            // 
            this.settingsSaveDialog.Filter = "XML Settings|*.fpa";
            // 
            // tabRetrieve
            // 
            this.tabRetrieve.Controls.Add(this.tabPage1);
            this.tabRetrieve.Controls.Add(this.tabPage2);
            this.tabRetrieve.Location = new System.Drawing.Point(243, 67);
            this.tabRetrieve.Name = "tabRetrieve";
            this.tabRetrieve.SelectedIndex = 0;
            this.tabRetrieve.Size = new System.Drawing.Size(334, 246);
            this.tabRetrieve.TabIndex = 19;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnModify);
            this.tabPage1.Controls.Add(this.btnRemove);
            this.tabPage1.Controls.Add(this.btnAdd);
            this.tabPage1.Controls.Add(this.txtDescription);
            this.tabPage1.Controls.Add(this.label18);
            this.tabPage1.Controls.Add(this.label24);
            this.tabPage1.Controls.Add(this.label19);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.numJerkPulse);
            this.tabPage1.Controls.Add(this.numReelPulse);
            this.tabPage1.Controls.Add(this.label17);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.numSpeed);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label16);
            this.tabPage1.Controls.Add(this.numJerking);
            this.tabPage1.Controls.Add(this.numReeling);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(326, 220);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Retrieve Settings";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(153, 191);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(75, 23);
            this.btnModify.TabIndex = 36;
            this.btnModify.Text = "MODIFY";
            this.toolTip1.SetToolTip(this.btnModify, "Modify a selected setting below");
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(234, 191);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 35;
            this.btnRemove.Text = "REMOVE";
            this.toolTip1.SetToolTip(this.btnRemove, "Remove selected item from the list below");
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(72, 191);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "ADD";
            this.toolTip1.SetToolTip(this.btnAdd, "Add settings to the list below");
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(72, 167);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(248, 20);
            this.txtDescription.TabIndex = 34;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(8, 170);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(60, 13);
            this.label18.TabIndex = 33;
            this.label18.Text = "Description";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label24.Location = new System.Drawing.Point(205, 137);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(64, 14);
            this.label24.TabIndex = 30;
            this.label24.Text = "NUMPAD \'.\'";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(53, 137);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(94, 13);
            this.label19.TabIndex = 29;
            this.label19.Text = "Reset Reel Speed";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(203, 49);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Jerk Pulse";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(201, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Reel Pulse";
            // 
            // numJerkPulse
            // 
            this.numJerkPulse.Location = new System.Drawing.Point(265, 44);
            this.numJerkPulse.Maximum = new decimal(new int[] {
            60000,
            0,
            0,
            0});
            this.numJerkPulse.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numJerkPulse.Name = "numJerkPulse";
            this.numJerkPulse.Size = new System.Drawing.Size(55, 20);
            this.numJerkPulse.TabIndex = 14;
            this.numJerkPulse.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numJerkPulse.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numJerkPulse.Click += new System.EventHandler(this.numJerkPulse_Click);
            this.numJerkPulse.Validating += new System.ComponentModel.CancelEventHandler(this.numJerkPulse_Validating);
            // 
            // numReelPulse
            // 
            this.numReelPulse.Location = new System.Drawing.Point(265, 17);
            this.numReelPulse.Maximum = new decimal(new int[] {
            60000,
            0,
            0,
            0});
            this.numReelPulse.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numReelPulse.Name = "numReelPulse";
            this.numReelPulse.Size = new System.Drawing.Size(55, 20);
            this.numReelPulse.TabIndex = 13;
            this.numReelPulse.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numReelPulse.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numReelPulse.Click += new System.EventHandler(this.numReelPulse_Click);
            this.numReelPulse.Validating += new System.ComponentModel.CancelEventHandler(this.numReelPulse_Validating);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(53, 114);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(82, 13);
            this.label17.TabIndex = 27;
            this.label17.Text = "Emergency Halt";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label16.Location = new System.Drawing.Point(190, 114);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(85, 14);
            this.label16.TabIndex = 26;
            this.label16.Text = "PAUSE / BREAK";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnPounds);
            this.tabPage2.Controls.Add(this.btnOunce);
            this.tabPage2.Controls.Add(this.btnKilograms);
            this.tabPage2.Controls.Add(this.btnGrams);
            this.tabPage2.Controls.Add(this.btnFeet);
            this.tabPage2.Controls.Add(this.btnInches);
            this.tabPage2.Controls.Add(this.btnMeters);
            this.tabPage2.Controls.Add(this.btnCentimeters);
            this.tabPage2.Controls.Add(this.label36);
            this.tabPage2.Controls.Add(this.txtPounds);
            this.tabPage2.Controls.Add(this.label37);
            this.tabPage2.Controls.Add(this.txtOunce);
            this.tabPage2.Controls.Add(this.label38);
            this.tabPage2.Controls.Add(this.label39);
            this.tabPage2.Controls.Add(this.txtKilograms);
            this.tabPage2.Controls.Add(this.txtGrams);
            this.tabPage2.Controls.Add(this.label35);
            this.tabPage2.Controls.Add(this.label34);
            this.tabPage2.Controls.Add(this.txtFeet);
            this.tabPage2.Controls.Add(this.label33);
            this.tabPage2.Controls.Add(this.txtInches);
            this.tabPage2.Controls.Add(this.label32);
            this.tabPage2.Controls.Add(this.label31);
            this.tabPage2.Controls.Add(this.label30);
            this.tabPage2.Controls.Add(this.txtMeters);
            this.tabPage2.Controls.Add(this.txtCentimeters);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(326, 220);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Quick Convert";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnPounds
            // 
            this.btnPounds.Location = new System.Drawing.Point(280, 167);
            this.btnPounds.Name = "btnPounds";
            this.btnPounds.Size = new System.Drawing.Size(30, 23);
            this.btnPounds.TabIndex = 25;
            this.btnPounds.Text = "go";
            this.btnPounds.UseVisualStyleBackColor = true;
            this.btnPounds.Click += new System.EventHandler(this.btnPounds_Click);
            // 
            // btnOunce
            // 
            this.btnOunce.Location = new System.Drawing.Point(280, 128);
            this.btnOunce.Name = "btnOunce";
            this.btnOunce.Size = new System.Drawing.Size(30, 23);
            this.btnOunce.TabIndex = 24;
            this.btnOunce.Text = "go";
            this.btnOunce.UseVisualStyleBackColor = true;
            this.btnOunce.Click += new System.EventHandler(this.btnOunce_Click);
            // 
            // btnKilograms
            // 
            this.btnKilograms.Location = new System.Drawing.Point(280, 91);
            this.btnKilograms.Name = "btnKilograms";
            this.btnKilograms.Size = new System.Drawing.Size(30, 23);
            this.btnKilograms.TabIndex = 23;
            this.btnKilograms.Text = "go";
            this.btnKilograms.UseVisualStyleBackColor = true;
            this.btnKilograms.Click += new System.EventHandler(this.btnKilograms_Click);
            // 
            // btnGrams
            // 
            this.btnGrams.Location = new System.Drawing.Point(280, 50);
            this.btnGrams.Name = "btnGrams";
            this.btnGrams.Size = new System.Drawing.Size(30, 23);
            this.btnGrams.TabIndex = 22;
            this.btnGrams.Text = "go";
            this.btnGrams.UseVisualStyleBackColor = true;
            this.btnGrams.Click += new System.EventHandler(this.btnGrams_Click);
            // 
            // btnFeet
            // 
            this.btnFeet.Location = new System.Drawing.Point(123, 169);
            this.btnFeet.Name = "btnFeet";
            this.btnFeet.Size = new System.Drawing.Size(30, 23);
            this.btnFeet.TabIndex = 21;
            this.btnFeet.Text = "go";
            this.btnFeet.UseVisualStyleBackColor = true;
            this.btnFeet.Click += new System.EventHandler(this.btnFeet_Click);
            // 
            // btnInches
            // 
            this.btnInches.Location = new System.Drawing.Point(123, 128);
            this.btnInches.Name = "btnInches";
            this.btnInches.Size = new System.Drawing.Size(30, 23);
            this.btnInches.TabIndex = 20;
            this.btnInches.Text = "go";
            this.btnInches.UseVisualStyleBackColor = true;
            this.btnInches.Click += new System.EventHandler(this.btnInches_Click);
            // 
            // btnMeters
            // 
            this.btnMeters.Location = new System.Drawing.Point(123, 89);
            this.btnMeters.Name = "btnMeters";
            this.btnMeters.Size = new System.Drawing.Size(30, 23);
            this.btnMeters.TabIndex = 19;
            this.btnMeters.Text = "go";
            this.btnMeters.UseVisualStyleBackColor = true;
            this.btnMeters.Click += new System.EventHandler(this.btnMeters_Click);
            // 
            // btnCentimeters
            // 
            this.btnCentimeters.Location = new System.Drawing.Point(123, 50);
            this.btnCentimeters.Name = "btnCentimeters";
            this.btnCentimeters.Size = new System.Drawing.Size(30, 23);
            this.btnCentimeters.TabIndex = 18;
            this.btnCentimeters.Text = "go";
            this.btnCentimeters.UseVisualStyleBackColor = true;
            this.btnCentimeters.Click += new System.EventHandler(this.btnCentimeters_Click);
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(255, 172);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(15, 13);
            this.label36.TabIndex = 17;
            this.label36.Text = "lb";
            // 
            // txtPounds
            // 
            this.txtPounds.Location = new System.Drawing.Point(174, 169);
            this.txtPounds.Name = "txtPounds";
            this.txtPounds.Size = new System.Drawing.Size(75, 20);
            this.txtPounds.TabIndex = 16;
            this.txtPounds.Text = "0";
            this.txtPounds.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPounds.Click += new System.EventHandler(this.txtPounds_Click);
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(255, 133);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(18, 13);
            this.label37.TabIndex = 15;
            this.label37.Text = "oz";
            // 
            // txtOunce
            // 
            this.txtOunce.Location = new System.Drawing.Point(174, 130);
            this.txtOunce.Name = "txtOunce";
            this.txtOunce.Size = new System.Drawing.Size(75, 20);
            this.txtOunce.TabIndex = 14;
            this.txtOunce.Text = "0";
            this.txtOunce.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtOunce.Click += new System.EventHandler(this.txtOunce_Click);
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(255, 94);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(19, 13);
            this.label38.TabIndex = 13;
            this.label38.Text = "kg";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(255, 55);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(13, 13);
            this.label39.TabIndex = 12;
            this.label39.Text = "g";
            // 
            // txtKilograms
            // 
            this.txtKilograms.Location = new System.Drawing.Point(174, 91);
            this.txtKilograms.Name = "txtKilograms";
            this.txtKilograms.Size = new System.Drawing.Size(75, 20);
            this.txtKilograms.TabIndex = 11;
            this.txtKilograms.Text = "0";
            this.txtKilograms.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtKilograms.Click += new System.EventHandler(this.txtKilograms_Click);
            // 
            // txtGrams
            // 
            this.txtGrams.Location = new System.Drawing.Point(174, 52);
            this.txtGrams.Name = "txtGrams";
            this.txtGrams.Size = new System.Drawing.Size(75, 20);
            this.txtGrams.TabIndex = 10;
            this.txtGrams.Text = "0";
            this.txtGrams.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtGrams.Click += new System.EventHandler(this.txtGrams_Click);
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.ForeColor = System.Drawing.Color.Green;
            this.label35.Location = new System.Drawing.Point(171, 18);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(32, 13);
            this.label35.TabIndex = 9;
            this.label35.Text = "Mass";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(96, 172);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(13, 13);
            this.label34.TabIndex = 8;
            this.label34.Text = "ft";
            // 
            // txtFeet
            // 
            this.txtFeet.Location = new System.Drawing.Point(15, 169);
            this.txtFeet.Name = "txtFeet";
            this.txtFeet.Size = new System.Drawing.Size(75, 20);
            this.txtFeet.TabIndex = 7;
            this.txtFeet.Text = "0";
            this.txtFeet.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtFeet.Click += new System.EventHandler(this.txtFeet_Click);
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(96, 133);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(15, 13);
            this.label33.TabIndex = 6;
            this.label33.Text = "in";
            // 
            // txtInches
            // 
            this.txtInches.Location = new System.Drawing.Point(15, 130);
            this.txtInches.Name = "txtInches";
            this.txtInches.Size = new System.Drawing.Size(75, 20);
            this.txtInches.TabIndex = 5;
            this.txtInches.Text = "0";
            this.txtInches.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtInches.Click += new System.EventHandler(this.txtInches_Click);
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(96, 94);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(15, 13);
            this.label32.TabIndex = 4;
            this.label32.Text = "m";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(96, 55);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(21, 13);
            this.label31.TabIndex = 3;
            this.label31.Text = "cm";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.ForeColor = System.Drawing.Color.Green;
            this.label30.Location = new System.Drawing.Point(12, 18);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(49, 13);
            this.label30.TabIndex = 2;
            this.label30.Text = "Distance";
            // 
            // txtMeters
            // 
            this.txtMeters.Location = new System.Drawing.Point(15, 91);
            this.txtMeters.Name = "txtMeters";
            this.txtMeters.Size = new System.Drawing.Size(75, 20);
            this.txtMeters.TabIndex = 1;
            this.txtMeters.Text = "0";
            this.txtMeters.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtMeters.Click += new System.EventHandler(this.txtMeters_Click);
            // 
            // txtCentimeters
            // 
            this.txtCentimeters.Location = new System.Drawing.Point(15, 52);
            this.txtCentimeters.Name = "txtCentimeters";
            this.txtCentimeters.Size = new System.Drawing.Size(75, 20);
            this.txtCentimeters.TabIndex = 0;
            this.txtCentimeters.Text = "0";
            this.txtCentimeters.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCentimeters.Click += new System.EventHandler(this.txtCentimeters_Click);
            // 
            // btnReload
            // 
            this.btnReload.Location = new System.Drawing.Point(498, 37);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(75, 23);
            this.btnReload.TabIndex = 28;
            this.btnReload.Text = "Reload";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // notifyIcon
            // 
            this.notifyIcon.Text = "Fishing Planet Assistor Notification";
            // 
            // tJerk
            // 
            this.tJerk.Interval = 1;
            this.tJerk.Tick += new System.EventHandler(this.tJerk_Tick);
            // 
            // tReel
            // 
            this.tReel.Interval = 1;
            this.tReel.Tick += new System.EventHandler(this.tReel_Tick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label29);
            this.groupBox3.Controls.Add(this.label28);
            this.groupBox3.Controls.Add(this.label27);
            this.groupBox3.Controls.Add(this.label26);
            this.groupBox3.Controls.Add(this.label25);
            this.groupBox3.ForeColor = System.Drawing.Color.Green;
            this.groupBox3.Location = new System.Drawing.Point(12, 524);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(561, 130);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "How to use";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.ForeColor = System.Drawing.Color.Black;
            this.label29.Location = new System.Drawing.Point(66, 92);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(225, 13);
            this.label29.TabIndex = 4;
            this.label29.Text = "Toggle OFF when you need to re-cast the rod.";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.ForeColor = System.Drawing.Color.Black;
            this.label28.Location = new System.Drawing.Point(66, 79);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(418, 13);
            this.label28.TabIndex = 3;
            this.label28.Text = "Toggle ON the retrieval methods except \'Plain Retrieve\' after casting the rod to " +
    "perform.";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.ForeColor = System.Drawing.Color.Black;
            this.label27.Location = new System.Drawing.Point(30, 66);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(83, 13);
            this.label27.TabIndex = 2;
            this.label27.Text = "RETRIEVING";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.ForeColor = System.Drawing.Color.Black;
            this.label26.Location = new System.Drawing.Point(66, 39);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(462, 13);
            this.label26.TabIndex = 1;
            this.label26.Text = "Toggle ON \'Plain Retrieve\' when the fish bites then Toggle OFF after pulling the " +
    "fish out of water.";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.ForeColor = System.Drawing.Color.Black;
            this.label25.Location = new System.Drawing.Point(30, 26);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(70, 13);
            this.label25.TabIndex = 0;
            this.label25.Text = "CATCHING";
            // 
            // tJerkTemp
            // 
            this.tJerkTemp.Interval = 1;
            this.tJerkTemp.Tick += new System.EventHandler(this.tJerkTemp_Tick);
            // 
            // tabSettings
            // 
            this.tabSettings.Controls.Add(this.tabFloat);
            this.tabSettings.Controls.Add(this.tabSpin);
            this.tabSettings.Controls.Add(this.tabCast);
            this.tabSettings.Location = new System.Drawing.Point(12, 319);
            this.tabSettings.Name = "tabSettings";
            this.tabSettings.SelectedIndex = 0;
            this.tabSettings.Size = new System.Drawing.Size(565, 199);
            this.tabSettings.TabIndex = 22;
            // 
            // tabFloat
            // 
            this.tabFloat.Controls.Add(this.lvFloat);
            this.tabFloat.Location = new System.Drawing.Point(4, 22);
            this.tabFloat.Name = "tabFloat";
            this.tabFloat.Padding = new System.Windows.Forms.Padding(3);
            this.tabFloat.Size = new System.Drawing.Size(557, 173);
            this.tabFloat.TabIndex = 0;
            this.tabFloat.Text = "Float Settings";
            this.tabFloat.UseVisualStyleBackColor = true;
            // 
            // lvFloat
            // 
            this.lvFloat.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lvFloat.FullRowSelect = true;
            this.lvFloat.HideSelection = false;
            this.lvFloat.Location = new System.Drawing.Point(7, 7);
            this.lvFloat.Name = "lvFloat";
            this.lvFloat.Size = new System.Drawing.Size(544, 160);
            this.lvFloat.TabIndex = 0;
            this.lvFloat.UseCompatibleStateImageBehavior = false;
            this.lvFloat.View = System.Windows.Forms.View.Details;
            this.lvFloat.SelectedIndexChanged += new System.EventHandler(this.lvFloat_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Reel Interval";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Jerk Interval";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Speed";
            this.columnHeader3.Width = 50;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Reel Pulse";
            this.columnHeader4.Width = 75;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Jerk Pulse";
            this.columnHeader5.Width = 75;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Description";
            this.columnHeader6.Width = 140;
            // 
            // tabSpin
            // 
            this.tabSpin.Controls.Add(this.lvSpin);
            this.tabSpin.Location = new System.Drawing.Point(4, 22);
            this.tabSpin.Name = "tabSpin";
            this.tabSpin.Padding = new System.Windows.Forms.Padding(3);
            this.tabSpin.Size = new System.Drawing.Size(557, 173);
            this.tabSpin.TabIndex = 1;
            this.tabSpin.Text = "Spin Settings";
            this.tabSpin.UseVisualStyleBackColor = true;
            // 
            // lvSpin
            // 
            this.lvSpin.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12});
            this.lvSpin.FullRowSelect = true;
            this.lvSpin.HideSelection = false;
            this.lvSpin.Location = new System.Drawing.Point(6, 6);
            this.lvSpin.Name = "lvSpin";
            this.lvSpin.Size = new System.Drawing.Size(544, 160);
            this.lvSpin.TabIndex = 1;
            this.lvSpin.UseCompatibleStateImageBehavior = false;
            this.lvSpin.View = System.Windows.Forms.View.Details;
            this.lvSpin.SelectedIndexChanged += new System.EventHandler(this.lvSpin_SelectedIndexChanged);
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Reel Interval";
            this.columnHeader7.Width = 100;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Jerk Interval";
            this.columnHeader8.Width = 100;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Speed";
            this.columnHeader9.Width = 50;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Reel Pulse";
            this.columnHeader10.Width = 75;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Jerk Pulse";
            this.columnHeader11.Width = 75;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Description";
            this.columnHeader12.Width = 140;
            // 
            // tabCast
            // 
            this.tabCast.Controls.Add(this.lvCast);
            this.tabCast.Location = new System.Drawing.Point(4, 22);
            this.tabCast.Name = "tabCast";
            this.tabCast.Padding = new System.Windows.Forms.Padding(3);
            this.tabCast.Size = new System.Drawing.Size(557, 173);
            this.tabCast.TabIndex = 2;
            this.tabCast.Text = "Cast Settings";
            this.tabCast.UseVisualStyleBackColor = true;
            // 
            // lvCast
            // 
            this.lvCast.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader13,
            this.columnHeader14,
            this.columnHeader15,
            this.columnHeader16,
            this.columnHeader17,
            this.columnHeader18});
            this.lvCast.FullRowSelect = true;
            this.lvCast.HideSelection = false;
            this.lvCast.Location = new System.Drawing.Point(6, 6);
            this.lvCast.Name = "lvCast";
            this.lvCast.Size = new System.Drawing.Size(544, 160);
            this.lvCast.TabIndex = 1;
            this.lvCast.UseCompatibleStateImageBehavior = false;
            this.lvCast.View = System.Windows.Forms.View.Details;
            this.lvCast.SelectedIndexChanged += new System.EventHandler(this.lvCast_SelectedIndexChanged);
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "Reel Interval";
            this.columnHeader13.Width = 100;
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "Jerk Interval";
            this.columnHeader14.Width = 100;
            // 
            // columnHeader15
            // 
            this.columnHeader15.Text = "Speed";
            this.columnHeader15.Width = 50;
            // 
            // columnHeader16
            // 
            this.columnHeader16.Text = "Reel Pulse";
            this.columnHeader16.Width = 75;
            // 
            // columnHeader17
            // 
            this.columnHeader17.Text = "Jerk Pulse";
            this.columnHeader17.Width = 75;
            // 
            // columnHeader18
            // 
            this.columnHeader18.Text = "Description";
            this.columnHeader18.Width = 140;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 679);
            this.Controls.Add(this.tabSettings);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.tabRetrieve);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fishing Planet - Assistor";
            this.Activated += new System.EventHandler(this.MainForm_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Enter += new System.EventHandler(this.MainForm_Enter);
            this.Leave += new System.EventHandler(this.MainForm_Leave);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numJerking)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numReeling)).EndInit();
            this.tabRetrieve.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numJerkPulse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numReelPulse)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabSettings.ResumeLayout(false);
            this.tabFloat.ResumeLayout(false);
            this.tabSpin.ResumeLayout(false);
            this.tabCast.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private System.Windows.Forms.ToolStripStatusLabel statusKeys;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuFileLoad;
        private System.Windows.Forms.ToolStripMenuItem mnuFileSave;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mnuFileExit;
        private System.Windows.Forms.ToolStripMenuItem mnuAbout;
        private System.Windows.Forms.RadioButton radCasting;
        private System.Windows.Forms.RadioButton radSpinning;
        private System.Windows.Forms.RadioButton radFloating;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton retrieveSlowStraight;
        private System.Windows.Forms.RadioButton retrieveLiftDrop;
        private System.Windows.Forms.RadioButton retrieveTwitch;
        private System.Windows.Forms.RadioButton retrieveStopGo;
        private System.Windows.Forms.RadioButton retrieveStraight;
        private System.Windows.Forms.RadioButton retrievePlain;
        private System.Windows.Forms.NumericUpDown numSpeed;
        private System.Windows.Forms.NumericUpDown numJerking;
        private System.Windows.Forms.NumericUpDown numReeling;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Timer timerReeling;
        private System.Windows.Forms.Timer timerJerking;
        private System.Windows.Forms.OpenFileDialog settingsOpenDialog;
        private System.Windows.Forms.SaveFileDialog settingsSaveDialog;
        private System.Windows.Forms.TabControl tabRetrieve;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numJerkPulse;
        private System.Windows.Forms.NumericUpDown numReelPulse;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.RadioButton retrieveTease;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Timer tJerk;
        private System.Windows.Forms.Timer tReel;
        private System.Windows.Forms.ToolStripMenuItem updatesToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.TextBox txtFeet;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.TextBox txtInches;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.TextBox txtMeters;
        private System.Windows.Forms.TextBox txtCentimeters;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.TextBox txtPounds;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.TextBox txtOunce;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.TextBox txtKilograms;
        private System.Windows.Forms.TextBox txtGrams;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Button btnPounds;
        private System.Windows.Forms.Button btnOunce;
        private System.Windows.Forms.Button btnKilograms;
        private System.Windows.Forms.Button btnGrams;
        private System.Windows.Forms.Button btnFeet;
        private System.Windows.Forms.Button btnInches;
        private System.Windows.Forms.Button btnMeters;
        private System.Windows.Forms.Button btnCentimeters;
        private System.Windows.Forms.Timer tJerkTemp;
        private System.Windows.Forms.TabControl tabSettings;
        private System.Windows.Forms.TabPage tabFloat;
        private System.Windows.Forms.TabPage tabSpin;
        private System.Windows.Forms.TabPage tabCast;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ListView lvFloat;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListView lvSpin;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ListView lvCast;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.ColumnHeader columnHeader15;
        private System.Windows.Forms.ColumnHeader columnHeader16;
        private System.Windows.Forms.ColumnHeader columnHeader17;
        private System.Windows.Forms.ColumnHeader columnHeader18;
    }
}

