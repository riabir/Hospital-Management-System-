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
    public partial class bill : Form
    {
        SqlConnection c = new SqlConnection(@"Data Source=desktop-n4o1quk;Initial Catalog=hospital1;Integrated Security=True");
        int i = 1;

        public bill()
        {
            
            InitializeComponent();
            
            billno.Text = i.ToString();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            SqlDataAdapter cm = new SqlDataAdapter(@"SELECT    patient.p_name, patient.p_age, patient.p_gender, patient.admit_date, room.charge
FROM            patient INNER JOIN
                         word ON patient.w_no = word.w_no INNER JOIN
                         room ON word.room_no = room.room_no WHERE (patient.p_id = '"+pid.Text+"')", c);

            DataTable dt = new DataTable();

            cm.Fill(dt);

            

            foreach (DataRow item in dt.Rows)
            {
                
                 
                pname.Text =  item[0].ToString();
                page.Text =  item[1].ToString();
                pgender.Text =  item[2].ToString();
                padmitdate.Text =  item[3].ToString();
                pdischargedate.Text = dateTimePicker1.Text;
                proomcharge.Text =  item[4].ToString();

            }
        }

        private void bill_Load(object sender, EventArgs e)
        {

        }

        

        

        
        
    }
}
