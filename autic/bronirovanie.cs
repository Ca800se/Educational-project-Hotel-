using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace autic
{
    public partial class bronirovanie : MetroFramework.Forms.MetroForm
    {
        BASE database = new BASE();
        public bronirovanie()
        {
            InitializeComponent();
        }

        private void bronirovanie_Load(object sender, EventArgs e)
        {
            ComboBox();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
                database.openConnection();

                var name = namebox.Text;
                if (string.IsNullOrEmpty(name))
                {
                    MessageBox.Show("Введите Имя", "Ошибка!");
                    return;
                }
                var famklient = textBox2.Text;
                if (string.IsNullOrEmpty(famklient))
                {
                    MessageBox.Show("Введите Фамилию", "Ошибка!");
                    return;
                }
                var sur2 = textBox3.Text;
                if (string.IsNullOrEmpty(sur2))
                {
                    MessageBox.Show("Введите Отчество ", "Ошибка!");
                    return;
                }
                var dataar = dateTimePicker1.Value;
                var dataviez = dateTimePicker2.Value;
                var numberph = textBox6.Text;
                if (textBox6.Text.Length <= 0)
                {
                    MessageBox.Show("Введите номер телефона", "Ошибка!");
                    return;
                }
                var id = comboBox1.SelectedIndex;
                var numberid = savedids[id];
                if (comboBox1.Text.Length <= 0)
                {
                    MessageBox.Show("Выберите Номер", "Ошибка!");
                    return;
                 }
                var addQuery = $"insert into Клиенты (Фамилия, Имя, Отчество, ДатаЗаезда, ДатаВыезда, НомерТелефона,ID_Номера) values ('{name}','{famklient}', '{sur2}' , '{dataar}', '{dataviez}', '{numberph}', '{numberid}')";
                var command = new SqlCommand(addQuery, database.GetConnection());
                    
                command.ExecuteNonQuery();
                database.openConnection();
                MessageBox.Show("Номер Забронирован", "Успешно!");
               

         
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        
      
        private void ComboBox()
        {
            string queryString = $"select ID_Номера,ТипКомнаты,СтатусКомнаты from Номера ";

            SqlCommand command = new SqlCommand(queryString, database.GetConnection());

            database.openConnection();
            List<String> timelist = new List<String>();

            List<int> listid = new List<int>();

            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    var idroom = reader.GetInt32(0);
                    listid.Add(idroom);

                    string number = reader["ТипКомнаты"].ToString();

                    bool number1 = Convert.ToBoolean(reader["СтатусКомнаты"]);
                    string text2 = number1.ToString();
                    if (number1 == false)
                    {
                        text2 = "Свободна";
                    }
                    else
                    {
                        text2 = "Занята";
                    }
                    string text = number + "  (" + text2 + ")";
                    timelist.Add((String)text);
                }
                foreach (var item in timelist)
                {
                    comboBox1.Items.Add(item);
                }

                savedids = listid;

            }
      }
        List<int> savedids = new List<int>();
        private void label6_Click(object sender, EventArgs e)
        {

        }
       
    }
}
