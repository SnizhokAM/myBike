// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.

// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
// GNU General Public License for more details.

// You should have received a copy of the GNU General Public License
// along with this program. If not, see <https://www.gnu.org/licenses/>.

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Xml;

namespace myBike
{
    public partial class FmMain : Form
    {
        public FmMain(FmSplash fmSplash)
        {
            InitializeComponent();
            fmSplash.Hide();
            fmSplash.Dispose();
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

        private void FmMain_Load(object sender, EventArgs e)
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
            cbCalc1TireType.Items.AddRange(TireType);
            cbCalc1TireType.SelectedIndex = 1;
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
            btnCalc1.ForeColor = SystemColors.ControlText;
            btnCalc2.ForeColor = SystemColors.ControlText;
            btnCalc3.ForeColor = SystemColors.ControlText;
            btnCalc4.ForeColor = SystemColors.ControlText;
            btnCalc5.ForeColor = SystemColors.ControlText;
            btnCalc6.ForeColor = SystemColors.ControlText;
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
            btnCalc6.ForeColor = SystemColors.ActiveCaptionText;
            SetDefPanelState();
            pnlCalc6.Enabled = true;
            pnlCalc6.Visible = true;
            if (rbMTB6.Checked) rbMTB6.Focus();
            if (rbRoad6.Checked) rbRoad6.Focus();
            if (rbTouring6.Checked) rbTouring6.Focus();
            if (rbBMX6.Checked) rbBMX6.Focus();
            if (rbChild6.Checked) rbChild6.Focus();
        }

        private void btnCalc2_Click(object sender, EventArgs e)
        {
            this.Text = "Велосипедний калькулятор - каденс";
            SetDefButtonColor();
            btnCalc2.ForeColor = SystemColors.ActiveCaptionText;
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
            btnCalc3.ForeColor = SystemColors.ActiveCaptionText;
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
            btnCalc4.ForeColor = SystemColors.ActiveCaptionText;
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
            btnCalc5.ForeColor = SystemColors.ActiveCaptionText;
            SetDefPanelState();
            pnlCalc5.Enabled = true;
            pnlCalc5.Visible = true;
            cbCalc5L.Focus();
        }

        private void btnCalc6_Click(object sender, EventArgs e)
        {
            this.Text = "Велосипедний калькулятор - подорож";
            SetDefButtonColor();
            btnCalc1.ForeColor = SystemColors.ActiveCaptionText;
            SetDefPanelState();
            pnlCalc1.Enabled = true;
            pnlCalc1.Visible = true;
            tbCalc1WeightBiker.Focus();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            btnAbout.ForeColor = SystemColors.ActiveCaptionText;
            FmAbout AboutProgram = new FmAbout();
            AboutProgram.ShowDialog();
            AboutProgram.Dispose();
            btnAbout.ForeColor = SystemColors.ControlText; ;
            if (pnlCalc6.Enabled) pnlCalc6.Focus();
            if (pnlCalc2.Enabled) pnlCalc2.Focus();
            if (pnlCalc3.Enabled) pnlCalc3.Focus();
            if (pnlCalc4.Enabled) pnlCalc4.Focus();
            if (pnlCalc5.Enabled) pnlCalc5.Focus();
            if (pnlCalc1.Enabled) pnlCalc1.Focus();
        }

        #region Калькулятор #1 "Потужність"

        private void tbCalc1Speed_Scroll(object sender, EventArgs e)
        {
            lblCalc1Speed.Text = tbCalc1Speed.Value.ToString() + " км/год";
            Calc1Update();
        }

        private void tbCalc1Distance_Scroll(object sender, EventArgs e)
        {
            lblCalc1Distance.Text = tbCalc1Distance.Value.ToString() + " км";
            Calc1Update();
        }

        private void tbCalc1WeightBiker_Scroll(object sender, EventArgs e)
        {
            lblCalc1WeightBiker.Text = tbCalc1WeightBiker.Value.ToString() + " кг";
            Calc1Update();
        }

        private void tbCalc1WeightBike_Scroll(object sender, EventArgs e)
        {
            lblCalc1WeightBike.Text = tbCalc1WeightBike.Value.ToString() + " кг";
            Calc1Update();
        }

        private void cbCalc1TireType_SelectedIndexChanged(object sender, EventArgs e)
        {
            Calc1Update();
        }

        private void tbCalc1Gradient_Scroll(object sender, EventArgs e)
        {
            lblCalc1Gradient.Text = (0.1 * tbCalc1Gradient.Value).ToString() + " %";
            Calc1Update();
        }

        private void tbCalc1WindSpeed_Scroll(object sender, EventArgs e)
        {
            lblCalc1WindSpeed.Text = tbCalc1WindSpeed.Value.ToString() + " м/с";
            Calc1Update();
        }

        private void btnCalc1AirResistance_Click(object sender, EventArgs e)
        {
            FmAirResist AirResistance = new FmAirResist(tmp_AeroPosition, tmp_Temperature, tmp_Elevation);
            AirResistance.ShowDialog();
            tbCalc1AirResistance.Text = (0.5f * BikerArea[AirResistance.AeroPositionValue] * (1.293f - 0.00426f * AirResistance.TemperatureValue) * (float)Math.Exp((float)(-AirResistance.ElevationValue) / 7000f)).ToString();
            tmp_AeroPosition = AirResistance.AeroPositionValue;
            tmp_Temperature = AirResistance.TemperatureValue;
            tmp_Elevation = AirResistance.ElevationValue;
            AirResistance.Dispose();
            Calc1Update();
        }

        private void tbCalc1Efficiency_Scroll(object sender, EventArgs e)
        {
            lblCalc1Efficiency.Text = tbCalc1Efficiency.Value.ToString() + " %";
            Calc1Update();
        }

        private void rbCalc1Note1_CheckedChanged(object sender, EventArgs e)
        {
            Calc1NoteUpdate();
        }

        private void rbCalc1Note2_CheckedChanged(object sender, EventArgs e)
        {
            Calc1NoteUpdate();
        }

        private void rbCalc1Note3_CheckedChanged(object sender, EventArgs e)
        {
            Calc1NoteUpdate();
        }

        private void Calc1NoteUpdate()
        {
            if (rbCalc1Note1.Checked)
            {
                pbCalc1.Image = Properties.Resources.aerobar;
            }
            if (rbCalc1Note2.Checked)
            {
                pbCalc1.Image = Properties.Resources.efficiency;
            }
            if (rbCalc1Note3.Checked)
            {
                pbCalc1.Image = Properties.Resources.power_time;
            }
        }

        private void Calc1Update()
        {
            if (cbCalc1TireType.SelectedIndex != -1)
            {
                lblCalc1Power.Text = Calc6.GetPowerValue(tbCalc1WeightBiker.Value, tbCalc1WeightBike.Value, 0.1f * tbCalc1Gradient.Value, RollingResistance[cbCalc1TireType.SelectedIndex], tbCalc1Speed.Value, tbCalc1WindSpeed.Value, (float)Convert.ToDouble(tbCalc1AirResistance.Text), tbCalc1Efficiency.Value);
                lblCalc1TripTime.Text = Calc6.GetTripTimeValue(tbCalc1Distance.Value, tbCalc1Speed.Value);
                lblCalc1Calories.Text = Calc6.GetCaloriesValue(tbCalc1WeightBiker.Value, tbCalc1WeightBike.Value, 0.1f * tbCalc1Gradient.Value, RollingResistance[cbCalc1TireType.SelectedIndex], tbCalc1Speed.Value, tbCalc1WindSpeed.Value, (float)Convert.ToDouble(tbCalc1AirResistance.Text), tbCalc1Efficiency.Value, tbCalc1Distance.Value);
                lblCalc1WeightLoss.Text = Calc6.GetWeightLossValue(tbCalc1WeightBiker.Value, tbCalc1WeightBike.Value, 0.1f * tbCalc1Gradient.Value, RollingResistance[cbCalc1TireType.SelectedIndex], tbCalc1Speed.Value, tbCalc1WindSpeed.Value, (float)Convert.ToDouble(tbCalc1AirResistance.Text), tbCalc1Efficiency.Value, tbCalc1Distance.Value);
            }
        }

        #endregion
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

        // Калькулятор #6 "Ростовка" 

        private void rbMTB6_CheckedChanged(object sender, EventArgs e)
        {
            Calc6Update();
        }

        private void rbRoad6_CheckedChanged(object sender, EventArgs e)
        {
            Calc6Update();
        }

        private void rbTouring6_CheckedChanged(object sender, EventArgs e)
        {
            Calc6Update();
        }

        private void rbBMX6_CheckedChanged(object sender, EventArgs e)
        {
            Calc6Update();
        }

        private void rbChild6_CheckedChanged(object sender, EventArgs e)
        {
            Calc6Update();
        }

        private void tbCalc6_Scroll(object sender, EventArgs e)
        {
            lblCalc6Height.Text = tbCalc6.Value.ToString() + " см";
            Calc6Update();
        }

        private void Calc6Update()
        {
            if (rbMTB6.Checked)
            {
                pbCalc6.Image = Properties.Resources.mtb;
                lblCalc6Value.Text = Calc1.GetValue(1, tbCalc6.Value);
                lblCalc6Note.Text = Calc1.GetNote(1);
            }
            if (rbRoad6.Checked)
            {
                pbCalc6.Image = Properties.Resources.road;
                lblCalc6Value.Text = Calc1.GetValue(2, tbCalc6.Value);
                lblCalc6Note.Text = Calc1.GetNote(2);
            }
            if (rbTouring6.Checked)
            {
                pbCalc6.Image = Properties.Resources.tour;
                lblCalc6Value.Text = Calc1.GetValue(3, tbCalc6.Value);
                lblCalc6Note.Text = Calc1.GetNote(3);
            }
            if (rbBMX6.Checked)
            {
                pbCalc6.Image = Properties.Resources.bmx;
                lblCalc6Value.Text = Calc1.GetValue(4, tbCalc6.Value);
                lblCalc6Note.Text = Calc1.GetNote(4);
            }
            if (rbChild6.Checked)
            {
                pbCalc6.Image = Properties.Resources.kids;
                lblCalc6Value.Text = Calc1.GetValue(5, tbCalc6.Value);
                lblCalc6Note.Text = Calc1.GetNote(5);
            }
        }     
    }
}