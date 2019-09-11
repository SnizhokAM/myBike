namespace myBike
{
    partial class fmAirResist
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
            this.btnOk = new System.Windows.Forms.Button();
            this.cbAeroPosition = new System.Windows.Forms.ComboBox();
            this.lblElevation = new System.Windows.Forms.Label();
            this.lblTemperature = new System.Windows.Forms.Label();
            this.tbElevation = new System.Windows.Forms.TrackBar();
            this.tbTemperature = new System.Windows.Forms.TrackBar();
            this.lblTElevation = new System.Windows.Forms.Label();
            this.lblTTemperature = new System.Windows.Forms.Label();
            this.lblTAeroPosition = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tbElevation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbTemperature)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOk.Location = new System.Drawing.Point(106, 168);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(100, 24);
            this.btnOk.TabIndex = 4;
            this.btnOk.Text = "Обчислити";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // cbAeroPosition
            // 
            this.cbAeroPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAeroPosition.FormattingEnabled = true;
            this.cbAeroPosition.Location = new System.Drawing.Point(10, 27);
            this.cbAeroPosition.Name = "cbAeroPosition";
            this.cbAeroPosition.Size = new System.Drawing.Size(195, 21);
            this.cbAeroPosition.TabIndex = 1;
            // 
            // lblElevation
            // 
            this.lblElevation.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblElevation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblElevation.Location = new System.Drawing.Point(155, 127);
            this.lblElevation.Name = "lblElevation";
            this.lblElevation.Size = new System.Drawing.Size(50, 20);
            this.lblElevation.TabIndex = 0;
            this.lblElevation.Text = "120 м";
            this.lblElevation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTemperature
            // 
            this.lblTemperature.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTemperature.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTemperature.Location = new System.Drawing.Point(155, 77);
            this.lblTemperature.Name = "lblTemperature";
            this.lblTemperature.Size = new System.Drawing.Size(50, 20);
            this.lblTemperature.TabIndex = 0;
            this.lblTemperature.Text = "20 °C";
            this.lblTemperature.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbElevation
            // 
            this.tbElevation.AutoSize = false;
            this.tbElevation.Location = new System.Drawing.Point(3, 124);
            this.tbElevation.Maximum = 2000;
            this.tbElevation.Name = "tbElevation";
            this.tbElevation.Size = new System.Drawing.Size(154, 30);
            this.tbElevation.TabIndex = 3;
            this.tbElevation.TickFrequency = 100;
            this.tbElevation.Value = 120;
            this.tbElevation.Scroll += new System.EventHandler(this.tbElevation_Scroll);
            // 
            // tbTemperature
            // 
            this.tbTemperature.AutoSize = false;
            this.tbTemperature.Location = new System.Drawing.Point(3, 74);
            this.tbTemperature.Maximum = 40;
            this.tbTemperature.Minimum = -20;
            this.tbTemperature.Name = "tbTemperature";
            this.tbTemperature.Size = new System.Drawing.Size(154, 30);
            this.tbTemperature.TabIndex = 2;
            this.tbTemperature.TickFrequency = 5;
            this.tbTemperature.Value = 20;
            this.tbTemperature.Scroll += new System.EventHandler(this.tbTemperature_Scroll);
            // 
            // lblTElevation
            // 
            this.lblTElevation.Location = new System.Drawing.Point(8, 108);
            this.lblTElevation.Name = "lblTElevation";
            this.lblTElevation.Size = new System.Drawing.Size(194, 14);
            this.lblTElevation.TabIndex = 0;
            this.lblTElevation.Text = "Висота над рівнем моря:";
            // 
            // lblTTemperature
            // 
            this.lblTTemperature.Location = new System.Drawing.Point(8, 58);
            this.lblTTemperature.Name = "lblTTemperature";
            this.lblTTemperature.Size = new System.Drawing.Size(194, 14);
            this.lblTTemperature.TabIndex = 0;
            this.lblTTemperature.Text = "Температура повітря (°C):";
            // 
            // lblTAeroPosition
            // 
            this.lblTAeroPosition.Location = new System.Drawing.Point(8, 8);
            this.lblTAeroPosition.Name = "lblTAeroPosition";
            this.lblTAeroPosition.Size = new System.Drawing.Size(194, 14);
            this.lblTAeroPosition.TabIndex = 0;
            this.lblTAeroPosition.Text = "Тип посадки:";
            // 
            // fmAirResist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(218, 204);
            this.ControlBox = false;
            this.Controls.Add(this.cbAeroPosition);
            this.Controls.Add(this.lblElevation);
            this.Controls.Add(this.lblTemperature);
            this.Controls.Add(this.tbElevation);
            this.Controls.Add(this.tbTemperature);
            this.Controls.Add(this.lblTElevation);
            this.Controls.Add(this.lblTTemperature);
            this.Controls.Add(this.lblTAeroPosition);
            this.Controls.Add(this.btnOk);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fmAirResist";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Коефіцієнт опору повітря";
            ((System.ComponentModel.ISupportInitialize)(this.tbElevation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbTemperature)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.ComboBox cbAeroPosition;
        private System.Windows.Forms.Label lblElevation;
        private System.Windows.Forms.Label lblTemperature;
        private System.Windows.Forms.TrackBar tbElevation;
        private System.Windows.Forms.TrackBar tbTemperature;
        private System.Windows.Forms.Label lblTElevation;
        private System.Windows.Forms.Label lblTTemperature;
        private System.Windows.Forms.Label lblTAeroPosition;
    }
}