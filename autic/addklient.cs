using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using MySqlX.XDevAPI;

namespace autic
{
    public partial class addklient : MetroFramework.Forms.MetroForm
    {
        BASE database = new BASE();
        public addklient()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void addklient_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            database.openConnection();
            
            var sur1 = sur.Text;
            if (string.IsNullOrEmpty(sur1))
            {
                MessageBox.Show("Введите фамилию клиента", "Ошибка!");
            }
            var nameklient = name.Text;
            if (string.IsNullOrEmpty(nameklient))
            {
                MessageBox.Show("Введите имя клиента", "Ошибка!");
            }
            var sur2 = surname2.Text;
            if (string.IsNullOrEmpty(sur2))
            {
                MessageBox.Show("Введите отчество клиента", "Ошибка!");
            }
            var dataar = dateTimePicker1.Value;
            var dataviez = dateTimePicker2.Value;
            var numberph = numberphone1.Text;
            if (numberphone1.Text.Length <= 0)
            {
                MessageBox.Show("Введите номер телефона клиента", "Ошибка!");
            }
            else
            {
                var addQuery = $"insert into Клиенты (Фамилия, Имя, Отчество, ДатаЗаезда, ДатаВыезда, НомерТелефона ) values ('{sur1}','{nameklient}', '{sur2}' , '{dataar}', '{dataviez}', '{numberph}')";
                var command = new SqlCommand(addQuery, database.GetConnection());
                command.ExecuteNonQuery();
                MessageBox.Show("Запись создана", "Успешно!");
            }
  
        database.closeConnection();
        }
        private void backbutton_Click_1(object sender, EventArgs e)
        {
            this.Close();
    
        }
    }
}
