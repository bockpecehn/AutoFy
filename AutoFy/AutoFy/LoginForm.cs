using System;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace AutoFy
{
    public partial class LoginForm : Form
    {
        // объявление приватного поля DB типа SQLiteConnection
        private SQLiteConnection DB;
        // 206; 50
        public LoginForm()
        {
            InitializeComponent();
        }

        private async void LoginForm_Load(object sender, EventArgs e)
        {
            // создание нового подключения к базе данных
            DB = new SQLiteConnection(Database.connection);
            // асинхронное открытие подключения к базе данных
            await DB.OpenAsync();
        }

        private void Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            Close();
        }
        #region MouseMove
        // объявление переменной типа Point
        private Point LastPoint;
        private void pictureBox3_MouseMove(object sender, MouseEventArgs e)
        {
            // если нажата левая кнопка мыши
            if (e.Button == MouseButtons.Left)
            {
                // изменение координаты Left формы
                Left += e.X - LastPoint.X;
                // изменение координаты Top формы
                Top += e.Y - LastPoint.Y;
            }
        }
        private void pictureBox3_MouseDown(object sender, MouseEventArgs e)
        {
            // сохранение текущей позиции мыши
            LastPoint = new Point(e.X, e.Y);
        }
        #endregion
        private void ContactsButton_Click(object sender, EventArgs e)
        {
            ContactsForm contactForm = new ContactsForm();
            contactForm.Show();
            Hide();
        }
        #region Login
        private async void LogInButton_Click(object sender, EventArgs e)
        {
            // создание новой таблицы данных
            DataTable table = new DataTable();
            // Создание нового адаптера для работы с данными SQLite
            SQLiteDataAdapter adapter = new SQLiteDataAdapter();
            // Создание нового объекта для чтения данных из SQLite
            SQLiteDataReader sqlReader = null;
            // создание новой команды SQL для выполнения запроса на выборку данных из таблицы пользователей
            SQLiteCommand command = new SQLiteCommand($"SELECT * FROM [{Users_table.main}] WHERE [{Users_table.PhoneNumber}]" +
                $" = '" + PhoneNumber.Text + $"' AND [{Users_table.Password}] = '" + Password.Text + "'", DB);
            try
            {
                // установка команды SQL для адаптера
                adapter.SelectCommand = command;
                // Заполнение таблицы данными, полученными из БД
                _ = adapter.Fill(table);
                // Если найдено несколько строк в таблице, то авторизация прошла успешно
                if (table.Rows.Count > 0)
                {
                    // Выполняем запрос на выборку данных из таблицы пользователей и получаем результат в виде объекта SQLiteDataReader
                    sqlReader = (SQLiteDataReader)await command.ExecuteReaderAsync();
                    // Читаем данные из объекта SQLiteDataReader
                    while (await sqlReader.ReadAsync())
                    {
                        // Если роль пользователя -Администратор, то открываем форму для работы с административной панелью
                        if (sqlReader[$"{Users_table.Role}"].ToString() == "ADMIN")
                        {
                            Form newForm = new AdminForm();
                            newForm.Show();
                            newForm.FormClosed += new FormClosedEventHandler(Form_FormClosed);
                            Hide();
                        }
                        // Если роль пользователя - Пользователь, то открываем форму выбора автомобиля
                        else if (sqlReader[$"{Users_table.Role}"].ToString() == "USER")
                        {
                            Form newForm = new ChooseCarForm();
                            newForm.Show();
                            Hide();
                        }
                    }
                }
                // Если не найдено ни одной строки в таблице, то авторизация не удалась
                else
                
                    _ = MessageBox.Show("Неверный логин или пароль", "Ошибка авторизации");
                
            }

            catch (Exception ex)
            {
                // Обработка других исключений
                _ = MessageBox.Show($"Произошла ошибка: {ex.Message}", ex.Source);
            }
            // Освобождение ресурсов
            finally
            {
                sqlReader?.Close();
            }
        }
        #endregion 

        private void ShowPass_Click(object sender, EventArgs e)
        {
            // изменение свойства UseSystemPasswordChar для поля Password
            Password.UseSystemPasswordChar = !Password.UseSystemPasswordChar;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {
            SignupForm newForm = new SignupForm();
            newForm.FormClosed += new FormClosedEventHandler(Form_FormClosed);
            Hide();
            newForm.Show();
        }
    }
}
