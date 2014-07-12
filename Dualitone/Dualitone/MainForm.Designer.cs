namespace Dualitone
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
            this.stepButton = new System.Windows.Forms.Button();
            this.playButton = new System.Windows.Forms.Button();
            this.volumeBar1 = new System.Windows.Forms.TrackBar();
            this.volumeBar2 = new System.Windows.Forms.TrackBar();
            this.stopButton = new System.Windows.Forms.Button();
            this.songBox1 = new System.Windows.Forms.TextBox();
            this.songBox2 = new System.Windows.Forms.TextBox();
            this.loadButton1 = new System.Windows.Forms.Button();
            this.loadButton2 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.workingDirectoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stepAmountNUD = new System.Windows.Forms.NumericUpDown();
            this.resetButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.volumeBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.volumeBar2)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stepAmountNUD)).BeginInit();
            this.SuspendLayout();
            // 
            // stepButton
            // 
            this.stepButton.Location = new System.Drawing.Point(212, 244);
            this.stepButton.Name = "stepButton";
            this.stepButton.Size = new System.Drawing.Size(75, 23);
            this.stepButton.TabIndex = 0;
            this.stepButton.Text = "Step";
            this.stepButton.UseVisualStyleBackColor = true;
            // 
            // playButton
            // 
            this.playButton.Location = new System.Drawing.Point(69, 168);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(75, 23);
            this.playButton.TabIndex = 1;
            this.playButton.Text = "Play/Pause";
            this.playButton.UseVisualStyleBackColor = true;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // volumeBar1
            // 
            this.volumeBar1.Location = new System.Drawing.Point(12, 231);
            this.volumeBar1.Name = "volumeBar1";
            this.volumeBar1.Size = new System.Drawing.Size(192, 45);
            this.volumeBar1.TabIndex = 2;
            this.volumeBar1.Value = 10;
            // 
            // volumeBar2
            // 
            this.volumeBar2.Location = new System.Drawing.Point(12, 282);
            this.volumeBar2.Name = "volumeBar2";
            this.volumeBar2.Size = new System.Drawing.Size(192, 45);
            this.volumeBar2.TabIndex = 2;
            // 
            // stopButton
            // 
            this.stopButton.Location = new System.Drawing.Point(150, 168);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(75, 23);
            this.stopButton.TabIndex = 3;
            this.stopButton.Text = "Stop";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // songBox1
            // 
            this.songBox1.Enabled = false;
            this.songBox1.Location = new System.Drawing.Point(13, 41);
            this.songBox1.Name = "songBox1";
            this.songBox1.Size = new System.Drawing.Size(134, 20);
            this.songBox1.TabIndex = 4;
            // 
            // songBox2
            // 
            this.songBox2.Enabled = false;
            this.songBox2.Location = new System.Drawing.Point(153, 41);
            this.songBox2.Name = "songBox2";
            this.songBox2.Size = new System.Drawing.Size(134, 20);
            this.songBox2.TabIndex = 4;
            // 
            // loadButton1
            // 
            this.loadButton1.Location = new System.Drawing.Point(46, 67);
            this.loadButton1.Name = "loadButton1";
            this.loadButton1.Size = new System.Drawing.Size(101, 23);
            this.loadButton1.TabIndex = 5;
            this.loadButton1.Text = "Load Song 1";
            this.loadButton1.UseVisualStyleBackColor = true;
            this.loadButton1.Click += new System.EventHandler(this.loadButton1_Click);
            // 
            // loadButton2
            // 
            this.loadButton2.Location = new System.Drawing.Point(153, 67);
            this.loadButton2.Name = "loadButton2";
            this.loadButton2.Size = new System.Drawing.Size(103, 23);
            this.loadButton2.TabIndex = 5;
            this.loadButton2.Text = "Load Song 2";
            this.loadButton2.UseVisualStyleBackColor = true;
            this.loadButton2.Click += new System.EventHandler(this.loadButton2_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(298, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.workingDirectoryToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // workingDirectoryToolStripMenuItem
            // 
            this.workingDirectoryToolStripMenuItem.Name = "workingDirectoryToolStripMenuItem";
            this.workingDirectoryToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.workingDirectoryToolStripMenuItem.Text = "Working Directory";
            this.workingDirectoryToolStripMenuItem.Click += new System.EventHandler(this.workingDirectoryToolStripMenuItem_Click);
            // 
            // stepAmountNUD
            // 
            this.stepAmountNUD.DecimalPlaces = 2;
            this.stepAmountNUD.Increment = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            this.stepAmountNUD.Location = new System.Drawing.Point(212, 273);
            this.stepAmountNUD.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.stepAmountNUD.Minimum = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            this.stepAmountNUD.Name = "stepAmountNUD";
            this.stepAmountNUD.Size = new System.Drawing.Size(74, 20);
            this.stepAmountNUD.TabIndex = 7;
            this.stepAmountNUD.Value = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(95, 320);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(75, 23);
            this.resetButton.TabIndex = 8;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 382);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.stepAmountNUD);
            this.Controls.Add(this.loadButton2);
            this.Controls.Add(this.loadButton1);
            this.Controls.Add(this.songBox2);
            this.Controls.Add(this.songBox1);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.volumeBar2);
            this.Controls.Add(this.volumeBar1);
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.stepButton);
            this.Controls.Add(this.menuStrip1);
            this.Name = "MainForm";
            this.Text = "Dualitone";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.volumeBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.volumeBar2)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stepAmountNUD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button stepButton;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.TrackBar volumeBar1;
        private System.Windows.Forms.TrackBar volumeBar2;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.TextBox songBox1;
        private System.Windows.Forms.TextBox songBox2;
        private System.Windows.Forms.Button loadButton1;
        private System.Windows.Forms.Button loadButton2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem workingDirectoryToolStripMenuItem;
        private System.Windows.Forms.NumericUpDown stepAmountNUD;
        private System.Windows.Forms.Button resetButton;
    }
}

