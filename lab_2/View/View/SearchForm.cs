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
            if (TextForSearchigMaskedTextBox.Text != "")
            {
                SearchDataGridView.Rows.Clear();
                if (StyleRadioButton.Checked == true) // поиск по стилю
                {
                    for (int i = 0; i < mainForm.motionList.Count; i++) // перебираем все объекты в списке на предмет свпадения стилей
                    {
                        if (TextForSearchigMaskedTextBox.Text == mainForm.motionList[i].Style) // при совпадении добавляем объект в таблицу
                        {
                            SearchDataGridView.Rows.Add(mainForm.motionList[i].Style, mainForm.motionList[i].StartCoordinate,
                            mainForm.motionList[i].StartSpeed, mainForm.motionList[i].Time, mainForm.motionList[i].CalcFinishCoordinate());
                        }
                    }
                }
                if (StartCoordinateRadioButton.Checked == true) // поиск по начальной координате
                {
                    for (int i = 0; i < mainForm.motionList.Count; i++) // перебираем все объекты в списке на предмет совпадения
                    {
                        if (TextForSearchigMaskedTextBox.Text == Convert.ToString(mainForm.motionList[i].StartCoordinate)) // при совпадении добавляем объект в таблицу
                        {
                            SearchDataGridView.Rows.Add(mainForm.motionList[i].Style, mainForm.motionList[i].StartCoordinate,
                            mainForm.motionList[i].StartSpeed, mainForm.motionList[i].Time, mainForm.motionList[i].CalcFinishCoordinate());
                        }
                    }
                }
                if (StartSpeedRadioButton.Checked == true) // поиск по начальной скорости
                {
                    for (int i = 0; i < mainForm.motionList.Count; i++) // перебираем все объекты в списке на предмет совпадения
                    {
                        if (TextForSearchigMaskedTextBox.Text == Convert.ToString(mainForm.motionList[i].StartSpeed)) // при совпадении добавляем объект в таблицу
                        {
                            SearchDataGridView.Rows.Add(mainForm.motionList[i].Style, mainForm.motionList[i].StartCoordinate,
                            mainForm.motionList[i].StartSpeed, mainForm.motionList[i].Time, mainForm.motionList[i].CalcFinishCoordinate());
                        }
                    }
                }
                if (MotionTimeRadioButton.Checked == true) // поиск по времени движения
                {
                    for (int i = 0; i < mainForm.motionList.Count; i++) // перебираем все объекты в списке на предмет совпадения
                    {
                        if (TextForSearchigMaskedTextBox.Text == Convert.ToString(mainForm.motionList[i].Time)) // при совпадении добавляем объект в таблицу
                        {
                            SearchDataGridView.Rows.Add(mainForm.motionList[i].Style, mainForm.motionList[i].StartCoordinate,
                            mainForm.motionList[i].StartSpeed, mainForm.motionList[i].Time, mainForm.motionList[i].CalcFinishCoordinate());
                        }
                    }
                }
                if (FinishCoordinateRadioButton.Checked == true) // поиск по конечной координате
                {
                    for (int i = 0; i < mainForm.motionList.Count; i++) // перебираем все объекты в списке на предмет совпадения
                    {
                        if (TextForSearchigMaskedTextBox.Text == Convert.ToString(mainForm.motionList[i].CalcFinishCoordinate())) // при совпадении добавляем объект в таблицу
                        {
                            SearchDataGridView.Rows.Add(mainForm.motionList[i].Style, mainForm.motionList[i].StartCoordinate,
                            mainForm.motionList[i].StartSpeed, mainForm.motionList[i].Time, mainForm.motionList[i].CalcFinishCoordinate());
                        }
                    }
                }
            }
            else MessageBox.Show("Searching text is absent");
        }
    }
}
