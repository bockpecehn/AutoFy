
namespace AutoFy
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        
        
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.CarsPicture = new System.Windows.Forms.PictureBox();
            this.PictureLogo = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.LogInButton = new System.Windows.Forms.Button();
            this.SignUpButton = new System.Windows.Forms.Button();
            this.OrLabel = new System.Windows.Forms.Label();
            this.NumberLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.ShowPass = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.MinimizeButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PhoneNumber = new System.Windows.Forms.MaskedTextBox();
            this.ContactsLabel = new System.Windows.Forms.Label();
            this.ContactsButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CarsPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CarsPicture
            // 
            this.CarsPicture.Image = ((System.Drawing.Image)(resources.GetObject("CarsPicture.Image")));
            this.CarsPicture.Location = new System.Drawing.Point(-78, 48);
            this.CarsPicture.Name = "CarsPicture";
            this.CarsPicture.Size = new System.Drawing.Size(458, 518);
            this.CarsPicture.TabIndex = 0;
            this.CarsPicture.TabStop = false;
            // 
            // PictureLogo
            // 
            this.PictureLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.PictureLogo.Image = ((System.Drawing.Image)(resources.GetObject("PictureLogo.Image")));
            this.PictureLogo.Location = new System.Drawing.Point(0, -2);
            this.PictureLogo.Name = "PictureLogo";
            this.PictureLogo.Size = new System.Drawing.Size(223, 50);
            this.PictureLogo.TabIndex = 1;
            this.PictureLogo.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(0, -2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(1106, 50);
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox3_MouseDown);
            this.pictureBox3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox3_MouseMove);
            // 
            // Password
            // 
            this.Password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.Password.Location = new System.Drawing.Point(44, 204);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(320, 21);
            this.Password.TabIndex = 5;
            this.Password.UseSystemPasswordChar = true;
            // 
            // LogInButton
            // 
            this.LogInButton.AutoSize = true;
            this.LogInButton.BackColor = System.Drawing.Color.White;
            this.LogInButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogInButton.FlatAppearance.BorderSize = 0;
            this.LogInButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogInButton.Image = ((System.Drawing.Image)(resources.GetObject("LogInButton.Image")));
            this.LogInButton.Location = new System.Drawing.Point(104, 290);
            this.LogInButton.Name = "LogInButton";
            this.LogInButton.Size = new System.Drawing.Size(206, 51);
            this.LogInButton.TabIndex = 6;
            this.LogInButton.TabStop = false;
            this.LogInButton.UseVisualStyleBackColor = false;
            this.LogInButton.Click += new System.EventHandler(this.LogInButton_Click);
            // 
            // SignUpButton
            // 
            this.SignUpButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SignUpButton.FlatAppearance.BorderSize = 0;
            this.SignUpButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SignUpButton.Image = ((System.Drawing.Image)(resources.GetObject("SignUpButton.Image")));
            this.SignUpButton.Location = new System.Drawing.Point(104, 366);
            this.SignUpButton.Name = "SignUpButton";
            this.SignUpButton.Size = new System.Drawing.Size(206, 50);
            this.SignUpButton.TabIndex = 7;
            this.SignUpButton.UseVisualStyleBackColor = true;
            this.SignUpButton.Click += new System.EventHandler(this.SignUpButton_Click);
            // 
            // OrLabel
            // 
            this.OrLabel.AutoSize = true;
            this.OrLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.OrLabel.Location = new System.Drawing.Point(181, 343);
            this.OrLabel.Name = "OrLabel";
            this.OrLabel.Size = new System.Drawing.Size(46, 20);
            this.OrLabel.TabIndex = 8;
            this.OrLabel.Text = "ИЛИ";
            // 
            // NumberLabel
            // 
            this.NumberLabel.AutoSize = true;
            this.NumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.NumberLabel.Location = new System.Drawing.Point(40, 122);
            this.NumberLabel.Name = "NumberLabel";
            this.NumberLabel.Size = new System.Drawing.Size(156, 20);
            this.NumberLabel.TabIndex = 9;
            this.NumberLabel.Text = "Номер телефона";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.PasswordLabel.Location = new System.Drawing.Point(40, 182);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(149, 20);
            this.PasswordLabel.TabIndex = 10;
            this.PasswordLabel.Text = "Введите пароль";
            // 
            // ShowPass
            // 
            this.ShowPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.ShowPass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ShowPass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ShowPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShowPass.Image = ((System.Drawing.Image)(resources.GetObject("ShowPass.Image")));
            this.ShowPass.Location = new System.Drawing.Point(330, 204);
            this.ShowPass.Name = "ShowPass";
            this.ShowPass.Size = new System.Drawing.Size(34, 21);
            this.ShowPass.TabIndex = 11;
            this.ShowPass.UseVisualStyleBackColor = false;
            this.ShowPass.Click += new System.EventHandler(this.ShowPass_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CloseButton.BackgroundImage")));
            this.CloseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.CloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseButton.FlatAppearance.BorderSize = 0;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.Location = new System.Drawing.Point(742, 8);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(30, 30);
            this.CloseButton.TabIndex = 12;
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // MinimizeButton
            // 
            this.MinimizeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.MinimizeButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MinimizeButton.BackgroundImage")));
            this.MinimizeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.MinimizeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MinimizeButton.FlatAppearance.BorderSize = 0;
            this.MinimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinimizeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.MinimizeButton.Location = new System.Drawing.Point(707, 8);
            this.MinimizeButton.Name = "MinimizeButton";
            this.MinimizeButton.Size = new System.Drawing.Size(29, 30);
            this.MinimizeButton.TabIndex = 13;
            this.MinimizeButton.UseVisualStyleBackColor = false;
            this.MinimizeButton.Click += new System.EventHandler(this.MinimizeButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.PhoneNumber);
            this.panel1.Controls.Add(this.ContactsLabel);
            this.panel1.Controls.Add(this.ContactsButton);
            this.panel1.Controls.Add(this.ShowPass);
            this.panel1.Controls.Add(this.PasswordLabel);
            this.panel1.Controls.Add(this.NumberLabel);
            this.panel1.Controls.Add(this.OrLabel);
            this.panel1.Controls.Add(this.SignUpButton);
            this.panel1.Controls.Add(this.LogInButton);
            this.panel1.Controls.Add(this.Password);
            this.panel1.Location = new System.Drawing.Point(377, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(407, 514);
            this.panel1.TabIndex = 14;
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.PhoneNumber.ForeColor = System.Drawing.SystemColors.WindowText;
            this.PhoneNumber.Location = new System.Drawing.Point(44, 144);
            this.PhoneNumber.Mask = "89990000000";
            this.PhoneNumber.Name = "PhoneNumber";
            this.PhoneNumber.Size = new System.Drawing.Size(320, 20);
            this.PhoneNumber.TabIndex = 14;
            // 
            // ContactsLabel
            // 
            this.ContactsLabel.AutoSize = true;
            this.ContactsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.ContactsLabel.Location = new System.Drawing.Point(40, 477);
            this.ContactsLabel.Name = "ContactsLabel";
            this.ContactsLabel.Size = new System.Drawing.Size(234, 20);
            this.ContactsLabel.TabIndex = 13;
            this.ContactsLabel.Text = "Хотите связаться с нами?";
            // 
            // ContactsButton
            // 
            this.ContactsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ContactsButton.FlatAppearance.BorderSize = 0;
            this.ContactsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ContactsButton.Image = ((System.Drawing.Image)(resources.GetObject("ContactsButton.Image")));
            this.ContactsButton.Location = new System.Drawing.Point(286, 475);
            this.ContactsButton.Name = "ContactsButton";
            this.ContactsButton.Size = new System.Drawing.Size(109, 26);
            this.ContactsButton.TabIndex = 12;
            this.ContactsButton.UseVisualStyleBackColor = true;
            this.ContactsButton.Click += new System.EventHandler(this.ContactsButton_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.MinimizeButton);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.PictureLogo);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.CarsPicture);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AutoFy.";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CarsPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox CarsPicture;
        private System.Windows.Forms.PictureBox PictureLogo;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Button LogInButton;
        private System.Windows.Forms.Button SignUpButton;
        private System.Windows.Forms.Label OrLabel;
        private System.Windows.Forms.Label NumberLabel;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Button ShowPass;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button MinimizeButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label ContactsLabel;
        private System.Windows.Forms.Button ContactsButton;
        private System.Windows.Forms.MaskedTextBox PhoneNumber;
    }
}