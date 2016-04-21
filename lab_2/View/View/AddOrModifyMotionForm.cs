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
        public IMotion Motion
        {
            get
            {
                return motionInfoUserControlCreate.Motion;
            }
            set
            {
                motionInfoUserControlCreate.Motion = value;
                if (Motion != null)
                {
                    this.Text = "Modify motion"; // в режимы Modify форма называется "Modify motion"
                    this.AddButton.Text = "Modify"; // текст кнопки "Modify"
                }
            }
        }

        public AddOrModifyMotionForm()
        {
            InitializeComponent(); // инициализация формы
        }

        /// <summary>
        /// Нажатие по кнопке "Add"
        /// </summary>
        private void AddButton_Click(object sender, EventArgs e)
        {
            if (!motionInfoUserControlCreate.IsFulness()) //если неполные данные вывести сообщение 
            {
                MessageBox.Show("Incomplete data");
                return;
            }
            this.Close(); // закрыть окно
        }
    
        private void CloseButton_Click(object sender, EventArgs e)
        {
            Motion = null;
            this.Close(); // закрыть окно
        }
        
    }
}
