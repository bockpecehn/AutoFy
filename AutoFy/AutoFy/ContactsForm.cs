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
            /*PhoneNumberAdmin.Text = "   Номер телефона\r\n+7(999) 228 - 13 - 37";
            TGMessage.Text = "Или можете написать свою \r\n          проблему здесь";
            Communication.Text = "          Связь \r\nс администрацией";*/
            // Создание объекта для поиска информации о операционной системе
            var osSearcher = new ManagementObjectSearcher("SELECT * FROM Win32_OperatingSystem");
            // Создание объекта для поиска информации о видеокарте
            var videoCardSearcher = new ManagementObjectSearcher("SELECT * FROM Win32_VideoController");
            // Создание объекта для поиска информации о процессоре
            var processorSearcher = new ManagementObjectSearcher("SELECT * FROM Win32_Processor");
            // Создание объекта для поиска информации о ОЗУ
            var memorySearcher = new ManagementObjectSearcher("SELECT * FROM Win32_PhysicalMemory");
            // Создание объекта StringBuilder для объединения результатов запросов
            var dotNetCoreVersion = Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\NET Core\", "Version", null);
            var dotNetFrameworkVersion = Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\NET Framework Setup\NDP\v4\Full\", "Version", null);

            StringBuilder sb = new StringBuilder();

            // Получаем информацию о версии Windows
            foreach (var os in osSearcher.Get())
            {
                var osCaption = (string)os["Caption"];
                var osBuildNumber = (string)os["BuildNumber"];

                sb.AppendLine($"ОС: {osCaption}");
                sb.AppendLine($"Номер сборки: {osBuildNumber}\n");
            }

            sb.AppendLine($".NET Core версия: {dotNetCoreVersion ?? "Нет информации"}");
            sb.AppendLine($".NET Framework версия: {dotNetFrameworkVersion ?? "Нет информации"}\n");

            // Обрабатываем информацию о видеокарте
            foreach (var videoCard in videoCardSearcher.Get())
            {
                var videoCardName = (string)videoCard["Name"];

                sb.AppendLine($"Видеокарта: {videoCardName}");
            }

            // Обрабатываем информацию о процессоре
            foreach (var processor in processorSearcher.Get())
            {
                var processorName = (string)processor["Name"];
                var processorSpeedMHz = processor["MaxClockSpeed"].ToString();
                var processorSpeedGHz = Convert.ToInt64(processorSpeedMHz) / 1000.0;
                sb.AppendLine($"Процессор: {processorName}");
                sb.AppendLine($"Частота процессора: {processorSpeedGHz} Ггц\n");
            }

            // Обрабатываем информацию об оперативной памяти
            foreach (var memory in memorySearcher.Get())
            {
                var memoryCapacity = Convert.ToUInt64(memory["Capacity"]);
                var memorySize = memoryCapacity / (1024 * 1024 * 1024); // Преобразуем к гигабайтам
                sb.AppendLine($"Оперативная память: {memorySize} ГБ");
            }           

            // Записываем результат в SysInfo
            InfoPCrtb.Text = sb.ToString();
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
                string pcinfo = InfoPCrtb.Text;
                // создание текстового сообщения
                string message = $"От: {email} Тема: {subject} \r\nПроблема: {messageText} \nИнофрмация о системе: \n{pcinfo}";

                // проверка, что все поля формы заполнены
                if (email != string.Empty
                && subject != string.Empty
                && messageText != string.Empty
                && pcinfo != string.Empty)
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
    }
}
