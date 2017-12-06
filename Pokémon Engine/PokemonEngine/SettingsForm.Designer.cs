﻿namespace PokemonEngine
{
    partial class SettingsForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.fixedFramerate = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.f12SoftReset = new System.Windows.Forms.CheckBox();
            this.screenHeight = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.screenWidth = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.smoothScaling = new System.Windows.Forms.CheckBox();
            this.fixedAspectRatio = new System.Windows.Forms.CheckBox();
            this.startFullscreen = new System.Windows.Forms.CheckBox();
            this.printFPS = new System.Windows.Forms.CheckBox();
            this.rgssVersion = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fixedFramerate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.screenHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.screenWidth)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(4, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(312, 224);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.fixedFramerate);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.f12SoftReset);
            this.tabPage2.Controls.Add(this.screenHeight);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.screenWidth);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.smoothScaling);
            this.tabPage2.Controls.Add(this.fixedAspectRatio);
            this.tabPage2.Controls.Add(this.startFullscreen);
            this.tabPage2.Controls.Add(this.printFPS);
            this.tabPage2.Controls.Add(this.rgssVersion);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(304, 198);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Game";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(159, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "FPS";
            // 
            // fixedFramerate
            // 
            this.fixedFramerate.Location = new System.Drawing.Point(117, 147);
            this.fixedFramerate.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.fixedFramerate.Name = "fixedFramerate";
            this.fixedFramerate.Size = new System.Drawing.Size(38, 20);
            this.fixedFramerate.TabIndex = 13;
            this.fixedFramerate.ValueChanged += new System.EventHandler(this.maxFramerate_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Fixed Framerate:";
            // 
            // f12SoftReset
            // 
            this.f12SoftReset.AutoSize = true;
            this.f12SoftReset.Location = new System.Drawing.Point(3, 124);
            this.f12SoftReset.Name = "f12SoftReset";
            this.f12SoftReset.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.f12SoftReset.Size = new System.Drawing.Size(128, 17);
            this.f12SoftReset.TabIndex = 11;
            this.f12SoftReset.Text = ":Allow F12 Soft-Reset";
            this.f12SoftReset.UseVisualStyleBackColor = true;
            this.f12SoftReset.CheckedChanged += new System.EventHandler(this.f12SoftReset_CheckedChanged);
            // 
            // screenHeight
            // 
            this.screenHeight.Location = new System.Drawing.Point(209, 173);
            this.screenHeight.Maximum = new decimal(new int[] {
            8192,
            0,
            0,
            0});
            this.screenHeight.Name = "screenHeight";
            this.screenHeight.Size = new System.Drawing.Size(48, 20);
            this.screenHeight.TabIndex = 10;
            this.screenHeight.ValueChanged += new System.EventHandler(this.screenHeight_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(190, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "H:";
            // 
            // screenWidth
            // 
            this.screenWidth.Location = new System.Drawing.Point(136, 173);
            this.screenWidth.Maximum = new decimal(new int[] {
            8192,
            0,
            0,
            0});
            this.screenWidth.Name = "screenWidth";
            this.screenWidth.Size = new System.Drawing.Size(48, 20);
            this.screenWidth.TabIndex = 8;
            this.screenWidth.ValueChanged += new System.EventHandler(this.screenWidth_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(115, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "W:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Resolution:";
            // 
            // smoothScaling
            // 
            this.smoothScaling.AutoSize = true;
            this.smoothScaling.Location = new System.Drawing.Point(28, 101);
            this.smoothScaling.Name = "smoothScaling";
            this.smoothScaling.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.smoothScaling.Size = new System.Drawing.Size(103, 17);
            this.smoothScaling.TabIndex = 5;
            this.smoothScaling.Text = ":Smooth Scaling";
            this.smoothScaling.UseVisualStyleBackColor = true;
            this.smoothScaling.CheckedChanged += new System.EventHandler(this.smoothScaling_CheckedChanged);
            // 
            // fixedAspectRatio
            // 
            this.fixedAspectRatio.AutoSize = true;
            this.fixedAspectRatio.Location = new System.Drawing.Point(13, 78);
            this.fixedAspectRatio.Name = "fixedAspectRatio";
            this.fixedAspectRatio.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.fixedAspectRatio.Size = new System.Drawing.Size(118, 17);
            this.fixedAspectRatio.TabIndex = 4;
            this.fixedAspectRatio.Text = ":Fixed Aspect Ratio";
            this.fixedAspectRatio.UseVisualStyleBackColor = true;
            this.fixedAspectRatio.CheckedChanged += new System.EventHandler(this.fixedAspectRatio_CheckedChanged);
            // 
            // startFullscreen
            // 
            this.startFullscreen.AutoSize = true;
            this.startFullscreen.Location = new System.Drawing.Point(29, 55);
            this.startFullscreen.Name = "startFullscreen";
            this.startFullscreen.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.startFullscreen.Size = new System.Drawing.Size(102, 17);
            this.startFullscreen.TabIndex = 3;
            this.startFullscreen.Text = ":Start Fullscreen";
            this.startFullscreen.UseVisualStyleBackColor = true;
            this.startFullscreen.CheckedChanged += new System.EventHandler(this.startFullscreen_CheckedChanged);
            // 
            // printFPS
            // 
            this.printFPS.AutoSize = true;
            this.printFPS.Location = new System.Drawing.Point(58, 32);
            this.printFPS.Name = "printFPS";
            this.printFPS.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.printFPS.Size = new System.Drawing.Size(73, 17);
            this.printFPS.TabIndex = 2;
            this.printFPS.Text = ":Print FPS";
            this.printFPS.UseVisualStyleBackColor = true;
            this.printFPS.CheckedChanged += new System.EventHandler(this.printFPS_CheckedChanged);
            // 
            // rgssVersion
            // 
            this.rgssVersion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.rgssVersion.FormattingEnabled = true;
            this.rgssVersion.Items.AddRange(new object[] {
            "Auto-Detect",
            "RGSS 1",
            "RGSS 2",
            "RGSS 3"});
            this.rgssVersion.Location = new System.Drawing.Point(117, 5);
            this.rgssVersion.Name = "rgssVersion";
            this.rgssVersion.Size = new System.Drawing.Size(121, 21);
            this.rgssVersion.TabIndex = 1;
            this.rgssVersion.SelectedIndexChanged += new System.EventHandler(this.rgssVersion_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "RGSS Version:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(4, 231);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(238, 231);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Apply";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 258);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SettingsForm_FormClosing);
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fixedFramerate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.screenHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.screenWidth)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ComboBox rgssVersion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox printFPS;
        private System.Windows.Forms.CheckBox startFullscreen;
        private System.Windows.Forms.CheckBox fixedAspectRatio;
        private System.Windows.Forms.CheckBox smoothScaling;
        private System.Windows.Forms.NumericUpDown screenHeight;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown screenWidth;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox f12SoftReset;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown fixedFramerate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}