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
    

    public partial class word : Form
    {
        SqlConnection c = new SqlConnection(@"Data Source=desktop-n4o1quk;Initial Catalog=hospital1;Integrated Security=True");
        bool st = true;
        public word()
        {
            InitializeComponent();
            Display();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Main m = new Main();
            m.Show();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            SqlDataAdapter cc = new SqlDataAdapter(" SELECT w_no FROM word", c);

            DataTable dw = new DataTable();

            cc.Fill(dw);


            foreach (DataRow item in dw.Rows)
            {

                int n = 0;
                string[] wn = new string[4];
                wn[n] = item[0].ToString();


                if (wno.Text == wn[n])
                {
                    MessageBox.Show("Already added.\n Add another.");
                    this.Close();
                    word p = new word();
                    p.Show();
                    st = false;
                }
            }

                if(st)
                {
                    if (wno.Text == "" || category.Text == "" || building.Text == "" || roomno.Text == "")
                    {
                        MessageBox.Show("Fill all boxes");
                        this.Close();
                        word p = new word();
                        p.Show();

                    }
                    else
                    {
                        c.Open();
                        SqlCommand cm = new SqlCommand(@"INSERT INTO word
                        (w_no, category, buildig, room_no)
             VALUES        ('" + wno.Text + "','" + category.Text + "','" + building.Text + "','" + roomno.Text + "')", c);
                        cm.ExecuteNonQuery();
                        c.Close();
                        Display();
                        MessageBox.Show("Successfully added.");
                    }
                    st = false;
                }

            }
        



        private void word_Load(object sender, EventArgs e)
        {

        }

        void Display()
        {

            SqlDataAdapter cm = new SqlDataAdapter("SELECT * FROM word ", c);

            DataTable dt = new DataTable();

            cm.Fill(dt);

            dataGridView1.Rows.Clear();

            foreach (DataRow item in dt.Rows)
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = item[0].ToString();
                dataGridView1.Rows[n].Cells[1].Value = item[1].ToString();
                dataGridView1.Rows[n].Cells[2].Value = item[2].ToString();
                dataGridView1.Rows[n].Cells[3].Value = item[3].ToString();
         
            }

        }

        
    }
}
