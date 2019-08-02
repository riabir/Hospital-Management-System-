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
    public partial class room : Form
    {
        SqlConnection c = new SqlConnection(@"Data Source=desktop-n4o1quk;Initial Catalog=hospital1;Integrated Security=True");
        bool st = true;
        public room()
        {
            InitializeComponent();
            Display();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlDataAdapter cc = new SqlDataAdapter(" SELECT room_no FROM room", c);

            DataTable dw = new DataTable();

            cc.Fill(dw);


            foreach (DataRow item in dw.Rows)
            {

                int n = 0;
                string[] wn = new string[4];
                wn[n] = item[0].ToString();


                if (rroomno.Text == wn[n])
                {
                    MessageBox.Show("Already added.\n Add another.");
                    this.Close();
                    room p = new room();
                    p.Show();
                    st = false;
                }
            }

            if (st)
            {
                if (rroomno.Text == "" || rroomtype.Text == "" || rsitcharge.Text == "" )
                {
                    MessageBox.Show("Fill all boxes");
                    this.Close();
                    room p = new room();
                    p.Show();

                }
                else
                {

                    c.Open();
                    SqlCommand cm = new SqlCommand(@"INSERT INTO room
                         (room_no, room_type, charge)
VALUES        ('" + rroomno.Text + "','" + rroomtype.Text + "','" + rsitcharge.Text + "') ", c);
                    cm.ExecuteNonQuery();
                    c.Close();

                    Display();
                    MessageBox.Show("Room added");
                }
                st = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Main m = new Main();
            m.Show();
        }

        private void room_Load(object sender, EventArgs e)
        {

        }


        void Display()
        {

            SqlDataAdapter cm = new SqlDataAdapter("SELECT * FROM room ", c);

            DataTable dt = new DataTable();

            cm.Fill(dt);

            dataGridView1.Rows.Clear();

            foreach (DataRow item in dt.Rows)
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = item[0].ToString();
                dataGridView1.Rows[n].Cells[1].Value = item[1].ToString();
                dataGridView1.Rows[n].Cells[2].Value = item[2].ToString();
               
            }

        }
        
    }
}
