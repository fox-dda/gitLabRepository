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
    public partial class SearchForm : Form
    {
        public SearchForm()
        {
            InitializeComponent(); //  инициализация формы
        }

        /// <summary>
        /// Объявление родительской формы
        /// </summary>
        private MotionCalculatorForm mainForm { get { return this.Owner as MotionCalculatorForm; } }

        /// <summary>
        /// Нажатие на кнопку "Search"
        /// </summary>
        private void SearchButton_Click(object sender, EventArgs e)
        {
            if (StyleRadioButton.Checked == true) // поиск по стилю
            {
                for (int i = 0; i < mainForm.motionList.Count; i++) // перебираем все объекты в списке на предмет свпадения стилей
                {
                    if (TextForSearchigMaskedTextBox.Text == mainForm.motionList[i].style) // при совпадении добавляем объект в таблицу
                    {
                        SearchDataGridView.Rows.Add(mainForm.motionList[i].style, mainForm.motionList[i].startCoor,
                        mainForm.motionList[i].startSpeed, mainForm.motionList[i].time, mainForm.motionList[i].CalcFinishCoor());
                    }
                }
            }
            if (StartCoordinateRadioButton.Checked == true) // поиск по начальной координате
            {
                for (int i = 0; i < mainForm.motionList.Count; i++) // перебираем все объекты в списке на предмет совпадения
                {
                    if (TextForSearchigMaskedTextBox.Text == Convert.ToString(mainForm.motionList[i].startCoor)) // при совпадении добавляем объект в таблицу
                    {
                        SearchDataGridView.Rows.Add(mainForm.motionList[i].style, mainForm.motionList[i].startCoor,
                        mainForm.motionList[i].startSpeed, mainForm.motionList[i].time, mainForm.motionList[i].CalcFinishCoor());
                    }
                }
            }
            if (StartSpeedRadioButton.Checked == true) // поиск по начальной скорости
            {
                for (int i = 0; i < mainForm.motionList.Count; i++) // перебираем все объекты в списке на предмет совпадения
                {
                    if (TextForSearchigMaskedTextBox.Text == Convert.ToString(mainForm.motionList[i].startSpeed)) // при совпадении добавляем объект в таблицу
                    {
                        SearchDataGridView.Rows.Add(mainForm.motionList[i].style, mainForm.motionList[i].startCoor,
                        mainForm.motionList[i].startSpeed, mainForm.motionList[i].time, mainForm.motionList[i].CalcFinishCoor());
                    }
                }
            }
            if (MotionTimeRadioButton.Checked == true) // поиск по времени движения
            {
                for (int i = 0; i < mainForm.motionList.Count; i++) // перебираем все объекты в списке на предмет совпадения
                {
                    if (TextForSearchigMaskedTextBox.Text == Convert.ToString(mainForm.motionList[i].time)) // при совпадении добавляем объект в таблицу
                    {
                        SearchDataGridView.Rows.Add(mainForm.motionList[i].style, mainForm.motionList[i].startCoor,
                        mainForm.motionList[i].startSpeed, mainForm.motionList[i].time, mainForm.motionList[i].CalcFinishCoor());
                    }
                }
            }
            if (FinishCoordinateRadioButton.Checked == true) // поиск по конечной координате
            {
                for (int i = 0; i < mainForm.motionList.Count; i++) // перебираем все объекты в списке на предмет совпадения
                {
                    if (TextForSearchigMaskedTextBox.Text == Convert.ToString(mainForm.motionList[i].CalcFinishCoor())) // при совпадении добавляем объект в таблицу
                    {
                        SearchDataGridView.Rows.Add(mainForm.motionList[i].style, mainForm.motionList[i].startCoor,
                        mainForm.motionList[i].startSpeed, mainForm.motionList[i].time, mainForm.motionList[i].CalcFinishCoor());
                    }
                }
            }
        }
    }
}
