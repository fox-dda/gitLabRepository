using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;

namespace View
{
    public partial class AddOrModifyMotionForm : Form
    {
        public AddOrModifyMotionForm()
        {
            InitializeComponent(); // инициализация формы
            motionInfoControl.Show();
            motionInfoControl.Location = new Point(10, 15);
            Controls.Add(motionInfoControl);
            motionInfoControl.Anchor = (AnchorStyles.Right | AnchorStyles.Top);
            //  motionInfoControl.Click += (s, e) => MessageBox.Show("He's Alive");
            motionInfoControl.ReadOnly = false;
        }

        public motionInfoUserControl motionInfoControl = new motionInfoUserControl();

        /// <summary>
        /// Объявление родительской формы как свойства дочерней 
        /// </summary>
        private MotionCalculatorForm mainForm
        {
            get { return this.Owner as MotionCalculatorForm; }
        }

        /// <summary>
        ///  Загрузка формы
        /// </summary>
        private void addMotion_Load(object sender, EventArgs e)
        {
            if (mainForm.modifyItemFlag != -1)
                // если при загрузке формы флаг редактирования не равен значению -1, то форма переходи в режим Modify, если нет, то режим Add
            {
                this.Text = "Modify motion"; // в режимы Modify форма называется "Modify motion"
                this.AddButton.Text = "Modify"; // текст кнопки "Modify"
                motionInfoControl.Motion = mainForm.motionList[mainForm.modifyItemFlag];
            }
        }

        /// <summary>
        /// Метод для оприделения все ли данные введены для добавления или редактикорования объекта
        /// </summary>
        //private void CheckDataComplitness()
        //{
        //    if (UniformRadioButton.Checked == true)
        //    {
        //        if (StartCoordinateMaskedTextBox.Text == "" || StartSpeedMaskedTextBox.Text == "" || MotionTimeMaskedTextBox.Text == "")
        //        {
        //            AddButton.Enabled = false; //если данных не достаточно то кнопка добавления не активна
        //        }
        //        else AddButton.Enabled = true;  // кнопка добавления иначе активна
        //    }
        //    if (AccelerationRadioButton.Checked == true)
        //    {
        //        if (StartCoordinateMaskedTextBox.Text == "" || StartSpeedMaskedTextBox.Text == "" || MotionTimeMaskedTextBox.Text == "" || AccelerationMaskedTextBox.Text == "")
        //        {
        //            AddButton.Enabled = false;
        //        }
        //        else AddButton.Enabled = true; 
        //    }
        //        if (VibrationalRadioButton.Checked == true)
        //        {
        //            if (StartCoordinateMaskedTextBox.Text == "" || StartSpeedMaskedTextBox.Text == "" || MotionTimeMaskedTextBox.Text == "" || AmplitudeMaskedTextBox.Text == "")
        //            {
        //                AddButton.Enabled = false;
        //            }
        //            else AddButton.Enabled = true;
        //        }
        //    }

        /// <summary>
        /// Локальная переменная для определения типа движения в связи выбором пользователя переключателя
        /// </summary>
        private byte _style;

        /// <summary>
        /// Нажатие по кнопке "Add"
        /// </summary>
        private void AddButton_Click(object sender, EventArgs e)
        {
            if (!motionInfoControl.IsFulness()) //если неполные данные вывести сообщение 
            {
                MessageBox.Show("Incomplete data");
                return;
            }
            if (mainForm.modifyItemFlag == -1) // если форма открыта в режиме Add, то добавить объект
                mainForm.motionList.Add(motionInfoControl.Motion);
            if (mainForm.modifyItemFlag != -1)
                // если форма открыта в режиме Modify,  то изменить выбранный ранее объект
            {
                mainForm.motionList[mainForm.modifyItemFlag] = motionInfoControl.Motion;
                mainForm.modifyItemFlag = -1;
            }
            this.Close(); // закрыть окно
        }

        ///// <summary>
        ///// Алгоритм если выбрано равномерное движения
        ///// </summary>
        //private void UniformCheckBox_CheckedChanged(object sender, EventArgs e)
        //{
        //    _style = 0; // uniform
        //    AccelerationMaskedTextBox.Text = "";
        //    AmplitudeMaskedTextBox.Text = "";
        //    AccelerationMaskedTextBox.Visible = false;
        //    AccelerationLabel.Visible = false;
        //    AmplitudeMaskedTextBox.Visible = false;
        //    AmplitudeLabel.Visible = false;
        //}

        ///// <summary>
        ///// Если выбрано равноускоренное движение
        ///// </summary>
        //private void AcceleratedRadioButton_CheckedChanged(object sender, EventArgs e)
        //{
        //    _style = 1;// accelerated
        //    AccelerationMaskedTextBox.Visible = true;
        //    AccelerationLabel.Visible = true;
        //    AmplitudeMaskedTextBox.Text = "";
        //    AmplitudeMaskedTextBox.Visible = false;
        //    AmplitudeLabel.Visible = false;
        //}

        ///// <summary>
        ///// Если выбранно колебательное движение
        ///// </summary>
        //private void VabrationalRadioButton_CheckedChanged(object sender, EventArgs e)
        //{
        //    _style = 2;// vibration
        //    AccelerationMaskedTextBox.Text = "";
        //    AccelerationMaskedTextBox.Visible = false;
        //    AccelerationLabel.Visible = false;
        //    AmplitudeMaskedTextBox.Visible = true;
        //    AmplitudeLabel.Visible = true;
        //    }

        /// <summary>
        /// Нажатие по кнопке "Close"
        /// </summary>
        private void CloseButton_Click(object sender, EventArgs e)
        {
            mainForm.modifyItemFlag = -1;
            this.Close(); // закрыть окно
        }
        //    //проверка на полноту данных для добавления или изменения объекта
        //    private void StartCoordinateMaskedTextBox_TextChanged(object sender, EventArgs e)
        //    {
        //        CheckDataComplitness();
        //    }

        //    private void StartSpeedMaskedTextBox_TextChanged(object sender, EventArgs e)
        //    {
        //        CheckDataComplitness();
        //    }

        //    private void MotionTimeMaskedTextBox_TextChanged(object sender, EventArgs e)
        //    {
        //        CheckDataComplitness();
        //    }

        //    private void AccelerationMaskedTextBox_TextChanged(object sender, EventArgs e)
        //    {
        //        CheckDataComplitness();
        //    }

        //    private void AmplitudeMaskedTextBox_TextChanged(object sender, EventArgs e)
        //    {
        //        CheckDataComplitness();
        //    }
        //}
    }
}
