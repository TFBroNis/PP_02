namespace theSchool
{
    partial class ServiceList
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button11 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.showDiscount1 = new System.Windows.Forms.Label();
            this.showPriceDuration1 = new System.Windows.Forms.Label();
            this.showName1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button12 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.showDiscount2 = new System.Windows.Forms.Label();
            this.showPriceDuration2 = new System.Windows.Forms.Label();
            this.showName2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button13 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.showDiscount3 = new System.Windows.Forms.Label();
            this.showPriceDuration3 = new System.Windows.Forms.Label();
            this.showName3 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button9 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button10 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(27, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Список услуг";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.button11);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.showDiscount1);
            this.groupBox1.Controls.Add(this.showPriceDuration1);
            this.groupBox1.Controls.Add(this.showName1);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Location = new System.Drawing.Point(31, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1074, 162);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(405, 125);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(145, 23);
            this.button11.TabIndex = 23;
            this.button11.Text = "Записаться на услугу";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(323, 125);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(76, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Удалить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(213, 125);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Редактировать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // showDiscount1
            // 
            this.showDiscount1.AutoSize = true;
            this.showDiscount1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.showDiscount1.Location = new System.Drawing.Point(210, 82);
            this.showDiscount1.Name = "showDiscount1";
            this.showDiscount1.Size = new System.Drawing.Size(55, 16);
            this.showDiscount1.TabIndex = 5;
            this.showDiscount1.Text = "Скидка";
            // 
            // showPriceDuration1
            // 
            this.showPriceDuration1.AutoSize = true;
            this.showPriceDuration1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.showPriceDuration1.Location = new System.Drawing.Point(209, 52);
            this.showPriceDuration1.Name = "showPriceDuration1";
            this.showPriceDuration1.Size = new System.Drawing.Size(167, 20);
            this.showPriceDuration1.TabIndex = 4;
            this.showPriceDuration1.Text = "Цена, длительность";
            // 
            // showName1
            // 
            this.showName1.AutoSize = true;
            this.showName1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.showName1.Location = new System.Drawing.Point(209, 25);
            this.showName1.Name = "showName1";
            this.showName1.Size = new System.Drawing.Size(174, 20);
            this.showName1.TabIndex = 3;
            this.showName1.Text = "Наименование услуги";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(14, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(189, 129);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button12);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.showDiscount2);
            this.groupBox2.Controls.Add(this.showPriceDuration2);
            this.groupBox2.Controls.Add(this.showName2);
            this.groupBox2.Controls.Add(this.pictureBox2);
            this.groupBox2.Location = new System.Drawing.Point(31, 232);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1074, 162);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(405, 125);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(145, 23);
            this.button12.TabIndex = 24;
            this.button12.Text = "Записаться на услугу";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // button3
            // 
            this.button3.Enabled = false;
            this.button3.Location = new System.Drawing.Point(323, 125);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(76, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "Удалить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Enabled = false;
            this.button4.Location = new System.Drawing.Point(213, 125);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(104, 23);
            this.button4.TabIndex = 6;
            this.button4.Text = "Редактировать";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // showDiscount2
            // 
            this.showDiscount2.AutoSize = true;
            this.showDiscount2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.showDiscount2.Location = new System.Drawing.Point(210, 82);
            this.showDiscount2.Name = "showDiscount2";
            this.showDiscount2.Size = new System.Drawing.Size(55, 16);
            this.showDiscount2.TabIndex = 5;
            this.showDiscount2.Text = "Скидка";
            // 
            // showPriceDuration2
            // 
            this.showPriceDuration2.AutoSize = true;
            this.showPriceDuration2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.showPriceDuration2.Location = new System.Drawing.Point(209, 52);
            this.showPriceDuration2.Name = "showPriceDuration2";
            this.showPriceDuration2.Size = new System.Drawing.Size(167, 20);
            this.showPriceDuration2.TabIndex = 4;
            this.showPriceDuration2.Text = "Цена, длительность";
            // 
            // showName2
            // 
            this.showName2.AutoSize = true;
            this.showName2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.showName2.Location = new System.Drawing.Point(209, 25);
            this.showName2.Name = "showName2";
            this.showName2.Size = new System.Drawing.Size(174, 20);
            this.showName2.TabIndex = 3;
            this.showName2.Text = "Наименование услуги";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(14, 19);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(189, 129);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button13);
            this.groupBox3.Controls.Add(this.button5);
            this.groupBox3.Controls.Add(this.button6);
            this.groupBox3.Controls.Add(this.showDiscount3);
            this.groupBox3.Controls.Add(this.showPriceDuration3);
            this.groupBox3.Controls.Add(this.showName3);
            this.groupBox3.Controls.Add(this.pictureBox3);
            this.groupBox3.Location = new System.Drawing.Point(31, 400);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1074, 162);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(405, 125);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(145, 23);
            this.button13.TabIndex = 25;
            this.button13.Text = "Записаться на услугу";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // button5
            // 
            this.button5.Enabled = false;
            this.button5.Location = new System.Drawing.Point(323, 125);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(76, 23);
            this.button5.TabIndex = 7;
            this.button5.Text = "Удалить";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Enabled = false;
            this.button6.Location = new System.Drawing.Point(213, 125);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(104, 23);
            this.button6.TabIndex = 6;
            this.button6.Text = "Редактировать";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // showDiscount3
            // 
            this.showDiscount3.AutoSize = true;
            this.showDiscount3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.showDiscount3.Location = new System.Drawing.Point(210, 82);
            this.showDiscount3.Name = "showDiscount3";
            this.showDiscount3.Size = new System.Drawing.Size(55, 16);
            this.showDiscount3.TabIndex = 5;
            this.showDiscount3.Text = "Скидка";
            // 
            // showPriceDuration3
            // 
            this.showPriceDuration3.AutoSize = true;
            this.showPriceDuration3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.showPriceDuration3.Location = new System.Drawing.Point(209, 52);
            this.showPriceDuration3.Name = "showPriceDuration3";
            this.showPriceDuration3.Size = new System.Drawing.Size(167, 20);
            this.showPriceDuration3.TabIndex = 4;
            this.showPriceDuration3.Text = "Цена, длительность";
            // 
            // showName3
            // 
            this.showName3.AutoSize = true;
            this.showName3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.showName3.Location = new System.Drawing.Point(209, 25);
            this.showName3.Name = "showName3";
            this.showName3.Size = new System.Drawing.Size(174, 20);
            this.showName3.TabIndex = 3;
            this.showName3.Text = "Наименование услуги";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(14, 19);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(189, 129);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(31, 585);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(193, 23);
            this.button7.TabIndex = 10;
            this.button7.Text = "Показать следующие услуги";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Enabled = false;
            this.button8.Location = new System.Drawing.Point(230, 585);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(193, 23);
            this.button8.TabIndex = 11;
            this.button8.Text = "Показать предыдущие услуги";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(787, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(213, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Введите код для входа в режим админа:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1006, 15);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 13;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(1030, 41);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 23);
            this.button9.TabIndex = 14;
            this.button9.Text = "Ввести";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Нет",
            "По возрастанию",
            "По убыванию"});
            this.comboBox1.Location = new System.Drawing.Point(256, 15);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 15;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(181, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Сортировка:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(963, 585);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "Количество услуг";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(391, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Скидка:";
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Любая",
            "от 0% до 5%",
            "от 5% до 15%",
            "от 15% до 30%",
            "от 30% до 70%",
            "от 70% до 100%"});
            this.comboBox2.Location = new System.Drawing.Point(444, 15);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 19;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(229, 44);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(381, 20);
            this.textBox2.TabIndex = 20;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(181, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Поиск:";
            // 
            // button10
            // 
            this.button10.Enabled = false;
            this.button10.Location = new System.Drawing.Point(837, 585);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(120, 23);
            this.button10.TabIndex = 22;
            this.button10.Text = "Добавить услугу";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(694, 585);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(137, 23);
            this.button14.TabIndex = 23;
            this.button14.Text = "Ближайшие записи";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // ServiceList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1138, 620);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "ServiceList";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label showDiscount1;
        private System.Windows.Forms.Label showPriceDuration1;
        private System.Windows.Forms.Label showName1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label showDiscount2;
        private System.Windows.Forms.Label showPriceDuration2;
        private System.Windows.Forms.Label showName2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label showDiscount3;
        private System.Windows.Forms.Label showPriceDuration3;
        private System.Windows.Forms.Label showName3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.GroupBox groupBox3;
        public System.Windows.Forms.Button button7;
        public System.Windows.Forms.Button button8;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.Button button9;
        public System.Windows.Forms.ComboBox comboBox1;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.ComboBox comboBox2;
        public System.Windows.Forms.TextBox textBox2;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Button button10;
        public System.Windows.Forms.Button button14;
    }
}

