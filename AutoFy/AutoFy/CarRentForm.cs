using System;
using System.Drawing;
using System.Windows.Forms;

namespace AutoFy
{
    public partial class CarRentForm : Form
    {

        public CarRentForm()
        {
            InitializeComponent();
        }
        private void Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            Close();
        }
        private void ChooseAnotherCar_Click(object sender, EventArgs e)
        {
            ChooseCarForm newForm = new ChooseCarForm();
            Close();
            newForm.Show();
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

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void RentButton_Click(object sender, EventArgs e)
        {
            PaymentForm newForm = new PaymentForm();
            // передача информации о выбранном автомобиле и количестве часов аренды на новую форму
            newForm.HourLab.Text = HourText.Text;
            newForm.CarNameLab.Text = NameCarLab.Text;
            newForm.FormClosed += new FormClosedEventHandler(Form_FormClosed);
            Close();
            newForm.Show();
        }
    }
}
