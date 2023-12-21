namespace AutoFy
{
    partial class ChooseCarForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChooseCarForm));
            this.ToyotaButton = new System.Windows.Forms.Button();
            this.ScodaButton = new System.Windows.Forms.Button();
            this.DaewooButton = new System.Windows.Forms.Button();
            this.MinimizeButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // ToyotaButton
            // 
            this.ToyotaButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ToyotaButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ToyotaButton.Image = ((System.Drawing.Image)(resources.GetObject("ToyotaButton.Image")));
            this.ToyotaButton.Location = new System.Drawing.Point(14, 75);
            this.ToyotaButton.Name = "ToyotaButton";
            this.ToyotaButton.Size = new System.Drawing.Size(760, 141);
            this.ToyotaButton.TabIndex = 5;
            this.ToyotaButton.UseVisualStyleBackColor = true;
            this.ToyotaButton.Click += new System.EventHandler(this.ToyotaButton_Click);
            // 
            // ScodaButton
            // 
            this.ScodaButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ScodaButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ScodaButton.Image = ((System.Drawing.Image)(resources.GetObject("ScodaButton.Image")));
            this.ScodaButton.Location = new System.Drawing.Point(12, 237);
            this.ScodaButton.Name = "ScodaButton";
            this.ScodaButton.Size = new System.Drawing.Size(760, 141);
            this.ScodaButton.TabIndex = 6;
            this.ScodaButton.UseVisualStyleBackColor = true;
            this.ScodaButton.Click += new System.EventHandler(this.ScodaButton_Click);
            // 
            // DaewooButton
            // 
            this.DaewooButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DaewooButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DaewooButton.Image = ((System.Drawing.Image)(resources.GetObject("DaewooButton.Image")));
            this.DaewooButton.Location = new System.Drawing.Point(12, 399);
            this.DaewooButton.Name = "DaewooButton";
            this.DaewooButton.Size = new System.Drawing.Size(760, 136);
            this.DaewooButton.TabIndex = 7;
            this.DaewooButton.UseVisualStyleBackColor = true;
            this.DaewooButton.Click += new System.EventHandler(this.DaewooButton_Click);
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
            this.MinimizeButton.TabIndex = 17;
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
            this.CloseButton.TabIndex = 16;
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, -2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(900, 50);
            this.pictureBox2.TabIndex = 18;
            this.pictureBox2.TabStop = false;
            // 
            // ChooseCarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.MinimizeButton);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.DaewooButton);
            this.Controls.Add(this.ScodaButton);
            this.Controls.Add(this.ToyotaButton);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ChooseCarForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "7";
            this.Load += new System.EventHandler(this.ChooseCarForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button ToyotaButton;
        private System.Windows.Forms.Button ScodaButton;
        private System.Windows.Forms.Button MinimizeButton;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.PictureBox pictureBox2;
        public System.Windows.Forms.Button DaewooButton;
    }
}