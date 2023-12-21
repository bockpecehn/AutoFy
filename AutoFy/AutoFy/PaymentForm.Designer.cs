namespace AutoFy
{
    partial class PaymentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaymentForm));
            this.PictureLogo = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TotalLabel = new System.Windows.Forms.Label();
            this.SecurityCode = new System.Windows.Forms.TextBox();
            this.Year = new System.Windows.Forms.TextBox();
            this.Month = new System.Windows.Forms.TextBox();
            this.CardHolder = new System.Windows.Forms.TextBox();
            this.CardNumber = new System.Windows.Forms.TextBox();
            this.PayButton = new System.Windows.Forms.Button();
            this.CardPicture = new System.Windows.Forms.PictureBox();
            this.MinimizeButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.HourLab = new System.Windows.Forms.Label();
            this.CarNameLab = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PictureLogo)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CardPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // PictureLogo
            // 
            this.PictureLogo.Image = ((System.Drawing.Image)(resources.GetObject("PictureLogo.Image")));
            this.PictureLogo.Location = new System.Drawing.Point(0, -2);
            this.PictureLogo.Name = "PictureLogo";
            this.PictureLogo.Size = new System.Drawing.Size(900, 50);
            this.PictureLogo.TabIndex = 2;
            this.PictureLogo.TabStop = false;
            this.PictureLogo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox2_MouseDown);
            this.PictureLogo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox2_MouseMove);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Controls.Add(this.TotalLabel);
            this.panel1.Controls.Add(this.SecurityCode);
            this.panel1.Controls.Add(this.Year);
            this.panel1.Controls.Add(this.Month);
            this.panel1.Controls.Add(this.CardHolder);
            this.panel1.Controls.Add(this.CardNumber);
            this.panel1.Controls.Add(this.PayButton);
            this.panel1.Controls.Add(this.CardPicture);
            this.panel1.Location = new System.Drawing.Point(59, 96);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(667, 410);
            this.panel1.TabIndex = 3;
            // 
            // TotalLabel
            // 
            this.TotalLabel.AutoSize = true;
            this.TotalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TotalLabel.Location = new System.Drawing.Point(231, 49);
            this.TotalLabel.Name = "TotalLabel";
            this.TotalLabel.Size = new System.Drawing.Size(161, 25);
            this.TotalLabel.TabIndex = 7;
            this.TotalLabel.Text = "Итого к оплате:";
            // 
            // SecurityCode
            // 
            this.SecurityCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.SecurityCode.Location = new System.Drawing.Point(401, 220);
            this.SecurityCode.MaxLength = 4;
            this.SecurityCode.Name = "SecurityCode";
            this.SecurityCode.PasswordChar = '*';
            this.SecurityCode.Size = new System.Drawing.Size(33, 20);
            this.SecurityCode.TabIndex = 6;
            this.SecurityCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SecurityCode_KeyPress);
            // 
            // Year
            // 
            this.Year.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.Year.Location = new System.Drawing.Point(277, 222);
            this.Year.MaxLength = 2;
            this.Year.Name = "Year";
            this.Year.Size = new System.Drawing.Size(26, 20);
            this.Year.TabIndex = 5;
            this.Year.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Year_KeyPress);
            // 
            // Month
            // 
            this.Month.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.Month.Location = new System.Drawing.Point(230, 222);
            this.Month.MaxLength = 2;
            this.Month.Name = "Month";
            this.Month.Size = new System.Drawing.Size(26, 20);
            this.Month.TabIndex = 4;
            this.Month.TextChanged += new System.EventHandler(this.Month_TextChanged);
            this.Month.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Month_KeyPress);
            // 
            // CardHolder
            // 
            this.CardHolder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.CardHolder.Location = new System.Drawing.Point(230, 179);
            this.CardHolder.Name = "CardHolder";
            this.CardHolder.Size = new System.Drawing.Size(205, 20);
            this.CardHolder.TabIndex = 3;
            // 
            // CardNumber
            // 
            this.CardNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.CardNumber.Location = new System.Drawing.Point(230, 137);
            this.CardNumber.MaxLength = 19;
            this.CardNumber.Name = "CardNumber";
            this.CardNumber.Size = new System.Drawing.Size(205, 20);
            this.CardNumber.TabIndex = 2;
            this.CardNumber.TextChanged += new System.EventHandler(this.CardNumber_TextChanged);
            this.CardNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CardNumber_KeyPress);
            // 
            // PayButton
            // 
            this.PayButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PayButton.FlatAppearance.BorderSize = 0;
            this.PayButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PayButton.Image = ((System.Drawing.Image)(resources.GetObject("PayButton.Image")));
            this.PayButton.Location = new System.Drawing.Point(236, 292);
            this.PayButton.Name = "PayButton";
            this.PayButton.Size = new System.Drawing.Size(210, 51);
            this.PayButton.TabIndex = 1;
            this.PayButton.UseVisualStyleBackColor = true;
            this.PayButton.Click += new System.EventHandler(this.PayButton_Click);
            // 
            // CardPicture
            // 
            this.CardPicture.Image = ((System.Drawing.Image)(resources.GetObject("CardPicture.Image")));
            this.CardPicture.Location = new System.Drawing.Point(208, 107);
            this.CardPicture.Name = "CardPicture";
            this.CardPicture.Size = new System.Drawing.Size(258, 150);
            this.CardPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.CardPicture.TabIndex = 0;
            this.CardPicture.TabStop = false;
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
            this.MinimizeButton.TabIndex = 21;
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
            this.CloseButton.TabIndex = 20;
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // HourLab
            // 
            this.HourLab.AutoSize = true;
            this.HourLab.Location = new System.Drawing.Point(731, 520);
            this.HourLab.Name = "HourLab";
            this.HourLab.Size = new System.Drawing.Size(0, 13);
            this.HourLab.TabIndex = 23;
            this.HourLab.Visible = false;
            // 
            // CarNameLab
            // 
            this.CarNameLab.AutoSize = true;
            this.CarNameLab.CausesValidation = false;
            this.CarNameLab.Location = new System.Drawing.Point(643, 545);
            this.CarNameLab.Name = "CarNameLab";
            this.CarNameLab.Size = new System.Drawing.Size(35, 13);
            this.CarNameLab.TabIndex = 24;
            this.CarNameLab.Text = "label1";
            // 
            // PaymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.CarNameLab);
            this.Controls.Add(this.HourLab);
            this.Controls.Add(this.MinimizeButton);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PictureLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PaymentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "     ";
            ((System.ComponentModel.ISupportInitialize)(this.PictureLogo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CardPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PictureLogo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button PayButton;
        private System.Windows.Forms.PictureBox CardPicture;
        private System.Windows.Forms.TextBox SecurityCode;
        private System.Windows.Forms.TextBox Year;
        private System.Windows.Forms.TextBox Month;
        private System.Windows.Forms.TextBox CardHolder;
        private System.Windows.Forms.TextBox CardNumber;
        private System.Windows.Forms.Label TotalLabel;
        private System.Windows.Forms.Button MinimizeButton;
        private System.Windows.Forms.Button CloseButton;
        public System.Windows.Forms.Label HourLab;
        public System.Windows.Forms.Label CarNameLab;
    }
}