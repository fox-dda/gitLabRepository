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
    public partial class DefaultDataUserControl : UserControl
    {
        public DefaultDataUserControl()
        {
            InitializeComponent();
        }

        public string StartSpeed
        {
            get
            {
              //  if (startSpeedTextBox.Text != "")
                return startSpeedTextBox.Text;
            //    return null;
            }
            set
            {
                startSpeedTextBox.Text = Convert.ToString(value);
            }
        }
        public string StartCoordinate
        {
            get
            {
                return startCoordinateTextBox.Text;
            }
            set
            {
                startCoordinateTextBox.Text = Convert.ToString(value);
            }
        }
        public string Time
        {
            get
            {
                return timeTextBox.Text;
            }
            set
            {
                timeTextBox.Text = Convert.ToString(value);
            }
        }

        private void startCoordinateTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (startCoordinateTextBox.Text.Length > 4)
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
            OnlyNumbers(sender, e);
        }

        private void startSpeedTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (startSpeedTextBox.Text.Length > 4)
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
            OnlyNumbers(sender, e);
        }

        private void timeTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (timeTextBox.Text.Length > 4)
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
            OnlyNumbers(sender, e);
        }
        private void OnlyNumbers(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && e.KeyChar != 8)
                e.Handled = true;
        }

        private bool readOnly = true;

        public bool ReadOnly
        {
            get { return readOnly; }
            set
            {
                readOnly = value;
                if (readOnly)
                {
                    startCoordinateTextBox.ReadOnly = true;
                    startSpeedTextBox.ReadOnly = true;
                    timeTextBox.ReadOnly = true;
                }
                else
                {
                    startCoordinateTextBox.ReadOnly = false;
                    startSpeedTextBox.ReadOnly = false;
                    timeTextBox.ReadOnly = false;
                }
            }
        }
    }
}
