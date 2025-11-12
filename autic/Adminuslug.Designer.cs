namespace autic
{
    partial class Adminuslug
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Adminuslug));
            this.dataGridViewuslugi = new System.Windows.Forms.DataGridView();
            this.buttonadduslug = new System.Windows.Forms.Button();
            this.buttondell = new System.Windows.Forms.Button();
            this.refresh = new System.Windows.Forms.Button();
            this.nameuslug = new System.Windows.Forms.TextBox();
            this.priceuslug = new System.Windows.Forms.TextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewuslugi)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewuslugi
            // 
            this.dataGridViewuslugi.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridViewuslugi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewuslugi.Location = new System.Drawing.Point(57, 192);
            this.dataGridViewuslugi.Name = "dataGridViewuslugi";
            this.dataGridViewuslugi.Size = new System.Drawing.Size(346, 217);
            this.dataGridViewuslugi.TabIndex = 0;
            // 
            // buttonadduslug
            // 
            this.buttonadduslug.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonadduslug.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonadduslug.Location = new System.Drawing.Point(57, 85);
            this.buttonadduslug.Name = "buttonadduslug";
            this.buttonadduslug.Size = new System.Drawing.Size(100, 38);
            this.buttonadduslug.TabIndex = 1;
            this.buttonadduslug.Text = "Добавить";
            this.buttonadduslug.UseVisualStyleBackColor = true;
            this.buttonadduslug.Click += new System.EventHandler(this.buttonadduslug_Click);
            // 
            // buttondell
            // 
            this.buttondell.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttondell.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttondell.Location = new System.Drawing.Point(194, 85);
            this.buttondell.Name = "buttondell";
            this.buttondell.Size = new System.Drawing.Size(86, 38);
            this.buttondell.TabIndex = 2;
            this.buttondell.Text = "Удалить";
            this.buttondell.UseVisualStyleBackColor = true;
            this.buttondell.Click += new System.EventHandler(this.buttondell_Click);
            // 
            // refresh
            // 
            this.refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refresh.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.refresh.Location = new System.Drawing.Point(307, 85);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(96, 38);
            this.refresh.TabIndex = 3;
            this.refresh.Text = "Обновить";
            this.refresh.UseVisualStyleBackColor = true;
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // nameuslug
            // 
            this.nameuslug.Location = new System.Drawing.Point(57, 157);
            this.nameuslug.Name = "nameuslug";
            this.nameuslug.Size = new System.Drawing.Size(100, 20);
            this.nameuslug.TabIndex = 4;
            // 
            // priceuslug
            // 
            this.priceuslug.Location = new System.Drawing.Point(194, 157);
            this.priceuslug.Name = "priceuslug";
            this.priceuslug.Size = new System.Drawing.Size(100, 20);
            this.priceuslug.TabIndex = 5;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(57, 135);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(47, 19);
            this.metroLabel1.TabIndex = 6;
            this.metroLabel1.Text = "Услуга";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(194, 135);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(98, 19);
            this.metroLabel2.TabIndex = 7;
            this.metroLabel2.Text = "Цена за услугу";
            // 
            // Adminuslug
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 450);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.priceuslug);
            this.Controls.Add(this.nameuslug);
            this.Controls.Add(this.refresh);
            this.Controls.Add(this.buttondell);
            this.Controls.Add(this.buttonadduslug);
            this.Controls.Add(this.dataGridViewuslugi);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Adminuslug";
            this.Text = "Панель управления таблицей услуги";
            this.Load += new System.EventHandler(this.Adminuslug_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewuslugi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewuslugi;
        private System.Windows.Forms.Button buttonadduslug;
        private System.Windows.Forms.Button buttondell;
        private System.Windows.Forms.Button refresh;
        private System.Windows.Forms.TextBox nameuslug;
        private System.Windows.Forms.TextBox priceuslug;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
    }
}