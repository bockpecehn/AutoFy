using System;
using System.Text;
using System.Windows.Forms;
using Telegram.Bot;
using Telegram.Bot.Exceptions;
using System.Management;
using Microsoft.Win32;

namespace AutoFy
{
    public partial class ContactsForm : Form
    {
        public ContactsForm()
        {
            InitializeComponent();
        }

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
        // обработчик события загрузки формы ContactsForm
        private void ContactsForm_Load(object sender, EventArgs e)
        {
            PhoneNumberAdmin.Text = "   Номер телефона\r\n+7(999) 228 - 13 - 37";
            TGMessage.Text = "Или можете написать свою \r\n          проблему здесь";
            Communication.Text = "          Связь \r\nс администрацией";            
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            LoginForm oldForm = new LoginForm();
            oldForm.FormClosed += new FormClosedEventHandler(Form_FormClosed);
            oldForm.Show();
            Close();
        }
        #region TGMessage
        private async void SendButton_Click(object sender, EventArgs e)
        {
            try
            {
                // получение текста из TextBox'ов и сохранение в переменных
                string email = EmailBox.Text;
                string subject = SubjectBox.Text;
                string messageText = MessageBox.Text;

                // создание текстового сообщения
                string message = $"От: {email} Тема: {subject} \r\nПроблема: {messageText}";

                // проверка, что все поля формы заполнены
                if (email != string.Empty
                && subject != string.Empty
                && messageText != string.Empty)
                {
                    // создание нового экземпляра TelegramBotClient с токеном бота
                    TelegramBotClient bot = new TelegramBotClient("5901448502:AAHluKkavkFJM9fLI1Hu3POkex45Ag2lZPA");
                    // отправка сообщения на указанный chatId
                    _ = await bot.SendTextMessageAsync(chatId: "1204870863", text: message);
                    // вывод информационного сообщения
                    _ = System.Windows.Forms.MessageBox.Show("Сообщение отправлено",
                        "Контакты", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                
                    // вывод сообщения об ошибке
                    _ = System.Windows.Forms.MessageBox.Show("Введите данные",
                        "Контакты", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
            catch (ApiRequestException ex)
            {
                // обработка исключения ApiRequestException
                _ = System.Windows.Forms.MessageBox.Show($"Сообщение не отправлено:{ex.Message}",
                    "Контакты", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        private void ConfigBtn_Click(object sender, EventArgs e)
        {
            Config.ConfigPc();
            System.Windows.Forms.MessageBox.Show($"{Config.GetConfigInfo()}","Конфигурация Вашего компьютера");
        }
    }
}
