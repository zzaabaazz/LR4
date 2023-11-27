namespace LR4
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.ModelBox = new System.Windows.Forms.TextBox();
            this.ClockRateBox = new System.Windows.Forms.TextBox();
            this.BrandBox = new System.Windows.Forms.TextBox();
            this.ResultBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.HardCapacityBox = new System.Windows.Forms.TextBox();
            this.RamCapacityBox = new System.Windows.Forms.TextBox();
            this.PriceBox = new System.Windows.Forms.TextBox();
            this.StartButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ModelBox
            // 
            this.ModelBox.Location = new System.Drawing.Point(143, 19);
            this.ModelBox.Name = "ModelBox";
            this.ModelBox.Size = new System.Drawing.Size(100, 20);
            this.ModelBox.TabIndex = 0;
            // 
            // ClockRateBox
            // 
            this.ClockRateBox.Location = new System.Drawing.Point(143, 45);
            this.ClockRateBox.Name = "ClockRateBox";
            this.ClockRateBox.Size = new System.Drawing.Size(100, 20);
            this.ClockRateBox.TabIndex = 1;
            // 
            // BrandBox
            // 
            this.BrandBox.Location = new System.Drawing.Point(143, 71);
            this.BrandBox.Name = "BrandBox";
            this.BrandBox.Size = new System.Drawing.Size(100, 20);
            this.BrandBox.TabIndex = 2;
            // 
            // ResultBox
            // 
            this.ResultBox.Location = new System.Drawing.Point(282, 27);
            this.ResultBox.Multiline = true;
            this.ResultBox.Name = "ResultBox";
            this.ResultBox.Size = new System.Drawing.Size(249, 206);
            this.ResultBox.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.PriceBox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.BrandBox);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.ClockRateBox);
            this.groupBox1.Controls.Add(this.ModelBox);
            this.groupBox1.Controls.Add(this.HardCapacityBox);
            this.groupBox1.Controls.Add(this.RamCapacityBox);
            this.groupBox1.Location = new System.Drawing.Point(27, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(249, 177);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Информация";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(68, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Объем HDD";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Модель";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(97, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Марка";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(75, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Стоимость";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Тактовая частота";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(68, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Объем RAM";
            // 
            // HardCapacityBox
            // 
            this.HardCapacityBox.Location = new System.Drawing.Point(143, 97);
            this.HardCapacityBox.Name = "HardCapacityBox";
            this.HardCapacityBox.Size = new System.Drawing.Size(100, 20);
            this.HardCapacityBox.TabIndex = 9;
            // 
            // RamCapacityBox
            // 
            this.RamCapacityBox.Location = new System.Drawing.Point(143, 123);
            this.RamCapacityBox.Name = "RamCapacityBox";
            this.RamCapacityBox.Size = new System.Drawing.Size(100, 20);
            this.RamCapacityBox.TabIndex = 8;
            // 
            // PriceBox
            // 
            this.PriceBox.Location = new System.Drawing.Point(143, 149);
            this.PriceBox.Name = "PriceBox";
            this.PriceBox.Size = new System.Drawing.Size(100, 20);
            this.PriceBox.TabIndex = 7;
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(27, 210);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(249, 23);
            this.StartButton.TabIndex = 5;
            this.StartButton.Text = "Добавить";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 311);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ResultBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ModelBox;
        private System.Windows.Forms.TextBox ClockRateBox;
        private System.Windows.Forms.TextBox BrandBox;
        private System.Windows.Forms.TextBox HardCapacityBox;
        private System.Windows.Forms.TextBox RamCapacityBox;
        private System.Windows.Forms.TextBox PriceBox;
        private System.Windows.Forms.TextBox ResultBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

