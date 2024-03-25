namespace AutoFy
{
    partial class SignupForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignupForm));
            this.PictureLogo = new System.Windows.Forms.PictureBox();
            this.CarsPicture = new System.Windows.Forms.PictureBox();
            this.UserPassword = new System.Windows.Forms.TextBox();
            this.ContinueButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.MinimizeButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.UserPhoneNumber = new System.Windows.Forms.MaskedTextBox();
            this.ContactsLabel = new System.Windows.Forms.Label();
            this.ContactsButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.UserName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.UserSurname = new System.Windows.Forms.TextBox();
            this.AutoTestBut = new System.Windows.Forms.Button();
            this.DelBut = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PictureLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CarsPicture)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PictureLogo
            // 
            this.PictureLogo.Image = ((System.Drawing.Image)(resources.GetObject("PictureLogo.Image")));
            this.PictureLogo.Location = new System.Drawing.Point(0, -2);
            this.PictureLogo.Name = "PictureLogo";
            this.PictureLogo.Size = new System.Drawing.Size(900, 50);
            this.PictureLogo.TabIndex = 0;
            this.PictureLogo.TabStop = false;
            this.PictureLogo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.PictureLogo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // CarsPicture
            // 
            this.CarsPicture.Image = ((System.Drawing.Image)(resources.GetObject("CarsPicture.Image")));
            this.CarsPicture.Location = new System.Drawing.Point(-78, 49);
            this.CarsPicture.Name = "CarsPicture";
            this.CarsPicture.Size = new System.Drawing.Size(458, 518);
            this.CarsPicture.TabIndex = 1;
            this.CarsPicture.TabStop = false;
            // 
            // UserPassword
            // 
            this.UserPassword.Location = new System.Drawing.Point(44, 317);
            this.UserPassword.Name = "UserPassword";
            this.UserPassword.Size = new System.Drawing.Size(320, 20);
            this.UserPassword.TabIndex = 3;
            // 
            // ContinueButton
            // 
            this.ContinueButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ContinueButton.FlatAppearance.BorderSize = 0;
            this.ContinueButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ContinueButton.Image = ((System.Drawing.Image)(resources.GetObject("ContinueButton.Image")));
            this.ContinueButton.Location = new System.Drawing.Point(102, 402);
            this.ContinueButton.Name = "ContinueButton";
            this.ContinueButton.Size = new System.Drawing.Size(200, 45);
            this.ContinueButton.TabIndex = 5;
            this.ContinueButton.UseVisualStyleBackColor = true;
            this.ContinueButton.Click += new System.EventHandler(this.ContinueButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(41, 231);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Номер телефона";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(40, 294);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Придумайте пароль";
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
            this.MinimizeButton.TabIndex = 15;
            this.MinimizeButton.UseVisualStyleBackColor = false;
            this.MinimizeButton.Click += new System.EventHandler(this.MinimizeButton_Click);
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
            this.CloseButton.TabIndex = 14;
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.UserPhoneNumber);
            this.panel1.Controls.Add(this.ContactsLabel);
            this.panel1.Controls.Add(this.ContactsButton);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.UserName);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.UserSurname);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.ContinueButton);
            this.panel1.Controls.Add(this.UserPassword);
            this.panel1.Location = new System.Drawing.Point(376, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(411, 610);
            this.panel1.TabIndex = 16;
            // 
            // UserPhoneNumber
            // 
            this.UserPhoneNumber.Location = new System.Drawing.Point(44, 254);
            this.UserPhoneNumber.Mask = "89990000000";
            this.UserPhoneNumber.Name = "UserPhoneNumber";
            this.UserPhoneNumber.Size = new System.Drawing.Size(320, 20);
            this.UserPhoneNumber.TabIndex = 19;
            // 
            // ContactsLabel
            // 
            this.ContactsLabel.AutoSize = true;
            this.ContactsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.ContactsLabel.Location = new System.Drawing.Point(40, 477);
            this.ContactsLabel.Name = "ContactsLabel";
            this.ContactsLabel.Size = new System.Drawing.Size(234, 20);
            this.ContactsLabel.TabIndex = 18;
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
            this.ContactsButton.TabIndex = 17;
            this.ContactsButton.UseVisualStyleBackColor = true;
            this.ContactsButton.Click += new System.EventHandler(this.ContactsButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(41, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Имя";
            // 
            // UserName
            // 
            this.UserName.Location = new System.Drawing.Point(44, 125);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(320, 20);
            this.UserName.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(40, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Фамилия";
            // 
            // UserSurname
            // 
            this.UserSurname.Location = new System.Drawing.Point(44, 186);
            this.UserSurname.Name = "UserSurname";
            this.UserSurname.Size = new System.Drawing.Size(320, 20);
            this.UserSurname.TabIndex = 8;
            // 
            // AutoTestBut
            // 
            this.AutoTestBut.Location = new System.Drawing.Point(498, 15);
            this.AutoTestBut.Name = "AutoTestBut";
            this.AutoTestBut.Size = new System.Drawing.Size(75, 23);
            this.AutoTestBut.TabIndex = 17;
            this.AutoTestBut.Text = "Автотест";
            this.AutoTestBut.UseVisualStyleBackColor = true;
            this.AutoTestBut.Click += new System.EventHandler(this.AutoTestBut_Click);
            // 
            // DelBut
            // 
            this.DelBut.Location = new System.Drawing.Point(588, 15);
            this.DelBut.Name = "DelBut";
            this.DelBut.Size = new System.Drawing.Size(75, 23);
            this.DelBut.TabIndex = 18;
            this.DelBut.Text = "Удалить";
            this.DelBut.UseVisualStyleBackColor = true;
            this.DelBut.Visible = false;
            this.DelBut.Click += new System.EventHandler(this.DelBut_Click);
            // 
            // SignupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.DelBut);
            this.Controls.Add(this.AutoTestBut);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.MinimizeButton);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.CarsPicture);
            this.Controls.Add(this.PictureLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SignupForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Регистрация";
            this.Load += new System.EventHandler(this.SignupForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CarsPicture)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PictureLogo;
        private System.Windows.Forms.PictureBox CarsPicture;
        private System.Windows.Forms.TextBox UserPassword;
        private System.Windows.Forms.Button ContinueButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button MinimizeButton;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox UserName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox UserSurname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label ContactsLabel;
        private System.Windows.Forms.Button ContactsButton;
        private System.Windows.Forms.MaskedTextBox UserPhoneNumber;
        private System.Windows.Forms.Button AutoTestBut;
        private System.Windows.Forms.Button DelBut;
    }
}