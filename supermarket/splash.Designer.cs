﻿namespace supermarket
{
    partial class splash
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(splash));
            this.siticoneAnimateWindow1 = new Siticone.Desktop.UI.WinForms.SiticoneAnimateWindow(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Myprogress = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Myprogress
            // 
            this.Myprogress.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Myprogress.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Myprogress.Location = new System.Drawing.Point(3, 452);
            this.Myprogress.Name = "Myprogress";
            this.Myprogress.Size = new System.Drawing.Size(901, 23);
            this.Myprogress.TabIndex = 12;
            this.Myprogress.Click += new System.EventHandler(this.Myprogress_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.label1.Location = new System.Drawing.Point(170, 401);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(557, 29);
            this.label1.TabIndex = 13;
            this.label1.Text = "BRIGHTO CLEANING SERVICE APPLICATION";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(820, 452);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "version 2.0";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // splash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(903, 466);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Myprogress);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(903, 466);
            this.MinimumSize = new System.Drawing.Size(903, 466);
            this.Name = "splash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "splash";
            this.Load += new System.EventHandler(this.splash_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Siticone.Desktop.UI.WinForms.SiticoneAnimateWindow siticoneAnimateWindow1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ProgressBar Myprogress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}