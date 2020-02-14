namespace myBike
{
    partial class FmAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FmAbout));
            this.btnExit = new System.Windows.Forms.Button();
            this.pbAbout = new System.Windows.Forms.PictureBox();
            this.lbAbout = new System.Windows.Forms.Label();
            this.llblGPL = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pbAbout)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnExit.Location = new System.Drawing.Point(261, 152);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 24);
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
            this.lbAbout.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbAbout.Location = new System.Drawing.Point(198, 16);
            this.lbAbout.Name = "lbAbout";
            this.lbAbout.Size = new System.Drawing.Size(167, 90);
            this.lbAbout.TabIndex = 2;
            this.lbAbout.Text = "myBike (Cycling calculator)\r\nВелосипедний калькулятор\r\nVersion 1.1.0\r\nCopyright ©" +
    " 2020 Snowsoft \r\n\r\nThis program is free software\r\n";
            // 
            // llblGPL
            // 
            this.llblGPL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.llblGPL.ForeColor = System.Drawing.SystemColors.ControlText;
            this.llblGPL.LinkColor = System.Drawing.SystemColors.HotTrack;
            this.llblGPL.Location = new System.Drawing.Point(198, 118);
            this.llblGPL.Name = "llblGPL";
            this.llblGPL.Size = new System.Drawing.Size(167, 23);
            this.llblGPL.TabIndex = 3;
            this.llblGPL.TabStop = true;
            this.llblGPL.Text = "GNU General Public License";
            this.llblGPL.VisitedLinkColor = System.Drawing.Color.Silver;
            this.llblGPL.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblGPL_LinkClicked);
            // 
            // FmAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(373, 188);
            this.Controls.Add(this.llblGPL);
            this.Controls.Add(this.lbAbout);
            this.Controls.Add(this.pbAbout);
            this.Controls.Add(this.btnExit);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FmAbout";
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
        private System.Windows.Forms.LinkLabel llblGPL;
    }
}