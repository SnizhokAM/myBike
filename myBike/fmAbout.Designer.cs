﻿namespace myPaint
{
    partial class fmAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmAbout));
            this.btnExit = new System.Windows.Forms.Button();
            this.pbAbout = new System.Windows.Forms.PictureBox();
            this.lbAbout = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbAbout)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(286, 153);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "&Ок";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pbAbout
            // 
            this.pbAbout.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbAbout.ErrorImage = null;
            this.pbAbout.Image = ((System.Drawing.Image)(resources.GetObject("pbAbout.Image")));
            this.pbAbout.InitialImage = null;
            this.pbAbout.Location = new System.Drawing.Point(12, 12);
            this.pbAbout.Name = "pbAbout";
            this.pbAbout.Size = new System.Drawing.Size(162, 162);
            this.pbAbout.TabIndex = 1;
            this.pbAbout.TabStop = false;
            // 
            // lbAbout
            // 
            this.lbAbout.AutoSize = true;
            this.lbAbout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(204)));
            this.lbAbout.ForeColor = System.Drawing.Color.White;
            this.lbAbout.Location = new System.Drawing.Point(198, 16);
            this.lbAbout.Name = "lbAbout";
            this.lbAbout.Size = new System.Drawing.Size(167, 90);
            this.lbAbout.TabIndex = 2;
            this.lbAbout.Text = "myBike (Bike Calculator)\r\nВелосипедний калькулятор\r\nVersion 1.0.0\r\n© Snowsoft, 20" +
    "19\r\n\r\nThis program is free software\r\n";
            // 
            // fmAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(373, 188);
            this.Controls.Add(this.lbAbout);
            this.Controls.Add(this.pbAbout);
            this.Controls.Add(this.btnExit);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fmAbout";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Про програму";
            ((System.ComponentModel.ISupportInitialize)(this.pbAbout)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.PictureBox pbAbout;
        private System.Windows.Forms.Label lbAbout;
    }
}