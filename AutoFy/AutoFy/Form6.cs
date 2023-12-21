using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AutoFy
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text) || string.IsNullOrEmpty(textBox3.Text) || string.IsNullOrEmpty(textBox4.Text) || string.IsNullOrEmpty(textBox5.Text))
                MessageBox.Show("Заполните все поля!");
            else
                MessageBox.Show("Оплата прошла успешно!");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {           
            string text = textBox1.Text.Replace(" ", "");
            if (text.Length > 0)
            {
                StringBuilder newText = new StringBuilder(text);
                for (int i = 4; i < newText.Length; i += 5)
                {
                    newText.Insert(i, " ");
                }
                textBox1.Text = newText.ToString();
                textBox1.SelectionStart = newText.Length;
            }
        }
        int maxValue = 12;
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        if (int.TryParse(textBox3.Text,out int value) && value > maxValue)
                textBox3.Text=maxValue.ToString();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != '\b') 
                e.Handled= true;
        }
    }
}
