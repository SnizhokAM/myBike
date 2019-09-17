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
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace myBike
{
    public partial class fmAirResist : Form
    {
        public fmAirResist(int aeroposition, int temperature, int elevation)
        {
            InitializeComponent();
            string[] AeroPosition = {"Пряма", "Незначний нахил", "Гібридна", "Шосейна", "Аеродинамічна"};
            cbAeroPosition.Items.AddRange(AeroPosition);
            cbAeroPosition.SelectedIndex = aeroposition;
            tbTemperature.Value = temperature;
            lblTemperature.Text = temperature.ToString() + " °C";
            tbElevation.Value = elevation;
            lblElevation.Text = elevation.ToString() + " м";
        }

        public int AeroPositionValue
        {
            get
            {
                return cbAeroPosition.SelectedIndex;
            }
        }

        public int TemperatureValue
        {
            get
            {
                return tbTemperature.Value;
            }
        }

        public int ElevationValue
        {
            get
            {
                return tbElevation.Value;
            }
        }

        private void tbTemperature_Scroll(object sender, EventArgs e)
        {
            lblTemperature.Text = tbTemperature.Value.ToString() + " °C";
        }

        private void tbElevation_Scroll(object sender, EventArgs e)
        {
            lblElevation.Text = tbElevation.Value.ToString() + " м";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}