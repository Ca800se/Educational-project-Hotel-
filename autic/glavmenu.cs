using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace autic
{
    public partial class glavmenu : MetroFramework.Forms.MetroForm
    {
        BASE database = new BASE();
        public glavmenu()
        {
            InitializeComponent();
        }

        private void glavmenu_Load(object sender, EventArgs e)
        {
       
            timer2.Start();
            label6.Text = DateTime.Now.ToShortTimeString();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            uslugi uslugi = new uslugi();
            this.Hide();
            uslugi.ShowDialog();
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Numbers Numbers = new Numbers();
            this.Hide();
            Numbers.ShowDialog();
            this.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            information information = new information();
            this.Hide();
            information.ShowDialog();
            this.Show();


        }

        private void metroLink1_Click(object sender, EventArgs e)
        {
            LoginForm glstr = new LoginForm();
            this.Hide();
            glstr.ShowDialog();
            this.Show();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            bronirovanie bronirovanie = new bronirovanie();
            this.Hide();
            bronirovanie.ShowDialog();
            this.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
         
           
            
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            label6.Text = DateTime.Now.ToShortTimeString();
            timer2.Start();
        }
    }
}
