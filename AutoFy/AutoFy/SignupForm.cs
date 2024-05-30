using System;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
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
        #region GenerateRandom
        string GRP(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
            Random random = new Random();
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }
        string GRPN(int length)
        {
            const string chars = "0123456789";
            Random random = new Random();
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }
        #endregion
        #region AutoTest
        private void AutoTestBut_Click(object sender, EventArgs e)
        {
            var randomName = File.ReadAllLines("randomNameSurname\\name.txt");
            Random random = new Random();

            string[] randomReg = { "950", "999", "912", "918", "909", "904", "963", "952" };
            var randomSurName = File.ReadAllLines("randomNameSurname\\surname.txt");
            int recordsToInsert = 5;

            for (int i = 0; i < recordsToInsert; i++)
            {
                string RanName = randomName[random.Next(randomName.Length)];
                string RanSName = randomSurName[random.Next(randomSurName.Length)];
                string RanPass = GRP(8);
                string RanPN = "+7" + "(" + randomReg[random.Next(randomReg.Length)] + ")" + GRPN(7);

                SQLiteCommand commandInsert = new SQLiteCommand($"INSERT INTO Users (Name, Surname, PhoneNumber ,Password, Role)" +
                    $" VALUES ('{RanName}','{RanSName}', '{RanPN}', '{RanPass}', 'USER')", DB);
                _ = commandInsert.ExecuteNonQueryAsync();
            }
            DelBut.Visible = true;
            AutoTestBut.Visible = false;
        }

        private void DelBut_Click(object sender, EventArgs e)
        {
            SQLiteCommand commandDelete = new SQLiteCommand("DELETE FROM Users ORDER BY ID DESC LIMIT 5", DB);
            _ = commandDelete.ExecuteNonQueryAsync();
            DelBut.Visible = false;
            AutoTestBut.Visible = true;
        }
        #endregion
    }
}
