using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Drawing.Text;
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
                    defaultDataUserControl1.ReadOnly = true;
                    accelerationDataUserControl1.ReadOnly = true;
                    vibrationalDataUserControl1.ReadOnly = true;
                    uniformRadioButton.Enabled = false;
                    accelerationRadioButton.Enabled = false;
                    vibrationalRadioButton.Enabled = false; // запретить изменения радиобаттонов
                    readOnly = true; // преключить флаг
                }
                if (!value) // если только для чтения отключено
                {
                    defaultDataUserControl1.ReadOnly = false;
                    accelerationDataUserControl1.ReadOnly = false;
                    vibrationalDataUserControl1.ReadOnly = false;
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

        /// <summary>
        /// Метод возвращает true, если достаточные данные, и false если недостаточные
        /// </summary>
        /// <returns></returns>
        public bool IsFulness()
        {
            if (uniformRadioButton.Checked && Convert.ToString(defaultDataUserControl1.StartSpeed) != "" && Convert.ToString(defaultDataUserControl1.StartCoordinate) != "" &&
                Convert.ToString(defaultDataUserControl1.Time) != "")
                return true;
            if (accelerationRadioButton.Checked && Convert.ToString(defaultDataUserControl1.StartSpeed) != "" &&
                Convert.ToString(defaultDataUserControl1.StartCoordinate) != "" &&
                Convert.ToString(defaultDataUserControl1.Time) != "" && Convert.ToString(accelerationDataUserControl1.Acceleration) != "")
                return true;
            if (vibrationalRadioButton.Checked && Convert.ToString(defaultDataUserControl1.StartSpeed) != "" && Convert.ToString(defaultDataUserControl1.StartCoordinate) != "" &&
               Convert.ToString(defaultDataUserControl1.Time) != "" && Convert.ToString(vibrationalDataUserControl1.Amplitude) != "")
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
                    defaultDataUserControl1.StartCoordinate = Convert.ToString(value.StartCoordinate);
                    defaultDataUserControl1.StartSpeed = Convert.ToString(value.StartSpeed);
                    defaultDataUserControl1.Time = Convert.ToString(value.Time);
                    uniformRadioButton.Checked = true;
                    accelerationDataUserControl1.Visible = false;
                    vibrationalDataUserControl1.Visible = false;
                }
                if (value is Accelerated)
                {
                    defaultDataUserControl1.StartCoordinate = Convert.ToString(value.StartCoordinate);
                    defaultDataUserControl1.StartSpeed = Convert.ToString(value.StartSpeed);
                    defaultDataUserControl1.Time = Convert.ToString(value.Time);
                    accelerationDataUserControl1.Acceleration = Convert.ToString((value as Accelerated).Acceleration); 
                    accelerationRadioButton.Checked = true;
                    accelerationDataUserControl1.Visible = true;
                    vibrationalDataUserControl1.Visible = false;
                }
                if (value is Vibrational)
                {
                    defaultDataUserControl1.StartCoordinate = Convert.ToString(value.StartCoordinate);
                    defaultDataUserControl1.StartSpeed = Convert.ToString(value.StartSpeed);
                    defaultDataUserControl1.Time = Convert.ToString(value.Time);
                    vibrationalDataUserControl1.Amplitude = Convert.ToString((value as Vibrational).Amplitude);
                    vibrationalRadioButton.Checked = true;
                    accelerationDataUserControl1.Visible = false;
                    vibrationalDataUserControl1.Visible = true;     
                }
                if (value == null)
                {
                    uniformRadioButton.Checked = false;
                    accelerationRadioButton.Checked = false;
                    vibrationalRadioButton.Checked = false;
                }
            }
            get
            {
                if (uniformRadioButton.Checked)
                {
                    var uniform = new Uniform
                        (
                         Convert.ToInt32(defaultDataUserControl1.StartCoordinate),
                         Convert.ToInt32(defaultDataUserControl1.StartSpeed),
                         Convert.ToInt32(defaultDataUserControl1.Time)
                        );
                    return uniform;
                }
                if (accelerationRadioButton.Checked)
                {
                    var accelerated = new Accelerated
                        (
                         Convert.ToInt32(defaultDataUserControl1.StartCoordinate),
                         Convert.ToInt32(defaultDataUserControl1.StartSpeed),
                         Convert.ToInt32(defaultDataUserControl1.Time),
                         Convert.ToInt32(accelerationDataUserControl1.Acceleration)
                        );
                    return accelerated;
                }
                if (vibrationalRadioButton.Checked)
                {
                    var vibrational = new Vibrational
                        (
                        Convert.ToInt32(defaultDataUserControl1.StartCoordinate),
                        Convert.ToInt32(defaultDataUserControl1.StartSpeed),
                        Convert.ToInt32(defaultDataUserControl1.Time),
                        Convert.ToInt32(vibrationalDataUserControl1.Amplitude)
                        );
                    return vibrational;
                }
                return null;
            }
        }

        private void uniformRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (uniformRadioButton.Checked)
            {
                accelerationDataUserControl1.Visible = false;
                vibrationalDataUserControl1.Visible = false;      

            }
        }

        private void accelerationRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (accelerationRadioButton.Checked)
            {
                accelerationDataUserControl1.Visible = true;
                vibrationalDataUserControl1.Visible = false;
                accelerationDataUserControl1.Location = new Point(8, 205);
                vibrationalDataUserControl1.Location = new Point(8, 231);
            }
        }

        private void vibrationalRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (vibrationalRadioButton.Checked)
            {
                accelerationDataUserControl1.Visible = false;
                vibrationalDataUserControl1.Visible = true;
                vibrationalDataUserControl1.Location = new Point(8, 205);
                accelerationDataUserControl1.Location = new Point(8, 231);  
            }
        }
    }
}
 

