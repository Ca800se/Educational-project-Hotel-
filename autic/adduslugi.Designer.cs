namespace autic
{
    partial class adduslugi
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
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.priceuslug = new System.Windows.Forms.TextBox();
            this.nameuslug = new System.Windows.Forms.TextBox();
            this.refresh = new System.Windows.Forms.Button();
            this.buttondell = new System.Windows.Forms.Button();
            this.buttonadduslug = new System.Windows.Forms.Button();
            this.dataGridViewuslugi = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewuslugi)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(38, 189);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(98, 19);
            this.metroLabel2.TabIndex = 15;
            this.metroLabel2.Text = "Цена за услугу";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(38, 130);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(47, 19);
            this.metroLabel1.TabIndex = 14;
            this.metroLabel1.Text = "Услуга";
            // 
            // priceuslug
            // 
            this.priceuslug.Location = new System.Drawing.Point(38, 211);
            this.priceuslug.Name = "priceuslug";
            this.priceuslug.Size = new System.Drawing.Size(170, 20);
            this.priceuslug.TabIndex = 13;
            // 
            // nameuslug
            // 
            this.nameuslug.Location = new System.Drawing.Point(38, 152);
            this.nameuslug.Name = "nameuslug";
            this.nameuslug.Size = new System.Drawing.Size(170, 20);
            this.nameuslug.TabIndex = 12;
            // 
            // refresh
            // 
            this.refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refresh.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.refresh.Location = new System.Drawing.Point(38, 360);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(166, 38);
            this.refresh.TabIndex = 11;
            this.refresh.Text = "Обновить";
            this.refresh.UseVisualStyleBackColor = true;
            this.refresh.Click += new System.EventHandler(this.refresh_Click_1);
            // 
            // buttondell
            // 
            this.buttondell.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttondell.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttondell.Location = new System.Drawing.Point(38, 304);
            this.buttondell.Name = "buttondell";
            this.buttondell.Size = new System.Drawing.Size(168, 38);
            this.buttondell.TabIndex = 10;
            this.buttondell.Text = "Удалить";
            this.buttondell.UseVisualStyleBackColor = true;
            this.buttondell.Click += new System.EventHandler(this.buttondell_Click_1);
            // 
            // buttonadduslug
            // 
            this.buttonadduslug.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonadduslug.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonadduslug.Location = new System.Drawing.Point(38, 251);
            this.buttonadduslug.Name = "buttonadduslug";
            this.buttonadduslug.Size = new System.Drawing.Size(168, 38);
            this.buttonadduslug.TabIndex = 9;
            this.buttonadduslug.Text = "Добавить";
            this.buttonadduslug.UseVisualStyleBackColor = true;
            this.buttonadduslug.Click += new System.EventHandler(this.buttonadduslug_Click_1);
            // 
            // dataGridViewuslugi
            // 
            this.dataGridViewuslugi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewuslugi.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewuslugi.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridViewuslugi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewuslugi.Location = new System.Drawing.Point(258, 130);
            this.dataGridViewuslugi.Name = "dataGridViewuslugi";
            this.dataGridViewuslugi.Size = new System.Drawing.Size(495, 268);
            this.dataGridViewuslugi.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(23, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "Настройка услуг ";
            // 
            // adduslugi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.priceuslug);
            this.Controls.Add(this.nameuslug);
            this.Controls.Add(this.refresh);
            this.Controls.Add(this.buttondell);
            this.Controls.Add(this.buttonadduslug);
            this.Controls.Add(this.dataGridViewuslugi);
            this.Name = "adduslugi";
            this.Size = new System.Drawing.Size(1178, 579);
            this.Load += new System.EventHandler(this.adduslugi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewuslugi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.TextBox priceuslug;
        private System.Windows.Forms.TextBox nameuslug;
        private System.Windows.Forms.Button refresh;
        private System.Windows.Forms.Button buttondell;
        private System.Windows.Forms.Button buttonadduslug;
        private System.Windows.Forms.DataGridView dataGridViewuslugi;
        private System.Windows.Forms.Label label1;
    }
}
