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
    public partial class adminnumber : MetroFramework.Forms.MetroForm
    {
        BASE database = new BASE();
        public adminnumber()
        {
            InitializeComponent();
        }
        private void сreatecolum()
        {
            dataGridViewnumber.Columns.Add("ID_Номера", "ID");
            dataGridViewnumber.Columns.Add("ТипКомнаты", "Тип Комнаты");
            dataGridViewnumber.Columns.Add("Цена", "Цена комнаты за сутки");

        }
        private void ReadSingleRow(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetInt32(0),record.GetString(1), record.GetDecimal(2));
        }

        private void RefreshDataGrid(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string queryString = $"select ID_Номера,ТипКомнаты,Цена from Номера";

            SqlCommand command = new SqlCommand(queryString, database.GetConnection());

            database.openConnection();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRow(dgw, reader);
            }
            reader.Close();
        }

        private void adminnumber_Load(object sender, EventArgs e)
        {
            сreatecolum();
            RefreshDataGrid(dataGridViewnumber);
        }
        private void daletedRow()
        {
            int index = dataGridViewnumber.CurrentCell.RowIndex;

            dataGridViewnumber.Rows[index].Visible = false;

            if (dataGridViewnumber.Rows[index].Cells[0].Value.ToString() == string.Empty)
            {
                dataGridViewnumber.Rows[index].Cells[1].Value = RowState.Deleted;
                return;
            }
            dataGridViewnumber.Rows[index].Cells[1].Value = RowState.Deleted;
        }

        private void Update()
        {

            database.openConnection();

            for (int index = 0; index < dataGridViewnumber.Rows.Count; index++)
            {

                if (dataGridViewnumber.Rows[index].Visible)
                {
                    continue;

                }


                var id = Convert.ToInt32(dataGridViewnumber.Rows[index].Cells[0].Value);
                var deleteQuery = $"delete from Номера where ID_Номера = '{id}'";

                var command = new SqlCommand(deleteQuery, database.GetConnection());
                command.ExecuteNonQuery();

            }
            database.closeConnection();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            database.openConnection();

           
            var typenumber = type.Text;
            var chena = price.Text;

            var addQuery = $"insert into Номера (ТипКомнаты,Цена) values ('{typenumber}','{chena}')";
            var command = new SqlCommand(addQuery, database.GetConnection());
            command.ExecuteNonQuery();

            MessageBox.Show("Запись создана", "Успех!");

            database.closeConnection();
        }
        
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void delnumber_Click(object sender, EventArgs e)
        {
            daletedRow();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            Update();
            RefreshDataGrid(dataGridViewnumber);
            
        }

        private void metroLabel2_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void price_TextChanged(object sender, EventArgs e)
        {

        }

        private void type_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
