using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
    public partial class AddOrModifyMotionForm : Form
    {
        public AddOrModifyMotionForm()
        {
            InitializeComponent(); // инициализация формы
        }

        /// <summary>
        /// Объявление родительской формы как свойства дочерней 
        /// </summary>
        private MotionCalculatorForm mainForm
        { 
            get 
            { 
                return this.Owner as MotionCalculatorForm;
            } 
        }

        /// <summary>
        ///  Загрузка формы
        /// </summary>
        private void addMotion_Load(object sender, EventArgs e)
        {   
            if (mainForm.modifyItemFlag != -1) // если при загрузке формы флаг редактирования не равен значению -1, то форма переходи в режим Modify, если нет, то режим Add
            {
                this.Text = "Modify motion"; // в режимы Modify форма называется "Modify motion"
                this.AddButton.Text = "Modify"; // текст кнопки "Modify"
                if (mainForm.motionList[mainForm.modifyItemFlag] is Model.Uniform)
                {
                    UniformRadioButton.Checked = true;
                    StartCoordinateMaskedTextBox.Text = Convert.ToString(mainForm.motionList[mainForm.modifyItemFlag].StartCoordinate);
                    StartSpeedMaskedTextBox.Text = Convert.ToString(mainForm.motionList[mainForm.modifyItemFlag].StartSpeed);
                    MotionTimeMaskedTextBox.Text = Convert.ToString(mainForm.motionList[mainForm.modifyItemFlag].Time);
                }
                if (mainForm.motionList[mainForm.modifyItemFlag] is Model.Accelerated)
                {
                    AccelerationRadioButton.Checked = true;
                    StartCoordinateMaskedTextBox.Text = Convert.ToString(mainForm.motionList[mainForm.modifyItemFlag].StartCoordinate);
                    StartSpeedMaskedTextBox.Text = Convert.ToString(mainForm.motionList[mainForm.modifyItemFlag].StartSpeed);
                    MotionTimeMaskedTextBox.Text = Convert.ToString(mainForm.motionList[mainForm.modifyItemFlag].Time);
                    if (mainForm.motionList[mainForm.modifyItemFlag].Time != 0)
                        AccelerationMaskedTextBox.Text = Convert.ToString(2 * (mainForm.motionList[mainForm.modifyItemFlag].CalcFinishCoordinate() - mainForm.motionList[mainForm.modifyItemFlag].StartCoordinate) / (mainForm.motionList[mainForm.modifyItemFlag].Time * mainForm.motionList[mainForm.modifyItemFlag].Time));
                    else
                        AccelerationMaskedTextBox.Text = "0";
                }
                if (mainForm.motionList[mainForm.modifyItemFlag] is Model.Vibrational)
                {
                    VibrationalRadioButton.Checked = true;
                    StartCoordinateMaskedTextBox.Text = Convert.ToString(mainForm.motionList[mainForm.modifyItemFlag].StartCoordinate);
                    StartSpeedMaskedTextBox.Text = Convert.ToString(mainForm.motionList[mainForm.modifyItemFlag].StartSpeed);
                    MotionTimeMaskedTextBox.Text = Convert.ToString(mainForm.motionList[mainForm.modifyItemFlag].Time);
                    AmplitudeMaskedTextBox.Text = Convert.ToString((mainForm.motionList[mainForm.modifyItemFlag].Time * mainForm.motionList[mainForm.modifyItemFlag].StartSpeed) / (mainForm.motionList[mainForm.modifyItemFlag].CalcFinishCoordinate() - mainForm.motionList[mainForm.modifyItemFlag].StartCoordinate + 1));
                }
            }
        }

        /// <summary>
        /// Метод для оприделения все ли данные введены для добавления или редактикорования объекта
        /// </summary>
        private void CheckDataComplitness()
        {
            if (UniformRadioButton.Checked == true)
            {
                if (StartCoordinateMaskedTextBox.Text == "" || StartSpeedMaskedTextBox.Text == "" || MotionTimeMaskedTextBox.Text == "")
                {
                    AddButton.Enabled = false; //если данных не достаточно то кнопка добавления не активна
                }
                else AddButton.Enabled = true;  // кнопка добавления иначе активна
            }
            if (AccelerationRadioButton.Checked == true)
            {
                if (StartCoordinateMaskedTextBox.Text == "" || StartSpeedMaskedTextBox.Text == "" || MotionTimeMaskedTextBox.Text == "" || AccelerationMaskedTextBox.Text == "")
                {
                    AddButton.Enabled = false;
                }
                else AddButton.Enabled = true; 
            }
                if (VibrationalRadioButton.Checked == true)
                {
                    if (StartCoordinateMaskedTextBox.Text == "" || StartSpeedMaskedTextBox.Text == "" || MotionTimeMaskedTextBox.Text == "" || AmplitudeMaskedTextBox.Text == "")
                    {
                        AddButton.Enabled = false;
                    }
                    else AddButton.Enabled = true;
                }
            }

        /// <summary>
        /// Локальная переменная для определения типа движения в связи выбором пользователя переключателя
        /// </summary>
        private byte _style;

        /// <summary>
        /// Нажатие по кнопке "Add"
        /// </summary>
        private void AddButton_Click(object sender, EventArgs e)
        {
            
            Model.IMotion motionModel = null; // создание локльной перменной интерфейса
            switch (_style) //  в зависимости от стиля создаем разные объекты
            {
                case 0:  // равноммерное движение
                    motionModel = new Model.Uniform(Convert.ToInt32(StartCoordinateMaskedTextBox.Text), Convert.ToInt32(StartSpeedMaskedTextBox.Text), Convert.ToInt32(MotionTimeMaskedTextBox.Text));
                    break;
                case 1:  // равноускоренное
                    motionModel = new Model.Accelerated(Convert.ToInt32(StartCoordinateMaskedTextBox.Text), Convert.ToInt32(StartSpeedMaskedTextBox.Text), Convert.ToInt32(MotionTimeMaskedTextBox.Text), Convert.ToInt32(AccelerationMaskedTextBox.Text));
                    break;
                case 2:  // колебательное
                    motionModel = new Model.Vibrational(Convert.ToInt32(StartCoordinateMaskedTextBox.Text), Convert.ToInt32(StartSpeedMaskedTextBox.Text), Convert.ToInt32(MotionTimeMaskedTextBox.Text), Convert.ToInt32(AmplitudeMaskedTextBox.Text));
                    if (Convert.ToInt32(AmplitudeMaskedTextBox.Text) == 0)
                    {
                        MessageBox.Show("Amplitude can not be zero");
                        AmplitudeMaskedTextBox.Text = "";
                        return;
                    }
            break;
            }
            if (mainForm.modifyItemFlag == -1) // если форма открыта в режиме Add, то добавить объект
                mainForm.motionList.Add(motionModel);
            if (mainForm.modifyItemFlag != -1)// если форма открыта в режиме Modify,  то изменить выбранный ранее объект
            {
                mainForm.motionList[mainForm.modifyItemFlag] = motionModel;
                mainForm.modifyItemFlag = -1; 
            }
            this.Close(); // закрыть окно
        }

        /// <summary>
        /// Алгоритм если выбрано равномерное движения
        /// </summary>
        private void UniformCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            _style = 0; // uniform
            AccelerationMaskedTextBox.Text = "";
            AmplitudeMaskedTextBox.Text = "";
            AccelerationMaskedTextBox.Visible = false;
            AccelerationLabel.Visible = false;
            AmplitudeMaskedTextBox.Visible = false;
            AmplitudeLabel.Visible = false;
        }

        /// <summary>
        /// Если выбрано равноускоренное движение
        /// </summary>
        private void AcceleratedRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            _style = 1;// accelerated
            AccelerationMaskedTextBox.Visible = true;
            AccelerationLabel.Visible = true;
            AmplitudeMaskedTextBox.Text = "";
            AmplitudeMaskedTextBox.Visible = false;
            AmplitudeLabel.Visible = false;
        }

        /// <summary>
        /// Если выбранно колебательное движение
        /// </summary>
        private void VabrationalRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            _style = 2;// vibration
            AccelerationMaskedTextBox.Text = "";
            AccelerationMaskedTextBox.Visible = false;
            AccelerationLabel.Visible = false;
            AmplitudeMaskedTextBox.Visible = true;
            AmplitudeLabel.Visible = true;
        }

        /// <summary>
        /// Нажатие по кнопке "Close"
        /// </summary>
        private void CloseButton_Click(object sender, EventArgs e)
        {
           mainForm.modifyItemFlag = -1;
           this.Close();
        }
        //проверка на полноту данных для добавления или изменения объекта
        private void StartCoordinateMaskedTextBox_TextChanged(object sender, EventArgs e)
        {
            CheckDataComplitness();
        }

        private void StartSpeedMaskedTextBox_TextChanged(object sender, EventArgs e)
        {
            CheckDataComplitness();
        }

        private void MotionTimeMaskedTextBox_TextChanged(object sender, EventArgs e)
        {
            CheckDataComplitness();
        }
         
        private void AccelerationMaskedTextBox_TextChanged(object sender, EventArgs e)
        {
            CheckDataComplitness();
        }

        private void AmplitudeMaskedTextBox_TextChanged(object sender, EventArgs e)
        {
            CheckDataComplitness();
        }
    }
}
