using System;
using System.Data.SQLite;
using System.Drawing;
using System.Windows.Forms;
using Telegram.Bot;
using Telegram.Bot.Exceptions;
using System.IO;
using System.Linq;

namespace AutoFy
{
    public partial class AdminForm : Form
    {
        // создание объекта SQLiteConnection
        private SQLiteConnection DB;
        public AdminForm()
        {
            InitializeComponent();
        }
        private async void AdminForm_Load(object sender, EventArgs e)
        {
            // инициализация объекта SQLiteConnection с помощью строки подключения
            DB = new SQLiteConnection(Database.connection);
            // асинхронное открытие базы данных
            await DB.OpenAsync();
        }
        #region MouseMove
        // объявление переменной типа Point
        private Point LastPoint;
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            // сохранение текущей позиции мыши
            LastPoint = new Point(e.X, e.Y);
        }

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
        #endregion
        #region AddCar
        private async void AddCar_Click(object sender, EventArgs e)
        {
            // Получение значений текстовых полей
            string NameCar = AddCarName.Text;
            string Engine = EngineText.Text;
            string Power = PowerText.Text;
            string Transmission = TransmissionText.Text;
            string DriveUnit = DriveUnitText.Text;
            string Color = ColorText.Text;
            string VINCode = VINCodeText.Text;
            string CarRat = AddCarRat.Text;
            string CarPrice = AddCarPrice.Text;
            try
            {
                // Формирование сообщения для отправки в Telegram-бота
                string message = $"От: ADMIN\r\n Тема: Добавление машины \r\n 'Название машины: '{NameCar}" +
                    $"\r\n {EngineCar.Text} {Engine}" +
                    $"\r\n {PowerCar.Text} {Power}" +
                    $"\r\n {TransmissionCar.Text} {Transmission}" +
                    $"\r\n {DriveUnitCar.Text} {DriveUnit}" +
                    $"\r\n {ColorCar.Text} {Color}" +
                    $"\r\n {VINCodeCar.Text} {VINCode}" +
                    $"\r\n Оценка:  {CarRat}" +
                    $"\r\n Стоимость: {CarPrice}";

                // Проверка, что ни одно из текстовых полей не пустое
                if (string.IsNullOrEmpty(NameCar) || string.IsNullOrEmpty(Engine)
                    || string.IsNullOrEmpty(Power) || string.IsNullOrEmpty(Transmission)
                    || string.IsNullOrEmpty(DriveUnit) || string.IsNullOrEmpty(Color)
                    || string.IsNullOrEmpty(CarRat) || string.IsNullOrEmpty(CarPrice))
                {
                    // Создание нового объекта TelegramBotClient с помощью токена бота
                    TelegramBotClient bot = new TelegramBotClient("5901448502:AAHluKkavkFJM9fLI1Hu3POkex45Ag2lZPA");
                    // Отправка сообщения в указанный идентификатор чата
                    _ = await bot.SendTextMessageAsync(chatId: "1204870863", text: message);
                    // Показ сообщения об успешной отправке сообщения
                    _ = System.Windows.Forms.MessageBox.Show("Сообщение отправлено", "Контакты", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                
                    // Показ сообщения о том, что текстовые поля пусты
                    _ = System.Windows.Forms.MessageBox.Show("Введите данные", "Контакты", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                
            }
            catch (ApiRequestException ex)
            {
                // Показ сообщения об ошибке отправки сообщения
                _ = System.Windows.Forms.MessageBox.Show($"Сообщение не отправлено:{ex.Message}", "Контакты", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            // Формирование строки для столбца CarSpecs
            string CarSpecs = $"{EngineCar.Text} {Engine}" +
                 $"\r\n {PowerCar.Text} {Power}" +
                 $"\r\n {TransmissionCar.Text} {Transmission}" +
                 $"\r\n {DriveUnitCar.Text} {DriveUnit}" +
                 $"\r\n {ColorCar.Text} {Color}" +
                 $"\r\n {VINCodeCar.Text} {VINCode}";
            // Формирование SQL-запроса на добавление записи в базу данных
            SQLiteCommand commandInsert = new SQLiteCommand($"INSERT INTO Cars (CarName, CarSpecs, CarRating, CarPrice)" +
                $" VALUES ('{NameCar}', '{CarSpecs}', '{"Рейтинг " + CarRat}', '{CarPrice}')", DB);
            // Выполнение запроса
            _ = commandInsert.ExecuteNonQueryAsync();
            _ = MessageBox.Show("Машина добавлена в базу данных");

        }
        #endregion

        private void AddCarPrice_TextChanged(object sender, EventArgs e)
        {
            // если текстовое поле может быть преобразовано в переменную типа double
            if (double.TryParse(AddCarPrice.Text, out double value))
                // Преобразование значения в строку и добавление к ней символа "₽/Час"
                AddCarPrice.Text = value.ToString() + " ₽/Час";
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        private readonly int maxValue = 10;

        private void AddCarRat_TextChanged(object sender, EventArgs e)
        {
            // если текст поля AddCarRat может быть преобразован в число и преобразованное число больше максимального значения
            if (int.TryParse(AddCarRat.Text, out int value) && value > maxValue)

                // присвоение тексту поля AddCarRat максимального значения
                AddCarRat.Text = maxValue.ToString();
        }
        string GRR(int length)
        {
            const string chars = "0123456789";
            Random random = new Random();
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }
        private async void ATBut_Click(object sender, EventArgs e)
        {
            Random random = new Random();

            var randomCName = File.ReadAllLines("random\\car.txt");
            string[] randomEn = { "Бензин, 1.2 л", "Бензин, 1.6 л", "Бензин 2.0 л"};
            string[] randomTr = { "Робот", "Механика", "Автомат"};
            string[] randomPw = { "50 л.с.", "100 л.с.", "150 л.с.", "200 л.с."};
            string[] randomDU = { "Полный", "Задний", "Передний" };
            string[] randomCl = { "Синий", "Чёрный", "Белый", "Красный"};
            string VCod = "*****************";
            string[] randomPr = { "1500 ₽/Час", "500 ₽/Час", "1000 ₽/Час" };
            
            int recordsToInsert = 5;
            TelegramBotClient bot = new TelegramBotClient("5901448502:AAHluKkavkFJM9fLI1Hu3POkex45Ag2lZPA");
            for (int i = 0; i < recordsToInsert; i++)
            {
                string RanNm = randomCName[random.Next(randomCName.Length)];
                string RanEn = randomEn[random.Next(randomEn.Length)];
                string RanTr = randomTr[random.Next(randomTr.Length)];
                string RanPw = randomPw[random.Next(randomPw.Length)];
                string RanDU = randomDU[random.Next(randomDU.Length)];
                string RanCl = randomCl[random.Next(randomCl.Length)];
                string RanRt = GRR(1) + "," + GRR(1);
                string RanPr = randomPr[random.Next(randomPr.Length)];
                string CS = $"{EngineCar.Text} {RanEn}" +
                 $"\r\n {PowerCar.Text} {RanPw}" +
                 $"\r\n {TransmissionCar.Text} {RanTr}" +
                 $"\r\n {DriveUnitCar.Text} {RanDU}" +
                 $"\r\n {ColorCar.Text} {RanCl}" +
                 $"\r\n {VINCodeCar.Text} {VCod}";
                SQLiteCommand commandInsert = new SQLiteCommand($"INSERT INTO Cars (CarName, CarSpecs, CarRating, CarPrice)" +
                    $" VALUES ('{RanNm}', '{CS}', '{RanRt}', '{RanPr}')", DB);
                _ = commandInsert.ExecuteNonQueryAsync();
                string message = $"От: ADMIN\r\n Тема: Добавление машины \r\n 'Название машины: '{RanNm}" +
                    $"\r\n {EngineCar.Text} {RanEn}" +
                    $"\r\n {PowerCar.Text} {RanPw}" +
                    $"\r\n {TransmissionCar.Text} {RanTr}" +
                    $"\r\n {DriveUnitCar.Text} {RanDU}" +
                    $"\r\n {ColorCar.Text} {RanCl}" +
                    $"\r\n {VINCodeCar.Text} {VCod}" +
                    $"\r\n Оценка:  {RanRt}" +
                    $"\r\n Стоимость: {RanPr}";            
                _ = await bot.SendTextMessageAsync(chatId: "1204870863", text: message);
            }
            DelBut.Visible = true;
            ATBut.Visible = false;
        }

        private void DelBut_Click(object sender, EventArgs e)
        {
            SQLiteCommand commandDelete = new SQLiteCommand("DELETE FROM Cars ORDER BY ID DESC LIMIT 5", DB);
            _ = commandDelete.ExecuteNonQueryAsync();
            DelBut.Visible = false;
            ATBut.Visible = true;
        }

        private void DBCloneBut_Click(object sender, EventArgs e)
        {
            string sourceFilePath = "database.db";
            string destinationFolderPath = "saveDB";

            string fileName = Path.GetFileName(sourceFilePath);
            string destinationFilePath = Path.Combine(destinationFolderPath, fileName);

            try
            {
                File.Copy(sourceFilePath, destinationFilePath, true);
                MessageBox.Show("База данных успешно скопированна", "Успех");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при копировании базы данных: " + ex.Message, "Ошибка");
            }
        }
    }
}
