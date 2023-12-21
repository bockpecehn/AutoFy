using System;
using System.Data.SQLite;
using System.Drawing;
using System.Windows.Forms;

namespace AutoFy
{
    public partial class ChooseCarForm : Form
    {
        // создание объекта SQLiteConnection
        private SQLiteConnection DB;
        public ChooseCarForm()
        {
            InitializeComponent();
        }
        private async void ChooseCarForm_Load(object sender, EventArgs e)
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

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        #region ChooseCar
        private void ShowCar(int carId)
        {
            _ = new CarRentForm();
            CarCheckoutForm newForm = new CarCheckoutForm();
            // SQL-запрос для получения данных о машине
            string queryString = "SELECT CarName, CarSpecs, CarRating, CarPrice," +
                " OriginalImage1, OriginalImage2, OriginalImage3, OriginalImage4," +
                " DarkenedImage1, DarkenedImage2, DarkenedImage3, DarkenedImage4, ChoosePic FROM Cars WHERE id = @CarId";
            SQLiteCommand command = new SQLiteCommand(queryString, DB);
            command.Parameters.AddWithValue("@CarId", carId);
            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                // чтение данных о машине из результирующего набора
                string CarName = reader.GetString(0);
                string CarSpecs = reader.GetString(1);
                string CarRating = reader.GetString(2);
                string CarPrice = reader.GetString(3);
                string CarOrigPic1 = reader.GetString(4);
                string CarOrigPic2 = reader.GetString(5);
                string CarOrigPic3 = reader.GetString(6);
                string CarOrigPic4 = reader.GetString(7);
                string CarDarkPic1 = reader.GetString(8);
                string CarDarkPic2 = reader.GetString(9);
                string CarDarkPic3 = reader.GetString(10);
                string CarDarkPic4 = reader.GetString(11);
                string ChoosePic = reader.GetString(12);

                // установка значений свойств формы CarCheckoutForm на основе данных о машине
                newForm.Car.Text = CarName;
                newForm.Specs.Text = CarSpecs;
                newForm.Rating.Text = CarRating;
                newForm.Price.Text = CarPrice;
                newForm.originalImage1 = Image.FromFile(CarOrigPic1);
                newForm.originalImage2 = Image.FromFile(CarOrigPic2);
                newForm.originalImage3 = Image.FromFile(CarOrigPic3);
                newForm.originalImage4 = Image.FromFile(CarOrigPic4);
                newForm.darkenedImage1 = Image.FromFile(CarDarkPic1);
                newForm.darkenedImage2 = Image.FromFile(CarDarkPic2);
                newForm.darkenedImage3 = Image.FromFile(CarDarkPic3);
                newForm.darkenedImage4 = Image.FromFile(CarDarkPic4);
                newForm.ImageCar = Image.FromFile(ChoosePic);
            }
            reader.Close();
            DB.Close();
            Close();
            newForm.Show();
        }
        #endregion
        // обработчик события нажатия кнопки DaewooButton
        private void DaewooButton_Click(object sender, EventArgs e)
        {
            ShowCar(3);
        }

        // обработчик события нажатия кнопки ScodaButton
        private void ScodaButton_Click(object sender, EventArgs e)
        {
            ShowCar(2);
        }

        // обработчик события нажатия кнопки ToyotaButton
        private void ToyotaButton_Click(object sender, EventArgs e)
        {
            ShowCar(1);
        }
    }
}
