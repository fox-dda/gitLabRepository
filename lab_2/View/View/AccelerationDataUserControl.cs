using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
    public partial class AccelerationDataUserControl : UserControl
    {
        public AccelerationDataUserControl()
        {
            InitializeComponent();
        }

        private void accelerationAmplitudeTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (accelerationTextBox.Text.Length > 4)
            {
                e.Handled = true;
                if (e.KeyChar == 8)
                {
                    e.Handled = false;
                    return;
                }
                MessageBox.Show("Too much importance");
                return;
            }
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && e.KeyChar != 8)
                e.Handled = true;
        }

        bool visible;

        public bool Visible
        {
            get { return visible; }
            set
            {
                visible = value;
                accelerationTextBox.Visible = visible;
                accelerationLabel.Visible = visible;
            }
        }
        public string Acceleration
        {
            get
            {
                return accelerationTextBox.Text;
            }
            set
            {
                accelerationTextBox.Text = Convert.ToString(value);
            }
        }

        private bool readOnly = true;

        public bool ReadOnly
        {
            get { return readOnly; }
            set
            {
                readOnly = value;
                if (readOnly)
                    accelerationTextBox.ReadOnly = true;
                else
                    accelerationTextBox.ReadOnly = false;
            }
        }
    }
}
