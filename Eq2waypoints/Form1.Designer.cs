namespace EQWaypoint
{
    partial class Form1
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
            this.Labelforx = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.zLabel = new System.Windows.Forms.Label();
            this.yLabel = new System.Windows.Forms.Label();
            this.xLabel = new System.Windows.Forms.Label();
            this.Labelforz = new System.Windows.Forms.Label();
            this.Labelfory = new System.Windows.Forms.Label();
            this.wpListBox = new System.Windows.Forms.ListBox();
            this.addWpButton = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.statusLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Labelforx
            // 
            this.Labelforx.AutoSize = true;
            this.Labelforx.Location = new System.Drawing.Point(6, 25);
            this.Labelforx.Name = "Labelforx";
            this.Labelforx.Size = new System.Drawing.Size(20, 13);
            this.Labelforx.TabIndex = 0;
            this.Labelforx.Text = "X: ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.zLabel);
            this.groupBox1.Controls.Add(this.yLabel);
            this.groupBox1.Controls.Add(this.xLabel);
            this.groupBox1.Controls.Add(this.Labelforz);
            this.groupBox1.Controls.Add(this.Labelfory);
            this.groupBox1.Controls.Add(this.Labelforx);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(103, 99);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Current Location";
            // 
            // zLabel
            // 
            this.zLabel.AutoSize = true;
            this.zLabel.Location = new System.Drawing.Point(25, 74);
            this.zLabel.Name = "zLabel";
            this.zLabel.Size = new System.Drawing.Size(0, 13);
            this.zLabel.TabIndex = 5;
            // 
            // yLabel
            // 
            this.yLabel.AutoSize = true;
            this.yLabel.Location = new System.Drawing.Point(26, 50);
            this.yLabel.Name = "yLabel";
            this.yLabel.Size = new System.Drawing.Size(0, 13);
            this.yLabel.TabIndex = 4;
            // 
            // xLabel
            // 
            this.xLabel.AutoSize = true;
            this.xLabel.Location = new System.Drawing.Point(25, 25);
            this.xLabel.Name = "xLabel";
            this.xLabel.Size = new System.Drawing.Size(0, 13);
            this.xLabel.TabIndex = 3;
            // 
            // Labelforz
            // 
            this.Labelforz.AutoSize = true;
            this.Labelforz.Location = new System.Drawing.Point(6, 74);
            this.Labelforz.Name = "Labelforz";
            this.Labelforz.Size = new System.Drawing.Size(17, 13);
            this.Labelforz.TabIndex = 2;
            this.Labelforz.Text = "Z:";
            // 
            // Labelfory
            // 
            this.Labelfory.AutoSize = true;
            this.Labelfory.Location = new System.Drawing.Point(6, 50);
            this.Labelfory.Name = "Labelfory";
            this.Labelfory.Size = new System.Drawing.Size(17, 13);
            this.Labelfory.TabIndex = 2;
            this.Labelfory.Text = "Y:";
            // 
            // wpListBox
            // 
            this.wpListBox.FormattingEnabled = true;
            this.wpListBox.Location = new System.Drawing.Point(12, 196);
            this.wpListBox.Name = "wpListBox";
            this.wpListBox.Size = new System.Drawing.Size(241, 147);
            this.wpListBox.TabIndex = 2;
            // 
            // addWpButton
            // 
            this.addWpButton.Location = new System.Drawing.Point(12, 167);
            this.addWpButton.Name = "addWpButton";
            this.addWpButton.Size = new System.Drawing.Size(241, 23);
            this.addWpButton.TabIndex = 3;
            this.addWpButton.Text = "Add Waypoint";
            this.addWpButton.UseVisualStyleBackColor = true;
            this.addWpButton.Click += new System.EventHandler(this.addWpButton_Click);
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(146, 37);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(86, 47);
            this.startButton.TabIndex = 4;
            this.startButton.Text = "Walk Path";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.statusLabel);
            this.groupBox2.Location = new System.Drawing.Point(14, 117);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(239, 37);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Status";
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(97, 16);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(47, 13);
            this.statusLabel.TabIndex = 0;
            this.statusLabel.Text = "Stopped";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 200;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 353);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.addWpButton);
            this.Controls.Add(this.wpListBox);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "EQ2 Waypoints";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Labelforx;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label Labelforz;
        private System.Windows.Forms.Label Labelfory;
        private System.Windows.Forms.ListBox wpListBox;
        private System.Windows.Forms.Button addWpButton;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Label zLabel;
        private System.Windows.Forms.Label yLabel;
        private System.Windows.Forms.Label xLabel;
        private System.Windows.Forms.Timer timer1;
    }
}

