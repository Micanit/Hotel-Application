using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Application
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Main();
            CreationComboboxInDataGrid_Rooms();
            CreationComboboxInDataGrid_Roomers();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "data_baseDataSet.Roomers". При необходимости она может быть перемещена или удалена.
            this.roomersTableAdapter.Fill(this.data_baseDataSet.Roomers);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "data_baseDataSet.Rooms". При необходимости она может быть перемещена или удалена.
            this.roomsTableAdapter.Fill(this.data_baseDataSet.Rooms);
        }
        private void CreationComboboxInDataGrid_Rooms()
        {
            // Метод вывода комбо боксов в таблице  

            //обязательные строки для отсутствия ошибки DataGridError
            dataGridView1.DataError += new DataGridViewDataErrorEventHandler(myDataGridView_DataError);
            void myDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
            {

            }
            //Создание combobox в data grid Номера в поле Этаж
            int[] list_room = new int[] { 1, 2, 3, 4, 5 };
            var oldcol3 = dataGridView1.Columns[1];
            var newcol3 = new DataGridViewComboBoxColumn();
            newcol3.FlatStyle = FlatStyle.Popup;
            newcol3.HeaderText = oldcol3.HeaderText;
            newcol3.HeaderCell = oldcol3.HeaderCell;
            newcol3.Name = oldcol3.Name;
            //newcol3.ValueType = oldcol3.ValueType;
            newcol3.DataSource = list_room;
            newcol3.DataPropertyName = oldcol3.DataPropertyName;
            dataGridView1.Columns.RemoveAt(1);
            dataGridView1.Columns.Insert(1, newcol3);
            //dataGridView2[1, 3].Value

            //Создание combobox в data grid Номера в поле Бронь 
            string[] list_bokinbg = new string[] { "Есть", "Нет" };
            var oldcol2 = dataGridView1.Columns[3];
            var newcol2 = new DataGridViewComboBoxColumn();
            newcol2.FlatStyle = FlatStyle.Popup;
            newcol2.HeaderText = oldcol2.HeaderText;
            newcol2.Name = oldcol2.Name;
            newcol2.DataSource = list_bokinbg;
            newcol2.DataPropertyName = oldcol2.DataPropertyName;
            dataGridView1.Columns.RemoveAt(3);
            dataGridView1.Columns.Insert(3, newcol2);

            //Создание combobox в data grid Номера в поле Класс обслуживания 
            string[] countrys = new string[] { "A", "B", "C" };
            var oldcol = dataGridView1.Columns[5];
            var newcol = new DataGridViewComboBoxColumn();
            newcol.FlatStyle = FlatStyle.Popup;
            newcol.HeaderText = oldcol.HeaderText;
            newcol.Name = oldcol.Name;
            newcol.DataSource = countrys;
            newcol.DataPropertyName = oldcol.DataPropertyName;
            dataGridView1.Columns.RemoveAt(5);
            dataGridView1.Columns.Insert(5, newcol);

            
            //Создание combobox в data grid Номера в поле Этаж
            int[] list_people = new int[] { 1, 2, 3, 4};
            var oldcol5 = dataGridView1.Columns[4];
            var newcol5 = new DataGridViewComboBoxColumn();
            newcol5.FlatStyle = FlatStyle.Popup;
            newcol5.HeaderText = oldcol5.HeaderText;
            newcol5.HeaderCell = oldcol5.HeaderCell;
            newcol5.Name = oldcol5.Name;
            newcol5.DataSource = list_people;
            newcol5.DataPropertyName = oldcol5.DataPropertyName;
            dataGridView1.Columns.RemoveAt(4);
            dataGridView1.Columns.Insert(4, newcol5);
        }

        private void CreationComboboxInDataGrid_Roomers()
        {
            // Метод вывода комбо боксов в таблице  

            //обязательные строки для отсутствия ошибки DataGridError
            dataGridView2.DataError += new DataGridViewDataErrorEventHandler(myDataGridView_DataError);
            void myDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
            {

            }
            //Создание combobox в data grid Постояльцы в поле Класс обслуживания 
            string[] countrys = new string[] { "A", "B", "C" };
            var oldcol4 = dataGridView2.Columns[4];
            var newcol4 = new DataGridViewComboBoxColumn();
            newcol4.FlatStyle = FlatStyle.Popup;
            newcol4.HeaderText = oldcol4.HeaderText;
            newcol4.Name = oldcol4.Name;
            newcol4.DataSource = countrys;
            newcol4.DataPropertyName = oldcol4.DataPropertyName;
            dataGridView2.Columns.RemoveAt(4);
            dataGridView2.Columns.Insert(4, newcol4);


            //Создание combobox в data grid Постояльцы в поле Этаж
            int[] list_people2 = new int[] { 1, 2, 3, 4 };
            var oldcol6 = dataGridView2.Columns[3];
            var newcol6 = new DataGridViewComboBoxColumn();
            newcol6.FlatStyle = FlatStyle.Popup;
            newcol6.HeaderText = oldcol6.HeaderText;
            newcol6.HeaderCell = oldcol6.HeaderCell;
            newcol6.Name = oldcol6.Name;
            newcol6.DataSource = list_people2;
            newcol6.DataPropertyName = oldcol6.DataPropertyName;
            dataGridView2.Columns.RemoveAt(3);
            dataGridView2.Columns.Insert(3, newcol6);
        }
            void Main()
        {
            dataGridView1.DataError += myDataGridView_DataError;
            void myDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
            {

            }
        }

        //Кнопка сохранить в таблице Комнаты
        private void сохранитьИзмененияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.EndEdit();
            roomsTableAdapter.Update(data_baseDataSet.Rooms);
            MessageBox.Show("Изменения сохраненнны", "Уведомление");
        }

        //Кнопка сохранить в таблице Постояльцы
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            dataGridView2.EndEdit();
            roomersTableAdapter.Update(data_baseDataSet.Roomers);
            MessageBox.Show("Изменения сохраненнны", "Уведомление");

        }

        //Кнопка удалить выделенную строчку в таблице Комнаты
        private void удалитьВыделеннуюСтрочкуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                int delet = dataGridView1.SelectedCells[0].RowIndex;
                dataGridView1.Rows.RemoveAt(delet);
                dataGridView1.EndEdit();
                roomsTableAdapter.Update(data_baseDataSet.Rooms);
                MessageBox.Show("Строчка удалена", "Уведомление");
            }
            catch 
            {
                MessageBox.Show("Нельзя удалить не существующую строку", "Ошибка");
            }
        }

        //Кнопка удалить выделенную строчку в таблице Постояльцы
        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            try
            {
                int delet1 = dataGridView2.SelectedCells[0].RowIndex;
                dataGridView2.Rows.RemoveAt(delet1);
                dataGridView2.EndEdit();
                roomersTableAdapter.Update(data_baseDataSet.Roomers);
                MessageBox.Show("Строчка удалена", "Уведомление");
            }
            catch 
            {
                MessageBox.Show("Нельзя удалить не существующую строку", "Ошибка");
            }

        }

        //выходы из приложения

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
