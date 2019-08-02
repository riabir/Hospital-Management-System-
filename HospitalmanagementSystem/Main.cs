using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HospitalmanagementSystem
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            patient pt = new patient();
            pt.Show();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            word w = new word();
            w.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            room r = new room();
            r.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            doctor d = new doctor();
            d.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            bill b = new bill();
            b.Show();
        }
    }
}
