namespace AutoFy
{
    partial class CarRentForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CarRentForm));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.ChooseAnotherCar = new System.Windows.Forms.Button();
            this.InfoBox = new System.Windows.Forms.PictureBox();
            this.RentButton = new System.Windows.Forms.Button();
            this.MinimizeButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.HourText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.NameCarLab = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InfoBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, -2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(900, 50);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox2_MouseDown);
            this.pictureBox2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox2_MouseMove);
            // 
            // ChooseAnotherCar
            // 
            this.ChooseAnotherCar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ChooseAnotherCar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChooseAnotherCar.Location = new System.Drawing.Point(12, 116);
            this.ChooseAnotherCar.Name = "ChooseAnotherCar";
            this.ChooseAnotherCar.Size = new System.Drawing.Size(760, 141);
            this.ChooseAnotherCar.TabIndex = 6;
            this.ChooseAnotherCar.UseVisualStyleBackColor = true;
            this.ChooseAnotherCar.Click += new System.EventHandler(this.ChooseAnotherCar_Click);
            // 
            // InfoBox
            // 
            this.InfoBox.Image = ((System.Drawing.Image)(resources.GetObject("InfoBox.Image")));
            this.InfoBox.Location = new System.Drawing.Point(305, 282);
            this.InfoBox.Name = "InfoBox";
            this.InfoBox.Size = new System.Drawing.Size(193, 66);
            this.InfoBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.InfoBox.TabIndex = 7;
            this.InfoBox.TabStop = false;
            // 
            // RentButton
            // 
            this.RentButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RentButton.Image = ((System.Drawing.Image)(resources.GetObject("RentButton.Image")));
            this.RentButton.Location = new System.Drawing.Point(300, 481);
            this.RentButton.Name = "RentButton";
            this.RentButton.Size = new System.Drawing.Size(198, 42);
            this.RentButton.TabIndex = 9;
            this.RentButton.UseVisualStyleBackColor = true;
            this.RentButton.Click += new System.EventHandler(this.RentButton_Click);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(8, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(768, 24);
            this.label1.TabIndex = 22;
            this.label1.Text = "Можете перейти к оплате текущего автомобиля или выбрать другой нажав на него";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // HourText
            // 
            this.HourText.Location = new System.Drawing.Point(352, 318);
            this.HourText.Name = "HourText";
            this.HourText.Size = new System.Drawing.Size(100, 20);
            this.HourText.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(332, 302);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Введите количество часов";
            // 
            // NameCarLab
            // 
            this.NameCarLab.AutoSize = true;
            this.NameCarLab.Location = new System.Drawing.Point(653, 483);
            this.NameCarLab.Name = "NameCarLab";
            this.NameCarLab.Size = new System.Drawing.Size(25, 13);
            this.NameCarLab.TabIndex = 25;
            this.NameCarLab.Text = "123";
            this.NameCarLab.Visible = false;
            // 
            // CarRentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.NameCarLab);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.HourText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MinimizeButton);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.RentButton);
            this.Controls.Add(this.InfoBox);
            this.Controls.Add(this.ChooseAnotherCar);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CarRentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form5";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InfoBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox InfoBox;
        private System.Windows.Forms.Button RentButton;
        private System.Windows.Forms.Button MinimizeButton;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button ChooseAnotherCar;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        public System.Windows.Forms.TextBox HourText;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label NameCarLab;
    }
}