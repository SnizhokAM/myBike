namespace myBike
{
    partial class fmMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmMain));
            this.btnCalc1 = new System.Windows.Forms.Button();
            this.btnCalc2 = new System.Windows.Forms.Button();
            this.btnAbout = new System.Windows.Forms.Button();
            this.tbCalc1 = new System.Windows.Forms.TrackBar();
            this.gbBikeType1 = new System.Windows.Forms.GroupBox();
            this.rbTouring1 = new System.Windows.Forms.RadioButton();
            this.rbChild1 = new System.Windows.Forms.RadioButton();
            this.rbBMX1 = new System.Windows.Forms.RadioButton();
            this.rbRoad1 = new System.Windows.Forms.RadioButton();
            this.rbMTB1 = new System.Windows.Forms.RadioButton();
            this.lblCalc1 = new System.Windows.Forms.Label();
            this.lblCalc1Height = new System.Windows.Forms.Label();
            this.pnlCalc1 = new System.Windows.Forms.Panel();
            this.pbCalc1 = new System.Windows.Forms.PictureBox();
            this.lblCalc1Note = new System.Windows.Forms.Label();
            this.lblCalc1Value = new System.Windows.Forms.Label();
            this.pnlCalc2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblCalc2Value = new System.Windows.Forms.Label();
            this.lblCalc2Speed = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.gbCalcMetod = new System.Windows.Forms.GroupBox();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.tbCalc2 = new System.Windows.Forms.TrackBar();
            this.cbCalc2B = new System.Windows.Forms.ComboBox();
            this.cbCalc2A = new System.Windows.Forms.ComboBox();
            this.cbCalc2L = new System.Windows.Forms.ComboBox();
            this.lblCalc2Note = new System.Windows.Forms.Label();
            this.tbCalc2L = new System.Windows.Forms.TrackBar();
            this.lblCalc2L = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tbCalc1)).BeginInit();
            this.gbBikeType1.SuspendLayout();
            this.pnlCalc1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCalc1)).BeginInit();
            this.pnlCalc2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbCalcMetod.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbCalc2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbCalc2L)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCalc1
            // 
            this.btnCalc1.BackColor = System.Drawing.Color.DimGray;
            this.btnCalc1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCalc1.ForeColor = System.Drawing.Color.White;
            this.btnCalc1.Location = new System.Drawing.Point(1, 0);
            this.btnCalc1.Name = "btnCalc1";
            this.btnCalc1.Size = new System.Drawing.Size(100, 24);
            this.btnCalc1.TabIndex = 1;
            this.btnCalc1.Text = "Ростовка";
            this.btnCalc1.UseVisualStyleBackColor = false;
            this.btnCalc1.Click += new System.EventHandler(this.btnCalc1_Click);
            // 
            // btnCalc2
            // 
            this.btnCalc2.BackColor = System.Drawing.Color.DimGray;
            this.btnCalc2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCalc2.ForeColor = System.Drawing.Color.White;
            this.btnCalc2.Location = new System.Drawing.Point(101, 0);
            this.btnCalc2.Name = "btnCalc2";
            this.btnCalc2.Size = new System.Drawing.Size(100, 24);
            this.btnCalc2.TabIndex = 2;
            this.btnCalc2.Text = "Каденс";
            this.btnCalc2.UseVisualStyleBackColor = false;
            this.btnCalc2.Click += new System.EventHandler(this.BtnCalc2_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.ForeColor = System.Drawing.Color.White;
            this.btnAbout.Location = new System.Drawing.Point(384, 1);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(86, 23);
            this.btnAbout.TabIndex = 3;
            this.btnAbout.Text = "Про програму";
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // tbCalc1
            // 
            this.tbCalc1.BackColor = System.Drawing.Color.DimGray;
            this.tbCalc1.Location = new System.Drawing.Point(200, 30);
            this.tbCalc1.Maximum = 215;
            this.tbCalc1.Minimum = 75;
            this.tbCalc1.Name = "tbCalc1";
            this.tbCalc1.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tbCalc1.Size = new System.Drawing.Size(45, 122);
            this.tbCalc1.TabIndex = 0;
            this.tbCalc1.TickFrequency = 10;
            this.tbCalc1.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.tbCalc1.Value = 150;
            this.tbCalc1.Scroll += new System.EventHandler(this.tbCalc1_Scroll);
            // 
            // gbBikeType1
            // 
            this.gbBikeType1.Controls.Add(this.rbTouring1);
            this.gbBikeType1.Controls.Add(this.rbChild1);
            this.gbBikeType1.Controls.Add(this.rbBMX1);
            this.gbBikeType1.Controls.Add(this.rbRoad1);
            this.gbBikeType1.Controls.Add(this.rbMTB1);
            this.gbBikeType1.Location = new System.Drawing.Point(8, 8);
            this.gbBikeType1.Name = "gbBikeType1";
            this.gbBikeType1.Size = new System.Drawing.Size(170, 144);
            this.gbBikeType1.TabIndex = 1;
            this.gbBikeType1.TabStop = false;
            this.gbBikeType1.Text = "Тип велосипеда";
            // 
            // rbTouring1
            // 
            this.rbTouring1.AutoSize = true;
            this.rbTouring1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbTouring1.Location = new System.Drawing.Point(8, 68);
            this.rbTouring1.Name = "rbTouring1";
            this.rbTouring1.Size = new System.Drawing.Size(154, 17);
            this.rbTouring1.TabIndex = 6;
            this.rbTouring1.Text = "Туристичний, трекінговий";
            this.rbTouring1.UseVisualStyleBackColor = true;
            this.rbTouring1.CheckedChanged += new System.EventHandler(this.rbTouring1_CheckedChanged);
            // 
            // rbChild1
            // 
            this.rbChild1.AutoSize = true;
            this.rbChild1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbChild1.Location = new System.Drawing.Point(8, 116);
            this.rbChild1.Name = "rbChild1";
            this.rbChild1.Size = new System.Drawing.Size(67, 17);
            this.rbChild1.TabIndex = 5;
            this.rbChild1.Text = "Дитячий";
            this.rbChild1.UseVisualStyleBackColor = true;
            this.rbChild1.CheckedChanged += new System.EventHandler(this.rbChild1_CheckedChanged);
            // 
            // rbBMX1
            // 
            this.rbBMX1.AutoSize = true;
            this.rbBMX1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbBMX1.Location = new System.Drawing.Point(8, 92);
            this.rbBMX1.Name = "rbBMX1";
            this.rbBMX1.Size = new System.Drawing.Size(47, 17);
            this.rbBMX1.TabIndex = 4;
            this.rbBMX1.Text = "BMX";
            this.rbBMX1.UseVisualStyleBackColor = true;
            this.rbBMX1.CheckedChanged += new System.EventHandler(this.rbBMX1_CheckedChanged);
            // 
            // rbRoad1
            // 
            this.rbRoad1.AutoSize = true;
            this.rbRoad1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbRoad1.Location = new System.Drawing.Point(8, 44);
            this.rbRoad1.Name = "rbRoad1";
            this.rbRoad1.Size = new System.Drawing.Size(131, 17);
            this.rbRoad1.TabIndex = 3;
            this.rbRoad1.Text = "Шосейний, дорожний";
            this.rbRoad1.UseVisualStyleBackColor = true;
            this.rbRoad1.CheckedChanged += new System.EventHandler(this.rbRoad1_CheckedChanged);
            // 
            // rbMTB1
            // 
            this.rbMTB1.AutoSize = true;
            this.rbMTB1.Checked = true;
            this.rbMTB1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbMTB1.Location = new System.Drawing.Point(8, 20);
            this.rbMTB1.Name = "rbMTB1";
            this.rbMTB1.Size = new System.Drawing.Size(130, 17);
            this.rbMTB1.TabIndex = 2;
            this.rbMTB1.TabStop = true;
            this.rbMTB1.Text = "MTB, гібрид, міський";
            this.rbMTB1.UseVisualStyleBackColor = true;
            this.rbMTB1.CheckedChanged += new System.EventHandler(this.rbMTB1_CheckedChanged);
            // 
            // lblCalc1
            // 
            this.lblCalc1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCalc1.Location = new System.Drawing.Point(199, 8);
            this.lblCalc1.Name = "lblCalc1";
            this.lblCalc1.Size = new System.Drawing.Size(82, 20);
            this.lblCalc1.TabIndex = 2;
            this.lblCalc1.Text = "Ваш зріст (см):";
            // 
            // lblCalc1Height
            // 
            this.lblCalc1Height.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCalc1Height.Location = new System.Drawing.Point(254, 74);
            this.lblCalc1Height.Name = "lblCalc1Height";
            this.lblCalc1Height.Size = new System.Drawing.Size(80, 24);
            this.lblCalc1Height.TabIndex = 3;
            this.lblCalc1Height.Text = "150 см";
            this.lblCalc1Height.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlCalc1
            // 
            this.pnlCalc1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlCalc1.BackColor = System.Drawing.Color.DimGray;
            this.pnlCalc1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCalc1.Controls.Add(this.pbCalc1);
            this.pnlCalc1.Controls.Add(this.lblCalc1Note);
            this.pnlCalc1.Controls.Add(this.lblCalc1Value);
            this.pnlCalc1.Controls.Add(this.lblCalc1Height);
            this.pnlCalc1.Controls.Add(this.lblCalc1);
            this.pnlCalc1.Controls.Add(this.gbBikeType1);
            this.pnlCalc1.Controls.Add(this.tbCalc1);
            this.pnlCalc1.Location = new System.Drawing.Point(1, 24);
            this.pnlCalc1.Name = "pnlCalc1";
            this.pnlCalc1.Size = new System.Drawing.Size(678, 392);
            this.pnlCalc1.TabIndex = 0;
            // 
            // pbCalc1
            // 
            this.pbCalc1.Image = global::myBike.Properties.Resources.mtb;
            this.pbCalc1.Location = new System.Drawing.Point(364, 12);
            this.pbCalc1.Name = "pbCalc1";
            this.pbCalc1.Size = new System.Drawing.Size(300, 210);
            this.pbCalc1.TabIndex = 6;
            this.pbCalc1.TabStop = false;
            // 
            // lblCalc1Note
            // 
            this.lblCalc1Note.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCalc1Note.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCalc1Note.Location = new System.Drawing.Point(10, 310);
            this.lblCalc1Note.Name = "lblCalc1Note";
            this.lblCalc1Note.Size = new System.Drawing.Size(656, 60);
            this.lblCalc1Note.TabIndex = 5;
            this.lblCalc1Note.Text = resources.GetString("lblCalc1Note.Text");
            this.lblCalc1Note.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCalc1Value
            // 
            this.lblCalc1Value.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCalc1Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCalc1Value.Location = new System.Drawing.Point(10, 170);
            this.lblCalc1Value.Name = "lblCalc1Value";
            this.lblCalc1Value.Size = new System.Drawing.Size(340, 130);
            this.lblCalc1Value.TabIndex = 4;
            this.lblCalc1Value.Text = "Рекомендується розмір рами 13\\\"-14\\\" або 33-35 сантиметрів (XS).";
            this.lblCalc1Value.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlCalc2
            // 
            this.pnlCalc2.BackColor = System.Drawing.Color.DimGray;
            this.pnlCalc2.Controls.Add(this.lblCalc2L);
            this.pnlCalc2.Controls.Add(this.label3);
            this.pnlCalc2.Controls.Add(this.tbCalc2L);
            this.pnlCalc2.Controls.Add(this.pictureBox1);
            this.pnlCalc2.Controls.Add(this.lblCalc2Value);
            this.pnlCalc2.Controls.Add(this.lblCalc2Speed);
            this.pnlCalc2.Controls.Add(this.label5);
            this.pnlCalc2.Controls.Add(this.label4);
            this.pnlCalc2.Controls.Add(this.gbCalcMetod);
            this.pnlCalc2.Controls.Add(this.tbCalc2);
            this.pnlCalc2.Controls.Add(this.cbCalc2B);
            this.pnlCalc2.Controls.Add(this.cbCalc2A);
            this.pnlCalc2.Controls.Add(this.cbCalc2L);
            this.pnlCalc2.Controls.Add(this.lblCalc2Note);
            this.pnlCalc2.Location = new System.Drawing.Point(1, 24);
            this.pnlCalc2.Name = "pnlCalc2";
            this.pnlCalc2.Size = new System.Drawing.Size(678, 392);
            this.pnlCalc2.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::myBike.Properties.Resources.mtb;
            this.pictureBox1.Location = new System.Drawing.Point(364, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 210);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // lblCalc2Value
            // 
            this.lblCalc2Value.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCalc2Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCalc2Value.Location = new System.Drawing.Point(8, 234);
            this.lblCalc2Value.Name = "lblCalc2Value";
            this.lblCalc2Value.Size = new System.Drawing.Size(348, 49);
            this.lblCalc2Value.TabIndex = 11;
            this.lblCalc2Value.Text = "Каденс: 100 об/хв";
            this.lblCalc2Value.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCalc2Speed
            // 
            this.lblCalc2Speed.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCalc2Speed.Location = new System.Drawing.Point(245, 106);
            this.lblCalc2Speed.Name = "lblCalc2Speed";
            this.lblCalc2Speed.Size = new System.Drawing.Size(110, 24);
            this.lblCalc2Speed.TabIndex = 10;
            this.lblCalc2Speed.Text = "20 км/год";
            this.lblCalc2Speed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.Location = new System.Drawing.Point(6, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(180, 14);
            this.label5.TabIndex = 9;
            this.label5.Text = "Кількість зубців задньої зірочки:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.Location = new System.Drawing.Point(8, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 14);
            this.label3.TabIndex = 9;
            this.label3.Text = "Кількість зубців передньої зірочки:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.Location = new System.Drawing.Point(209, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Швидкість велосипеда:";
            // 
            // gbCalcMetod
            // 
            this.gbCalcMetod.Controls.Add(this.radioButton4);
            this.gbCalcMetod.Controls.Add(this.radioButton5);
            this.gbCalcMetod.Location = new System.Drawing.Point(8, 8);
            this.gbCalcMetod.Name = "gbCalcMetod";
            this.gbCalcMetod.Size = new System.Drawing.Size(180, 74);
            this.gbCalcMetod.TabIndex = 8;
            this.gbCalcMetod.TabStop = false;
            this.gbCalcMetod.Text = "Розрахунок по";
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButton4.Location = new System.Drawing.Point(8, 44);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(170, 17);
            this.radioButton4.TabIndex = 3;
            this.radioButton4.Text = "Довжині кола  колеса (в мм)";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Checked = true;
            this.radioButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButton5.Location = new System.Drawing.Point(8, 20);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(150, 17);
            this.radioButton5.TabIndex = 2;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "Розміру коліс (в дюймах)";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // tbCalc2
            // 
            this.tbCalc2.BackColor = System.Drawing.Color.DimGray;
            this.tbCalc2.Location = new System.Drawing.Point(210, 30);
            this.tbCalc2.Maximum = 80;
            this.tbCalc2.Minimum = 1;
            this.tbCalc2.Name = "tbCalc2";
            this.tbCalc2.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tbCalc2.Size = new System.Drawing.Size(45, 182);
            this.tbCalc2.TabIndex = 7;
            this.tbCalc2.TickFrequency = 5;
            this.tbCalc2.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.tbCalc2.Value = 20;
            this.tbCalc2.Scroll += new System.EventHandler(this.TbCalc2_Scroll);
            // 
            // cbCalc2B
            // 
            this.cbCalc2B.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCalc2B.FormattingEnabled = true;
            this.cbCalc2B.Items.AddRange(new object[] {
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50"});
            this.cbCalc2B.Location = new System.Drawing.Point(8, 196);
            this.cbCalc2B.Name = "cbCalc2B";
            this.cbCalc2B.Size = new System.Drawing.Size(180, 21);
            this.cbCalc2B.TabIndex = 0;
            this.cbCalc2B.SelectedIndexChanged += new System.EventHandler(this.CbCalc2B_SelectedIndexChanged);
            // 
            // cbCalc2A
            // 
            this.cbCalc2A.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCalc2A.FormattingEnabled = true;
            this.cbCalc2A.Items.AddRange(new object[] {
            "22",
            "24",
            "28",
            "32",
            "34",
            "38",
            "40",
            "42",
            "44",
            "46",
            "48",
            "52",
            "53"});
            this.cbCalc2A.Location = new System.Drawing.Point(8, 146);
            this.cbCalc2A.Name = "cbCalc2A";
            this.cbCalc2A.Size = new System.Drawing.Size(180, 21);
            this.cbCalc2A.TabIndex = 0;
            this.cbCalc2A.SelectedIndexChanged += new System.EventHandler(this.CbCalc2A_SelectedIndexChanged);
            // 
            // cbCalc2L
            // 
            this.cbCalc2L.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCalc2L.FormattingEnabled = true;
            this.cbCalc2L.Location = new System.Drawing.Point(8, 96);
            this.cbCalc2L.Name = "cbCalc2L";
            this.cbCalc2L.Size = new System.Drawing.Size(180, 21);
            this.cbCalc2L.TabIndex = 0;
            // 
            // lblCalc2Note
            // 
            this.lblCalc2Note.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCalc2Note.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCalc2Note.Location = new System.Drawing.Point(8, 300);
            this.lblCalc2Note.Name = "lblCalc2Note";
            this.lblCalc2Note.Size = new System.Drawing.Size(666, 84);
            this.lblCalc2Note.TabIndex = 12;
            this.lblCalc2Note.Text = resources.GetString("lblCalc2Note.Text");
            // 
            // tbCalc2L
            // 
            this.tbCalc2L.AutoSize = false;
            this.tbCalc2L.Location = new System.Drawing.Point(0, 96);
            this.tbCalc2L.Maximum = 2400;
            this.tbCalc2L.Minimum = 900;
            this.tbCalc2L.Name = "tbCalc2L";
            this.tbCalc2L.Size = new System.Drawing.Size(104, 30);
            this.tbCalc2L.TabIndex = 14;
            this.tbCalc2L.Value = 2068;
            this.tbCalc2L.Scroll += new System.EventHandler(this.TbCalc2L_Scroll);
            // 
            // lblCalc2L
            // 
            this.lblCalc2L.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCalc2L.Location = new System.Drawing.Point(126, 99);
            this.lblCalc2L.Name = "lblCalc2L";
            this.lblCalc2L.Size = new System.Drawing.Size(60, 14);
            this.lblCalc2L.TabIndex = 15;
            this.lblCalc2L.Text = "2068 мм";
            // 
            // fmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(680, 417);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.btnCalc2);
            this.Controls.Add(this.btnCalc1);
            this.Controls.Add(this.pnlCalc2);
            this.Controls.Add(this.pnlCalc1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "fmMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.fmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbCalc1)).EndInit();
            this.gbBikeType1.ResumeLayout(false);
            this.gbBikeType1.PerformLayout();
            this.pnlCalc1.ResumeLayout(false);
            this.pnlCalc1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCalc1)).EndInit();
            this.pnlCalc2.ResumeLayout(false);
            this.pnlCalc2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gbCalcMetod.ResumeLayout(false);
            this.gbCalcMetod.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbCalc2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbCalc2L)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnCalc1;
        private System.Windows.Forms.Button btnCalc2;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.TrackBar tbCalc1;
        private System.Windows.Forms.GroupBox gbBikeType1;
        private System.Windows.Forms.RadioButton rbTouring1;
        private System.Windows.Forms.RadioButton rbChild1;
        private System.Windows.Forms.RadioButton rbBMX1;
        private System.Windows.Forms.RadioButton rbRoad1;
        private System.Windows.Forms.RadioButton rbMTB1;
        private System.Windows.Forms.Label lblCalc1;
        private System.Windows.Forms.Label lblCalc1Height;
        private System.Windows.Forms.Panel pnlCalc1;
        private System.Windows.Forms.Label lblCalc1Note;
        private System.Windows.Forms.Label lblCalc1Value;
        private System.Windows.Forms.PictureBox pbCalc1;
        private System.Windows.Forms.Panel pnlCalc2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblCalc2Value;
        private System.Windows.Forms.Label lblCalc2Speed;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox gbCalcMetod;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.TrackBar tbCalc2;
        private System.Windows.Forms.ComboBox cbCalc2B;
        private System.Windows.Forms.ComboBox cbCalc2A;
        private System.Windows.Forms.ComboBox cbCalc2L;
        private System.Windows.Forms.Label lblCalc2Note;
        private System.Windows.Forms.Label lblCalc2L;
        private System.Windows.Forms.TrackBar tbCalc2L;
    }
}

