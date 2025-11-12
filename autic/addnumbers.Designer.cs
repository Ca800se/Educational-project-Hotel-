namespace autic
{
    partial class addnumbers
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
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.price = new System.Windows.Forms.TextBox();
            this.type = new System.Windows.Forms.TextBox();
            this.delnumber = new System.Windows.Forms.Button();
            this.addnumber = new System.Windows.Forms.Button();
            this.dataGridViewnumber = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewnumber)).BeginInit();
            this.SuspendLayout();
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(24, 372);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(166, 29);
            this.metroButton1.TabIndex = 15;
            this.metroButton1.Text = "Обновить";
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click_1);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(24, 221);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(92, 19);
            this.metroLabel2.TabIndex = 14;
            this.metroLabel2.Text = "Цена номера";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(24, 152);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(89, 19);
            this.metroLabel1.TabIndex = 13;
            this.metroLabel1.Text = "Тип Комнаты";
            // 
            // price
            // 
            this.price.Location = new System.Drawing.Point(24, 243);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(166, 20);
            this.price.TabIndex = 12;
            // 
            // type
            // 
            this.type.Location = new System.Drawing.Point(24, 174);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(166, 20);
            this.type.TabIndex = 11;
            // 
            // delnumber
            // 
            this.delnumber.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delnumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.delnumber.Location = new System.Drawing.Point(24, 324);
            this.delnumber.Name = "delnumber";
            this.delnumber.Size = new System.Drawing.Size(166, 29);
            this.delnumber.TabIndex = 10;
            this.delnumber.Text = "Удаление";
            this.delnumber.UseVisualStyleBackColor = true;
            this.delnumber.Click += new System.EventHandler(this.delnumber_Click_1);
            // 
            // addnumber
            // 
            this.addnumber.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addnumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addnumber.Location = new System.Drawing.Point(24, 278);
            this.addnumber.Name = "addnumber";
            this.addnumber.Size = new System.Drawing.Size(166, 29);
            this.addnumber.TabIndex = 9;
            this.addnumber.Text = "Добавление";
            this.addnumber.UseVisualStyleBackColor = true;
            this.addnumber.Click += new System.EventHandler(this.addnumber_Click);
            // 
            // dataGridViewnumber
            // 
            this.dataGridViewnumber.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewnumber.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewnumber.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridViewnumber.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewnumber.Location = new System.Drawing.Point(261, 174);
            this.dataGridViewnumber.Name = "dataGridViewnumber";
            this.dataGridViewnumber.Size = new System.Drawing.Size(444, 227);
            this.dataGridViewnumber.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(20, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "Настройка номеров";
            // 
            // addnumbers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.price);
            this.Controls.Add(this.type);
            this.Controls.Add(this.delnumber);
            this.Controls.Add(this.addnumber);
            this.Controls.Add(this.dataGridViewnumber);
            this.Name = "addnumbers";
            this.Size = new System.Drawing.Size(1178, 579);
            this.Load += new System.EventHandler(this.addnumbers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewnumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.TextBox price;
        private System.Windows.Forms.TextBox type;
        private System.Windows.Forms.Button delnumber;
        private System.Windows.Forms.Button addnumber;
        private System.Windows.Forms.DataGridView dataGridViewnumber;
        private System.Windows.Forms.Label label1;
    }
}
