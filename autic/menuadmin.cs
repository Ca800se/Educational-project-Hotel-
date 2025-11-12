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
    public partial class menuadmin : MetroFramework.Forms.MetroForm

    {
        BASE database = new BASE();
     
        public menuadmin()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            baseklient baseklient = new baseklient();
            addUserControl(baseklient);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Adminuslug adminuslug = new Adminuslug();
            this.Hide();
            adminuslug.ShowDialog();
            this.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            adduslugi adduslugi = new adduslugi();
            addUserControl(adduslugi);
            
        }



        private void buttonadd_Click(object sender, EventArgs e)
        {
            addklient addklient = new addklient();
            addklient.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            addnumbers addnumbers = new addnumbers();
            addUserControl(addnumbers);
        }
        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panel1.Controls.Clear();
            panel1.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

       
    }
}
