namespace TimeTrackerBeta
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TimerButton = new System.Windows.Forms.Button();
            this.SundayTime = new System.Windows.Forms.TextBox();
            this.TimeTracker = new System.Windows.Forms.Timer(this.components);
            this.MondayTime = new System.Windows.Forms.TextBox();
            this.TotalTime = new System.Windows.Forms.TextBox();
            this.SundayButton = new System.Windows.Forms.RadioButton();
            this.MondayButton = new System.Windows.Forms.RadioButton();
            this.TuesdayButton = new System.Windows.Forms.RadioButton();
            this.WednesdayButton = new System.Windows.Forms.RadioButton();
            this.ThursdayButton = new System.Windows.Forms.RadioButton();
            this.FridayButton = new System.Windows.Forms.RadioButton();
            this.SaturdayButton = new System.Windows.Forms.RadioButton();
            this.TuesdayTime = new System.Windows.Forms.TextBox();
            this.WednesdayTime = new System.Windows.Forms.TextBox();
            this.ThursdayTime = new System.Windows.Forms.TextBox();
            this.FridayTime = new System.Windows.Forms.TextBox();
            this.SaturdayTime = new System.Windows.Forms.TextBox();
            this.totalLabel = new System.Windows.Forms.Label();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.SaveDialog = new System.Windows.Forms.SaveFileDialog();
            this.LoadDialog = new System.Windows.Forms.OpenFileDialog();
            this.SundayLabel = new System.Windows.Forms.Label();
            this.MondayLabel = new System.Windows.Forms.Label();
            this.TuesdayLabel = new System.Windows.Forms.Label();
            this.WednesdayLabel = new System.Windows.Forms.Label();
            this.ThursdayLabel = new System.Windows.Forms.Label();
            this.FridayLabel = new System.Windows.Forms.Label();
            this.SaturdayLabel = new System.Windows.Forms.Label();
            this.averageLabel = new System.Windows.Forms.Label();
            this.AverageTime = new System.Windows.Forms.TextBox();
            this.SundayReset = new System.Windows.Forms.Button();
            this.MondayReset = new System.Windows.Forms.Button();
            this.TuesdayReset = new System.Windows.Forms.Button();
            this.WednesdayReset = new System.Windows.Forms.Button();
            this.ThursdayReset = new System.Windows.Forms.Button();
            this.FridayReset = new System.Windows.Forms.Button();
            this.SaturdayReset = new System.Windows.Forms.Button();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.runningTotalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.supportToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(437, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.loadToolStripMenuItem,
            this.toolStripSeparator2,
            this.exportToolStripMenuItem,
            this.runningTotalToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(228, 6);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.Enabled = false;
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.exportToolStripMenuItem.Text = "Export (Not yet implemented)";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // supportToolStripMenuItem
            // 
            this.supportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.supportToolStripMenuItem.Name = "supportToolStripMenuItem";
            this.supportToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.supportToolStripMenuItem.Text = "Support";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // TimerButton
            // 
            this.TimerButton.BackgroundImage = global::TimeTrackerBeta.Properties.Resources.ButtonStart;
            this.TimerButton.Location = new System.Drawing.Point(40, 230);
            this.TimerButton.Name = "TimerButton";
            this.TimerButton.Size = new System.Drawing.Size(100, 100);
            this.TimerButton.TabIndex = 1;
            this.TimerButton.UseVisualStyleBackColor = true;
            this.TimerButton.Click += new System.EventHandler(this.TimerButton_Click);
            // 
            // SundayTime
            // 
            this.SundayTime.Location = new System.Drawing.Point(288, 44);
            this.SundayTime.Name = "SundayTime";
            this.SundayTime.Size = new System.Drawing.Size(65, 20);
            this.SundayTime.TabIndex = 2;
            this.SundayTime.Text = "00:00:00.00";
            this.SundayTime.Leave += new System.EventHandler(this.SundayTime_Leave);
            // 
            // TimeTracker
            // 
            this.TimeTracker.Interval = 10;
            this.TimeTracker.Tick += new System.EventHandler(this.TimeTracker_Tick);
            // 
            // MondayTime
            // 
            this.MondayTime.Location = new System.Drawing.Point(288, 79);
            this.MondayTime.Name = "MondayTime";
            this.MondayTime.Size = new System.Drawing.Size(65, 20);
            this.MondayTime.TabIndex = 3;
            this.MondayTime.Text = "00:00:00.00";
            this.MondayTime.Leave += new System.EventHandler(this.MondayTime_Leave);
            // 
            // TotalTime
            // 
            this.TotalTime.Location = new System.Drawing.Point(281, 293);
            this.TotalTime.Name = "TotalTime";
            this.TotalTime.ReadOnly = true;
            this.TotalTime.Size = new System.Drawing.Size(65, 20);
            this.TotalTime.TabIndex = 4;
            this.TotalTime.Text = "00:00:00.00";
            // 
            // SundayButton
            // 
            this.SundayButton.AutoSize = true;
            this.SundayButton.Location = new System.Drawing.Point(195, 47);
            this.SundayButton.Name = "SundayButton";
            this.SundayButton.Size = new System.Drawing.Size(14, 13);
            this.SundayButton.TabIndex = 5;
            this.SundayButton.TabStop = true;
            this.SundayButton.UseVisualStyleBackColor = true;
            this.SundayButton.CheckedChanged += new System.EventHandler(this.SundayButton_CheckedChanged);
            // 
            // MondayButton
            // 
            this.MondayButton.AutoSize = true;
            this.MondayButton.Location = new System.Drawing.Point(195, 82);
            this.MondayButton.Name = "MondayButton";
            this.MondayButton.Size = new System.Drawing.Size(14, 13);
            this.MondayButton.TabIndex = 6;
            this.MondayButton.TabStop = true;
            this.MondayButton.UseVisualStyleBackColor = true;
            this.MondayButton.CheckedChanged += new System.EventHandler(this.MondayButton_CheckedChanged);
            // 
            // TuesdayButton
            // 
            this.TuesdayButton.AutoSize = true;
            this.TuesdayButton.Location = new System.Drawing.Point(195, 117);
            this.TuesdayButton.Name = "TuesdayButton";
            this.TuesdayButton.Size = new System.Drawing.Size(14, 13);
            this.TuesdayButton.TabIndex = 7;
            this.TuesdayButton.TabStop = true;
            this.TuesdayButton.UseVisualStyleBackColor = true;
            this.TuesdayButton.CheckedChanged += new System.EventHandler(this.TuesdayButton_CheckedChanged);
            // 
            // WednesdayButton
            // 
            this.WednesdayButton.AutoSize = true;
            this.WednesdayButton.Location = new System.Drawing.Point(195, 152);
            this.WednesdayButton.Name = "WednesdayButton";
            this.WednesdayButton.Size = new System.Drawing.Size(14, 13);
            this.WednesdayButton.TabIndex = 8;
            this.WednesdayButton.TabStop = true;
            this.WednesdayButton.UseVisualStyleBackColor = true;
            this.WednesdayButton.CheckedChanged += new System.EventHandler(this.WednesdayButton_CheckedChanged);
            // 
            // ThursdayButton
            // 
            this.ThursdayButton.AutoSize = true;
            this.ThursdayButton.Location = new System.Drawing.Point(195, 184);
            this.ThursdayButton.Name = "ThursdayButton";
            this.ThursdayButton.Size = new System.Drawing.Size(14, 13);
            this.ThursdayButton.TabIndex = 9;
            this.ThursdayButton.TabStop = true;
            this.ThursdayButton.UseVisualStyleBackColor = true;
            this.ThursdayButton.CheckedChanged += new System.EventHandler(this.ThursdayButton_CheckedChanged);
            // 
            // FridayButton
            // 
            this.FridayButton.AutoSize = true;
            this.FridayButton.Location = new System.Drawing.Point(195, 219);
            this.FridayButton.Name = "FridayButton";
            this.FridayButton.Size = new System.Drawing.Size(14, 13);
            this.FridayButton.TabIndex = 10;
            this.FridayButton.TabStop = true;
            this.FridayButton.UseVisualStyleBackColor = true;
            this.FridayButton.CheckedChanged += new System.EventHandler(this.FridayButton_CheckedChanged);
            // 
            // SaturdayButton
            // 
            this.SaturdayButton.AutoSize = true;
            this.SaturdayButton.Location = new System.Drawing.Point(195, 254);
            this.SaturdayButton.Name = "SaturdayButton";
            this.SaturdayButton.Size = new System.Drawing.Size(14, 13);
            this.SaturdayButton.TabIndex = 11;
            this.SaturdayButton.TabStop = true;
            this.SaturdayButton.UseVisualStyleBackColor = true;
            this.SaturdayButton.CheckedChanged += new System.EventHandler(this.SaturdayButton_CheckedChanged);
            // 
            // TuesdayTime
            // 
            this.TuesdayTime.Location = new System.Drawing.Point(286, 114);
            this.TuesdayTime.Name = "TuesdayTime";
            this.TuesdayTime.Size = new System.Drawing.Size(65, 20);
            this.TuesdayTime.TabIndex = 12;
            this.TuesdayTime.Text = "00:00:00.00";
            this.TuesdayTime.Leave += new System.EventHandler(this.TuesdayTime_Leave);
            // 
            // WednesdayTime
            // 
            this.WednesdayTime.Location = new System.Drawing.Point(284, 149);
            this.WednesdayTime.Name = "WednesdayTime";
            this.WednesdayTime.Size = new System.Drawing.Size(67, 20);
            this.WednesdayTime.TabIndex = 13;
            this.WednesdayTime.Text = "00:00:00.00";
            this.WednesdayTime.Leave += new System.EventHandler(this.WednesdayTime_Leave);
            // 
            // ThursdayTime
            // 
            this.ThursdayTime.Location = new System.Drawing.Point(284, 181);
            this.ThursdayTime.Name = "ThursdayTime";
            this.ThursdayTime.Size = new System.Drawing.Size(65, 20);
            this.ThursdayTime.TabIndex = 14;
            this.ThursdayTime.Text = "00:00:00.00";
            this.ThursdayTime.Leave += new System.EventHandler(this.ThursdayTime_Leave);
            // 
            // FridayTime
            // 
            this.FridayTime.Location = new System.Drawing.Point(284, 216);
            this.FridayTime.Name = "FridayTime";
            this.FridayTime.Size = new System.Drawing.Size(65, 20);
            this.FridayTime.TabIndex = 15;
            this.FridayTime.Text = "00:00:00.00";
            this.FridayTime.Leave += new System.EventHandler(this.FridayTime_Leave);
            // 
            // SaturdayTime
            // 
            this.SaturdayTime.Location = new System.Drawing.Point(284, 251);
            this.SaturdayTime.Name = "SaturdayTime";
            this.SaturdayTime.Size = new System.Drawing.Size(65, 20);
            this.SaturdayTime.TabIndex = 16;
            this.SaturdayTime.Text = "00:00:00.00";
            this.SaturdayTime.Leave += new System.EventHandler(this.SaturdayTime_Leave);
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Location = new System.Drawing.Point(192, 300);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(34, 13);
            this.totalLabel.TabIndex = 17;
            this.totalLabel.Text = "Total:";
            // 
            // Logo
            // 
            this.Logo.Image = ((System.Drawing.Image)(resources.GetObject("Logo.Image")));
            this.Logo.Location = new System.Drawing.Point(12, 44);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(150, 150);
            this.Logo.TabIndex = 18;
            this.Logo.TabStop = false;
            // 
            // SaveDialog
            // 
            this.SaveDialog.Filter = "Text File | *.txt";
            // 
            // LoadDialog
            // 
            this.LoadDialog.FileName = "openFileDialog1";
            this.LoadDialog.Filter = "Text File | *.txt";
            // 
            // SundayLabel
            // 
            this.SundayLabel.AutoSize = true;
            this.SundayLabel.Location = new System.Drawing.Point(218, 47);
            this.SundayLabel.Name = "SundayLabel";
            this.SundayLabel.Size = new System.Drawing.Size(43, 13);
            this.SundayLabel.TabIndex = 19;
            this.SundayLabel.Text = "Sunday";
            // 
            // MondayLabel
            // 
            this.MondayLabel.AutoSize = true;
            this.MondayLabel.Location = new System.Drawing.Point(218, 82);
            this.MondayLabel.Name = "MondayLabel";
            this.MondayLabel.Size = new System.Drawing.Size(45, 13);
            this.MondayLabel.TabIndex = 20;
            this.MondayLabel.Text = "Monday";
            // 
            // TuesdayLabel
            // 
            this.TuesdayLabel.AutoSize = true;
            this.TuesdayLabel.Location = new System.Drawing.Point(215, 117);
            this.TuesdayLabel.Name = "TuesdayLabel";
            this.TuesdayLabel.Size = new System.Drawing.Size(48, 13);
            this.TuesdayLabel.TabIndex = 21;
            this.TuesdayLabel.Text = "Tuesday";
            // 
            // WednesdayLabel
            // 
            this.WednesdayLabel.AutoSize = true;
            this.WednesdayLabel.Location = new System.Drawing.Point(215, 152);
            this.WednesdayLabel.Name = "WednesdayLabel";
            this.WednesdayLabel.Size = new System.Drawing.Size(64, 13);
            this.WednesdayLabel.TabIndex = 22;
            this.WednesdayLabel.Text = "Wednesday";
            // 
            // ThursdayLabel
            // 
            this.ThursdayLabel.AutoSize = true;
            this.ThursdayLabel.Location = new System.Drawing.Point(215, 188);
            this.ThursdayLabel.Name = "ThursdayLabel";
            this.ThursdayLabel.Size = new System.Drawing.Size(51, 13);
            this.ThursdayLabel.TabIndex = 23;
            this.ThursdayLabel.Text = "Thursday";
            // 
            // FridayLabel
            // 
            this.FridayLabel.AutoSize = true;
            this.FridayLabel.Location = new System.Drawing.Point(218, 223);
            this.FridayLabel.Name = "FridayLabel";
            this.FridayLabel.Size = new System.Drawing.Size(35, 13);
            this.FridayLabel.TabIndex = 24;
            this.FridayLabel.Text = "Friday";
            // 
            // SaturdayLabel
            // 
            this.SaturdayLabel.AutoSize = true;
            this.SaturdayLabel.Location = new System.Drawing.Point(218, 254);
            this.SaturdayLabel.Name = "SaturdayLabel";
            this.SaturdayLabel.Size = new System.Drawing.Size(49, 13);
            this.SaturdayLabel.TabIndex = 25;
            this.SaturdayLabel.Text = "Saturday";
            // 
            // averageLabel
            // 
            this.averageLabel.AutoSize = true;
            this.averageLabel.Location = new System.Drawing.Point(192, 333);
            this.averageLabel.Name = "averageLabel";
            this.averageLabel.Size = new System.Drawing.Size(50, 13);
            this.averageLabel.TabIndex = 26;
            this.averageLabel.Text = "Average:";
            // 
            // AverageTime
            // 
            this.AverageTime.Location = new System.Drawing.Point(281, 330);
            this.AverageTime.Name = "AverageTime";
            this.AverageTime.Size = new System.Drawing.Size(65, 20);
            this.AverageTime.TabIndex = 27;
            this.AverageTime.Text = "00:00:00.00";
            // 
            // SundayReset
            // 
            this.SundayReset.Location = new System.Drawing.Point(359, 42);
            this.SundayReset.Name = "SundayReset";
            this.SundayReset.Size = new System.Drawing.Size(52, 23);
            this.SundayReset.TabIndex = 28;
            this.SundayReset.Text = "Reset";
            this.SundayReset.UseVisualStyleBackColor = true;
            this.SundayReset.Click += new System.EventHandler(this.SundayReset_Click);
            // 
            // MondayReset
            // 
            this.MondayReset.Location = new System.Drawing.Point(360, 75);
            this.MondayReset.Name = "MondayReset";
            this.MondayReset.Size = new System.Drawing.Size(51, 23);
            this.MondayReset.TabIndex = 29;
            this.MondayReset.Text = "Reset";
            this.MondayReset.UseVisualStyleBackColor = true;
            this.MondayReset.Click += new System.EventHandler(this.MondayReset_Click);
            // 
            // TuesdayReset
            // 
            this.TuesdayReset.Location = new System.Drawing.Point(360, 114);
            this.TuesdayReset.Name = "TuesdayReset";
            this.TuesdayReset.Size = new System.Drawing.Size(51, 23);
            this.TuesdayReset.TabIndex = 30;
            this.TuesdayReset.Text = "Reset";
            this.TuesdayReset.UseVisualStyleBackColor = true;
            this.TuesdayReset.Click += new System.EventHandler(this.TuesdayReset_Click);
            // 
            // WednesdayReset
            // 
            this.WednesdayReset.Location = new System.Drawing.Point(357, 146);
            this.WednesdayReset.Name = "WednesdayReset";
            this.WednesdayReset.Size = new System.Drawing.Size(53, 23);
            this.WednesdayReset.TabIndex = 31;
            this.WednesdayReset.Text = "Reset";
            this.WednesdayReset.UseVisualStyleBackColor = true;
            this.WednesdayReset.Click += new System.EventHandler(this.WednesdayReset_Click);
            // 
            // ThursdayReset
            // 
            this.ThursdayReset.Location = new System.Drawing.Point(355, 179);
            this.ThursdayReset.Name = "ThursdayReset";
            this.ThursdayReset.Size = new System.Drawing.Size(56, 23);
            this.ThursdayReset.TabIndex = 32;
            this.ThursdayReset.Text = "Reset";
            this.ThursdayReset.UseVisualStyleBackColor = true;
            this.ThursdayReset.Click += new System.EventHandler(this.ThursdayReset_Click);
            // 
            // FridayReset
            // 
            this.FridayReset.Location = new System.Drawing.Point(355, 213);
            this.FridayReset.Name = "FridayReset";
            this.FridayReset.Size = new System.Drawing.Size(56, 23);
            this.FridayReset.TabIndex = 33;
            this.FridayReset.Text = "Reset";
            this.FridayReset.UseVisualStyleBackColor = true;
            this.FridayReset.Click += new System.EventHandler(this.FridayReset_Click);
            // 
            // SaturdayReset
            // 
            this.SaturdayReset.Location = new System.Drawing.Point(355, 249);
            this.SaturdayReset.Name = "SaturdayReset";
            this.SaturdayReset.Size = new System.Drawing.Size(56, 23);
            this.SaturdayReset.TabIndex = 34;
            this.SaturdayReset.Text = "Reset";
            this.SaturdayReset.UseVisualStyleBackColor = true;
            this.SaturdayReset.Click += new System.EventHandler(this.SaturdayReset_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(269, 6);
            // 
            // runningTotalToolStripMenuItem
            // 
            this.runningTotalToolStripMenuItem.Enabled = false;
            this.runningTotalToolStripMenuItem.Name = "runningTotalToolStripMenuItem";
            this.runningTotalToolStripMenuItem.Size = new System.Drawing.Size(272, 22);
            this.runningTotalToolStripMenuItem.Text = "Running Total (Not Yet Implemented)";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 368);
            this.Controls.Add(this.SaturdayReset);
            this.Controls.Add(this.FridayReset);
            this.Controls.Add(this.ThursdayReset);
            this.Controls.Add(this.WednesdayReset);
            this.Controls.Add(this.TuesdayReset);
            this.Controls.Add(this.MondayReset);
            this.Controls.Add(this.SundayReset);
            this.Controls.Add(this.AverageTime);
            this.Controls.Add(this.averageLabel);
            this.Controls.Add(this.SaturdayLabel);
            this.Controls.Add(this.FridayLabel);
            this.Controls.Add(this.ThursdayLabel);
            this.Controls.Add(this.WednesdayLabel);
            this.Controls.Add(this.TuesdayLabel);
            this.Controls.Add(this.MondayLabel);
            this.Controls.Add(this.SundayLabel);
            this.Controls.Add(this.Logo);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.SaturdayTime);
            this.Controls.Add(this.FridayTime);
            this.Controls.Add(this.ThursdayTime);
            this.Controls.Add(this.WednesdayTime);
            this.Controls.Add(this.TuesdayTime);
            this.Controls.Add(this.SaturdayButton);
            this.Controls.Add(this.FridayButton);
            this.Controls.Add(this.ThursdayButton);
            this.Controls.Add(this.WednesdayButton);
            this.Controls.Add(this.TuesdayButton);
            this.Controls.Add(this.MondayButton);
            this.Controls.Add(this.SundayButton);
            this.Controls.Add(this.TotalTime);
            this.Controls.Add(this.MondayTime);
            this.Controls.Add(this.SundayTime);
            this.Controls.Add(this.TimerButton);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Time Tracker";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button TimerButton;
        private System.Windows.Forms.TextBox SundayTime;
        private System.Windows.Forms.Timer TimeTracker;
        private System.Windows.Forms.TextBox MondayTime;
        private System.Windows.Forms.TextBox TotalTime;
        private System.Windows.Forms.RadioButton SundayButton;
        private System.Windows.Forms.RadioButton MondayButton;
        private System.Windows.Forms.RadioButton TuesdayButton;
        private System.Windows.Forms.RadioButton WednesdayButton;
        private System.Windows.Forms.RadioButton ThursdayButton;
        private System.Windows.Forms.RadioButton FridayButton;
        private System.Windows.Forms.RadioButton SaturdayButton;
        private System.Windows.Forms.TextBox TuesdayTime;
        private System.Windows.Forms.TextBox WednesdayTime;
        private System.Windows.Forms.TextBox ThursdayTime;
        private System.Windows.Forms.TextBox FridayTime;
        private System.Windows.Forms.TextBox SaturdayTime;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.SaveFileDialog SaveDialog;
        private System.Windows.Forms.OpenFileDialog LoadDialog;
        private System.Windows.Forms.Label SundayLabel;
        private System.Windows.Forms.Label MondayLabel;
        private System.Windows.Forms.Label TuesdayLabel;
        private System.Windows.Forms.Label WednesdayLabel;
        private System.Windows.Forms.Label ThursdayLabel;
        private System.Windows.Forms.Label FridayLabel;
        private System.Windows.Forms.Label SaturdayLabel;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.Label averageLabel;
        private System.Windows.Forms.TextBox AverageTime;
        private System.Windows.Forms.Button SundayReset;
        private System.Windows.Forms.Button MondayReset;
        private System.Windows.Forms.Button TuesdayReset;
        private System.Windows.Forms.Button WednesdayReset;
        private System.Windows.Forms.Button ThursdayReset;
        private System.Windows.Forms.Button FridayReset;
        private System.Windows.Forms.Button SaturdayReset;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem runningTotalToolStripMenuItem;
    }
}

