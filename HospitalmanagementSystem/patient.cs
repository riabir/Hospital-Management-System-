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
    public partial class patient : Form
    {

        SqlConnection c = new SqlConnection(@"Data Source=desktop-n4o1quk;Initial Catalog=hospital1;Integrated Security=True");
        bool st = true;
        public patient()
        {
            
            InitializeComponent();
            psearchtype.SelectedIndex = 0;
            Display();
            Displayw();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            admitdate.Text = dateTimePicker1.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlDataAdapter cc = new SqlDataAdapter(" SELECT p_id FROM patient", c);

            DataTable dw = new DataTable();

            cc.Fill(dw);


            foreach (DataRow item in dw.Rows)
            {

                int n = 0;
                string[] wn = new string[4];
                wn[n] = item[0].ToString();


                if (pid.Text == wn[n])
                {
                    MessageBox.Show("Already added.\n Add another.");
                    this.Close();
                    patient p = new patient();
                    p.Show();

                    st = false;
                }
            }

            if (st)
            {
                if (pid.Text == "" || pname.Text == "" || pgender.Text == "" || pcity.Text == "" || pcountry.Text == "" || pmobile.Text == "" || pword.Text == "" || pdid.Text == "" || admitdate.Text == "" || proomno.Text == "")
                {
                    MessageBox.Show("Fill all boxes");
                    this.Close();
                    patient p = new patient();
                    p.Show();

                }
                else
                {
                    c.Open();

                    SqlCommand cm = new SqlCommand("INSERT INTO patient (p_id, p_name, p_gender, p_age, city, country, p_mobile, w_no, d_id, admit_date,room_no) VALUES ('" + pid.Text + "','" + pname.Text + "','" + pgender.Text + "','" + page.Text + "','" + pcity.Text + "','" + pcountry.Text + "','" + pmobile.Text + "','" + pword.Text + "','" + pdid.Text + "','" + admitdate.Text + "','" + proomno.Text + "')", c);
                    cm.ExecuteNonQuery();
                    c.Close();


                    MessageBox.Show("Successfully Added.");
                    Display();
                    Displayw();
                    pid.Text = "";
                    pname.Text = "";
                    pgender.SelectedIndex = -1;
                    page.Text = "";
                    pcity.Text = "";
                    pcountry.SelectedIndex = -1;
                    pmobile.Text = "";
                    pword.Text = "";
                    pdid.Text = "";
                    admitdate.Text = "";
                    psearchtype.SelectedIndex = 0;
                    proomtype.SelectedIndex = -1;
                    psitcharge.SelectedIndex = -1;
                    proomno.SelectedIndex = -1;
                    st = false;
                }

            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            c.Open();
            SqlCommand cm = new SqlCommand(@"UPDATE patient
              SET  p_id = '" + pid.Text + "', p_name = '" + pname.Text + "', p_gender = '" + pgender.Text + "', p_age = '" + page.Text + "', city = '" + pcity.Text + "', country = '" + pcountry.Text + "', p_mobile = '" + pmobile.Text + "', w_no = '" + pword.Text + "', d_id = '" + pdid.Text + "', admit_date = '" + admitdate.Text + "' WHERE (p_id = '" + pid.Text + "')",c);
            cm.ExecuteNonQuery();
            c.Close();
            
            MessageBox.Show("Successfully Updated.");
            Display();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            c.Open();
            SqlCommand cm = new SqlCommand("DELETE  FROM patient WHERE (p_id = '" + pid.Text + "') ",c);
            cm.ExecuteNonQuery();
            c.Close();
            
            MessageBox.Show("Successfully Deleted.");
            Display();

        }

        void Display()
        {
            
            SqlDataAdapter cm = new SqlDataAdapter("SELECT * FROM patient ",c);
           
            DataTable dt = new DataTable();

            cm.Fill(dt);

             dataGridView1.Rows.Clear();

            foreach(DataRow item in dt.Rows)
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = item[0].ToString();
                dataGridView1.Rows[n].Cells[1].Value = item[1].ToString();
                dataGridView1.Rows[n].Cells[2].Value = item[2].ToString();
                dataGridView1.Rows[n].Cells[3].Value = item[3].ToString();
                dataGridView1.Rows[n].Cells[4].Value = item[4].ToString();
                dataGridView1.Rows[n].Cells[5].Value = item[5].ToString();
                dataGridView1.Rows[n].Cells[6].Value = item[6].ToString();
                dataGridView1.Rows[n].Cells[7].Value = item[7].ToString();
                dataGridView1.Rows[n].Cells[8].Value = item[8].ToString();
                dataGridView1.Rows[n].Cells[9].Value = item[9].ToString();
                dataGridView1.Rows[n].Cells[10].Value = item[10].ToString();
            }

        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            string test = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            if (test == "")
            {
                MessageBox.Show("You have selected an empty row.");
            }
            else
            {
                pid.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                pname.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                pgender.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                page.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                pcity.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                pcountry.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                pmobile.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
                pword.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
                pdid.Text = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
                admitdate.Text = dataGridView1.SelectedRows[0].Cells[9].Value.ToString();
                proomno.Text = dataGridView1.SelectedRows[0].Cells[10].Value.ToString();
            }
            
        }

        private void F5_Click(object sender, EventArgs e)
        {
            pid.Text = "";
            pname.Text = "";
            pgender.SelectedIndex = -1;
            page.Text = "";
            pcity.Text = "";
            pcountry.SelectedIndex = -1;
            pmobile.Text = "";
            pword.Text = "";
            pdid.Text = "";
            admitdate.Text = "";
            psearch.Text = "";
            psearchtype.SelectedIndex = 0;
            proomtype.SelectedIndex= -1;
            psitcharge.SelectedIndex = -1;
            proomno.SelectedIndex = -1;
        }

        
        private void button4_Click(object sender, EventArgs e)
        {
            word w = new word();
            this.Hide();
            w.Show();
        }

        void Displayw()
        {

            SqlDataAdapter cm = new SqlDataAdapter(@"SELECT        patient.p_id, word.w_no, room.room_no, room.room_type
FROM            patient INNER JOIN
                         word ON patient.w_no = word.w_no INNER JOIN
                         room ON word.room_no = room.room_no", c);

            DataTable dt = new DataTable();

            cm.Fill(dt);

            dataGridView2.Rows.Clear();

            foreach (DataRow item in dt.Rows)
            {
                int n = dataGridView2.Rows.Add();
                dataGridView2.Rows[n].Cells[0].Value = item[0].ToString();
                dataGridView2.Rows[n].Cells[1].Value = item[1].ToString();
                dataGridView2.Rows[n].Cells[2].Value = item[2].ToString();
                dataGridView2.Rows[n].Cells[3].Value = item[3].ToString();
                
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            SqlDataAdapter cc = new SqlDataAdapter(" SELECT room_no FROM room", c);

            DataTable dw = new DataTable();

            cc.Fill(dw);


            foreach (DataRow item in dw.Rows)
            {

                int n = 0;
                string[] wn = new string[4];
                wn[n] = item[0].ToString();


                if (proomno.Text == wn[n])
                {
                    MessageBox.Show("Already added.\n Add another.");
                    this.Close();
                    patient p = new patient();
                    p.Show();
                    st = false;
                }
            }

            if (st)
            {
                if (proomno.Text == "" || proomtype.Text == "" || psitcharge.Text == "")
                {
                    MessageBox.Show("Fill all boxes");
                    this.Close();
                    patient p = new patient();
                    p.Show();

                }
                else
                {

                    c.Open();
                    SqlCommand cm = new SqlCommand(@"INSERT INTO room
                         (room_no, room_type, charge)
VALUES        ('" + proomno.Text + "','" + proomtype.Text + "','" + psitcharge.Text + "') ", c);
                    cm.ExecuteNonQuery();
                    c.Close();

                    Display();
                    MessageBox.Show("Room added");
                }
                st = false;
            }
            
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            this.Close();
            Main m = new Main();
            m.Show();
        }

        private void psearch_TextChanged(object sender, EventArgs e)
        {
            switch (psearchtype.Text)
            { 
            
                case "Name":
                    SqlDataAdapter cm = new SqlDataAdapter("SELECT * FROM patient WHERE p_name like ('%"+psearch.Text+"%')",c);
           
            DataTable dt = new DataTable();

            cm.Fill(dt);

             dataGridView1.Rows.Clear();

            foreach(DataRow item in dt.Rows)
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = item[0].ToString();
                dataGridView1.Rows[n].Cells[1].Value = item[1].ToString();
                dataGridView1.Rows[n].Cells[2].Value = item[2].ToString();
                dataGridView1.Rows[n].Cells[3].Value = item[3].ToString();
                dataGridView1.Rows[n].Cells[4].Value = item[4].ToString();
                dataGridView1.Rows[n].Cells[5].Value = item[5].ToString();
                dataGridView1.Rows[n].Cells[6].Value = item[6].ToString();
                dataGridView1.Rows[n].Cells[7].Value = item[7].ToString();
                dataGridView1.Rows[n].Cells[8].Value = item[8].ToString();
                dataGridView1.Rows[n].Cells[9].Value = item[9].ToString();
            }
                    break;


                case "ID":
                    SqlDataAdapter cmid = new SqlDataAdapter("SELECT * FROM patient WHERE p_id like ('%" + psearch.Text + "%')", c);

                    DataTable dtid = new DataTable();

                    cmid.Fill(dtid);

                    dataGridView1.Rows.Clear();

                    foreach (DataRow item in dtid.Rows)
                    {
                        int n = dataGridView1.Rows.Add();
                        dataGridView1.Rows[n].Cells[0].Value = item[0].ToString();
                        dataGridView1.Rows[n].Cells[1].Value = item[1].ToString();
                        dataGridView1.Rows[n].Cells[2].Value = item[2].ToString();
                        dataGridView1.Rows[n].Cells[3].Value = item[3].ToString();
                        dataGridView1.Rows[n].Cells[4].Value = item[4].ToString();
                        dataGridView1.Rows[n].Cells[5].Value = item[5].ToString();
                        dataGridView1.Rows[n].Cells[6].Value = item[6].ToString();
                        dataGridView1.Rows[n].Cells[7].Value = item[7].ToString();
                        dataGridView1.Rows[n].Cells[8].Value = item[8].ToString();
                        dataGridView1.Rows[n].Cells[9].Value = item[9].ToString();
                    }
                    break;

                case "Mobile":
                    SqlDataAdapter cmobile = new SqlDataAdapter("SELECT * FROM patient WHERE p_mobile like ('%" + psearch.Text + "%')", c);

                    DataTable dtmobile = new DataTable();

                    cmobile.Fill(dtmobile);

                    dataGridView1.Rows.Clear();

                    foreach (DataRow item in dtmobile.Rows)
                    {
                        int n = dataGridView1.Rows.Add();
                        dataGridView1.Rows[n].Cells[0].Value = item[0].ToString();
                        dataGridView1.Rows[n].Cells[1].Value = item[1].ToString();
                        dataGridView1.Rows[n].Cells[2].Value = item[2].ToString();
                        dataGridView1.Rows[n].Cells[3].Value = item[3].ToString();
                        dataGridView1.Rows[n].Cells[4].Value = item[4].ToString();
                        dataGridView1.Rows[n].Cells[5].Value = item[5].ToString();
                        dataGridView1.Rows[n].Cells[6].Value = item[6].ToString();
                        dataGridView1.Rows[n].Cells[7].Value = item[7].ToString();
                        dataGridView1.Rows[n].Cells[8].Value = item[8].ToString();
                        dataGridView1.Rows[n].Cells[9].Value = item[9].ToString();
                    }
                    break;

                case "Gender":
                    SqlDataAdapter cg = new SqlDataAdapter("SELECT * FROM patient WHERE p_gender like ('%" + psearch.Text + "%')", c);

                    DataTable dg = new DataTable();

                    cg.Fill(dg);

                    dataGridView1.Rows.Clear();

                    foreach (DataRow item in dg.Rows)
                    {
                        int n = dataGridView1.Rows.Add();
                        dataGridView1.Rows[n].Cells[0].Value = item[0].ToString();
                        dataGridView1.Rows[n].Cells[1].Value = item[1].ToString();
                        dataGridView1.Rows[n].Cells[2].Value = item[2].ToString();
                        dataGridView1.Rows[n].Cells[3].Value = item[3].ToString();
                        dataGridView1.Rows[n].Cells[4].Value = item[4].ToString();
                        dataGridView1.Rows[n].Cells[5].Value = item[5].ToString();
                        dataGridView1.Rows[n].Cells[6].Value = item[6].ToString();
                        dataGridView1.Rows[n].Cells[7].Value = item[7].ToString();
                        dataGridView1.Rows[n].Cells[8].Value = item[8].ToString();
                        dataGridView1.Rows[n].Cells[9].Value = item[9].ToString();
                    }
                    break;

                case "Age":
                    SqlDataAdapter ce = new SqlDataAdapter("SELECT * FROM patient WHERE p_age like ('%" + psearch.Text + "%')", c);

                    DataTable de = new DataTable();

                    ce.Fill(de);

                    dataGridView1.Rows.Clear();

                    foreach (DataRow item in de.Rows)
                    {
                        int n = dataGridView1.Rows.Add();
                        dataGridView1.Rows[n].Cells[0].Value = item[0].ToString();
                        dataGridView1.Rows[n].Cells[1].Value = item[1].ToString();
                        dataGridView1.Rows[n].Cells[2].Value = item[2].ToString();
                        dataGridView1.Rows[n].Cells[3].Value = item[3].ToString();
                        dataGridView1.Rows[n].Cells[4].Value = item[4].ToString();
                        dataGridView1.Rows[n].Cells[5].Value = item[5].ToString();
                        dataGridView1.Rows[n].Cells[6].Value = item[6].ToString();
                        dataGridView1.Rows[n].Cells[7].Value = item[7].ToString();
                        dataGridView1.Rows[n].Cells[8].Value = item[8].ToString();
                        dataGridView1.Rows[n].Cells[9].Value = item[9].ToString();
                    }
                    break;

                case "Country":
                    SqlDataAdapter cco = new SqlDataAdapter("SELECT * FROM patient WHERE country like ('%" + psearch.Text + "%')", c);

                    DataTable dco = new DataTable();

                    cco.Fill(dco);

                    dataGridView1.Rows.Clear();

                    foreach (DataRow item in dco.Rows)
                    {
                        int n = dataGridView1.Rows.Add();
                        dataGridView1.Rows[n].Cells[0].Value = item[0].ToString();
                        dataGridView1.Rows[n].Cells[1].Value = item[1].ToString();
                        dataGridView1.Rows[n].Cells[2].Value = item[2].ToString();
                        dataGridView1.Rows[n].Cells[3].Value = item[3].ToString();
                        dataGridView1.Rows[n].Cells[4].Value = item[4].ToString();
                        dataGridView1.Rows[n].Cells[5].Value = item[5].ToString();
                        dataGridView1.Rows[n].Cells[6].Value = item[6].ToString();
                        dataGridView1.Rows[n].Cells[7].Value = item[7].ToString();
                        dataGridView1.Rows[n].Cells[8].Value = item[8].ToString();
                        dataGridView1.Rows[n].Cells[9].Value = item[9].ToString();
                    }
                    break;

                case "City":
                    SqlDataAdapter cci = new SqlDataAdapter("SELECT * FROM patient WHERE city like ('%" + psearch.Text + "%')", c);

                    DataTable dci = new DataTable();

                    cci.Fill(dci);

                    dataGridView1.Rows.Clear();

                    foreach (DataRow item in dci.Rows)
                    {
                        int n = dataGridView1.Rows.Add();
                        dataGridView1.Rows[n].Cells[0].Value = item[0].ToString();
                        dataGridView1.Rows[n].Cells[1].Value = item[1].ToString();
                        dataGridView1.Rows[n].Cells[2].Value = item[2].ToString();
                        dataGridView1.Rows[n].Cells[3].Value = item[3].ToString();
                        dataGridView1.Rows[n].Cells[4].Value = item[4].ToString();
                        dataGridView1.Rows[n].Cells[5].Value = item[5].ToString();
                        dataGridView1.Rows[n].Cells[6].Value = item[6].ToString();
                        dataGridView1.Rows[n].Cells[7].Value = item[7].ToString();
                        dataGridView1.Rows[n].Cells[8].Value = item[8].ToString();
                        dataGridView1.Rows[n].Cells[9].Value = item[9].ToString();
                    }
                    break;

            }
        }

        private void proomno_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (proomno.Text != "")
            {
                SqlDataAdapter cm = new SqlDataAdapter(@"SELECT  room_no, room_type, charge
FROM            room WHERE (room_no = '" + proomno.Text + "')", c);

                DataTable dt = new DataTable();

                cm.Fill(dt);

                foreach (DataRow item in dt.Rows)
                {


                    if (proomno.Text != item[0].ToString())
                    {
                        proomtype.SelectedIndex = -1;
                        psitcharge.SelectedIndex = -1;



                    }
                    if (proomno.Text == item[0].ToString())
                    {
                        proomtype.Text = item[1].ToString(); ;
                        psitcharge.Text = item[2].ToString(); ;



                    }
                }
                
            }
        }
        

        
       
    }
}
