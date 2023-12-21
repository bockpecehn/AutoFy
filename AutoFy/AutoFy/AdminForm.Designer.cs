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
            this.BodyTypeCar = new System.Windows.Forms.Label();
            this.ColorCar = new System.Windows.Forms.Label();
            this.MileageCar = new System.Windows.Forms.Label();
            this.SteeringWheelCar = new System.Windows.Forms.Label();
            this.GenerationCar = new System.Windows.Forms.Label();
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
            this.BodyTypeText = new System.Windows.Forms.TextBox();
            this.ColorText = new System.Windows.Forms.TextBox();
            this.MileageText = new System.Windows.Forms.TextBox();
            this.SteeringWheelText = new System.Windows.Forms.TextBox();
            this.GenerationText = new System.Windows.Forms.TextBox();
            this.VINCodeText = new System.Windows.Forms.TextBox();
            this.MinimizeButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
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
            this.EngineCar.Location = new System.Drawing.Point(27, 164);
            this.EngineCar.Name = "EngineCar";
            this.EngineCar.Size = new System.Drawing.Size(65, 13);
            this.EngineCar.TabIndex = 9;
            this.EngineCar.Text = "Двигатель:";
            // 
            // PowerCar
            // 
            this.PowerCar.AutoSize = true;
            this.PowerCar.Location = new System.Drawing.Point(27, 190);
            this.PowerCar.Name = "PowerCar";
            this.PowerCar.Size = new System.Drawing.Size(63, 13);
            this.PowerCar.TabIndex = 10;
            this.PowerCar.Text = "Мощность:";
            // 
            // TransmissionCar
            // 
            this.TransmissionCar.AutoSize = true;
            this.TransmissionCar.Location = new System.Drawing.Point(27, 216);
            this.TransmissionCar.Name = "TransmissionCar";
            this.TransmissionCar.Size = new System.Drawing.Size(102, 13);
            this.TransmissionCar.TabIndex = 11;
            this.TransmissionCar.Text = "Коробчка передач:";
            // 
            // DriveUnitCar
            // 
            this.DriveUnitCar.AutoSize = true;
            this.DriveUnitCar.Location = new System.Drawing.Point(27, 242);
            this.DriveUnitCar.Name = "DriveUnitCar";
            this.DriveUnitCar.Size = new System.Drawing.Size(48, 13);
            this.DriveUnitCar.TabIndex = 12;
            this.DriveUnitCar.Text = "Привод:";
            // 
            // BodyTypeCar
            // 
            this.BodyTypeCar.AutoSize = true;
            this.BodyTypeCar.Location = new System.Drawing.Point(26, 268);
            this.BodyTypeCar.Name = "BodyTypeCar";
            this.BodyTypeCar.Size = new System.Drawing.Size(67, 13);
            this.BodyTypeCar.TabIndex = 13;
            this.BodyTypeCar.Text = "Тип кузова:";
            // 
            // ColorCar
            // 
            this.ColorCar.AutoSize = true;
            this.ColorCar.Location = new System.Drawing.Point(28, 294);
            this.ColorCar.Name = "ColorCar";
            this.ColorCar.Size = new System.Drawing.Size(35, 13);
            this.ColorCar.TabIndex = 14;
            this.ColorCar.Text = "Цвет:";
            // 
            // MileageCar
            // 
            this.MileageCar.AutoSize = true;
            this.MileageCar.Location = new System.Drawing.Point(27, 324);
            this.MileageCar.Name = "MileageCar";
            this.MileageCar.Size = new System.Drawing.Size(47, 13);
            this.MileageCar.TabIndex = 15;
            this.MileageCar.Text = "Пробег:";
            // 
            // SteeringWheelCar
            // 
            this.SteeringWheelCar.AutoSize = true;
            this.SteeringWheelCar.Location = new System.Drawing.Point(28, 349);
            this.SteeringWheelCar.Name = "SteeringWheelCar";
            this.SteeringWheelCar.Size = new System.Drawing.Size(34, 13);
            this.SteeringWheelCar.TabIndex = 16;
            this.SteeringWheelCar.Text = "Руль:";
            // 
            // GenerationCar
            // 
            this.GenerationCar.AutoSize = true;
            this.GenerationCar.Location = new System.Drawing.Point(27, 372);
            this.GenerationCar.Name = "GenerationCar";
            this.GenerationCar.Size = new System.Drawing.Size(66, 13);
            this.GenerationCar.TabIndex = 17;
            this.GenerationCar.Text = "Поколение:";
            // 
            // VINCodeCar
            // 
            this.VINCodeCar.AutoSize = true;
            this.VINCodeCar.Location = new System.Drawing.Point(28, 398);
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
            this.EngineText.Location = new System.Drawing.Point(128, 161);
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
            this.PowerText.Location = new System.Drawing.Point(128, 187);
            this.PowerText.Name = "PowerText";
            this.PowerText.Size = new System.Drawing.Size(135, 20);
            this.PowerText.TabIndex = 27;
            // 
            // TransmissionText
            // 
            this.TransmissionText.Location = new System.Drawing.Point(128, 213);
            this.TransmissionText.Name = "TransmissionText";
            this.TransmissionText.Size = new System.Drawing.Size(135, 20);
            this.TransmissionText.TabIndex = 28;
            // 
            // DriveUnitText
            // 
            this.DriveUnitText.Location = new System.Drawing.Point(129, 239);
            this.DriveUnitText.Name = "DriveUnitText";
            this.DriveUnitText.Size = new System.Drawing.Size(135, 20);
            this.DriveUnitText.TabIndex = 29;
            // 
            // BodyTypeText
            // 
            this.BodyTypeText.Location = new System.Drawing.Point(128, 265);
            this.BodyTypeText.Name = "BodyTypeText";
            this.BodyTypeText.Size = new System.Drawing.Size(135, 20);
            this.BodyTypeText.TabIndex = 30;
            // 
            // ColorText
            // 
            this.ColorText.Location = new System.Drawing.Point(128, 291);
            this.ColorText.Name = "ColorText";
            this.ColorText.Size = new System.Drawing.Size(135, 20);
            this.ColorText.TabIndex = 31;
            // 
            // MileageText
            // 
            this.MileageText.Location = new System.Drawing.Point(128, 317);
            this.MileageText.Name = "MileageText";
            this.MileageText.Size = new System.Drawing.Size(135, 20);
            this.MileageText.TabIndex = 32;
            // 
            // SteeringWheelText
            // 
            this.SteeringWheelText.Location = new System.Drawing.Point(128, 343);
            this.SteeringWheelText.Name = "SteeringWheelText";
            this.SteeringWheelText.Size = new System.Drawing.Size(135, 20);
            this.SteeringWheelText.TabIndex = 33;
            // 
            // GenerationText
            // 
            this.GenerationText.Location = new System.Drawing.Point(129, 369);
            this.GenerationText.Name = "GenerationText";
            this.GenerationText.Size = new System.Drawing.Size(135, 20);
            this.GenerationText.TabIndex = 34;
            // 
            // VINCodeText
            // 
            this.VINCodeText.Location = new System.Drawing.Point(128, 395);
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
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.MinimizeButton);
            this.Controls.Add(this.VINCodeText);
            this.Controls.Add(this.GenerationText);
            this.Controls.Add(this.SteeringWheelText);
            this.Controls.Add(this.MileageText);
            this.Controls.Add(this.ColorText);
            this.Controls.Add(this.BodyTypeText);
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
            this.Controls.Add(this.GenerationCar);
            this.Controls.Add(this.SteeringWheelCar);
            this.Controls.Add(this.MileageCar);
            this.Controls.Add(this.ColorCar);
            this.Controls.Add(this.BodyTypeCar);
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
        private System.Windows.Forms.Label BodyTypeCar;
        private System.Windows.Forms.Label ColorCar;
        private System.Windows.Forms.Label MileageCar;
        private System.Windows.Forms.Label SteeringWheelCar;
        private System.Windows.Forms.Label GenerationCar;
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
        private System.Windows.Forms.TextBox BodyTypeText;
        private System.Windows.Forms.TextBox ColorText;
        private System.Windows.Forms.TextBox MileageText;
        private System.Windows.Forms.TextBox SteeringWheelText;
        private System.Windows.Forms.TextBox GenerationText;
        private System.Windows.Forms.TextBox VINCodeText;
        private System.Windows.Forms.Button MinimizeButton;
        private System.Windows.Forms.Button CloseButton;
    }
}