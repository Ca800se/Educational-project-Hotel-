using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace autic
{
    public partial class Adminuslug : MetroFramework.Forms.MetroForm
    {
        BASE database = new BASE();
        public Adminuslug()
        {
            InitializeComponent();
        }
        private void сreatecolum()
        {
            dataGridViewuslugi.Columns.Add("ID_Услуги", "ID");
            dataGridViewuslugi.Columns.Add("НазваниеУслуги", "Услуга");
            dataGridViewuslugi.Columns.Add("Цена", "Цена за услугу");

        }

        private void ReadSingleRow(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetInt32(2));
        }
        private void RefreshDataGrid(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string queryString = $"select ID_Услуги,НазваниеУслуги,Цена from Дополнительные_услуги";

            SqlCommand command = new SqlCommand(queryString, database.GetConnection());

            database.openConnection();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRow(dgw, reader);
            }
            reader.Close();
        }
        private void Adminuslug_Load(object sender, EventArgs e)
        {
            сreatecolum();
            RefreshDataGrid(dataGridViewuslugi);
        }
        private void daletedRow()
        {
            int index = dataGridViewuslugi.CurrentCell.RowIndex;

            dataGridViewuslugi.Rows[index].Visible = false;

            if (dataGridViewuslugi.Rows[index].Cells[0].Value.ToString() == string.Empty)
            {
                dataGridViewuslugi.Rows[index].Cells[1].Value = RowState.Deleted;
                return;
            }
            dataGridViewuslugi.Rows[index].Cells[1].Value = RowState.Deleted;
        }     
        private void Update()
        {

            database.openConnection();

            for (int index = 0; index < dataGridViewuslugi.Rows.Count; index++)
            {

                if (dataGridViewuslugi.Rows[index].Visible)
                {
                    continue;

                }


                var id = Convert.ToInt32(dataGridViewuslugi.Rows[index].Cells[0].Value);
                var deleteQuery = $"delete from Дополнительные_Услуги where ID_Услуги = '{id}'";

                var command = new SqlCommand(deleteQuery, database.GetConnection());
                command.ExecuteNonQuery();

            }
            database.closeConnection();
        }

        private void buttonadduslug_Click(object sender, EventArgs e)
        {
            database.openConnection();


            var nameuslg = nameuslug.Text;
            var chena = priceuslug.Text;

            var addQuery = $"insert into Дополнительные_Услуги (НазваниеУслуги,Цена) values ('{nameuslg}','{chena}')";
            var command = new SqlCommand(addQuery, database.GetConnection());
            command.ExecuteNonQuery();

            MessageBox.Show("Запись создана", "Успех!");

            database.closeConnection();
        }

        private void buttondell_Click(object sender, EventArgs e)
        {
            daletedRow();
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            Update();
            RefreshDataGrid(dataGridViewuslugi);
        }
    }
}
