using System;
using System.Drawing;
using System.Windows.Forms;

namespace AutoFy
{
    public partial class CarCheckout : Form
    {
        public CarCheckout()
        {
            InitializeComponent();
        }

        public CarCheckout(string imageChange1)
        {
            InitializeComponent();
            pictureBox1.Image = Image.FromFile(imageChange1);
        }

        private void Form4_Load(object sender, EventArgs e)
        {
         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form5 newForm = new Form5();
            this.Close();
            newForm.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            LoginForm oldForm = new LoginForm();
            this.Close();
            oldForm.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox3_MouseDown(object sender, MouseEventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            if (e.Button == MouseButtons.Left)
                pictureBox1.Image = (Image)pictureBox3.Image.Clone();
        }

        private void pictureBox6_MouseDown(object sender, MouseEventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            if (e.Button == MouseButtons.Left)
                pictureBox1.Image = (Image)pictureBox6.Image.Clone();
        }

        private void pictureBox5_MouseDown(object sender, MouseEventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            if (e.Button == MouseButtons.Left)
                pictureBox1.Image = (Image)pictureBox5.Image.Clone();
        }

        private void pictureBox4_MouseDown(object sender, MouseEventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            if (e.Button == MouseButtons.Left)
                pictureBox1.Image = (Image)pictureBox4.Image.Clone();
        }

        Point LastPoint;
        private void pictureBox2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - LastPoint.X;
                this.Top += e.Y - LastPoint.Y;
            }
        }

        private void pictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
            LastPoint = new Point(e.X, e.Y);
        }

        private void pictureBox3_MouseEnter(object sender, EventArgs e)
        {
            Image newImage = Image.FromFile(@"G:\AutoFy\AutoFy\Пикчерс\image 6 dark.png");
            pictureBox3.Image = newImage;
        }

        private void pictureBox6_MouseEnter(object sender, EventArgs e)
        {
            Image newImage = Image.FromFile(@"G:\AutoFy\AutoFy\Пикчерс\image 8 dark.png");
            pictureBox6.Image = newImage;
        }

        private void pictureBox4_MouseEnter(object sender, EventArgs e)
        {
            Image newImage = Image.FromFile(@"G:\AutoFy\AutoFy\Пикчерс\image 10 dark.png");
            pictureBox4.Image = newImage;
        }

        private void pictureBox5_MouseEnter(object sender, EventArgs e)
        {
            Image newImage = Image.FromFile(@"G:\AutoFy\AutoFy\Пикчерс\image 9 dark.png");
            pictureBox5.Image = newImage;
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            pictureBox3.Image = Image.FromFile(@"G:\AutoFy\AutoFy\Пикчерс\image 6.png");
        }

        private void pictureBox6_MouseLeave(object sender, EventArgs e)
        {
            pictureBox6.Image = Image.FromFile(@"G:\AutoFy\AutoFy\Пикчерс\image 8.png");
        }

        private void pictureBox5_MouseLeave(object sender, EventArgs e)
        {
            pictureBox5.Image = Image.FromFile(@"G:\AutoFy\AutoFy\Пикчерс\image 9.png");
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            pictureBox4.Image = Image.FromFile(@"G:\AutoFy\AutoFy\Пикчерс\image 10.png");
        }
    }
}