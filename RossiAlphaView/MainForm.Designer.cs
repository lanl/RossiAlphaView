namespace RossiAlphaView
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PulsePanel = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.HistChart = new LiveCharts.WinForms.CartesianChart();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.MaxFissionsTextBox = new System.Windows.Forms.TextBox();
            this.SystemCheckBox = new System.Windows.Forms.CheckBox();
            this.EfficiencyTrackBar = new System.Windows.Forms.TrackBar();
            this.EfficiencyLabel = new System.Windows.Forms.Label();
            this.LongDelayTrackBar = new System.Windows.Forms.TrackBar();
            this.LongDelayLabel = new System.Windows.Forms.Label();
            this.GateWidthTrackBar = new System.Windows.Forms.TrackBar();
            this.GateWidthLabel = new System.Windows.Forms.Label();
            this.PreDelayTrackBar = new System.Windows.Forms.TrackBar();
            this.PreDelayLabel = new System.Windows.Forms.Label();
            this.GateCheckBox = new System.Windows.Forms.CheckBox();
            this.PauseButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.StrengthTrackBar = new System.Windows.Forms.TrackBar();
            this.DieAwayTrackBar = new System.Windows.Forms.TrackBar();
            this.DieAwayLabel = new System.Windows.Forms.Label();
            this.SpeedTrackBar = new System.Windows.Forms.TrackBar();
            this.CorrelatedTrackBar = new System.Windows.Forms.TrackBar();
            this.SpeedLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ResetButton = new System.Windows.Forms.Button();
            this.HeartBeat = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.FissionCountLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.FissionPulsesLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.AlphaCountLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.AlphaPulsesLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.RPlusAMinusALabel = new System.Windows.Forms.Label();
            this.UncertaintyLabel = new System.Windows.Forms.Label();
            this.DragToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PulsePanel)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EfficiencyTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LongDelayTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GateWidthTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PreDelayTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StrengthTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DieAwayTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpeedTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CorrelatedTrackBar)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.PulsePanel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 170);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10);
            this.panel1.Size = new System.Drawing.Size(1043, 218);
            this.panel1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(971, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Alpha";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Green;
            this.label2.Location = new System.Drawing.Point(971, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fission";
            // 
            // PulsePanel
            // 
            this.PulsePanel.Location = new System.Drawing.Point(34, 10);
            this.PulsePanel.Name = "PulsePanel";
            this.PulsePanel.Size = new System.Drawing.Size(1000, 198);
            this.PulsePanel.TabIndex = 0;
            this.PulsePanel.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.HistChart);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 388);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1043, 209);
            this.panel2.TabIndex = 1;
            // 
            // HistChart
            // 
            this.HistChart.BackColor = System.Drawing.SystemColors.Control;
            this.HistChart.Location = new System.Drawing.Point(9, 0);
            this.HistChart.Name = "HistChart";
            this.HistChart.Size = new System.Drawing.Size(1025, 202);
            this.HistChart.TabIndex = 0;
            this.HistChart.Text = "cartesianChart2";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.menuStrip1);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.MaxFissionsTextBox);
            this.panel3.Controls.Add(this.SystemCheckBox);
            this.panel3.Controls.Add(this.EfficiencyTrackBar);
            this.panel3.Controls.Add(this.EfficiencyLabel);
            this.panel3.Controls.Add(this.LongDelayTrackBar);
            this.panel3.Controls.Add(this.LongDelayLabel);
            this.panel3.Controls.Add(this.GateWidthTrackBar);
            this.panel3.Controls.Add(this.GateWidthLabel);
            this.panel3.Controls.Add(this.PreDelayTrackBar);
            this.panel3.Controls.Add(this.PreDelayLabel);
            this.panel3.Controls.Add(this.GateCheckBox);
            this.panel3.Controls.Add(this.PauseButton);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.StrengthTrackBar);
            this.panel3.Controls.Add(this.DieAwayTrackBar);
            this.panel3.Controls.Add(this.DieAwayLabel);
            this.panel3.Controls.Add(this.SpeedTrackBar);
            this.panel3.Controls.Add(this.CorrelatedTrackBar);
            this.panel3.Controls.Add(this.SpeedLabel);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.ResetButton);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1043, 170);
            this.panel3.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(791, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Max # Fissions";
            // 
            // MaxFissionsTextBox
            // 
            this.MaxFissionsTextBox.Location = new System.Drawing.Point(873, 28);
            this.MaxFissionsTextBox.MaxLength = 9;
            this.MaxFissionsTextBox.Name = "MaxFissionsTextBox";
            this.MaxFissionsTextBox.Size = new System.Drawing.Size(68, 20);
            this.MaxFissionsTextBox.TabIndex = 22;
            this.MaxFissionsTextBox.TextChanged += new System.EventHandler(this.MaxFissionsTextBox_TextChanged);
            // 
            // SystemCheckBox
            // 
            this.SystemCheckBox.AutoSize = true;
            this.SystemCheckBox.Location = new System.Drawing.Point(794, 97);
            this.SystemCheckBox.Name = "SystemCheckBox";
            this.SystemCheckBox.Size = new System.Drawing.Size(140, 17);
            this.SystemCheckBox.TabIndex = 21;
            this.SystemCheckBox.Text = "Show System Properties";
            this.SystemCheckBox.UseVisualStyleBackColor = true;
            this.SystemCheckBox.CheckedChanged += new System.EventHandler(this.SystemCheckBox_CheckedChanged);
            // 
            // EfficiencyTrackBar
            // 
            this.EfficiencyTrackBar.Location = new System.Drawing.Point(370, 77);
            this.EfficiencyTrackBar.Maximum = 50;
            this.EfficiencyTrackBar.Name = "EfficiencyTrackBar";
            this.EfficiencyTrackBar.Size = new System.Drawing.Size(150, 45);
            this.EfficiencyTrackBar.TabIndex = 20;
            this.EfficiencyTrackBar.Value = 50;
            this.EfficiencyTrackBar.Visible = false;
            this.EfficiencyTrackBar.Scroll += new System.EventHandler(this.EfficiencyTrackBar_Scroll);
            // 
            // EfficiencyLabel
            // 
            this.EfficiencyLabel.AutoSize = true;
            this.EfficiencyLabel.Location = new System.Drawing.Point(316, 77);
            this.EfficiencyLabel.Name = "EfficiencyLabel";
            this.EfficiencyLabel.Size = new System.Drawing.Size(53, 13);
            this.EfficiencyLabel.TabIndex = 19;
            this.EfficiencyLabel.Text = "Efficiency";
            this.EfficiencyLabel.Visible = false;
            // 
            // LongDelayTrackBar
            // 
            this.LongDelayTrackBar.Location = new System.Drawing.Point(626, 127);
            this.LongDelayTrackBar.Maximum = 80;
            this.LongDelayTrackBar.Minimum = 20;
            this.LongDelayTrackBar.Name = "LongDelayTrackBar";
            this.LongDelayTrackBar.Size = new System.Drawing.Size(150, 45);
            this.LongDelayTrackBar.TabIndex = 18;
            this.LongDelayTrackBar.Value = 50;
            this.LongDelayTrackBar.Visible = false;
            this.LongDelayTrackBar.Scroll += new System.EventHandler(this.LongDelayTrackBar_Scroll);
            // 
            // LongDelayLabel
            // 
            this.LongDelayLabel.AutoSize = true;
            this.LongDelayLabel.Location = new System.Drawing.Point(559, 127);
            this.LongDelayLabel.Name = "LongDelayLabel";
            this.LongDelayLabel.Size = new System.Drawing.Size(61, 13);
            this.LongDelayLabel.TabIndex = 17;
            this.LongDelayLabel.Text = "Long Delay";
            this.LongDelayLabel.Visible = false;
            // 
            // GateWidthTrackBar
            // 
            this.GateWidthTrackBar.Location = new System.Drawing.Point(370, 127);
            this.GateWidthTrackBar.Maximum = 50;
            this.GateWidthTrackBar.Minimum = 1;
            this.GateWidthTrackBar.Name = "GateWidthTrackBar";
            this.GateWidthTrackBar.Size = new System.Drawing.Size(150, 45);
            this.GateWidthTrackBar.TabIndex = 16;
            this.GateWidthTrackBar.Value = 25;
            this.GateWidthTrackBar.Visible = false;
            this.GateWidthTrackBar.Scroll += new System.EventHandler(this.GateWidthTrackBar_Scroll);
            // 
            // GateWidthLabel
            // 
            this.GateWidthLabel.AutoSize = true;
            this.GateWidthLabel.Location = new System.Drawing.Point(308, 127);
            this.GateWidthLabel.Name = "GateWidthLabel";
            this.GateWidthLabel.Size = new System.Drawing.Size(61, 13);
            this.GateWidthLabel.TabIndex = 15;
            this.GateWidthLabel.Text = "Gate Width";
            this.GateWidthLabel.Visible = false;
            // 
            // PreDelayTrackBar
            // 
            this.PreDelayTrackBar.Location = new System.Drawing.Point(114, 127);
            this.PreDelayTrackBar.Maximum = 25;
            this.PreDelayTrackBar.Minimum = 1;
            this.PreDelayTrackBar.Name = "PreDelayTrackBar";
            this.PreDelayTrackBar.Size = new System.Drawing.Size(150, 45);
            this.PreDelayTrackBar.TabIndex = 14;
            this.PreDelayTrackBar.Value = 5;
            this.PreDelayTrackBar.Visible = false;
            this.PreDelayTrackBar.Scroll += new System.EventHandler(this.PreDelayTrackBar_Scroll);
            // 
            // PreDelayLabel
            // 
            this.PreDelayLabel.AutoSize = true;
            this.PreDelayLabel.Location = new System.Drawing.Point(54, 127);
            this.PreDelayLabel.Name = "PreDelayLabel";
            this.PreDelayLabel.Size = new System.Drawing.Size(53, 13);
            this.PreDelayLabel.TabIndex = 13;
            this.PreDelayLabel.Text = "Pre-Delay";
            this.PreDelayLabel.Visible = false;
            // 
            // GateCheckBox
            // 
            this.GateCheckBox.AutoSize = true;
            this.GateCheckBox.Location = new System.Drawing.Point(794, 141);
            this.GateCheckBox.Name = "GateCheckBox";
            this.GateCheckBox.Size = new System.Drawing.Size(84, 17);
            this.GateCheckBox.TabIndex = 12;
            this.GateCheckBox.Text = "Show Gates";
            this.GateCheckBox.UseVisualStyleBackColor = true;
            this.GateCheckBox.CheckedChanged += new System.EventHandler(this.GateCheckBox_CheckedChanged);
            // 
            // PauseButton
            // 
            this.PauseButton.Location = new System.Drawing.Point(972, 31);
            this.PauseButton.Name = "PauseButton";
            this.PauseButton.Size = new System.Drawing.Size(62, 30);
            this.PauseButton.TabIndex = 11;
            this.PauseButton.Text = "Pause";
            this.PauseButton.UseVisualStyleBackColor = true;
            this.PauseButton.Click += new System.EventHandler(this.PauseButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Source Strength";
            // 
            // StrengthTrackBar
            // 
            this.StrengthTrackBar.Location = new System.Drawing.Point(114, 28);
            this.StrengthTrackBar.Maximum = 50;
            this.StrengthTrackBar.Minimum = 1;
            this.StrengthTrackBar.Name = "StrengthTrackBar";
            this.StrengthTrackBar.Size = new System.Drawing.Size(150, 45);
            this.StrengthTrackBar.TabIndex = 9;
            this.StrengthTrackBar.Value = 1;
            this.StrengthTrackBar.Scroll += new System.EventHandler(this.StrengthTrackBar_Scroll);
            // 
            // DieAwayTrackBar
            // 
            this.DieAwayTrackBar.Location = new System.Drawing.Point(114, 77);
            this.DieAwayTrackBar.Maximum = 50;
            this.DieAwayTrackBar.Minimum = 1;
            this.DieAwayTrackBar.Name = "DieAwayTrackBar";
            this.DieAwayTrackBar.Size = new System.Drawing.Size(150, 45);
            this.DieAwayTrackBar.TabIndex = 8;
            this.DieAwayTrackBar.Value = 5;
            this.DieAwayTrackBar.Visible = false;
            this.DieAwayTrackBar.Scroll += new System.EventHandler(this.DieAwayTrackBar_Scroll);
            // 
            // DieAwayLabel
            // 
            this.DieAwayLabel.AutoSize = true;
            this.DieAwayLabel.Location = new System.Drawing.Point(58, 77);
            this.DieAwayLabel.Name = "DieAwayLabel";
            this.DieAwayLabel.Size = new System.Drawing.Size(52, 13);
            this.DieAwayLabel.TabIndex = 7;
            this.DieAwayLabel.Text = "Die Away";
            this.DieAwayLabel.Visible = false;
            // 
            // SpeedTrackBar
            // 
            this.SpeedTrackBar.Location = new System.Drawing.Point(626, 28);
            this.SpeedTrackBar.Maximum = 50;
            this.SpeedTrackBar.Minimum = 1;
            this.SpeedTrackBar.Name = "SpeedTrackBar";
            this.SpeedTrackBar.Size = new System.Drawing.Size(150, 45);
            this.SpeedTrackBar.TabIndex = 6;
            this.SpeedTrackBar.Value = 1;
            this.SpeedTrackBar.Scroll += new System.EventHandler(this.SpeedTrackBar_Scroll);
            // 
            // CorrelatedTrackBar
            // 
            this.CorrelatedTrackBar.Location = new System.Drawing.Point(370, 28);
            this.CorrelatedTrackBar.Maximum = 50;
            this.CorrelatedTrackBar.Name = "CorrelatedTrackBar";
            this.CorrelatedTrackBar.Size = new System.Drawing.Size(150, 45);
            this.CorrelatedTrackBar.TabIndex = 5;
            this.CorrelatedTrackBar.Scroll += new System.EventHandler(this.CorrelatedTrackBar_Scroll);
            // 
            // SpeedLabel
            // 
            this.SpeedLabel.AutoSize = true;
            this.SpeedLabel.Location = new System.Drawing.Point(582, 28);
            this.SpeedLabel.Name = "SpeedLabel";
            this.SpeedLabel.Size = new System.Drawing.Size(38, 13);
            this.SpeedLabel.TabIndex = 4;
            this.SpeedLabel.Text = "Speed";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(270, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Correlated Fraction";
            // 
            // ResetButton
            // 
            this.ResetButton.Location = new System.Drawing.Point(972, 67);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(62, 30);
            this.ResetButton.TabIndex = 2;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // HeartBeat
            // 
            this.HeartBeat.Tick += new System.EventHandler(this.HeartBeat_Tick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FissionCountLabel,
            this.FissionPulsesLabel,
            this.AlphaCountLabel,
            this.AlphaPulsesLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 675);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 10, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1043, 25);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // FissionCountLabel
            // 
            this.FissionCountLabel.AutoSize = false;
            this.FissionCountLabel.Name = "FissionCountLabel";
            this.FissionCountLabel.Size = new System.Drawing.Size(200, 20);
            this.FissionCountLabel.Text = "Fission Count: 0";
            this.FissionCountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FissionPulsesLabel
            // 
            this.FissionPulsesLabel.AutoSize = false;
            this.FissionPulsesLabel.Name = "FissionPulsesLabel";
            this.FissionPulsesLabel.Size = new System.Drawing.Size(200, 20);
            this.FissionPulsesLabel.Text = "Fission Pulses: 0";
            this.FissionPulsesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // AlphaCountLabel
            // 
            this.AlphaCountLabel.AutoSize = false;
            this.AlphaCountLabel.Name = "AlphaCountLabel";
            this.AlphaCountLabel.Size = new System.Drawing.Size(200, 20);
            this.AlphaCountLabel.Text = "Alpha Count: 0";
            this.AlphaCountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // AlphaPulsesLabel
            // 
            this.AlphaPulsesLabel.AutoSize = false;
            this.AlphaPulsesLabel.Name = "AlphaPulsesLabel";
            this.AlphaPulsesLabel.Size = new System.Drawing.Size(200, 20);
            this.AlphaPulsesLabel.Text = "Alpha Pulses: 0";
            this.AlphaPulsesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // RPlusAMinusALabel
            // 
            this.RPlusAMinusALabel.AutoSize = true;
            this.RPlusAMinusALabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RPlusAMinusALabel.Location = new System.Drawing.Point(9, 605);
            this.RPlusAMinusALabel.Name = "RPlusAMinusALabel";
            this.RPlusAMinusALabel.Size = new System.Drawing.Size(114, 29);
            this.RPlusAMinusALabel.TabIndex = 4;
            this.RPlusAMinusALabel.Text = "R+A - A =";
            this.RPlusAMinusALabel.Visible = false;
            // 
            // UncertaintyLabel
            // 
            this.UncertaintyLabel.AutoSize = true;
            this.UncertaintyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UncertaintyLabel.Location = new System.Drawing.Point(9, 641);
            this.UncertaintyLabel.Name = "UncertaintyLabel";
            this.UncertaintyLabel.Size = new System.Drawing.Size(152, 29);
            this.UncertaintyLabel.TabIndex = 5;
            this.UncertaintyLabel.Text = "Uncertainty =";
            this.UncertaintyLabel.Visible = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1043, 24);
            this.menuStrip1.TabIndex = 24;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 700);
            this.Controls.Add(this.UncertaintyLabel);
            this.Controls.Add(this.RPlusAMinusALabel);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1059, 768);
            this.MinimumSize = new System.Drawing.Size(1059, 739);
            this.Name = "MainForm";
            this.Text = "Rossi Alpha View (Version 0.1)";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PulsePanel)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EfficiencyTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LongDelayTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GateWidthTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PreDelayTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StrengthTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DieAwayTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpeedTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CorrelatedTrackBar)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private LiveCharts.WinForms.CartesianChart HistChart;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Timer HeartBeat;
        private System.Windows.Forms.PictureBox PulsePanel;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label SpeedLabel;
        private System.Windows.Forms.TrackBar CorrelatedTrackBar;
        private System.Windows.Forms.TrackBar SpeedTrackBar;
        private System.Windows.Forms.TrackBar DieAwayTrackBar;
        private System.Windows.Forms.Label DieAwayLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar StrengthTrackBar;
        private System.Windows.Forms.Button PauseButton;
        private System.Windows.Forms.CheckBox GateCheckBox;
        private System.Windows.Forms.TrackBar LongDelayTrackBar;
        private System.Windows.Forms.Label LongDelayLabel;
        private System.Windows.Forms.TrackBar GateWidthTrackBar;
        private System.Windows.Forms.Label GateWidthLabel;
        private System.Windows.Forms.TrackBar PreDelayTrackBar;
        private System.Windows.Forms.Label PreDelayLabel;
        private System.Windows.Forms.TrackBar EfficiencyTrackBar;
        private System.Windows.Forms.Label EfficiencyLabel;
        private System.Windows.Forms.CheckBox SystemCheckBox;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel FissionCountLabel;
        private System.Windows.Forms.ToolStripStatusLabel FissionPulsesLabel;
        private System.Windows.Forms.ToolStripStatusLabel AlphaCountLabel;
        private System.Windows.Forms.ToolStripStatusLabel AlphaPulsesLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox MaxFissionsTextBox;
        private System.Windows.Forms.Label RPlusAMinusALabel;
        private System.Windows.Forms.Label UncertaintyLabel;
        private System.Windows.Forms.ToolTip DragToolTip;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}

