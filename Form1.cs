using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

//Разработайте приложение, позволяющее динамически обновлять список товаров в DataGridView 
//через привязку данных и интерфейс INotifyPropertyChanged.

//Создайте класс Product, содержащий свойства Name, Category и Price,
//реализующий интерфейс INotifyPropertyChanged.
//Создайте коллекцию объектов Product и привяжите ее к DataGridView.
//Реализуйте возможность добавления, удаления и редактирования товаров 
//через пользовательский интерфейс, обеспечив динамическое обновление DataGridView 
//при изменении коллекции товаров.
//Убедитесь, что при изменении свойств объектов Product через код DataGridView 
//также обновляется автоматически.

//Расширение: Добавьте возможность фильтрации и сортировки списка товаров 
//через пользовательский интерфейс.


namespace CatalogApp
{
    public partial class Catalog : Form
    {
        private List<Product> products = new List<Product>();

        public Catalog()
        {
            InitializeComponent();
            //dataGridView1.AllowUserToAddRows = false; //без последнего ряда для добавления

            // Инициализируем коллекцию товаров и привязываем ее к DataGridView



            dataGridView1.DataSource = products;

            //auto center screen
            StartPosition = FormStartPosition.CenterScreen;

            Panel panel1 = new Panel();
            panel1.BackColor = Color.SlateGray;
            panel1.Location = new Point(0, 0);
            panel1.Size = new Size(200, 500);
            panel1.BorderStyle = BorderStyle.None;


            Label label1 = new Label();
            label1.Location = new Point(10, 10);
            label1.AutoSize = true;
            label1.Size = new Size(200, 60);
            label1.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Text = "Меню \nредактирования";

            Button buttonOpen_Click = new Button();
            buttonOpen_Click.Location = new Point(0, 80); //от края и вниз
            buttonOpen_Click.Size = new Size(200, 60); //ширина и высота
            buttonOpen_Click.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            buttonOpen_Click.TextAlign = ContentAlignment.MiddleCenter;
            buttonOpen_Click.FlatAppearance.BorderSize = 0;
            buttonOpen_Click.FlatStyle = FlatStyle.Flat;
            buttonOpen_Click.FlatAppearance.MouseOverBackColor = Color.LightSteelBlue;
            buttonOpen_Click.Text = "Открыть";
            buttonOpen_Click.Click += buttonOpen_Click_Click;


            Button buttonSave_Click = new Button();
            buttonSave_Click.Location = new Point(0, 140); //от края и вниз
            buttonSave_Click.Size = new Size(200, 60); //ширина и высота
            buttonSave_Click.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            buttonSave_Click.TextAlign = ContentAlignment.MiddleCenter;
            buttonSave_Click.FlatAppearance.BorderSize = 0;
            buttonSave_Click.FlatStyle = FlatStyle.Flat;
            buttonSave_Click.FlatAppearance.MouseOverBackColor = Color.LightSteelBlue;
            buttonSave_Click.Text = "Сохранить как";
            buttonSave_Click.Click += buttonSave_Click_Click;


            Button buttonNewTable_Click = new Button();
            buttonNewTable_Click.Location = new Point(0, 200); //от края и вниз
            buttonNewTable_Click.Size = new Size(200, 60); //ширина и высота
            buttonNewTable_Click.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            buttonNewTable_Click.TextAlign = ContentAlignment.MiddleCenter;
            buttonNewTable_Click.FlatAppearance.BorderSize = 0;
            buttonNewTable_Click.FlatStyle = FlatStyle.Flat;
            buttonNewTable_Click.FlatAppearance.MouseOverBackColor = Color.LightSteelBlue;
            buttonNewTable_Click.Text = "Новая Таблица";
            buttonNewTable_Click.Click += buttonNewTable_Click_Click;

            Button buttonDelete_Click = new Button();
            buttonDelete_Click.Location = new Point(0, 260); //от края и вниз
            buttonDelete_Click.Size = new Size(200, 60); //ширина и высота
            buttonDelete_Click.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            buttonDelete_Click.TextAlign = ContentAlignment.MiddleCenter;
            buttonDelete_Click.FlatAppearance.BorderSize = 0;
            buttonDelete_Click.FlatStyle = FlatStyle.Flat;
            buttonDelete_Click.FlatAppearance.MouseOverBackColor = Color.LightSteelBlue;
            buttonDelete_Click.Text = "Удалить";
            buttonDelete_Click.Click += buttonDelete_Click_Click;

            // Редактирование выбранного товара 
            Button buttonRedactor_Click = new Button();
            buttonRedactor_Click.Location = new Point(0, 320); //от края и вниз
            buttonRedactor_Click.Size = new Size(200, 60); //ширина и высота
            buttonRedactor_Click.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            buttonRedactor_Click.TextAlign = ContentAlignment.MiddleCenter;
            buttonRedactor_Click.FlatAppearance.BorderSize = 0;
            buttonRedactor_Click.FlatStyle = FlatStyle.Flat;
            buttonRedactor_Click.FlatAppearance.MouseOverBackColor = Color.LightSteelBlue;
            buttonRedactor_Click.Text = "Редактировать";
            buttonRedactor_Click.Click +=buttonRedactor_Click_Click;

            Button buttonExit_Click = new Button();
            buttonExit_Click.Location = new Point(0, 380); //от края и вниз
            buttonExit_Click.Size = new Size(200, 60); //ширина и высота
            buttonExit_Click.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            buttonExit_Click.TextAlign = ContentAlignment.MiddleCenter;
            buttonExit_Click.FlatAppearance.BorderSize = 0;
            buttonExit_Click.FlatStyle = FlatStyle.Flat;
            buttonExit_Click.FlatAppearance.MouseOverBackColor = Color.LightSteelBlue;
            buttonExit_Click.Text = "Выход";
            buttonExit_Click.Click += buttonExit_Click_Click;

            // Добавление текста и кнопок на панель
            panel1.Controls.Add(label1);
            panel1.Controls.Add(buttonOpen_Click);
            panel1.Controls.Add(buttonSave_Click);
            panel1.Controls.Add(buttonNewTable_Click);
            panel1.Controls.Add(buttonDelete_Click);
            panel1.Controls.Add(buttonRedactor_Click);
            panel1.Controls.Add(buttonExit_Click);

            // Добавление панели на форму
            this.Controls.Add(panel1);
        }

        DataTable table = new DataTable();
        private void Form1_Load(object sender, EventArgs e)
        {


            //fixed screen
            ClientSize = new Size(900, 500);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            //BackColor = Color.Black;
            BackColor = Color.LightSteelBlue;

            //Для новой таблицы
            table.Columns.Add("Name", typeof(string));
            table.Columns.Add("Category", typeof(string));
            table.Columns.Add("Price", typeof(int));

            
            


            dataGridView1.DataSource = table;
        }

        private void SaveProductToFile(Product product)
        {
            using (StreamWriter sw = new StreamWriter("catalog.txt", true))
            {
                sw.WriteLine($"{product.Name} {product.Category} {product.Price}");
            }
        }

        private void buttonOpen_Click_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "all (*.*) |*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                LoadDataFromFile(filePath); // Загрузка данных из выбранного файла
            }
        }

        private void LoadDataFromFile(string filePath)
        {
            try
            {
                StreamReader rd = new StreamReader(filePath);
                DataSet ds = new DataSet();

                // Создаем таблицу
                ds.Tables.Add("Score");

                // Читаем заголовок
                string header = rd.ReadLine();
                string[] col = header.Split(',');

                for (int i = 0; i < col.Length; i++)
                {
                    ds.Tables[0].Columns.Add(col[i]);
                }

                // Читаем строки с данными
                string row = rd.ReadLine();

                while (row != null)
                {
                    string[] rvalue = row.Split(',');
                    ds.Tables[0].Rows.Add(rvalue);
                    row = rd.ReadLine();
                }

                // Привязываем таблицу к DataGridView
                dataGridView1.DataSource = ds.Tables[0];
                dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                rd.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при открытии файла: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SaveDataToFile(string filePath)
        {
            try
            {
                StreamWriter writer = new StreamWriter(filePath);

                // Записываем заголовок
                string header = string.Join(",", dataGridView1.Columns.Cast<DataGridViewColumn>().Select(col => col.HeaderText));
                writer.WriteLine(header);

                // Записываем данные
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        string[] values = row.Cells.Cast<DataGridViewCell>().Select(cell => cell.Value.ToString()).ToArray();
                        string rowString = string.Join(",", values);
                        writer.WriteLine(rowString);
                    }
                }

                writer.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при сохранении файла: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void buttonSave_Click_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "all (*.*) |*.*"; // Укажите необходимые фильтры для сохранения файла.

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;
                SaveDataToFile(filePath); // Сохранение данных в выбранный файл
            }
        }


        private void buttonNewTable_Click_Click(object sender, EventArgs e)
        {
            // Создайте новую пустую таблицу данных
            DataTable newTable = new DataTable();

            // Определите столбцы для новой таблицы (пример):
            newTable.Columns.Add("Name");
            newTable.Columns.Add("Category");
            newTable.Columns.Add("Price");

            // Свяжите новую таблицу с DataGridView
            dataGridView1.DataSource = newTable;
        }

        private void buttonDelete_Click_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Получите выбранное имя из второй колонки выбранной строки
                string selectedName = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();

                // Получите объект DataTable, связанный с DataGridView
                DataTable dt = (DataTable)dataGridView1.DataSource;

                // Найдите и удалите строку с соответствующим именем во второй колонке
                DataRow[] rowsToDelete = dt.Select($"Category = '{selectedName}'");

                foreach (DataRow row in rowsToDelete)
                {
                    dt.Rows.Remove(row);
                }
                // После внесения изменений в таблицу, например, после добавления, редактирования или удаления строк
                dt.AcceptChanges();
            }
            else
            {
                MessageBox.Show("Выберите строку для удаления.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void buttonRedactor_Click_Click(object sender, EventArgs e)
        {
            dataGridView1.EditMode = DataGridViewEditMode.EditOnKeystrokeOrF2;
            if (dataGridView1.SelectedCells.Count > 0)
            {
                // Получите выбранную ячейку
                DataGridViewCell selectedCell = dataGridView1.SelectedCells[0];

                // Проверьте, что выбранная ячейка не является заголовком (header)
                if (selectedCell.RowIndex != -1 && selectedCell.ColumnIndex != -1)
                {
                    // Перейдите в режим редактирования ячейки
                    dataGridView1.CurrentCell = selectedCell;
                    dataGridView1.BeginEdit(true);
                }
            }
            else
            {
                MessageBox.Show("Выберите ячейку для редактирования.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonExit_Click_Click(object sender, EventArgs e)
        {
            // Ваш код для обработки события кнопки "Выход" здесь

            //найти выборку yes/no
            DialogResult result = MessageBox.Show("Закрыть без сохранения?", "Закрытие приложения", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                // Пользователь нажал "Да"
                // Ваш код для обработки сценария, когда пользователь выбрал "Да"
                Close();
            }
            else
            {
                // Пользователь нажал "Нет" или закрыл MessageBox
                // Ваш код для обработки сценария, когда пользователь выбрал "Нет"
                buttonSave_Click_Click(sender, e);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AddRowToTable(string name, string category, int price)
        {
            // Получите таблицу данных из DataGridView
            DataTable dt = (DataTable)dataGridView1.DataSource;

            // Создайте новую строку
            DataRow newRow = dt.NewRow();

            // Установите значения для столбцов в новой строке
            newRow["Name"] = name;
            newRow["Category"] = category;
            newRow["Price"] = price;

            // Добавьте новую строку в таблицу
            dt.Rows.Add(newRow);

            // Обновите DataGridView, если необходимо
            dataGridView1.Refresh();
            // После внесения изменений в таблицу, например, после добавления, редактирования или удаления строк
            dt.AcceptChanges();
        }


        private void Add_Click(object sender, EventArgs e)
        {

            // Получите значения из текстовых полей TextBox
            string name = textName.Text;
            string category = textCategory.Text;
            int price;

            if (int.TryParse(textPrice.Text, out price))
            {
                // Вызовите метод для добавления строки в таблицу данных
                AddRowToTable(name, category, price);

                // Очистите текстовые поля после добавления
                textName.Clear();
                textCategory.Clear();
                textPrice.Clear();
            }
            else
            {
                MessageBox.Show("Некорректное значение для цены.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SearchInDataGrid(string searchText)
        {
            try
            {
                dataGridView1.ClearSelection();
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        if (cell.Value != null && cell.Value.ToString().IndexOf(searchText, StringComparison.OrdinalIgnoreCase) >= 0)
                        {
                            row.Selected = true;
                            break;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при выполнении поиска: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchText = txtSearchText.Text;
            if (!string.IsNullOrEmpty(searchText))
            {
                SearchInDataGrid(searchText);
            }
        }
    }
}
