using System;
using System.Data.SQLite;
using System.Drawing;
using System.Windows.Forms;

namespace AutoFy
{
    public partial class SignupForm : Form
    {
        // объявление переменной типа SQLiteConnection
        private SQLiteConnection DB;
        public SignupForm()
        {
            InitializeComponent();
        }
        private async void SignupForm_Load(object sender, EventArgs e)
        {
            // создание экземпляра класса SQLiteConnection с параметрами подключения к базе данных
            DB = new SQLiteConnection(Database.connection);
            // асинхронное открытие соединения с базой данных
            await DB.OpenAsync();
        }
        #region MouseMove
        // объявление переменной типа Point
        private Point LastPoint;
        // обработчик события перемещения мыши над изображением pictureBox1
        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
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
        // обработчик события нажатия кнопки мыши над изображением pictureBox1
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            // сохранение координат мыши в переменной типа Point
            LastPoint = new Point(e.X, e.Y);
        }
        #endregion

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            Close();
        }

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        #region Signup
        private void ContinueButton_Click(object sender, EventArgs e)
        {
            // если хотя бы одно из полей пустое
            if (string.IsNullOrEmpty(UserName.Text) || string.IsNullOrEmpty(UserSurname.Text)
    || string.IsNullOrEmpty(UserPhoneNumber.Text) || string.IsNullOrEmpty(UserPassword.Text))
            {
                // вывод сообщения о необходимости заполнения всех полей
                _ = MessageBox.Show("Заполните все поля");
                // выход из метода
                return;
            }
            // получение значений из текстовых полей
            string Name = UserName.Text;
            string Surname = UserSurname.Text;
            string PhoneNumber = UserPhoneNumber.Text;
            string Password = UserPassword.Text;
            // создание экземпляра класса SQLiteCommand для выполнения запроса на добавление нового пользователя в базу данных
            SQLiteCommand commandInsert = new SQLiteCommand($"INSERT INTO Users (Name, Surname, PhoneNumber,Password, Role)" +
                $" VALUES ('{Name}', '{Surname}', '{PhoneNumber}', '{Password}','USER')", DB);
            // выполнение асинхронного запроса на добавление нового пользователя в базу данных
            _ = commandInsert.ExecuteNonQueryAsync();
            // вывод сообщения об успешной регистрации
            _ = MessageBox.Show("Регистрация прошла успешно");
            Form newForm = new ChooseCarForm();
            newForm.FormClosed += new FormClosedEventHandler(Form_FormClosed);
            newForm.Show();
            Hide();
        }
        #endregion

        private void ContactsButton_Click(object sender, EventArgs e)
        {
            SignupForm thisForm = new SignupForm();
            ContactsForm newForm = new ContactsForm();
            newForm.FormClosed += new FormClosedEventHandler(Form_FormClosed);
            newForm.Show();
            thisForm.Close();
        }
    }
}
