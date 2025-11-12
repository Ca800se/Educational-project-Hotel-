using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace autic
{
    public partial class uslugi : MetroFramework.Forms.MetroForm
    {
        BASE database = new BASE();
        public uslugi()
        {
            InitializeComponent();
        }

       
        private void CreateColumns()
        {
            dataGridView2.Columns.Add("НазваниеУслуги", "Наименование услуги");
            dataGridView2.Columns.Add("Цена", "Цена услуги");
        }
        private void ReadSingleRow(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetString(0), record.GetInt32(1));
        }
        private void uslugi_Load(object sender, EventArgs e)
        {
            CreateColumns();
            RefreshDataGrid(dataGridView2);
        }

        private void RefreshDataGrid(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string queryString = $"select НазваниеУслуги,Цена from Дополнительные_услуги";

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

        private void metroButton1_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }
    }
}
