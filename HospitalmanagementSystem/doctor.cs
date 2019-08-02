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
    public partial class doctor : Form
    {
        bool st = true;
       
        SqlConnection c = new SqlConnection(@"Data Source=desktop-n4o1quk;Initial Catalog=hospital1;Integrated Security=True");
       
        public doctor()
        {
            InitializeComponent();
            Display();
            dsearchcategory.SelectedIndex = 0;
            
        }

        void Display()
        {

            SqlDataAdapter cm = new SqlDataAdapter("SELECT * FROM doctor ", c);

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
                dataGridView1.Rows[n].Cells[4].Value = item[4].ToString();
                dataGridView1.Rows[n].Cells[5].Value = item[5].ToString();
                dataGridView1.Rows[n].Cells[6].Value = item[6].ToString();
                dataGridView1.Rows[n].Cells[7].Value = item[7].ToString();
                dataGridView1.Rows[n].Cells[8].Value = item[8].ToString();
                
            }
      
        }

        private void button1_Click(object sender, EventArgs e)
        {

            SqlDataAdapter cc = new SqlDataAdapter(" SELECT d_id FROM doctor", c);

            DataTable dw = new DataTable();

            cc.Fill(dw);


            foreach (DataRow item in dw.Rows)
            {

                int n = 0;
                string[] wn = new string[4];
                wn[n] = item[0].ToString();


                if (did.Text == wn[n])
                {
                    MessageBox.Show("Already Exist.\n  Try again");
                    this.Close();
                    doctor d = new doctor();
                    d.Show();
                    st = false;
                }
            }

            if (st)
            {
                if (did.Text == "" || dname.Text == "" || dgender.Text == "" || dage.Text == "" || dq.Text == "" || dsalary.Text == "" || dmobile.Text == "" || daddress.Text == "" || dword.Text == "")
                {
                    MessageBox.Show("Fill all boxes");

                }
                else
                {

                    c.Open();

                    SqlCommand cm = new SqlCommand(@"INSERT INTO 
                                        doctor (d_id, d_name, d_gender, d_age, qualification,salary, d_mobile, d_address, w_no) 
              VALUES ('" + did.Text + "','" + dname.Text + "','" + dgender.Text + "','" + dage.Text + "','" + dq.Text + "','" + dsalary.Text + "','" + dmobile.Text + "','" + daddress.Text + "','" + dword.Text + "')", c);
                    cm.ExecuteNonQuery();
                    c.Close();

                    MessageBox.Show("Successfully Added.");
                    Display();
                    
                    did.Text = "";
                    dname.Text = "";
                    dgender.SelectedIndex = -1;
                    dage.Text = "";
                    dq.Text = "";
                    dsalary.Text = "";
                    dmobile.Text = "";
                    dword.SelectedIndex = -1;
                    daddress.Text = "";
                    dsearch.Text = "";
                    dsearchcategory.SelectedIndex = 0;
                }
                st = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            did.Text = "";
            dname.Text = "";
            dgender.SelectedIndex = -1;
            dage.Text = "";
            dq.Text = "";
            dsalary.Text = "";
            dmobile.Text = "";
            dword.Text = "";
            daddress.Text = "";
            dsearch.Text = "";
            dsearchcategory.SelectedIndex = 0;
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            Main m = new Main();
            m.Show();
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            did.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
           dname.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            dgender.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            dage.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            dq.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            dsalary.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            dmobile.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            daddress.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
            dword.Text = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            c.Open();
            SqlCommand cm = new SqlCommand(@"UPDATE doctor
              SET  d_id = '" + did.Text + "', d_name = '" + dname.Text + "', d_gender = '" + dgender.Text + "', d_age = '" + dage.Text + "', qualification = '" + dq.Text + "', salary = '" + dsalary.Text + "', d_mobile = '" + dmobile.Text + "', d_address = '" + daddress.Text + "', w_no = '" + dword.Text + "' WHERE (d_id = '" + did.Text + "')", c);
            cm.ExecuteNonQuery();
            c.Close();

            MessageBox.Show("Successfully Updated.");
            Display();
        }

        private void doctor_Load(object sender, EventArgs e)
        {

        }

        private void dsearch_TextChanged(object sender, EventArgs e)
        {
            

            switch (dsearchcategory.Text)
            { 
            
                case "Name":
                    SqlDataAdapter cm = new SqlDataAdapter("SELECT * FROM doctor WHERE d_name like ('%"+dsearch.Text+"%')",c);
           
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
              
            }
                    break;


                case "ID":
                    SqlDataAdapter cmid = new SqlDataAdapter("SELECT * FROM doctor WHERE d_id like ('%" + dsearch.Text + "%')", c);

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
                     
                    }
                    break;

                case "Mobile":
                    SqlDataAdapter cmobile = new SqlDataAdapter("SELECT * FROM doctor WHERE d_mobile like ('%" + dsearch.Text + "%')", c);

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
                       
                    }
                    break;

                case "Gender":
                    SqlDataAdapter cg = new SqlDataAdapter("SELECT * FROM doctor WHERE d_gender like ('%" + dsearch.Text + "%')", c);

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
                   
                    }
                    break;

                case "Age":
                    SqlDataAdapter ce = new SqlDataAdapter("SELECT * FROM doctor WHERE d_age like ('%" + dsearch.Text + "%')", c);

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
                  
                    }
                    break;

                case "Qualification":
                    SqlDataAdapter cco = new SqlDataAdapter("SELECT * FROM doctor WHERE qualification like ('%" + dsearch.Text + "%')", c);

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
                   
                    }
                    break;

                case "Salary >":
                    SqlDataAdapter cci = new SqlDataAdapter("SELECT * FROM doctor WHERE salary >  ('" + dsearch.Text + "')", c);

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
                       
                    }
                    break;

                case "Salary <":
                    SqlDataAdapter ccl = new SqlDataAdapter("SELECT * FROM doctor WHERE salary <  ('" + dsearch.Text + "')", c);

                    DataTable dcl = new DataTable();

                    ccl.Fill(dcl);

                    dataGridView1.Rows.Clear();

                    foreach (DataRow item in dcl.Rows)
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
                      
                    }
                    break;

            }
        }

        
    }
}
