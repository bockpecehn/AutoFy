using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telegram.Bot;
using Telegram.Bot.Exceptions;

namespace AutoFy
{
    public partial class PaymentForm : Form
    {
        public PaymentForm()
        {
            InitializeComponent();
        }
        #region MouseMove
        // объявление переменной типа Point
        private Point LastPoint;
        private void pictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
            // сохранение текущей позиции мыши
            LastPoint = new Point(e.X, e.Y);
        }
        private void pictureBox2_MouseMove(object sender, MouseEventArgs e)
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
        // объявление константы, определяющей максимальное значение для поля Month
        private readonly int maxValue = 12;

        private void CloseButton_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void CardNumber_TextChanged(object sender, EventArgs e)
        {
            // удаление пробелов из текста поля CardNumber
            string text = CardNumber.Text.Replace(" ", "");
            if (text.Length > 0)
            {
                // создание нового экземпляра класса StringBuilder
                StringBuilder newText = new StringBuilder(text);
                //цикл для вставки пробелов в текст
                for (int i = 4; i < newText.Length; i += 5)
                {
                    // вставка пробела в текст
                    _ = newText.Insert(i, " ");
                }
                // присвоение тексту поля CardNumber нового значения с пробелами
                CardNumber.Text = newText.ToString();
                // установка курсора в конец текста поля CardNumber
                CardNumber.SelectionStart = newText.Length;
            }
        }

        private void Month_TextChanged(object sender, EventArgs e)
        {
            // если текст поля Month может быть преобразован в число и преобразованное число больше максимального значения
            if (int.TryParse(Month.Text, out int value) && value > maxValue)

                // присвоение тексту поля Month максимального значения
                Month.Text = maxValue.ToString();

        }
        #region PayButton
        private async void PayButton_Click(object sender, EventArgs e)
        {
            _ = new CarRentForm();
            try
            {
                // получение значений из текстовых полей
                string cardholder = CardHolder.Text;
                string hour = HourLab.Text;
                string car = CarNameLab.Text;
                // формирование текста сообщения
                string message = $"{cardholder} оформил {car} на {hour} часов";
                // если все поля заполнены
                if (cardholder != string.Empty
                && hour != string.Empty
                && car != string.Empty)
                {
                    // создание экземпляра класса TelegramBotClient с токеном бота
                    TelegramBotClient bot = new TelegramBotClient("5901448502:AAHluKkavkFJM9fLI1Hu3POkex45Ag2lZPA");
                    // отправка сообщения в чат с указанным идентификатором
                    _ = await bot.SendTextMessageAsync(chatId: "1204870863", text: message);
                    // вывод сообщения об успешной оплате
                    _ = System.Windows.Forms.MessageBox.Show("Оплата прошла успешно!", "Контакты", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                // если не все поля заполнены
                else

                    // вывод сообщения о необходимости заполнения всех полей
                    _ = System.Windows.Forms.MessageBox.Show("Введите данные", "Контакты", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            // если произошла ошибка при отправке сообщения
            catch (ApiRequestException ex)
            {
                // вывод сообщения об ошибке
                _ = System.Windows.Forms.MessageBox.Show($"Сообщение не отправлено:{ex.Message}", "Контакты", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
        #region KeyPress
        private void Month_KeyPress(object sender, KeyPressEventArgs e)
        {
            // если нажата не цифровая клавиша или не клавиша "Backspace"
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')

                // запрет обработки события
                e.Handled = true;

        }

        private void Year_KeyPress(object sender, KeyPressEventArgs e)
        {
            // если нажата не цифровая клавиша или не клавиша "Backspace"
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')

                // запрет обработки события
                e.Handled = true;

        }
        private void CardNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            // если нажата не цифровая клавиша или не клавиша "Backspace"
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')

                // запрет обработки события
                e.Handled = true;

        }

        private void SecurityCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            // если нажата не цифровая клавиша или не клавиша "Backspace"
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')

                // запрет обработки события
                e.Handled = true;

        }
        #endregion
    }
}
