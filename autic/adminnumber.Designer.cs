namespace autic
{
    partial class adminnumber
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
            this.dataGridViewnumber = new System.Windows.Forms.DataGridView();
            this.addnumber = new System.Windows.Forms.Button();
            this.delnumber = new System.Windows.Forms.Button();
            this.type = new System.Windows.Forms.TextBox();
            this.price = new System.Windows.Forms.TextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewnumber)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewnumber
            // 
            this.dataGridViewnumber.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridViewnumber.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewnumber.Location = new System.Drawing.Point(55, 207);
            this.dataGridViewnumber.Name = "dataGridViewnumber";
            this.dataGridViewnumber.Size = new System.Drawing.Size(338, 220);
            this.dataGridViewnumber.TabIndex = 0;
            this.dataGridViewnumber.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // addnumber
            // 
            this.addnumber.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addnumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addnumber.Location = new System.Drawing.Point(55, 89);
            this.addnumber.Name = "addnumber";
            this.addnumber.Size = new System.Drawing.Size(98, 29);
            this.addnumber.TabIndex = 1;
            this.addnumber.Text = "Добавление";
            this.addnumber.UseVisualStyleBackColor = true;
            this.addnumber.Click += new System.EventHandler(this.button1_Click);
            // 
            // delnumber
            // 
            this.delnumber.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delnumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.delnumber.Location = new System.Drawing.Point(186, 89);
            this.delnumber.Name = "delnumber";
            this.delnumber.Size = new System.Drawing.Size(103, 29);
            this.delnumber.TabIndex = 2;
            this.delnumber.Text = "Удаление";
            this.delnumber.UseVisualStyleBackColor = true;
            this.delnumber.Click += new System.EventHandler(this.delnumber_Click);
            // 
            // type
            // 
            this.type.Location = new System.Drawing.Point(55, 163);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(106, 20);
            this.type.TabIndex = 3;
            this.type.TextChanged += new System.EventHandler(this.type_TextChanged);
            // 
            // price
            // 
            this.price.Location = new System.Drawing.Point(186, 163);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(106, 20);
            this.price.TabIndex = 4;
            this.price.TextChanged += new System.EventHandler(this.price_TextChanged);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(55, 141);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(89, 19);
            this.metroLabel1.TabIndex = 5;
            this.metroLabel1.Text = "Тип Комнаты";
            this.metroLabel1.Click += new System.EventHandler(this.metroLabel1_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(186, 141);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(92, 19);
            this.metroLabel2.TabIndex = 6;
            this.metroLabel2.Text = "Цена номера";
            this.metroLabel2.Click += new System.EventHandler(this.metroLabel2_Click);
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(310, 89);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(83, 29);
            this.metroButton1.TabIndex = 7;
            this.metroButton1.Text = "Обновить";
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // adminnumber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 450);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.price);
            this.Controls.Add(this.type);
            this.Controls.Add(this.delnumber);
            this.Controls.Add(this.addnumber);
            this.Controls.Add(this.dataGridViewnumber);
            this.Name = "adminnumber";
            this.Text = "Панель управления таблицей Номера";
            this.Load += new System.EventHandler(this.adminnumber_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewnumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewnumber;
        private System.Windows.Forms.Button addnumber;
        private System.Windows.Forms.Button delnumber;
        private System.Windows.Forms.TextBox type;
        private System.Windows.Forms.TextBox price;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroButton metroButton1;
    }
}