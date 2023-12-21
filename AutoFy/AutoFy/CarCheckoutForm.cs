using System;
using System.Data.SQLite;
using System.Drawing;
using System.Windows.Forms;
namespace AutoFy
{
    public partial class CarCheckoutForm : Form
    {
        public CarCheckoutForm()
        {
            InitializeComponent();
        }
        // поля для хранения оригинальных и затемненных изображений автомобилей
        public Image originalImage1;
        public Image originalImage2;
        public Image originalImage3;
        public Image originalImage4;
        public Image darkenedImage1;
        public Image darkenedImage2;
        public Image darkenedImage3;
        public Image darkenedImage4;
        public Image ImageCar;
        // объявление переменной типа SQLiteConnection
        private SQLiteConnection DB;
        private async void CarCheckoutForm_Load(object sender, EventArgs e)
        {
            // создание экземпляра класса SQLiteConnection с параметрами подключения к базе данных
            DB = new SQLiteConnection(Database.connection);
            // асинхронное открытие соединения с базой данных
            await DB.OpenAsync();
            // установка оригинальных изображений на панель с изображениями автомобилей
            CarPicture1.Image = originalImage1;
            CarPicture2.Image = originalImage1;
            CarPicture3.Image = originalImage2;
            CarPicture4.Image = originalImage3;
            CarPicture5.Image = originalImage4;
        }
        private void Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            Close();
        }
        public CarCheckoutForm(string imageChange1)
        {
            InitializeComponent();
            // загрузка главного изображения
            CarPicture1.Image = Image.FromFile(imageChange1);
        }
        #region PictureChange
        // обработчики событий нажатия кнопок мыши на изображениях автомобилей
        private void CarPicture2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            
                CarPicture1.Image = (Image)originalImage1.Clone();
            
        }
        private void CarPicture3_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            
                CarPicture1.Image = (Image)originalImage2.Clone();
            
        }
        private void CarPicture5_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            
                CarPicture1.Image = (Image)originalImage4.Clone();
            
        }
        private void CarPicture4_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            
                CarPicture1.Image = (Image)originalImage3.Clone();
            
        }
        #endregion
        #region MouseMove
        // объявление переменной типа Point
        private Point LastPoint;
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
        private void pictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
            // сохранение текущей позиции мыши
            LastPoint = new Point(e.X, e.Y);
        }
        #endregion
        #region MouseEnter
        // обработчики событий наведения курсора мыши на изображения автомобилей
        private void CarPicture2_MouseEnter(object sender, EventArgs e)
        {
            CarPicture2.Image = darkenedImage1;
        }
        private void CarPicture3_MouseEnter(object sender, EventArgs e)
        {
            CarPicture3.Image = darkenedImage2;
        }
        private void CarPicture4_MouseEnter(object sender, EventArgs e)
        {
            CarPicture4.Image = darkenedImage3;
        }
        private void CarPicture5_MouseEnter(object sender, EventArgs e)
        {
            CarPicture5.Image = darkenedImage4;
        }
        #endregion
        #region MouseLeave
        // обработчики событий ухода курсора мыши с изображений автомобилей
        private void CarPicture2_MouseLeave(object sender, EventArgs e)
        {
            CarPicture2.Image = originalImage1;
        }
        private void CarPicture3_MouseLeave(object sender, EventArgs e)
        {
            CarPicture3.Image = originalImage2;
        }
        private void CarPicture5_MouseLeave(object sender, EventArgs e)
        {
            CarPicture5.Image = originalImage4;
        }
        private void CarPicture4_MouseLeave(object sender, EventArgs e)
        {
            CarPicture4.Image = originalImage3;
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
        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            CarRentForm newForm = new CarRentForm();
            // передача информации о выбранном автомобиле на новую форму
            newForm.NameCarLab.Text = Car.Text;
            newForm.ChooseAnotherCar.Image = ImageCar;
            newForm.FormClosed += new FormClosedEventHandler(Form_FormClosed);
            newForm.Show();
            Close();
        }
    }
}