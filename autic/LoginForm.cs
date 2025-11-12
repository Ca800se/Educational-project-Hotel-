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

namespace autic
{
    public partial class LoginForm:MetroFramework.Forms.MetroForm
    {
        BASE database = new BASE();
        public LoginForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }
        private void buttonvxod_Click(object sender, EventArgs e)
        {
            var loguser = LoginField.Text;
            if (LoginField.Text.Length <= 0)
            {
                MessageBox.Show("Введите логин", "Ошибка!");
                return;
            }
            var passuser = PassField.Text;
            if (PassField.Text.Length <= 0)
            {
                MessageBox.Show("Введите пароль", "Ошибка!");
                return;

            }
            else
            {
                SqlDataAdapter adapter = new SqlDataAdapter();
                DataTable table = new DataTable();

                string querystring = $"select user_login,user_password from админ where user_login = '{loguser}' and user_password = '{passuser}'";

                SqlCommand command = new SqlCommand(querystring, database.GetConnection());


                adapter.SelectCommand = command;
                adapter.Fill(table);

                if (table.Rows.Count == 1)
                {
                    MessageBox.Show("Вы вошли в систему","Успешно!");
                    menuadmin menuadmin = new menuadmin();
                    this.Hide();
                    menuadmin.ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("Неверный логин или пароль","Ошибка!");
                }
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
