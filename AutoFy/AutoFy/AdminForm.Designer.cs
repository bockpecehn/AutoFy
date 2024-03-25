namespace AutoFy
{
    partial class AdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AddCarName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.EngineCar = new System.Windows.Forms.Label();
            this.PowerCar = new System.Windows.Forms.Label();
            this.TransmissionCar = new System.Windows.Forms.Label();
            this.DriveUnitCar = new System.Windows.Forms.Label();
            this.ColorCar = new System.Windows.Forms.Label();
            this.VINCodeCar = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.AddCarRat = new System.Windows.Forms.TextBox();
            this.AddCarPrice = new System.Windows.Forms.TextBox();
            this.AddCar = new System.Windows.Forms.Button();
            this.EngineText = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.PowerText = new System.Windows.Forms.TextBox();
            this.TransmissionText = new System.Windows.Forms.TextBox();
            this.DriveUnitText = new System.Windows.Forms.TextBox();
            this.ColorText = new System.Windows.Forms.TextBox();
            this.VINCodeText = new System.Windows.Forms.TextBox();
            this.MinimizeButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.ATBut = new System.Windows.Forms.Button();
            this.DelBut = new System.Windows.Forms.Button();
            this.DBCloneBut = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(900, 50);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label1.Location = new System.Drawing.Point(25, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Напишите название авто";
            // 
            // AddCarName
            // 
            this.AddCarName.Location = new System.Drawing.Point(29, 112);
            this.AddCarName.Name = "AddCarName";
            this.AddCarName.Size = new System.Drawing.Size(309, 20);
            this.AddCarName.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(25, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(452, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Добавьте описание и технические характеристики  ";
            // 
            // EngineCar
            // 
            this.EngineCar.AutoSize = true;
            this.EngineCar.Location = new System.Drawing.Point(28, 174);
            this.EngineCar.Name = "EngineCar";
            this.EngineCar.Size = new System.Drawing.Size(65, 13);
            this.EngineCar.TabIndex = 9;
            this.EngineCar.Text = "Двигатель:";
            // 
            // PowerCar
            // 
            this.PowerCar.AutoSize = true;
            this.PowerCar.Location = new System.Drawing.Point(28, 200);
            this.PowerCar.Name = "PowerCar";
            this.PowerCar.Size = new System.Drawing.Size(63, 13);
            this.PowerCar.TabIndex = 10;
            this.PowerCar.Text = "Мощность:";
            // 
            // TransmissionCar
            // 
            this.TransmissionCar.AutoSize = true;
            this.TransmissionCar.Location = new System.Drawing.Point(28, 226);
            this.TransmissionCar.Name = "TransmissionCar";
            this.TransmissionCar.Size = new System.Drawing.Size(102, 13);
            this.TransmissionCar.TabIndex = 11;
            this.TransmissionCar.Text = "Коробчка передач:";
            // 
            // DriveUnitCar
            // 
            this.DriveUnitCar.AutoSize = true;
            this.DriveUnitCar.Location = new System.Drawing.Point(28, 252);
            this.DriveUnitCar.Name = "DriveUnitCar";
            this.DriveUnitCar.Size = new System.Drawing.Size(48, 13);
            this.DriveUnitCar.TabIndex = 12;
            this.DriveUnitCar.Text = "Привод:";
            // 
            // ColorCar
            // 
            this.ColorCar.AutoSize = true;
            this.ColorCar.Location = new System.Drawing.Point(29, 278);
            this.ColorCar.Name = "ColorCar";
            this.ColorCar.Size = new System.Drawing.Size(35, 13);
            this.ColorCar.TabIndex = 14;
            this.ColorCar.Text = "Цвет:";
            // 
            // VINCodeCar
            // 
            this.VINCodeCar.AutoSize = true;
            this.VINCodeCar.Location = new System.Drawing.Point(29, 303);
            this.VINCodeCar.Name = "VINCodeCar";
            this.VINCodeCar.Size = new System.Drawing.Size(50, 13);
            this.VINCodeCar.TabIndex = 18;
            this.VINCodeCar.Text = "VIN-Код:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label13.Location = new System.Drawing.Point(27, 418);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(71, 20);
            this.label13.TabIndex = 19;
            this.label13.Text = "Оценка";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label14.Location = new System.Drawing.Point(28, 472);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(102, 20);
            this.label14.TabIndex = 20;
            this.label14.Text = "Стоимость";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label15.Location = new System.Drawing.Point(97, 500);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(36, 17);
            this.label15.TabIndex = 21;
            this.label15.Text = "Час";
            // 
            // AddCarRat
            // 
            this.AddCarRat.Location = new System.Drawing.Point(28, 441);
            this.AddCarRat.Name = "AddCarRat";
            this.AddCarRat.Size = new System.Drawing.Size(68, 20);
            this.AddCarRat.TabIndex = 22;
            this.AddCarRat.TextChanged += new System.EventHandler(this.AddCarRat_TextChanged);
            // 
            // AddCarPrice
            // 
            this.AddCarPrice.Location = new System.Drawing.Point(31, 499);
            this.AddCarPrice.Name = "AddCarPrice";
            this.AddCarPrice.Size = new System.Drawing.Size(59, 20);
            this.AddCarPrice.TabIndex = 23;
            this.AddCarPrice.TextChanged += new System.EventHandler(this.AddCarPrice_TextChanged);
            // 
            // AddCar
            // 
            this.AddCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.AddCar.Location = new System.Drawing.Point(551, 445);
            this.AddCar.Name = "AddCar";
            this.AddCar.Size = new System.Drawing.Size(161, 55);
            this.AddCar.TabIndex = 24;
            this.AddCar.Text = "Добавить авто";
            this.AddCar.UseVisualStyleBackColor = true;
            this.AddCar.Click += new System.EventHandler(this.AddCar_Click);
            // 
            // EngineText
            // 
            this.EngineText.Location = new System.Drawing.Point(129, 171);
            this.EngineText.Name = "EngineText";
            this.EngineText.Size = new System.Drawing.Size(135, 20);
            this.EngineText.TabIndex = 25;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // PowerText
            // 
            this.PowerText.Location = new System.Drawing.Point(129, 197);
            this.PowerText.Name = "PowerText";
            this.PowerText.Size = new System.Drawing.Size(135, 20);
            this.PowerText.TabIndex = 27;
            // 
            // TransmissionText
            // 
            this.TransmissionText.Location = new System.Drawing.Point(129, 223);
            this.TransmissionText.Name = "TransmissionText";
            this.TransmissionText.Size = new System.Drawing.Size(135, 20);
            this.TransmissionText.TabIndex = 28;
            // 
            // DriveUnitText
            // 
            this.DriveUnitText.Location = new System.Drawing.Point(130, 249);
            this.DriveUnitText.Name = "DriveUnitText";
            this.DriveUnitText.Size = new System.Drawing.Size(135, 20);
            this.DriveUnitText.TabIndex = 29;
            // 
            // ColorText
            // 
            this.ColorText.Location = new System.Drawing.Point(129, 275);
            this.ColorText.Name = "ColorText";
            this.ColorText.Size = new System.Drawing.Size(135, 20);
            this.ColorText.TabIndex = 31;
            // 
            // VINCodeText
            // 
            this.VINCodeText.Location = new System.Drawing.Point(129, 300);
            this.VINCodeText.Name = "VINCodeText";
            this.VINCodeText.Size = new System.Drawing.Size(135, 20);
            this.VINCodeText.TabIndex = 35;
            // 
            // MinimizeButton
            // 
            this.MinimizeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MinimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinimizeButton.Location = new System.Drawing.Point(704, 19);
            this.MinimizeButton.Name = "MinimizeButton";
            this.MinimizeButton.Size = new System.Drawing.Size(28, 10);
            this.MinimizeButton.TabIndex = 36;
            this.MinimizeButton.UseVisualStyleBackColor = true;
            this.MinimizeButton.Click += new System.EventHandler(this.MinimizeButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.Image = ((System.Drawing.Image)(resources.GetObject("CloseButton.Image")));
            this.CloseButton.Location = new System.Drawing.Point(742, 9);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(30, 30);
            this.CloseButton.TabIndex = 37;
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // ATBut
            // 
            this.ATBut.Location = new System.Drawing.Point(423, 16);
            this.ATBut.Name = "ATBut";
            this.ATBut.Size = new System.Drawing.Size(75, 23);
            this.ATBut.TabIndex = 38;
            this.ATBut.Text = "Автотест";
            this.ATBut.UseVisualStyleBackColor = true;
            this.ATBut.Click += new System.EventHandler(this.ATBut_Click);
            // 
            // DelBut
            // 
            this.DelBut.Location = new System.Drawing.Point(504, 16);
            this.DelBut.Name = "DelBut";
            this.DelBut.Size = new System.Drawing.Size(75, 23);
            this.DelBut.TabIndex = 39;
            this.DelBut.Text = "Удалить";
            this.DelBut.UseVisualStyleBackColor = true;
            this.DelBut.Click += new System.EventHandler(this.DelBut_Click);
            // 
            // DBCloneBut
            // 
            this.DBCloneBut.Location = new System.Drawing.Point(12, 3);
            this.DBCloneBut.Name = "DBCloneBut";
            this.DBCloneBut.Size = new System.Drawing.Size(104, 42);
            this.DBCloneBut.TabIndex = 40;
            this.DBCloneBut.Text = "Резервное копирование БД";
            this.DBCloneBut.UseVisualStyleBackColor = true;
            this.DBCloneBut.Click += new System.EventHandler(this.DBCloneBut_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.DBCloneBut);
            this.Controls.Add(this.DelBut);
            this.Controls.Add(this.ATBut);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.MinimizeButton);
            this.Controls.Add(this.VINCodeText);
            this.Controls.Add(this.ColorText);
            this.Controls.Add(this.DriveUnitText);
            this.Controls.Add(this.TransmissionText);
            this.Controls.Add(this.PowerText);
            this.Controls.Add(this.EngineText);
            this.Controls.Add(this.AddCar);
            this.Controls.Add(this.AddCarPrice);
            this.Controls.Add(this.AddCarRat);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.VINCodeCar);
            this.Controls.Add(this.ColorCar);
            this.Controls.Add(this.DriveUnitCar);
            this.Controls.Add(this.TransmissionCar);
            this.Controls.Add(this.PowerCar);
            this.Controls.Add(this.EngineCar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AddCarName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminForm";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox AddCarName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label EngineCar;
        private System.Windows.Forms.Label PowerCar;
        private System.Windows.Forms.Label TransmissionCar;
        private System.Windows.Forms.Label DriveUnitCar;
        private System.Windows.Forms.Label ColorCar;
        private System.Windows.Forms.Label VINCodeCar;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox AddCarRat;
        private System.Windows.Forms.TextBox AddCarPrice;
        private System.Windows.Forms.Button AddCar;
        private System.Windows.Forms.TextBox EngineText;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox PowerText;
        private System.Windows.Forms.TextBox TransmissionText;
        private System.Windows.Forms.TextBox DriveUnitText;
        private System.Windows.Forms.TextBox ColorText;
        private System.Windows.Forms.TextBox VINCodeText;
        private System.Windows.Forms.Button MinimizeButton;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button ATBut;
        private System.Windows.Forms.Button DelBut;
        private System.Windows.Forms.Button DBCloneBut;
    }
}