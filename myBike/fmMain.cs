using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace myBike
{
    public partial class fmMain : Form
    {
        public fmMain(fmSplash screenform)
        {
            InitializeComponent();
            screenform.Hide();
            screenform.Dispose();
        }

        private CalcSize Calc1;
        private CalcCadence Calc2;
        private CalcSpeed Calc3;
        private CalcSprocketB Calc4;
        private CalcPower Calc6;
        private string[] SprocketA;
        private string[] SprocketB;
        private string[] TireType;
        private float[] RollingResistance;
        private float[] BikerArea;
        private List<string> TireName;
        private List<int> TireLength;
        private int tmp_AeroPosition = 0;
        private int tmp_Temperature = 20;
        private int tmp_Elevation = 120;

        private void fmMain_Load(object sender, EventArgs e)
        {
            Calc1 = new CalcSize();
            Calc2 = new CalcCadence();
            Calc3 = new CalcSpeed();
            Calc4 = new CalcSprocketB();
            Calc6 = new CalcPower();
            SprocketA = new[] {"22", "24", "28", "32", "34", "38", "40", "42", "44", "46", "48", "52", "53"};
            SprocketB = new string[40];
            for (int bi = 0; bi < 40; bi++)
            {
                SprocketB[bi] = (bi + 11).ToString();
            }
            TireType = new[] {"Шосейна", "МТБ слік/напівслік", "МТБ грязева"};
            RollingResistance = new[] { 0.004f, 0.005f, 0.012f };
            BikerArea = new[] { 0.445f, 0.420f, 0.388f, 0.300f, 0.233f };
            TireName = new List<string>();
            TireLength = new List<int>();
            try
            {
                XmlDocument tiretable = new XmlDocument();
                tiretable.Load("myBike.xml");
                XmlElement tireroot = tiretable.DocumentElement;
                foreach (XmlNode tirenode in tireroot)
                {
                    foreach (XmlNode tiredata in tirenode.ChildNodes)
                    {
                        if (tiredata.Name == "tirename") TireName.Add(tiredata.InnerText);
                        if (tiredata.Name == "l") TireLength.Add(Convert.ToInt32(tiredata.InnerText));
                    }
                }
            }
            catch
            {
                MessageBox.Show("Файл бази данних myBike.xml відсутній або пошкоджений. Функціональність програмного забезпечення обмежена!", "Попередження!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                TireName.Add("26x2.10");
                TireLength.Add(2068);
            }
            ComboBoxAddItemsFromList(cbCalc2L, TireName);
            cbCalc2A.Items.AddRange(SprocketA);
            cbCalc2A.SelectedIndex = 0;
            cbCalc2B.Items.AddRange(SprocketB);
            cbCalc2B.SelectedIndex = 0;
            ComboBoxAddItemsFromList(cbCalc3L, TireName);
            cbCalc3A.Items.AddRange(SprocketA);
            cbCalc3A.SelectedIndex = 0;
            cbCalc3B.Items.AddRange(SprocketB);
            cbCalc3B.SelectedIndex = 0;
            ComboBoxAddItemsFromList(cbCalc4L, TireName);
            cbCalc4A.Items.AddRange(SprocketA);
            cbCalc4A.SelectedIndex = 0;
            ComboBoxAddItemsFromList(cbCalc5L, TireName);
            cbCalc6TireType.Items.AddRange(TireType);
            cbCalc6TireType.SelectedIndex = 1;
        }

        private void ComboBoxAddItemsFromList(ComboBox combobox, List<string> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                combobox.Items.Add(list[i]);
            }
            if (combobox.Items.Count != 0) combobox.SelectedIndex = 0;
        }

        private void SetDefButtonColor()
        {
            btnCalc1.BackColor = Color.Black;
            btnCalc2.BackColor = Color.Black;
            btnCalc3.BackColor = Color.Black;
            btnCalc4.BackColor = Color.Black;
            btnCalc5.BackColor = Color.Black;
            btnCalc6.BackColor = Color.Black;
        }

        private void SetDefPanelState()
        {
            pnlCalc1.Enabled = false;
            pnlCalc1.Visible = false;
            pnlCalc2.Enabled = false;
            pnlCalc2.Visible = false;
            pnlCalc3.Enabled = false;
            pnlCalc3.Visible = false;
            pnlCalc4.Enabled = false;
            pnlCalc4.Visible = false;
            pnlCalc5.Enabled = false;
            pnlCalc5.Visible = false;
            pnlCalc6.Enabled = false;
            pnlCalc6.Visible = false;
        }

        private void btnCalc1_Click(object sender, EventArgs e)
        {
            this.Text = "Велосипедний калькулятор - ростовка";
            SetDefButtonColor();
            btnCalc1.BackColor = Color.DimGray;
            SetDefPanelState();
            pnlCalc1.Enabled = true;
            pnlCalc1.Visible = true;
            if (rbMTB1.Checked) rbMTB1.Focus();
            if (rbRoad1.Checked) rbRoad1.Focus();
            if (rbTouring1.Checked) rbTouring1.Focus();
            if (rbBMX1.Checked) rbBMX1.Focus();
            if (rbChild1.Checked) rbChild1.Focus();
        }

        private void btnCalc2_Click(object sender, EventArgs e)
        {
            this.Text = "Велосипедний калькулятор - каденс";
            SetDefButtonColor();
            btnCalc2.BackColor = Color.DimGray;
            SetDefPanelState();
            pnlCalc2.Enabled = true;
            pnlCalc2.Visible = true;
            if (rbCalc2D.Checked) rbCalc2D.Focus();
            if (rbCalc2L.Checked) rbCalc2L.Focus();
        }

        private void btnCalc3_Click(object sender, EventArgs e)
        {
            this.Text = "Велосипедний калькулятор - швидкість";
            SetDefButtonColor();
            btnCalc3.BackColor = Color.DimGray;
            SetDefPanelState();
            pnlCalc3.Enabled = true;
            pnlCalc3.Visible = true;
            if (rbCalc3D.Checked) rbCalc3D.Focus();
            if (rbCalc3L.Checked) rbCalc3L.Focus();
        }

        private void btnCalc4_Click(object sender, EventArgs e)
        {
            this.Text = "Велосипедний калькулятор - касета";
            SetDefButtonColor();
            btnCalc4.BackColor = Color.DimGray;
            SetDefPanelState();
            pnlCalc4.Enabled = true;
            pnlCalc4.Visible = true;
            if (rbCalc4D.Checked) rbCalc4D.Focus();
            if (rbCalc4L.Checked) rbCalc4L.Focus();
        }

        private void btnCalc5_Click(object sender, EventArgs e)
        {
            this.Text = "Велосипедний калькулятор - велокомп'ютер";
            SetDefButtonColor();
            btnCalc5.BackColor = Color.DimGray;
            SetDefPanelState();
            pnlCalc5.Enabled = true;
            pnlCalc5.Visible = true;
            cbCalc5L.Focus();
        }

        private void btnCalc6_Click(object sender, EventArgs e)
        {
            this.Text = "Велосипедний калькулятор - подорож";
            SetDefButtonColor();
            btnCalc6.BackColor = Color.DimGray;
            SetDefPanelState();
            pnlCalc6.Enabled = true;
            pnlCalc6.Visible = true;
            tbCalc6WeightBiker.Focus();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            btnAbout.BackColor = Color.DimGray;
            fmAbout AboutProgram = new fmAbout();
            AboutProgram.ShowDialog();
            AboutProgram.Dispose();
            btnAbout.BackColor = Color.Black;
            if (pnlCalc1.Enabled) pnlCalc1.Focus();
            if (pnlCalc2.Enabled) pnlCalc2.Focus();
            if (pnlCalc3.Enabled) pnlCalc3.Focus();
            if (pnlCalc4.Enabled) pnlCalc4.Focus();
            if (pnlCalc5.Enabled) pnlCalc5.Focus();
            if (pnlCalc6.Enabled) pnlCalc6.Focus();
        }

        // Калькулятор #1 "Ростовка" 

        private void rbMTB1_CheckedChanged(object sender, EventArgs e)
        {
            Calc1Update();
        }

        private void rbRoad1_CheckedChanged(object sender, EventArgs e)
        {
            Calc1Update();
        }

        private void rbTouring1_CheckedChanged(object sender, EventArgs e)
        {
            Calc1Update();
        }

        private void rbBMX1_CheckedChanged(object sender, EventArgs e)
        {
            Calc1Update();
        }

        private void rbChild1_CheckedChanged(object sender, EventArgs e)
        {
            Calc1Update();
        }

        private void tbCalc1_Scroll(object sender, EventArgs e)
        {
            lblCalc1Height.Text = tbCalc1.Value.ToString() + " см";
            Calc1Update();
        }

        private void Calc1Update()
        {
            if (rbMTB1.Checked)
            {
                pbCalc1.Image = Properties.Resources.mtb;
                lblCalc1Value.Text = Calc1.GetValue(1, tbCalc1.Value);
                lblCalc1Note.Text = Calc1.GetNote(1);
            }
            if (rbRoad1.Checked)
            {
                pbCalc1.Image = Properties.Resources.road;
                lblCalc1Value.Text = Calc1.GetValue(2, tbCalc1.Value);
                lblCalc1Note.Text = Calc1.GetNote(2);
            }
            if (rbTouring1.Checked)
            {
                pbCalc1.Image = Properties.Resources.tour;
                lblCalc1Value.Text = Calc1.GetValue(3, tbCalc1.Value);
                lblCalc1Note.Text = Calc1.GetNote(3);
            }
            if (rbBMX1.Checked)
            {
                pbCalc1.Image = Properties.Resources.bmx;
                lblCalc1Value.Text = Calc1.GetValue(4, tbCalc1.Value);
                lblCalc1Note.Text = Calc1.GetNote(4);
            }
            if (rbChild1.Checked)
            {
                pbCalc1.Image = Properties.Resources.kids;
                lblCalc1Value.Text = Calc1.GetValue(5, tbCalc1.Value);
                lblCalc1Note.Text = Calc1.GetNote(5);
            }
        }

        // Калькулятор #2 "Каденс" 

        private void rbCalc2D_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCalc2D.Checked)
            {
                tbCalc2L.Enabled = false;
                tbCalc2L.Visible = false;
                lblCalc2L.Visible = false;
                cbCalc2L.Enabled = true;
                cbCalc2L.Visible = true;
            }
            else
            {
                tbCalc2L.Enabled = true;
                tbCalc2L.Visible = true;
                lblCalc2L.Visible = true;
                cbCalc2L.Enabled = false;
                cbCalc2L.Visible = false;
            }
            Calc2Update();
        }

        private void tbCalc2Speed_Scroll(object sender, EventArgs e)
        {
            lblCalc2Speed.Text = tbCalc2Speed.Value.ToString() + " км/год";
            Calc2Update();
        }

        private void tbCalc2L_Scroll(object sender, EventArgs e)
        {
            lblCalc2L.Text = tbCalc2L.Value.ToString() + " мм";
            Calc2Update();
        }

        private void сbCalc2L_SelectedIndexChanged(object sender, EventArgs e)
        {
            Calc2Update();
        }

        private void cbCalc2A_SelectedIndexChanged(object sender, EventArgs e)
        {
            Calc2Update();
        }

        private void cbCalc2B_SelectedIndexChanged(object sender, EventArgs e)
        {
            Calc2Update();
        }

        private void Calc2Update()
        {
            if ((cbCalc2L.SelectedIndex != -1) && (cbCalc2A.SelectedIndex != -1) && (cbCalc2B.SelectedIndex != -1))
            {
                if (rbCalc2D.Checked)
                {
                    pbCalc2.Image = Properties.Resources.wheel_d;
                    lblCalc2Value.Text = Calc2.GetValue(int.Parse(cbCalc2A.Text), int.Parse(cbCalc2B.Text), tbCalc2Speed.Value, TireLength[cbCalc2L.SelectedIndex]);
                }
                else
                {
                    pbCalc2.Image = Properties.Resources.wheel_l;
                    lblCalc2Value.Text = Calc2.GetValue(int.Parse(cbCalc2A.Text), int.Parse(cbCalc2B.Text), tbCalc2Speed.Value, tbCalc2L.Value);
                }
            }
        }

        // Калькулятор #3 "Швидкість"
        private void rbCalc3D_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCalc3D.Checked)
            {
                tbCalc3L.Enabled = false;
                tbCalc3L.Visible = false;
                lblCalc3L.Visible = false;
                cbCalc3L.Enabled = true;
                cbCalc3L.Visible = true;
            }
            else
            {
                tbCalc3L.Enabled = true;
                tbCalc3L.Visible = true;
                lblCalc3L.Visible = true;
                cbCalc3L.Enabled = false;
                cbCalc3L.Visible = false;
            }
            Calc3Update();
        }

        private void tbCalc3Cadence_Scroll(object sender, EventArgs e)
        {
            lblCalc3Cadence.Text = tbCalc3Cadence.Value.ToString() + " об/хв";
            Calc3Update();
        }

        private void tbCalc3L_Scroll(object sender, EventArgs e)
        {
            lblCalc3L.Text = tbCalc3L.Value.ToString() + " мм";
            Calc3Update();
        }

        private void cbCalc3L_SelectedIndexChanged(object sender, EventArgs e)
        {
            Calc3Update();
        }

        private void cbCalc3A_SelectedIndexChanged(object sender, EventArgs e)
        {
            Calc3Update();
        }

        private void cbCalc3B_SelectedIndexChanged(object sender, EventArgs e)
        {
            Calc3Update();
        }

        private void Calc3Update()
        {
            if ((cbCalc3L.SelectedIndex != -1) && (cbCalc3A.SelectedIndex != -1) && (cbCalc3B.SelectedIndex != -1))
            {
                if (rbCalc3D.Checked)
                {
                    pbCalc3.Image = Properties.Resources.wheel_d;
                    lblCalc3Value.Text = Calc3.GetValue(int.Parse(cbCalc3A.Text), int.Parse(cbCalc3B.Text), tbCalc3Cadence.Value, TireLength[cbCalc3L.SelectedIndex]);
                }
                else
                {
                    pbCalc3.Image = Properties.Resources.wheel_l;
                    lblCalc3Value.Text = Calc3.GetValue(int.Parse(cbCalc3A.Text), int.Parse(cbCalc3B.Text), tbCalc3Cadence.Value, tbCalc3L.Value);
                }
            }
        }

        // Калькулятор #4 "Касета"

        private void rbCalc4D_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCalc4D.Checked)
            {
                tbCalc4L.Enabled = false;
                tbCalc4L.Visible = false;
                lblCalc4L.Visible = false;
                cbCalc4L.Enabled = true;
                cbCalc4L.Visible = true;
            }
            else
            {
                tbCalc4L.Enabled = true;
                tbCalc4L.Visible = true;
                lblCalc4L.Visible = true;
                cbCalc4L.Enabled = false;
                cbCalc4L.Visible = false;
            }
            Calc4Update();
        }

        private void tbCalc4Speed_Scroll(object sender, EventArgs e)
        {
            lblCalc4Speed.Text = tbCalc4Speed.Value.ToString() + " км/год";
            Calc4Update();
        }

        private void tbCalc4L_Scroll(object sender, EventArgs e)
        {
            lblCalc4L.Text = tbCalc4L.Value.ToString() + " мм";
            Calc4Update();
        }

        private void cbCalc4L_SelectedIndexChanged(object sender, EventArgs e)
        {
            Calc4Update();
        }

        private void cbCalc4A_SelectedIndexChanged(object sender, EventArgs e)
        {
            Calc4Update();
        }

        private void tbCalc4Cadence_Scroll(object sender, EventArgs e)
        {
            lblCalc4Cadence.Text = tbCalc4Cadence.Value.ToString() + " об/хв";
            Calc4Update();
        }

        private void Calc4Update()
        {
            if ((cbCalc4L.SelectedIndex != -1) && (cbCalc4A.SelectedIndex != -1))
            {
                string value_b = "";
                if (rbCalc4D.Checked)
                {
                    pbCalc4.Image = Properties.Resources.wheel_d;
                    value_b = Calc4.GetValue(int.Parse(cbCalc4A.Text), tbCalc4Speed.Value, tbCalc4Cadence.Value, TireLength[cbCalc4L.SelectedIndex]);

                }
                else
                {
                    pbCalc4.Image = Properties.Resources.wheel_l;
                    value_b = Calc4.GetValue(int.Parse(cbCalc4A.Text), tbCalc4Speed.Value, tbCalc4Cadence.Value, tbCalc4L.Value);
                }
                if (value_b.Length > 25)
                {
                    lblCalc4Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 14);
                }
                else
                {
                    lblCalc4Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 22);
                }
                lblCalc4Value.Text = value_b;
            }
        }

        // Калькулятор #5 "Велокомп'ютер"

        private void cbCalc5L_SelectedIndexChanged(object sender, EventArgs e)
        {
            Calc5Update();
        }

        private void Calc5Update()
        {
            if (cbCalc5L.SelectedIndex != -1)
            {
                lblCalc5Value.Text = "Довжина кола колеса:\n" + (TireLength[cbCalc5L.SelectedIndex]).ToString() + " мм";
            }
        }

        private void llblCalc5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            llblCalc5.LinkVisited = true;
            System.Diagnostics.Process.Start("https://drive.google.com/open?id=1E0ymR-hGUBh2kr-ruo77w4zkaEc6xG20");
        }

        // Калькулятор #6 "Потужність"

        private void tbCalc6Speed_Scroll(object sender, EventArgs e)
        {
            lblCalc6Speed.Text = tbCalc6Speed.Value.ToString() + " км/год";
            Calc6Update();
        }

        private void tbCalc6Distance_Scroll(object sender, EventArgs e)
        {
            lblCalc6Distance.Text = tbCalc6Distance.Value.ToString() + " км";
            Calc6Update();
        }

        private void tbCalc6WeightBiker_Scroll(object sender, EventArgs e)
        {
            lblCalc6WeightBiker.Text = tbCalc6WeightBiker.Value.ToString() + " кг";
            Calc6Update();
        }

        private void tbCalc6WeightBike_Scroll(object sender, EventArgs e)
        {
            lblCalc6WeightBike.Text = tbCalc6WeightBike.Value.ToString() + " кг";
            Calc6Update();
        }

        private void cbCalc6TireType_SelectedIndexChanged(object sender, EventArgs e)
        {
            Calc6Update();
        }

        private void tbCalc6Gradient_Scroll(object sender, EventArgs e)
        {
            lblCalc6Gradient.Text = (0.1 * tbCalc6Gradient.Value).ToString() + " %";
            Calc6Update();
        }

        private void tbCalc6WindSpeed_Scroll(object sender, EventArgs e)
        {
            lblCalc6WindSpeed.Text = tbCalc6WindSpeed.Value.ToString() + " м/с";
            Calc6Update();
        }

        private void btnCalc6AirResistance_Click(object sender, EventArgs e)
        {
            fmAirResist AirResistance = new fmAirResist(tmp_AeroPosition, tmp_Temperature, tmp_Elevation);
            AirResistance.ShowDialog();
            tbCalc6AirResistance.Text = (0.5f * BikerArea[AirResistance.AeroPositionValue] * (1.293f - 0.00426f * AirResistance.TemperatureValue) * (float)Math.Exp((float)(-AirResistance.ElevationValue) / 7000f)).ToString();
            tmp_AeroPosition = AirResistance.AeroPositionValue;
            tmp_Temperature = AirResistance.TemperatureValue;
            tmp_Elevation = AirResistance.ElevationValue;
            AirResistance.Dispose();
            Calc6Update();
        }

        private void tbCalc6Efficiency_Scroll(object sender, EventArgs e)
        {
            lblCalc6Efficiency.Text = tbCalc6Efficiency.Value.ToString() + " %";
            Calc6Update();
        }

        private void rbCalc6Note1_CheckedChanged(object sender, EventArgs e)
        {
            Calc6NoteUpdate();
        }

        private void rbCalc6Note2_CheckedChanged(object sender, EventArgs e)
        {
            Calc6NoteUpdate();
        }

        private void rbCalc6Note3_CheckedChanged(object sender, EventArgs e)
        {
            Calc6NoteUpdate();
        }

        private void Calc6NoteUpdate()
        {
            if (rbCalc6Note1.Checked)
            {
                pbCalc6.Image = Properties.Resources.aerobar;
            }
            if (rbCalc6Note2.Checked)
            {
                pbCalc6.Image = Properties.Resources.efficiency;
            }
            if (rbCalc6Note3.Checked)
            {
                pbCalc6.Image = Properties.Resources.power_time;
            }
        }

        private void Calc6Update()
        {
            if (cbCalc6TireType.SelectedIndex != -1)
            {
                lblCalc6Power.Text = Calc6.GetPowerValue(tbCalc6WeightBiker.Value, tbCalc6WeightBike.Value, 0.1f * tbCalc6Gradient.Value, RollingResistance[cbCalc6TireType.SelectedIndex], tbCalc6Speed.Value, tbCalc6WindSpeed.Value, (float)Convert.ToDouble(tbCalc6AirResistance.Text), tbCalc6Efficiency.Value);
                lblCalc6TripTime.Text = Calc6.GetTripTimeValue(tbCalc6Distance.Value, tbCalc6Speed.Value);
                lblCalories.Text = Calc6.GetCaloriesValue(tbCalc6WeightBiker.Value, tbCalc6WeightBike.Value, 0.1f * tbCalc6Gradient.Value, RollingResistance[cbCalc6TireType.SelectedIndex], tbCalc6Speed.Value, tbCalc6WindSpeed.Value, (float)Convert.ToDouble(tbCalc6AirResistance.Text), tbCalc6Efficiency.Value, tbCalc6Distance.Value);
                lblWeightLoss.Text = Calc6.GetWeightLossValue(tbCalc6WeightBiker.Value, tbCalc6WeightBike.Value, 0.1f * tbCalc6Gradient.Value, RollingResistance[cbCalc6TireType.SelectedIndex], tbCalc6Speed.Value, tbCalc6WindSpeed.Value, (float)Convert.ToDouble(tbCalc6AirResistance.Text), tbCalc6Efficiency.Value, tbCalc6Distance.Value);
            }
        }
    }
}