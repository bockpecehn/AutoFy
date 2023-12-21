using System;
using System.Data.SQLite;
using System.Drawing;
using System.Windows.Forms;
using Telegram.Bot;
using Telegram.Bot.Exceptions;

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
            string BodyTipe = BodyTypeText.Text;
            string Color = ColorText.Text;
            string Mileage = MileageText.Text;
            string SteeringWheel = SteeringWheelText.Text;
            string Generation = GenerationText.Text;
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
                    $"\r\n {BodyTypeCar.Text} {BodyTipe}" +
                    $"\r\n {ColorCar.Text} {Color}" +
                    $"\r\n {MileageCar.Text} {Mileage}" +
                    $"\r\n {SteeringWheelCar.Text} {SteeringWheel}" +
                    $"\r\n {GenerationCar.Text} {Generation}" +
                    $"\r\n {VINCodeCar.Text} {VINCode}" +
                    $"\r\n Оценка:  {CarRat}" +
                    $"\r\n Стоимость: {CarPrice}";

                // Проверка, что ни одно из текстовых полей не пустое
                if (NameCar != string.Empty
                && Engine != string.Empty
                && Power != string.Empty
                && Transmission != string.Empty
                && DriveUnit != string.Empty
                && BodyTipe != string.Empty
                && Color != string.Empty
                && Mileage != string.Empty
                && SteeringWheel != string.Empty
                && Generation != string.Empty
                && VINCode != string.Empty
                && CarRat != string.Empty
                && CarPrice != string.Empty)
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
                 $"\r\n {BodyTypeCar.Text} {BodyTipe}" +
                 $"\r\n {ColorCar.Text} {Color}" +
                 $"\r\n {MileageCar.Text} {Mileage}" +
                 $"\r\n {SteeringWheelCar.Text} {SteeringWheel}" +
                 $"\r\n {GenerationCar.Text} {Generation}" +
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
    }
}
