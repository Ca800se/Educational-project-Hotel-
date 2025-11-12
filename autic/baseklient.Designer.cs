namespace autic
{
    partial class baseklient
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttondel = new System.Windows.Forms.Button();
            this.buttonadd = new System.Windows.Forms.Button();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.ID_klient1 = new System.Windows.Forms.TextBox();
            this.numberphone = new System.Windows.Forms.TextBox();
            this.dateviezd = new System.Windows.Forms.TextBox();
            this.datearrival = new System.Windows.Forms.TextBox();
            this.surname1 = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.surname = new System.Windows.Forms.TextBox();
            this.NumberKlient = new System.Windows.Forms.TextBox();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonSave
            // 
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F);
            this.buttonSave.Location = new System.Drawing.Point(852, 76);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(134, 27);
            this.buttonSave.TabIndex = 4;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click_1);
            // 
            // buttondel
            // 
            this.buttondel.BackColor = System.Drawing.Color.White;
            this.buttondel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttondel.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttondel.Location = new System.Drawing.Point(712, 76);
            this.buttondel.Name = "buttondel";
            this.buttondel.Size = new System.Drawing.Size(134, 27);
            this.buttondel.TabIndex = 2;
            this.buttondel.Text = "Удалить запись";
            this.buttondel.UseVisualStyleBackColor = false;
            this.buttondel.Click += new System.EventHandler(this.buttondel_Click_1);
            // 
            // buttonadd
            // 
            this.buttonadd.BackColor = System.Drawing.Color.White;
            this.buttonadd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonadd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonadd.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonadd.Location = new System.Drawing.Point(572, 76);
            this.buttonadd.Name = "buttonadd";
            this.buttonadd.Size = new System.Drawing.Size(134, 27);
            this.buttonadd.TabIndex = 0;
            this.buttonadd.Text = "Добавить запись";
            this.buttonadd.UseVisualStyleBackColor = false;
            this.buttonadd.Click += new System.EventHandler(this.buttonadd_Click_1);
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel10.Location = new System.Drawing.Point(376, 76);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(175, 25);
            this.metroLabel10.TabIndex = 23;
            this.metroLabel10.Text = "Данные об клиентах";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(376, 112);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(775, 346);
            this.dataGridView1.TabIndex = 22;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Controls.Add(this.ID_klient1);
            this.groupBox1.Controls.Add(this.numberphone);
            this.groupBox1.Controls.Add(this.dateviezd);
            this.groupBox1.Controls.Add(this.datearrival);
            this.groupBox1.Controls.Add(this.surname1);
            this.groupBox1.Controls.Add(this.name);
            this.groupBox1.Controls.Add(this.surname);
            this.groupBox1.Controls.Add(this.NumberKlient);
            this.groupBox1.Controls.Add(this.metroLabel9);
            this.groupBox1.Controls.Add(this.metroLabel8);
            this.groupBox1.Controls.Add(this.metroLabel7);
            this.groupBox1.Controls.Add(this.metroLabel6);
            this.groupBox1.Controls.Add(this.metroLabel5);
            this.groupBox1.Controls.Add(this.metroLabel4);
            this.groupBox1.Controls.Add(this.metroLabel3);
            this.groupBox1.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(28, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(320, 431);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Данные клиента";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(25, 365);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(21, 19);
            this.metroLabel2.TabIndex = 16;
            this.metroLabel2.Text = "ID";
            // 
            // ID_klient1
            // 
            this.ID_klient1.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ID_klient1.Location = new System.Drawing.Point(156, 365);
            this.ID_klient1.Name = "ID_klient1";
            this.ID_klient1.Size = new System.Drawing.Size(144, 24);
            this.ID_klient1.TabIndex = 15;
            // 
            // numberphone
            // 
            this.numberphone.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numberphone.Location = new System.Drawing.Point(156, 170);
            this.numberphone.Name = "numberphone";
            this.numberphone.Size = new System.Drawing.Size(144, 24);
            this.numberphone.TabIndex = 14;
            // 
            // dateviezd
            // 
            this.dateviezd.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateviezd.Location = new System.Drawing.Point(156, 266);
            this.dateviezd.Name = "dateviezd";
            this.dateviezd.Size = new System.Drawing.Size(144, 24);
            this.dateviezd.TabIndex = 13;
            // 
            // datearrival
            // 
            this.datearrival.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.datearrival.Location = new System.Drawing.Point(156, 221);
            this.datearrival.Name = "datearrival";
            this.datearrival.Size = new System.Drawing.Size(144, 24);
            this.datearrival.TabIndex = 12;
            // 
            // surname1
            // 
            this.surname1.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.surname1.Location = new System.Drawing.Point(156, 123);
            this.surname1.Name = "surname1";
            this.surname1.Size = new System.Drawing.Size(144, 24);
            this.surname1.TabIndex = 11;
            // 
            // name
            // 
            this.name.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.name.Location = new System.Drawing.Point(156, 76);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(144, 24);
            this.name.TabIndex = 10;
            // 
            // surname
            // 
            this.surname.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.surname.Location = new System.Drawing.Point(156, 26);
            this.surname.Name = "surname";
            this.surname.Size = new System.Drawing.Size(144, 24);
            this.surname.TabIndex = 9;
            this.surname.TextChanged += new System.EventHandler(this.surname_TextChanged);
            // 
            // NumberKlient
            // 
            this.NumberKlient.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NumberKlient.Location = new System.Drawing.Point(156, 312);
            this.NumberKlient.Name = "NumberKlient";
            this.NumberKlient.Size = new System.Drawing.Size(144, 24);
            this.NumberKlient.TabIndex = 8;
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(25, 170);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(112, 19);
            this.metroLabel9.TabIndex = 7;
            this.metroLabel9.Text = "Номер телефона";
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(25, 266);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(84, 19);
            this.metroLabel8.TabIndex = 6;
            this.metroLabel8.Text = "Дата выезда";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(25, 221);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(81, 19);
            this.metroLabel7.TabIndex = 5;
            this.metroLabel7.Text = "Дата заезда";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(25, 123);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(65, 19);
            this.metroLabel6.TabIndex = 4;
            this.metroLabel6.Text = "Отчество";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(25, 76);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(35, 19);
            this.metroLabel5.TabIndex = 3;
            this.metroLabel5.Text = "Имя";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(25, 26);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(65, 19);
            this.metroLabel4.TabIndex = 2;
            this.metroLabel4.Text = "Фамилия";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(25, 312);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(103, 19);
            this.metroLabel3.TabIndex = 1;
            this.metroLabel3.Text = "Номер Клиента";
            // 
            // baseklient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttondel);
            this.Controls.Add(this.metroLabel10);
            this.Controls.Add(this.buttonadd);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Name = "baseklient";
            this.Size = new System.Drawing.Size(1178, 579);
            this.Load += new System.EventHandler(this.baseklient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttondel;
        private System.Windows.Forms.Button buttonadd;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.TextBox ID_klient1;
        private System.Windows.Forms.TextBox numberphone;
        private System.Windows.Forms.TextBox dateviezd;
        private System.Windows.Forms.TextBox datearrival;
        private System.Windows.Forms.TextBox surname1;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox surname;
        private System.Windows.Forms.TextBox NumberKlient;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
    }
}
