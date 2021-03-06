﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft;
using Newtonsoft.Json;


namespace View
{
    /// <summary>
    /// Главная форма калькулятора
    /// </summary>
    public partial class MotionCalculatorForm : Form
    {
        /// <summary>
        /// Конструктор формы
        /// </summary>
        public MotionCalculatorForm()
        {
            InitializeComponent(); 
            #if !DEBUG // если открыто не в дебаге
            CreateRandomDataButton.Visible = false; // сделать кнопку генерации объектов со случайными данными невидимой, т.е. недоступной пользователю
            #endif // конец условия препроцессора
            foreach (DataGridViewColumn column in MotionDataGridView.Columns) // запретить сортировку по столбцам столбцов
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }

        /// <summary>
        /// Список объектов движения
        /// </summary>
        public List<Model.IMotion> motionList = new List<Model.IMotion>();

        /// <summary>
        /// Переменная для храниения выбранной строки в таблице 
        /// </summary>
        private int selectedRowIndex;

        /// <summary>
        /// Нажатие на кнопку "Remove motion"
        /// </summary>
        private void RemoveMotionButton_Click(object sender, EventArgs e)
        {
            if (MotionDataGridView.SelectedRows.Count != 0)
            {
                selectedRowIndex = MotionDataGridView.SelectedRows[0].Index; // запоминаем выбранную строку т.к. после вызова диалогового окна выбранная строка "слетает"
            }

                if (MotionDataGridView.Rows.Count != 0) // если таблица не пуста 
                {
                    DialogResult result = MessageBox.Show("Remove the row and item?", "Remove", MessageBoxButtons.YesNo, MessageBoxIcon.Question); // вывести сообщение с вопросом: действительно ли пользователь хочет удалить запись
                    if (result == DialogResult.Yes) // если пользователь отвечает да 
                    {
                        motionList.RemoveAt(selectedRowIndex);             // удалить объект из списка по индексу выделенной в таблице строки
                        MotionDataGridView.Rows.RemoveAt(selectedRowIndex);     // удалить выденную строку из таблицы     
                    }
                }
            else MessageBox.Show("Table is empty!"); // если выбрана пустая строка
        }

        /// <summary>
        /// Нажатие по кнопке "Add motion"
        /// </summary>
        private void AddMotionButton_Click(object sender, EventArgs e)
        {
            var addMotion = new AddOrModifyMotionForm();// инициализовать форму для добавление объекта в список и таблицу
            addMotion.Owner = this; // указываем родителя формы
            addMotion.ShowDialog(); // открыть форму addMotion поверх MotionCalculator
            if (addMotion.Motion != null)
            {
                motionList.Add(addMotion.Motion);
                MessageBox.Show("Motion added");
            }
        }

        /// <summary>
        /// Метод для перерисовки таблицы при активации формы MotionCalculation
        /// </summary>
        private void MotionCalculator_Activated(object sender, EventArgs e)
        {
            {
                if (motionList.Count != 0) // если список объектов не пуст
                {
                    MotionDataGridView.Rows.Clear(); // очистить таблицу
                    for (int i = 0; i < motionList.Count; i++) // перебираем все объекты из списка и добавляем в таблицу
                    {
                        MotionDataGridView.Rows.Add(motionList[i].Style, motionList[i].StartCoordinate,
                        motionList[i].StartSpeed, motionList[i].Time, motionList[i].CalcFinishCoordinate());
                    }
                }
            }
        }

        /// <summary>
        /// Нажание по кнопке "Create random data"
        /// </summary>
        private void CreateRandomDataButton_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();  // инициализация объекта класса Random
           /// <summary>
           /// Переменная для генерации рандомного типа движения
           /// <summary>
            int style;
            for (int i = 0; i < 10; i++) // генерируем 10 обЪектов со случайными данными
            {
                style = rnd.Next(0, 3);
                Model.IMotion motionModel = null;
                switch (style)
                {
                    case 0:  // если равномерное движение
                        motionModel = new Model.Uniform(rnd.Next(0, 100), rnd.Next(0, 100), rnd.Next(1, 15));
                        break;
                    case 1: // если равноускоренное
                        motionModel = new Model.Accelerated(rnd.Next(0, 100), rnd.Next(0, 100), rnd.Next(1, 15), rnd.Next(0, 10));
                        break;
                    case 2: // если колебательно движение
                        motionModel = new Model.Vibrational(rnd.Next(0, 100), rnd.Next(0, 100), rnd.Next(1, 15), rnd.Next(1, 100));
                        break;
                }
                motionList.Add(motionModel); // добавить сгенерированный объект в список объектов
            }
            MessageBox.Show("Data is successfully generated!"); //  вывести сообщение
        }

        /// <summary>
        /// Нажание по кнопке Modify
        /// </summary>
        private void ModifyButton_Click(object sender, EventArgs e)
        {
            if (MotionDataGridView.SelectedRows.Count != 0)
            {
                selectedRowIndex = MotionDataGridView.SelectedRows[0].Index;
                var modifyMotion = new AddOrModifyMotionForm();// инициализовать форму для добавление объекта в список и таблицу
                modifyMotion.Owner = this; // указываем родителя формы
                modifyMotion.Motion = motionList[selectedRowIndex]; //передаем объект для редактикования
                modifyMotion.ShowDialog(); // открыть окно поверх MotionCalculator
                if (modifyMotion.Motion != null)
                {
                    motionList[selectedRowIndex] = modifyMotion.Motion;
                    MessageBox.Show("Motion was changed");
                }
            }
            else MessageBox.Show("Table is empty");
        }

        /// <summary>
        /// Нажатие на кнопу в меню "New" в меню
        /// </summary>
        private void NewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Current data will be lost. Сontinue?", "New", MessageBoxButtons.YesNo, MessageBoxIcon.Question); // выводим сообщение с вопросом
            if (result == DialogResult.Yes) // если пользователь отвечает да 
            {
               // motionInfoControl.Motion = null;
                motionList.Clear();             // очистить список объектов
                MotionDataGridView.Rows.Clear();     // очистить таблицу    
            }
        }

        /// <summary>
        /// Нажатие по кнопке "Search"
        /// </summary>
        private void SearchButton_Click(object sender, EventArgs e)
        {
            var SearchMotion = new SearchForm();// инициализовать форму для поиска объекта в таблице
            SearchMotion.Owner = this; // указываем родителя формы
            SearchMotion.ShowDialog(); // открыть форму Search поверх MotionCalculator
        }

        /// <summary>
        /// Нажатие по кнопке "Save"
        /// </summary>
        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var serializer = new JsonSerializer()
            {
                NullValueHandling = NullValueHandling.Ignore,
                TypeNameHandling = TypeNameHandling.Auto,
                Formatting = Formatting.Indented,
                DefaultValueHandling = DefaultValueHandling.Ignore
            };
            var saveFileDialog = new SaveFileDialog();
            var fileName = saveFileDialog.FileName;
            saveFileDialog.Filter = "Motion | *.motion";
            saveFileDialog.OverwritePrompt = true;          
            if (saveFileDialog.ShowDialog() == DialogResult.Cancel)
            return; 
            string outputString = JsonConvert.SerializeObject(motionList);
            using (StreamWriter streamWriter = new StreamWriter(saveFileDialog.FileName))
            {
                using (JsonWriter jWriter = new JsonTextWriter(streamWriter))
                {
                    serializer.Serialize(jWriter, motionList);
                }
            }           
            MessageBox.Show("File is saved");
        }

        /// <summary>
        /// Нажатие по клавише "Load" в главном меню
        /// </summary>
        private void LoadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            {
                var serializer = new Newtonsoft.Json.JsonSerializer()
                {
                NullValueHandling = NullValueHandling.Ignore,
                TypeNameHandling = TypeNameHandling.Auto,
                Formatting = Formatting.Indented,
                DefaultValueHandling = DefaultValueHandling.Ignore
                };
                var openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "Motion data|*.motion";
                if (openFileDialog.ShowDialog() == DialogResult.Cancel)
                    return;
                    using (StreamReader streamReader = new StreamReader(openFileDialog.FileName))
                    {
                        using (Newtonsoft.Json.JsonReader jReader = new Newtonsoft.Json.JsonTextReader(streamReader))
                        {
                            motionList = serializer.Deserialize<List<Model.IMotion>>(jReader);
                        }
                    }
                    MessageBox.Show("File is loading");
            }
        }

        /// <summary>
        /// Событие при выборе строки в таблице
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MotionDataGridView_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            motionInfoUserControl.Motion = motionList[e.RowIndex];
        }
    }
}

