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
using System.Xml.Linq;
using System.Runtime.InteropServices;

namespace autic
{
    enum RowState
    {
        Existed,
        New,
        Modified,
        ModifiedNew,
        Deleted

    }
    public partial class admin : MetroFramework.Forms.MetroForm
    {
        BASE database = new BASE();
        int selectedRow;

        public admin()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void CreateColumns()
        {
            dataGridView1.Columns.Add("ID_Клиента", "ID");
            dataGridView1.Columns.Add("Фамилия", "Фамилия");
            dataGridView1.Columns.Add("Имя", "Имя");
            dataGridView1.Columns.Add("Отчество", "Отчество");
            dataGridView1.Columns.Add("ДатаЗаезда", "Дата заезда");
            dataGridView1.Columns.Add("ДатаВыезда", "Дата выезда");
            dataGridView1.Columns.Add("НомерТелефона", "Номер телефона");
            


        }

        private void ReadSingleRow(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2), record.GetString(3), record.GetDateTime(4), record.GetDateTime(5), record.GetDecimal(6));
        }

        private void RefreshDataGrid(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string queryString = $"select ID_Клиента,Фамилия,Имя,Отчество,ДатаЗаезда,ДатаВыезда,НомерТелефона from Клиенты";

            SqlCommand command = new SqlCommand(queryString, database.GetConnection());

            database.openConnection();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRow(dgw, reader);
            }
            reader.Close();
        }
        private void glstr_Load(object sender, EventArgs e)
        {
            CreateColumns();
            RefreshDataGrid(dataGridView1);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[selectedRow];

                ID_klient1.Text = row.Cells[0].Value.ToString();
                surname.Text = row.Cells[1].Value.ToString();
                name.Text = row.Cells[2].Value.ToString();
                surname1.Text = row.Cells[3].Value.ToString();
                datearrival.Text = row.Cells[4].Value.ToString();
                dateviezd.Text = row.Cells[5].Value.ToString();
                numberphone.Text = row.Cells[6].Value.ToString();
               

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            RefreshDataGrid(dataGridView1);
            MessageBox.Show("Таблица успешно обновлена", "Успех");
        }

        private void buttonadd_Click(object sender, EventArgs e)
        {
            addklient addklient = new addklient();
            addklient.Show();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void daletedRow()
        {
            int index = dataGridView1.CurrentCell.RowIndex;

            dataGridView1.Rows[index].Visible = false;

            if (dataGridView1.Rows[index].Cells[0].Value.ToString() == string.Empty)
            {
                dataGridView1.Rows[index].Cells[6].Value = RowState.Deleted;
                return;
            }
            dataGridView1.Rows[index].Cells[6].Value = RowState.Deleted;
        }

        private void Update()
        {

            database.openConnection();

            for (int index = 0; index < dataGridView1.Rows.Count; index++)
            {

                if (dataGridView1.Rows[index].Visible)
                {
                    continue;

                }


                var id = Convert.ToInt32(dataGridView1.Rows[index].Cells[0].Value);
                var deleteQuery = $"delete from Клиенты where ID_Клиента = '{id}'";

                var command = new SqlCommand(deleteQuery, database.GetConnection());
                command.ExecuteNonQuery();
              
            }
            database.closeConnection();
        }
        private void buttondel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверенны, что хотите удалить запись?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                daletedRow();
                MessageBox.Show("Запись успешно удалена", "Выполнено!");
                return;
            }

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {

            Update();
            RefreshDataGrid(dataGridView1);
            MessageBox.Show("Данные успешно сохранены в базу данных","Выполнено!");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

     

        private void metroButton1_Click_1(object sender, EventArgs e)
        {
            this.Close();
           
        }

        private void datearrival_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
