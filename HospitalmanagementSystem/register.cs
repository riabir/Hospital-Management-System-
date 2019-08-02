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
    public partial class register : Form
    {
        SqlConnection c = new SqlConnection(@"Data Source=desktop-n4o1quk;Initial Catalog=hospital1;Integrated Security=True");
        
        public register()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox5.Text == textBox6.Text)
            {
                c.Open();
                SqlCommand cm = new SqlCommand(@"INSERT INTO register
                         (First_name, Last_name, Email, username, passward)
VALUES        ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox6.Text + "')", c);

                cm.ExecuteNonQuery();
                c.Close();
                MessageBox.Show("Registration Successfull.");
                this.Close();
                Form1 r = new Form1();
                r.Show();
            }
            else 
            {
                MessageBox.Show("Passward does mot mach.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 r = new Form1();
            r.Show();
        }
        }
    
}
