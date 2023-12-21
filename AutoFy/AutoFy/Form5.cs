using System;
using System.Drawing;
using System.Windows.Forms;

namespace AutoFy
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ChooseCarForm newForm = new ChooseCarForm();
            this.Close();
            newForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Form6 newForm = new Form6();
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
        Point LastPoint;
        private void pictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
            LastPoint = new Point(e.X, e.Y);
        }

        private void pictureBox2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - LastPoint.X;
                this.Top += e.Y - LastPoint.Y;
            }
        }
    }
}
