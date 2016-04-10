using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;

namespace View
{
    public partial class motionInfoUserControl : UserControl
    {
        public motionInfoUserControl()
        {
            InitializeComponent();
        }

        private void OnlyNumbers(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void startCoordinateTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyNumbers(sender, e);
        }

        private void startSpeedTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyNumbers(sender, e);
        }

        private void timeTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyNumbers(sender, e);
        }

        private void accelerationAmplitudeTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyNumbers(sender, e);
        }

        /// <summary>
        /// Флаг "Только для чтения"
        /// </summary>
        private bool readOnly; 

        /// <summary>
        /// Свойство "Только для чтения"
        /// </summary>
        public bool ReadOnly 
        {
            set
            {
                if (value) // если только для чтения
                {
                    foreach (Control control in Controls)
                    {
                        if (control is TextBox)
                            (control as TextBox).ReadOnly = true; // выбрать текстбоксы из всех контролов и присвоить им свойство только чтение
                    }
                    uniformRadioButton.Enabled = false;
                    accelerationRadioButton.Enabled = false;
                    vibrationalRadioButton.Enabled = false; // запретить изменения радиобаттонов
                    readOnly = true; // преключить флаг
                }
                if (!value) // если только для чтения отключено
                {
                    foreach (Control control in Controls)
                    {
                        if (control is TextBox)
                            (control as TextBox).ReadOnly = false;
                    }
                    uniformRadioButton.Enabled = true;
                    accelerationRadioButton.Enabled = true;
                    vibrationalRadioButton.Enabled = true;
                    readOnly = false;
                }
            }
            get
            {
                return readOnly;
            }
        }

        public bool IsFulness()
        {
            if (uniformRadioButton.Checked && startSpeedTextBox.Text != "" && startCoordinateTextBox.Text != "" &&
                timeTextBox.Text != "")
                return true;
            if ((accelerationRadioButton.Checked || vibrationalRadioButton.Checked) && startSpeedTextBox.Text != "" &&
                startCoordinateTextBox.Text != "" &&
                timeTextBox.Text != "" && accelerationAmplitudeLabel.Text != "")
                return true;
            return false;
        }

        /// <summary>
        /// Свойство хранящее обьект типа IMotion
        /// </summary>
        public IMotion Motion
        {
            set
            {
                if (value is Uniform)
                {
                    startCoordinateTextBox.Text = Convert.ToString(value.StartCoordinate);
                    startSpeedTextBox.Text = Convert.ToString(value.StartSpeed);
                    timeTextBox.Text = Convert.ToString(value.Time);
                    uniformRadioButton.Checked = true;
                    accelerationAmplitudeTextBox.Visible = false;
                    accelerationAmplitudeLabel.Visible = false;
                }
                if (value is Accelerated)
                {
                    startCoordinateTextBox.Text = Convert.ToString(value.StartCoordinate);
                    startSpeedTextBox.Text = Convert.ToString(value.StartSpeed);
                    timeTextBox.Text = Convert.ToString(value.Time);
                    accelerationAmplitudeTextBox.Text = Convert.ToString((value as Accelerated).Acceleration); // привести к базовому классу
                    accelerationRadioButton.Checked = true;
                    accelerationAmplitudeTextBox.Visible = true;
                    accelerationAmplitudeLabel.Visible = true;
                    accelerationAmplitudeLabel.Text = "Acceleration";
                }
                if (value is Vibrational)
                {
                    startCoordinateTextBox.Text = Convert.ToString(value.StartCoordinate);
                    startSpeedTextBox.Text = Convert.ToString(value.StartSpeed);
                    timeTextBox.Text = Convert.ToString(value.Time);
                    accelerationAmplitudeTextBox.Text = Convert.ToString((value as Vibrational).Amplitude);  // привести к базовуму классу
                    vibrationalRadioButton.Checked = true;
                    accelerationAmplitudeTextBox.Visible = true;
                    accelerationAmplitudeLabel.Visible = true;
                    accelerationAmplitudeLabel.Text = "Amplitude";
                }
                if (value == null)
                {
                    foreach (Control control in Controls)
                    {
                        if (control is TextBox)
                            (control as TextBox).Clear();
                    }
                    uniformRadioButton.Checked = false;
                    accelerationRadioButton.Checked = false;
                    vibrationalRadioButton.Checked = false;
                }
            }
            get
            {
                if (uniformRadioButton.Checked == true)
                {
                    var uniform = new Uniform
                        (
                        Convert.ToInt32(startCoordinateTextBox.Text),
                        Convert.ToInt32(startSpeedTextBox.Text),
                        Convert.ToInt32(timeTextBox.Text)
                        );
                    return uniform;
                }
                if (accelerationRadioButton.Checked == true)
                {
                    var accelerated = new Accelerated
                        (
                        Convert.ToInt32(startCoordinateTextBox.Text),
                        Convert.ToInt32(startSpeedTextBox.Text),
                        Convert.ToInt32(timeTextBox.Text),
                        Convert.ToInt32(accelerationAmplitudeTextBox.Text)
                        );
                    return accelerated;
                }
                if (vibrationalRadioButton.Checked == true)
                {
                    var vibrational = new Vibrational
                        (
                        Convert.ToInt32(startCoordinateTextBox.Text),
                        Convert.ToInt32(startSpeedTextBox.Text),
                        Convert.ToInt32(timeTextBox.Text),
                        Convert.ToInt32(accelerationAmplitudeTextBox.Text)
                        );
                    return vibrational;
                }
                return null;
            }
        }

        private void accelerationRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            accelerationAmplitudeLabel.Text = "Acceleration";
            accelerationAmplitudeLabel.Visible = true;
            accelerationAmplitudeTextBox.Visible = true;
        }

        private void vibrationalRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            accelerationAmplitudeLabel.Text = "Amplitude";
            accelerationAmplitudeLabel.Visible = true;
            accelerationAmplitudeTextBox.Visible = true;


        }

        private void uniformRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            accelerationAmplitudeLabel.Visible = false;
            accelerationAmplitudeTextBox.Visible = false;
        }
    }
}
 

