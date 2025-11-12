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

namespace autic
{
    public partial class Numbers : MetroFramework.Forms.MetroForm
    {
        BASE database = new BASE();
        public Numbers()
        {
            InitializeComponent();
        }
        private void CreateColumns()
        {
            dataGridView3.Columns.Add("ТипКомнаты", "Тип Номера");
            dataGridView3.Columns.Add("Цена", "Цена номера за сутки");
        }
        private void ReadSingleRow(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetString(0), record.GetDecimal(1));
        }

        private void RefreshDataGrid(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string queryString = $"select ТипКомнаты,Цена from Номера";

            SqlCommand command = new SqlCommand(queryString, database.GetConnection());

            database.openConnection();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRow(dgw, reader);
            }
            reader.Close();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void Numbers_Load(object sender, EventArgs e)
        {
            CreateColumns();
            RefreshDataGrid(dataGridView3);
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
