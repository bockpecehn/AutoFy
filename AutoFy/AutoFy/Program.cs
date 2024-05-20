using Microsoft.Win32;
using System;
using System.Management;
using System.Text;
using System.Windows.Forms;

namespace AutoFy
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Включение визуальных стилей Windows Forms
            Application.EnableVisualStyles();
            // Установка значения по умолчанию для отображения текста в Windows Forms
            Application.SetCompatibleTextRenderingDefault(false);
            // Запуск формы входа
            Application.Run(new LoginForm());
        }
    }

    // Класс, содержащий информацию о базе данных
    static class Database
    {
        // Строка подключения к базе данных
        public static string connection = @"Data Source=database.db; Integrated Security=False; MultipleActiveResultSets=True";
    }
    #region DBTable
    #region UsersTable
    // Класс, содержащий информацию о таблице пользователей
    static class Users_table
    {
        // Название таблицы пользователей
        public static string main = "Users";
        // Название столбцов таблицы пользователей
        public static string Id = "id";
        public static string Name = "Name";
        public static string PhoneNumber = "PhoneNumber";
        public static string Password = "Password";
        public static string Role = "Role";
    }
    #endregion
    #region CarsTable
    // Класс, содержащий информацию о таблице автомобилей
    static class Cars_table
    {
        // Название таблицы автомобилей
        public static string main = "Cars";
        // Название столбцов таблицы автомобилей
        public static string ID = "id";
        public static string CarName = "CarName";
        public static string CarSpecs = "CarSpecs";
        public static string CarRating = "CarRating";
        public static string CarPrice = "CarPrice";
        public static string OriginalImage1 = "OriginalImage1";
        public static string OriginalImage2 = "OriginalImage2";
        public static string OriginalImage3 = "OriginalImage3";
        public static string OriginalImage4 = "OriginalImage4";
        public static string DarkenedImage1 = "DarkenedImage1";
        public static string DarkenedImage2 = "DarkenedImage2";
        public static string DarkenedImage3 = "DarkenedImage3";
        public static string DarkenedImage4 = "DarkenedImage4";
        public static string ChoosePic = "ChoosePic";
    }
    #endregion
    #endregion
}
