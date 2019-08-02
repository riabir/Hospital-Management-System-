using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HospitalmanagementSystem
{
    
    public partial class Form1 : Form
    {
        SqlConnection c = new SqlConnection(@"Data Source=desktop-n4o1quk;Initial Catalog=hospital1;Integrated Security=True");
        
        bool t1 = false;
        bool t2 = false;
        public Form1()
        {
            
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if// (textBox1.Text == "Abir" &&
                (textBox2.Text == "2544")

            {
                this.Hide();
                patient ss = new patient();
                ss.Show();
            }
            else
            {

                MessageBox.Show("Please check your password");
            }
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {

        }

       

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
            register r = new register();
            r.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Hide();
            reset r = new reset();
            r.Show();
        }

       
    }
}
