﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace myBike
{
    public partial class fmSplash : Form
    {
        public fmSplash()
        {
            InitializeComponent();
        }

        private void tmSplash_Tick(object sender, EventArgs e)
        {
            tmSplash.Enabled = false;
        }
    }
}
