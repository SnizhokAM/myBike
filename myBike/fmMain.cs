using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

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

        private void fmMain_Load(object sender, EventArgs e)
        {

            Calc1 = new CalcSize();
            Calc2 = new CalcCadence();

        }

        private void btnAbout_Click(object sender, EventArgs e)
        {

        }

        private void tbCalc1_Scroll(object sender, EventArgs e)
        {
            lblCalc1Height.Text = tbCalc1.Value.ToString() + " см";
            Calc1Update();
        }

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

        private void btnCalc1_Click(object sender, EventArgs e)
        {

        }

        private void TbCalc2_Scroll(object sender, EventArgs e)
        {
            lblCalc2Speed.Text = tbCalc2.Value.ToString() + " км/год";
            Calc2Update();
        }

        private void Calc2Update()
        {
            if ((cbCalc2A.SelectedIndex != -1) && (cbCalc2B.SelectedIndex != -1))
            {
                lblCalc2Value.Text = Calc2.GetValue(int.Parse(cbCalc2A.Text), int.Parse(cbCalc2B.Text), tbCalc2.Value, 1200);
            }
        }

        private void BtnCalc2_Click(object sender, EventArgs e)
        {
            cbCalc2A.SelectedIndex = 0;
            cbCalc2B.SelectedIndex = 0;
        }

        private void CbCalc2A_SelectedIndexChanged(object sender, EventArgs e)
        {
            Calc2Update();
        }

        private void CbCalc2B_SelectedIndexChanged(object sender, EventArgs e)
        {
            Calc2Update();
        }

        private void TbCalc2L_TextChanged(object sender, EventArgs e)
        {
            Calc2Update();
        }

        private void TbCalc2L_Scroll(object sender, EventArgs e)
        {
            lblCalc2L.Text = tbCalc2L.Value.ToString() + " мм";
        }
    }
}
