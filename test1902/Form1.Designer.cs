namespace test1902
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
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Имя = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.dbColumn1 = new System.Windows.Forms.TextBox();
            this.dbColumn2 = new System.Windows.Forms.TextBox();
            this.dbColumn3 = new System.Windows.Forms.TextBox();
            this.dbName = new System.Windows.Forms.TextBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.dataType2 = new System.Windows.Forms.ComboBox();
            this.dataType3 = new System.Windows.Forms.ComboBox();
            this.dataType4 = new System.Windows.Forms.ComboBox();
            this.dbTableName = new System.Windows.Forms.ComboBox();
            this.dbView = new System.Windows.Forms.Button();
            this.refreshTable = new System.Windows.Forms.Button();
            this.insertdbValue1 = new System.Windows.Forms.TextBox();
            this.insertdbValue2 = new System.Windows.Forms.TextBox();
            this.insertdbValue3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dbTableName2 = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.consoleDb = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(105, 401);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 22);
            this.button1.TabIndex = 0;
            this.button1.Text = "Внести значение в таблицу";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dataGridView1.Location = new System.Drawing.Point(250, 60);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(352, 300);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Column2";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Column3";
            this.Column3.Name = "Column3";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Имя});
            this.dataGridView2.Location = new System.Drawing.Point(28, 45);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(195, 159);
            this.dataGridView2.TabIndex = 4;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // Имя
            // 
            this.Имя.FillWeight = 150F;
            this.Имя.HeaderText = "Название таблиц";
            this.Имя.Name = "Имя";
            this.Имя.Width = 150;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(686, 342);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(140, 32);
            this.button2.TabIndex = 5;
            this.button2.Text = "Создать таблицу";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dbColumn1
            // 
            this.dbColumn1.Location = new System.Drawing.Point(704, 149);
            this.dbColumn1.Name = "dbColumn1";
            this.dbColumn1.Size = new System.Drawing.Size(100, 20);
            this.dbColumn1.TabIndex = 6;
            // 
            // dbColumn2
            // 
            this.dbColumn2.Location = new System.Drawing.Point(704, 206);
            this.dbColumn2.Name = "dbColumn2";
            this.dbColumn2.Size = new System.Drawing.Size(100, 20);
            this.dbColumn2.TabIndex = 7;
            // 
            // dbColumn3
            // 
            this.dbColumn3.Location = new System.Drawing.Point(704, 267);
            this.dbColumn3.Name = "dbColumn3";
            this.dbColumn3.Size = new System.Drawing.Size(100, 20);
            this.dbColumn3.TabIndex = 8;
            // 
            // dbName
            // 
            this.dbName.Location = new System.Drawing.Point(704, 94);
            this.dbName.Name = "dbName";
            this.dbName.Size = new System.Drawing.Size(100, 20);
            this.dbName.TabIndex = 9;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(664, 152);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(15, 14);
            this.checkBox2.TabIndex = 11;
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(664, 206);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(15, 14);
            this.checkBox3.TabIndex = 12;
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(664, 267);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(15, 14);
            this.checkBox4.TabIndex = 13;
            this.checkBox4.UseVisualStyleBackColor = true;
            this.checkBox4.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // dataType2
            // 
            this.dataType2.FormattingEnabled = true;
            this.dataType2.Items.AddRange(new object[] {
            "INTEGER\t",
            "TEXT",
            "REAL",
            "DATE"});
            this.dataType2.Location = new System.Drawing.Point(835, 148);
            this.dataType2.Name = "dataType2";
            this.dataType2.Size = new System.Drawing.Size(121, 21);
            this.dataType2.TabIndex = 15;
            // 
            // dataType3
            // 
            this.dataType3.FormattingEnabled = true;
            this.dataType3.Items.AddRange(new object[] {
            "INTEGER\t",
            "TEXT",
            "REAL",
            "DATE"});
            this.dataType3.Location = new System.Drawing.Point(835, 205);
            this.dataType3.Name = "dataType3";
            this.dataType3.Size = new System.Drawing.Size(121, 21);
            this.dataType3.TabIndex = 16;
            // 
            // dataType4
            // 
            this.dataType4.FormattingEnabled = true;
            this.dataType4.Items.AddRange(new object[] {
            "INTEGER\t",
            "TEXT",
            "REAL",
            "DATE"});
            this.dataType4.Location = new System.Drawing.Point(835, 266);
            this.dataType4.Name = "dataType4";
            this.dataType4.Size = new System.Drawing.Size(121, 21);
            this.dataType4.TabIndex = 17;
            // 
            // dbTableName
            // 
            this.dbTableName.FormattingEnabled = true;
            this.dbTableName.Location = new System.Drawing.Point(272, 12);
            this.dbTableName.Name = "dbTableName";
            this.dbTableName.Size = new System.Drawing.Size(121, 21);
            this.dbTableName.TabIndex = 18;
            this.dbTableName.SelectedIndexChanged += new System.EventHandler(this.dbTableName_SelectedIndexChanged);
            // 
            // dbView
            // 
            this.dbView.Location = new System.Drawing.Point(410, 12);
            this.dbView.Name = "dbView";
            this.dbView.Size = new System.Drawing.Size(116, 23);
            this.dbView.TabIndex = 19;
            this.dbView.Text = "Вывести таблицу";
            this.dbView.UseVisualStyleBackColor = true;
            this.dbView.Click += new System.EventHandler(this.button3_Click);
            // 
            // refreshTable
            // 
            this.refreshTable.Location = new System.Drawing.Point(68, 222);
            this.refreshTable.Name = "refreshTable";
            this.refreshTable.Size = new System.Drawing.Size(112, 22);
            this.refreshTable.TabIndex = 20;
            this.refreshTable.Text = "Перезагрузить БД";
            this.refreshTable.UseVisualStyleBackColor = true;
            this.refreshTable.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // insertdbValue1
            // 
            this.insertdbValue1.Location = new System.Drawing.Point(275, 401);
            this.insertdbValue1.Name = "insertdbValue1";
            this.insertdbValue1.Size = new System.Drawing.Size(100, 20);
            this.insertdbValue1.TabIndex = 21;
            // 
            // insertdbValue2
            // 
            this.insertdbValue2.Location = new System.Drawing.Point(382, 401);
            this.insertdbValue2.Name = "insertdbValue2";
            this.insertdbValue2.Size = new System.Drawing.Size(100, 20);
            this.insertdbValue2.TabIndex = 22;
            // 
            // insertdbValue3
            // 
            this.insertdbValue3.Location = new System.Drawing.Point(489, 401);
            this.insertdbValue3.Name = "insertdbValue3";
            this.insertdbValue3.Size = new System.Drawing.Size(100, 20);
            this.insertdbValue3.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(293, 385);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Столбец 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(400, 385);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Столбец 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(506, 385);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Столбец 3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(775, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Создание таблицы";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1006, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "Удаление таблицы";
            // 
            // dbTableName2
            // 
            this.dbTableName2.FormattingEnabled = true;
            this.dbTableName2.Location = new System.Drawing.Point(998, 78);
            this.dbTableName2.Name = "dbTableName2";
            this.dbTableName2.Size = new System.Drawing.Size(121, 21);
            this.dbTableName2.TabIndex = 29;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(998, 114);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(121, 23);
            this.button3.TabIndex = 30;
            this.button3.Text = "Удалить таблицу";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_2);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(702, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 13);
            this.label6.TabIndex = 31;
            this.label6.Text = "Название таблицы";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(723, 129);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 32;
            this.label7.Text = "Столбец 1";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(723, 186);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 33;
            this.label8.Text = "Столбец 2";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(723, 247);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 13);
            this.label9.TabIndex = 34;
            this.label9.Text = "Столбец 3";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(846, 129);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(110, 13);
            this.label10.TabIndex = 35;
            this.label10.Text = "Тип данных столбца";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(846, 186);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(110, 13);
            this.label11.TabIndex = 36;
            this.label11.Text = "Тип данных столбца";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(846, 247);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(110, 13);
            this.label12.TabIndex = 37;
            this.label12.Text = "Тип данных столбца";
            // 
            // consoleDb
            // 
            this.consoleDb.Location = new System.Drawing.Point(105, 497);
            this.consoleDb.Name = "consoleDb";
            this.consoleDb.Size = new System.Drawing.Size(612, 20);
            this.consoleDb.TabIndex = 38;
            this.consoleDb.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(105, 478);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(112, 13);
            this.label13.TabIndex = 39;
            this.label13.Text = "Консоль для команд";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(105, 523);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 40;
            this.button4.Text = "Выполнить";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(640, 129);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(61, 13);
            this.label14.TabIndex = 41;
            this.label14.Text = "Primary key";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1172, 563);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.consoleDb);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dbTableName2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.insertdbValue3);
            this.Controls.Add(this.insertdbValue2);
            this.Controls.Add(this.insertdbValue1);
            this.Controls.Add(this.refreshTable);
            this.Controls.Add(this.dbView);
            this.Controls.Add(this.dbTableName);
            this.Controls.Add(this.dataType4);
            this.Controls.Add(this.dataType3);
            this.Controls.Add(this.dataType2);
            this.Controls.Add(this.checkBox4);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.dbName);
            this.Controls.Add(this.dbColumn3);
            this.Controls.Add(this.dbColumn2);
            this.Controls.Add(this.dbColumn1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox dbColumn1;
        private System.Windows.Forms.TextBox dbColumn2;
        private System.Windows.Forms.TextBox dbColumn3;
        private System.Windows.Forms.TextBox dbName;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.ComboBox dataType2;
        private System.Windows.Forms.ComboBox dataType3;
        private System.Windows.Forms.ComboBox dataType4;
        private System.Windows.Forms.ComboBox dbTableName;
        private System.Windows.Forms.Button dbView;
        private System.Windows.Forms.Button refreshTable;
        private System.Windows.Forms.TextBox insertdbValue1;
        private System.Windows.Forms.TextBox insertdbValue2;
        private System.Windows.Forms.TextBox insertdbValue3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Имя;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox dbTableName2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox consoleDb;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

