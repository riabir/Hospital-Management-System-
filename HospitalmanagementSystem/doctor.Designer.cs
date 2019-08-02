namespace HospitalmanagementSystem
{
    partial class doctor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(doctor));
            this.button1 = new System.Windows.Forms.Button();
            this.dword = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.did = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.dname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dsearch = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dage = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dq = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dsalary = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.daddress = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dmobile = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dgender = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.dsearchcategory = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Location = new System.Drawing.Point(185, 355);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dword
            // 
            this.dword.BackColor = System.Drawing.Color.DarkCyan;
            this.dword.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dword.ForeColor = System.Drawing.SystemColors.Window;
            this.dword.FormattingEnabled = true;
            this.dword.Items.AddRange(new object[] {
            "ACC",
            "MEN",
            "PREG",
            "BRN"});
            this.dword.Location = new System.Drawing.Point(124, 321);
            this.dword.Name = "dword";
            this.dword.Size = new System.Drawing.Size(153, 28);
            this.dword.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(75, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID :";
            // 
            // did
            // 
            this.did.BackColor = System.Drawing.Color.DarkCyan;
            this.did.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.did.ForeColor = System.Drawing.SystemColors.Window;
            this.did.Location = new System.Drawing.Point(124, 22);
            this.did.Name = "did";
            this.did.Size = new System.Drawing.Size(153, 26);
            this.did.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9});
            this.dataGridView1.Location = new System.Drawing.Point(311, 221);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(544, 161);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            this.Column1.Width = 60;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Name";
            this.Column2.Name = "Column2";
            this.Column2.Width = 140;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Gender";
            this.Column3.Name = "Column3";
            this.Column3.Width = 60;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Age";
            this.Column4.Name = "Column4";
            this.Column4.Width = 40;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Qalification";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Salary";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Mobile";
            this.Column7.Name = "Column7";
            this.Column7.Width = 120;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Address";
            this.Column8.Name = "Column8";
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Word";
            this.Column9.Name = "Column9";
            this.Column9.Width = 60;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(50, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name :";
            // 
            // dname
            // 
            this.dname.BackColor = System.Drawing.Color.DarkCyan;
            this.dname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dname.ForeColor = System.Drawing.SystemColors.Window;
            this.dname.Location = new System.Drawing.Point(124, 54);
            this.dname.Name = "dname";
            this.dname.Size = new System.Drawing.Size(153, 26);
            this.dname.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(38, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Gender :";
            // 
            // dsearch
            // 
            this.dsearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dsearch.Location = new System.Drawing.Point(598, 176);
            this.dsearch.Name = "dsearch";
            this.dsearch.Size = new System.Drawing.Size(244, 26);
            this.dsearch.TabIndex = 13;
            this.dsearch.TextChanged += new System.EventHandler(this.dsearch_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(63, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Age :";
            // 
            // dage
            // 
            this.dage.BackColor = System.Drawing.Color.DarkCyan;
            this.dage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dage.ForeColor = System.Drawing.SystemColors.Window;
            this.dage.Location = new System.Drawing.Point(124, 118);
            this.dage.Name = "dage";
            this.dage.Size = new System.Drawing.Size(153, 26);
            this.dage.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Qualification :";
            // 
            // dq
            // 
            this.dq.BackColor = System.Drawing.Color.DarkCyan;
            this.dq.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dq.ForeColor = System.Drawing.SystemColors.Window;
            this.dq.Location = new System.Drawing.Point(124, 150);
            this.dq.Name = "dq";
            this.dq.Size = new System.Drawing.Size(153, 26);
            this.dq.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(48, 185);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "Salary :";
            // 
            // dsalary
            // 
            this.dsalary.BackColor = System.Drawing.Color.DarkCyan;
            this.dsalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dsalary.ForeColor = System.Drawing.SystemColors.Window;
            this.dsalary.Location = new System.Drawing.Point(124, 182);
            this.dsalary.Name = "dsalary";
            this.dsalary.Size = new System.Drawing.Size(153, 26);
            this.dsalary.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(33, 260);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 20);
            this.label7.TabIndex = 2;
            this.label7.Text = "Address :";
            // 
            // daddress
            // 
            this.daddress.BackColor = System.Drawing.Color.DarkCyan;
            this.daddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.daddress.ForeColor = System.Drawing.SystemColors.Window;
            this.daddress.Location = new System.Drawing.Point(124, 257);
            this.daddress.Multiline = true;
            this.daddress.Name = "daddress";
            this.daddress.Size = new System.Drawing.Size(153, 55);
            this.daddress.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(46, 217);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 20);
            this.label8.TabIndex = 2;
            this.label8.Text = "Mobile :";
            // 
            // dmobile
            // 
            this.dmobile.BackColor = System.Drawing.Color.DarkCyan;
            this.dmobile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dmobile.ForeColor = System.Drawing.SystemColors.Window;
            this.dmobile.Location = new System.Drawing.Point(124, 214);
            this.dmobile.Name = "dmobile";
            this.dmobile.Size = new System.Drawing.Size(153, 26);
            this.dmobile.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(54, 321);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 20);
            this.label9.TabIndex = 2;
            this.label9.Text = "Word :";
            // 
            // dgender
            // 
            this.dgender.BackColor = System.Drawing.Color.DarkCyan;
            this.dgender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dgender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgender.ForeColor = System.Drawing.SystemColors.Window;
            this.dgender.FormattingEnabled = true;
            this.dgender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.dgender.Location = new System.Drawing.Point(124, 86);
            this.dgender.Name = "dgender";
            this.dgender.Size = new System.Drawing.Size(153, 28);
            this.dgender.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.Controls.Add(this.daddress);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.dmobile);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.dsalary);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.dq);
            this.panel2.Controls.Add(this.dage);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.dname);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.did);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.dgender);
            this.panel2.Controls.Add(this.dword);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Location = new System.Drawing.Point(11, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(289, 387);
            this.panel2.TabIndex = 6;
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(335, 10);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(114, 39);
            this.button2.TabIndex = 11;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button3.Location = new System.Drawing.Point(335, 58);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(114, 39);
            this.button3.TabIndex = 12;
            this.button3.Text = "Refresh";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(528, 179);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 20);
            this.label10.TabIndex = 2;
            this.label10.Text = "Search :";
            // 
            // button4
            // 
            this.button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button4.BackgroundImage")));
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button4.Location = new System.Drawing.Point(335, 106);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(114, 39);
            this.button4.TabIndex = 11;
            this.button4.Text = "Home";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // dsearchcategory
            // 
            this.dsearchcategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dsearchcategory.FormattingEnabled = true;
            this.dsearchcategory.Items.AddRange(new object[] {
            "ID",
            "Name",
            "Qualification",
            "Salary >",
            "Salary <",
            "Age",
            "Gender"});
            this.dsearchcategory.Location = new System.Drawing.Point(607, 145);
            this.dsearchcategory.Name = "dsearchcategory";
            this.dsearchcategory.Size = new System.Drawing.Size(114, 21);
            this.dsearchcategory.TabIndex = 15;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(507, 148);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(94, 13);
            this.label11.TabIndex = 16;
            this.label11.Text = "Searchig Category";
            // 
            // doctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(909, 394);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dsearchcategory);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dsearch);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.MaximumSize = new System.Drawing.Size(925, 433);
            this.MinimumSize = new System.Drawing.Size(925, 433);
            this.Name = "doctor";
            this.Text = "doctor";
            this.Load += new System.EventHandler(this.doctor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox dword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox did;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox dname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox dsearch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox dage;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox dq;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox dsalary;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox daddress;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox dmobile;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox dgender;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ComboBox dsearchcategory;
        private System.Windows.Forms.Label label11;
    }
}