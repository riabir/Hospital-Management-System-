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
    public partial class newpass : Form
    {
        SqlConnection c = new SqlConnection(@"Data Source=desktop-n4o1quk;Initial Catalog=hospital1;Integrated Security=True");
        
        public newpass()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlDataAdapter cp = new SqlDataAdapter(@" SELECT        First_name, Last_name, Email, username, passward
FROM            register", c);

            DataTable dpt = new DataTable();

            cp.Fill(dpt);


            foreach (DataRow item in dpt.Rows)
            {

                int n = 0;
                string[] fs = new string[4];
                string[] ls = new string[4];
                string[] em = new string[4];
                string[] us = new string[4];
                string[] ps = new string[4];

                fs[n] = item[0].ToString();
                ls[n] = item[1].ToString();
                em[n] = item[2].ToString();
                us[n] = item[3].ToString();
                ps[n] = item[4].ToString();


                if (usr.Text == us[n])
                {
                    string first = fs[n];
                    string lirst = ls[n];
                    string email = em[n];
                    string user = us[n];
                    string pass = ps[n];

                    c.Open();
                    SqlCommand cm = new SqlCommand(@"UPDATE       register
          SET   username = '" + user + "' ,passward = '" + textBox2.Text + "'", c);
                    cm.ExecuteNonQuery();
                    c.Close();

                    MessageBox.Show("Password reset successfull.");
                    this.Close();
            Form1 r = new Form1();
            r.Show();

                    break;
                }
                else
                { 
                    
                }
               
            }

            
            

        }
    }
}
