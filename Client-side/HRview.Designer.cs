
namespace EmployeeMaster
{
    partial class HRview
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
            this.HR_CMS = new System.Windows.Forms.TabControl();
            this.Employee_List = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Department_1 = new System.Windows.Forms.TabPage();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.Search_Option2 = new System.Windows.Forms.ComboBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.Department_2 = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Search_Option1 = new System.Windows.Forms.ComboBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Department_3 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Search_Option = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Add_Employee = new System.Windows.Forms.TabPage();
            this.Schedule_Manager = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.Daily = new System.Windows.Forms.TabPage();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.Name_Surname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Check_IN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Check_Out = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hours_Worked = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.Monthly = new System.Windows.Forms.TabPage();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.dataGridView5 = new System.Windows.Forms.DataGridView();
            this.Name_Surname_M = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_M = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.N1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.N2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.N3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.N4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.N5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.N6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.N7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.N8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.N9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.N10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.N11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.N12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.N13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.N14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.N15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Positions = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.HR_CMS.SuspendLayout();
            this.Employee_List.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.Department_1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.Department_2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.Department_3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.Schedule_Manager.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.Daily.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.Monthly.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).BeginInit();
            this.SuspendLayout();
            // 
            // HR_CMS
            // 
            this.HR_CMS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.HR_CMS.Controls.Add(this.Employee_List);
            this.HR_CMS.Controls.Add(this.Add_Employee);
            this.HR_CMS.Controls.Add(this.Schedule_Manager);
            this.HR_CMS.Location = new System.Drawing.Point(12, 12);
            this.HR_CMS.Name = "HR_CMS";
            this.HR_CMS.SelectedIndex = 0;
            this.HR_CMS.Size = new System.Drawing.Size(996, 567);
            this.HR_CMS.TabIndex = 0;
            // 
            // Employee_List
            // 
            this.Employee_List.Controls.Add(this.tabControl1);
            this.Employee_List.Location = new System.Drawing.Point(4, 22);
            this.Employee_List.Name = "Employee_List";
            this.Employee_List.Padding = new System.Windows.Forms.Padding(3);
            this.Employee_List.Size = new System.Drawing.Size(988, 541);
            this.Employee_List.TabIndex = 1;
            this.Employee_List.Text = "Employee List";
            this.Employee_List.UseVisualStyleBackColor = true;
            this.Employee_List.Click += new System.EventHandler(this.Department_1_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Department_1);
            this.tabControl1.Controls.Add(this.Department_2);
            this.tabControl1.Controls.Add(this.Department_3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(982, 535);
            this.tabControl1.TabIndex = 0;
            // 
            // Department_1
            // 
            this.Department_1.Controls.Add(this.comboBox3);
            this.Department_1.Controls.Add(this.dataGridView3);
            this.Department_1.Controls.Add(this.Search_Option2);
            this.Department_1.Controls.Add(this.textBox3);
            this.Department_1.Location = new System.Drawing.Point(4, 22);
            this.Department_1.Margin = new System.Windows.Forms.Padding(1);
            this.Department_1.Name = "Department_1";
            this.Department_1.Padding = new System.Windows.Forms.Padding(1);
            this.Department_1.Size = new System.Drawing.Size(974, 509);
            this.Department_1.TabIndex = 0;
            this.Department_1.Text = "Department 1";
            this.Department_1.UseVisualStyleBackColor = true;
            this.Department_1.Click += new System.EventHandler(this.tabPage1_Click_2);
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView3.Location = new System.Drawing.Point(1, 1);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(972, 480);
            this.dataGridView3.TabIndex = 7;
            this.dataGridView3.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellContentClick);
            // 
            // Search_Option2
            // 
            this.Search_Option2.FormattingEnabled = true;
            this.Search_Option2.Items.AddRange(new object[] {
            "Name/Surname",
            "ID",
            "Email"});
            this.Search_Option2.Location = new System.Drawing.Point(234, 484);
            this.Search_Option2.Name = "Search_Option2";
            this.Search_Option2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Search_Option2.Size = new System.Drawing.Size(199, 21);
            this.Search_Option2.TabIndex = 6;
            this.Search_Option2.Tag = "";
            this.Search_Option2.Text = "Search by:";
            this.Search_Option2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged_1);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(4, 485);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(224, 20);
            this.textBox3.TabIndex = 5;
            // 
            // Department_2
            // 
            this.Department_2.Controls.Add(this.Positions);
            this.Department_2.Controls.Add(this.dataGridView2);
            this.Department_2.Controls.Add(this.Search_Option1);
            this.Department_2.Controls.Add(this.textBox2);
            this.Department_2.Location = new System.Drawing.Point(4, 22);
            this.Department_2.Name = "Department_2";
            this.Department_2.Padding = new System.Windows.Forms.Padding(3);
            this.Department_2.Size = new System.Drawing.Size(974, 509);
            this.Department_2.TabIndex = 1;
            this.Department_2.Text = "Department 2";
            this.Department_2.UseVisualStyleBackColor = true;
            this.Department_2.Click += new System.EventHandler(this.Department_2_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView2.Location = new System.Drawing.Point(3, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(968, 480);
            this.dataGridView2.TabIndex = 7;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // Search_Option1
            // 
            this.Search_Option1.FormattingEnabled = true;
            this.Search_Option1.Location = new System.Drawing.Point(233, 486);
            this.Search_Option1.Name = "Search_Option1";
            this.Search_Option1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Search_Option1.Size = new System.Drawing.Size(199, 21);
            this.Search_Option1.TabIndex = 6;
            this.Search_Option1.Tag = "";
            this.Search_Option1.Text = "Search by:";
            this.Search_Option1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(3, 486);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(224, 20);
            this.textBox2.TabIndex = 5;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Department_3
            // 
            this.Department_3.Controls.Add(this.comboBox4);
            this.Department_3.Controls.Add(this.dataGridView1);
            this.Department_3.Controls.Add(this.Search_Option);
            this.Department_3.Controls.Add(this.textBox1);
            this.Department_3.Location = new System.Drawing.Point(4, 22);
            this.Department_3.Name = "Department_3";
            this.Department_3.Padding = new System.Windows.Forms.Padding(3);
            this.Department_3.Size = new System.Drawing.Size(974, 509);
            this.Department_3.TabIndex = 2;
            this.Department_3.Text = "Department 3";
            this.Department_3.UseVisualStyleBackColor = true;
            this.Department_3.Click += new System.EventHandler(this.Department_3_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(968, 480);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Search_Option
            // 
            this.Search_Option.FormattingEnabled = true;
            this.Search_Option.Items.AddRange(new object[] {
            "Name/Surname",
            "ID",
            "Email"});
            this.Search_Option.Location = new System.Drawing.Point(233, 485);
            this.Search_Option.Name = "Search_Option";
            this.Search_Option.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Search_Option.Size = new System.Drawing.Size(199, 21);
            this.Search_Option.TabIndex = 4;
            this.Search_Option.Tag = "";
            this.Search_Option.Text = "Search by:";
            this.Search_Option.SelectedIndexChanged += new System.EventHandler(this.Search_Option_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(3, 486);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(224, 20);
            this.textBox1.TabIndex = 3;
            // 
            // Add_Employee
            // 
            this.Add_Employee.Location = new System.Drawing.Point(4, 22);
            this.Add_Employee.Name = "Add_Employee";
            this.Add_Employee.Padding = new System.Windows.Forms.Padding(3);
            this.Add_Employee.Size = new System.Drawing.Size(988, 541);
            this.Add_Employee.TabIndex = 3;
            this.Add_Employee.Text = "Add Employee";
            this.Add_Employee.UseVisualStyleBackColor = true;
            // 
            // Schedule_Manager
            // 
            this.Schedule_Manager.Controls.Add(this.tabControl2);
            this.Schedule_Manager.Location = new System.Drawing.Point(4, 22);
            this.Schedule_Manager.Name = "Schedule_Manager";
            this.Schedule_Manager.Padding = new System.Windows.Forms.Padding(3);
            this.Schedule_Manager.Size = new System.Drawing.Size(988, 541);
            this.Schedule_Manager.TabIndex = 2;
            this.Schedule_Manager.Text = "Schedule Manager";
            this.Schedule_Manager.UseVisualStyleBackColor = true;
            this.Schedule_Manager.Click += new System.EventHandler(this.tabPage1_Click_1);
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.Daily);
            this.tabControl2.Controls.Add(this.Monthly);
            this.tabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl2.Location = new System.Drawing.Point(3, 3);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(982, 535);
            this.tabControl2.TabIndex = 0;
            // 
            // Daily
            // 
            this.Daily.Controls.Add(this.comboBox1);
            this.Daily.Controls.Add(this.dataGridView4);
            this.Daily.Controls.Add(this.textBox4);
            this.Daily.Location = new System.Drawing.Point(4, 22);
            this.Daily.Name = "Daily";
            this.Daily.Padding = new System.Windows.Forms.Padding(3);
            this.Daily.Size = new System.Drawing.Size(974, 509);
            this.Daily.TabIndex = 0;
            this.Daily.Text = "Daily";
            this.Daily.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Name/Surname",
            "ID",
            "Email"});
            this.comboBox1.Location = new System.Drawing.Point(236, 482);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.comboBox1.Size = new System.Drawing.Size(199, 21);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.Tag = "";
            this.comboBox1.Text = "Search by:";
            // 
            // dataGridView4
            // 
            this.dataGridView4.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Name_Surname,
            this.ID,
            this.Check_IN,
            this.Check_Out,
            this.Hours_Worked});
            this.dataGridView4.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView4.Location = new System.Drawing.Point(3, 3);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.Size = new System.Drawing.Size(968, 473);
            this.dataGridView4.TabIndex = 0;
            // 
            // Name_Surname
            // 
            this.Name_Surname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Name_Surname.HeaderText = "Name/Surname";
            this.Name_Surname.Name = "Name_Surname";
            this.Name_Surname.Width = 107;
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.Width = 43;
            // 
            // Check_IN
            // 
            this.Check_IN.HeaderText = "Check in time";
            this.Check_IN.Name = "Check_IN";
            this.Check_IN.ReadOnly = true;
            // 
            // Check_Out
            // 
            this.Check_Out.HeaderText = "Check out time";
            this.Check_Out.Name = "Check_Out";
            this.Check_Out.ReadOnly = true;
            // 
            // Hours_Worked
            // 
            this.Hours_Worked.HeaderText = "Hours Worked";
            this.Hours_Worked.Name = "Hours_Worked";
            this.Hours_Worked.ReadOnly = true;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(6, 483);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(224, 20);
            this.textBox4.TabIndex = 5;
            // 
            // Monthly
            // 
            this.Monthly.Controls.Add(this.comboBox2);
            this.Monthly.Controls.Add(this.textBox5);
            this.Monthly.Controls.Add(this.dataGridView5);
            this.Monthly.Location = new System.Drawing.Point(4, 22);
            this.Monthly.Name = "Monthly";
            this.Monthly.Padding = new System.Windows.Forms.Padding(3);
            this.Monthly.Size = new System.Drawing.Size(974, 509);
            this.Monthly.TabIndex = 1;
            this.Monthly.Text = "Monthly";
            this.Monthly.UseVisualStyleBackColor = true;
            this.Monthly.Click += new System.EventHandler(this.Monthly_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Name/Surname",
            "ID",
            "Email"});
            this.comboBox2.Location = new System.Drawing.Point(236, 482);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.comboBox2.Size = new System.Drawing.Size(199, 21);
            this.comboBox2.TabIndex = 6;
            this.comboBox2.Tag = "";
            this.comboBox2.Text = "Search by:";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(6, 483);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(224, 20);
            this.textBox5.TabIndex = 5;
            // 
            // dataGridView5
            // 
            this.dataGridView5.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView5.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Name_Surname_M,
            this.ID_M,
            this.N1,
            this.N2,
            this.N3,
            this.N4,
            this.N5,
            this.N6,
            this.N7,
            this.N8,
            this.N9,
            this.N10,
            this.N11,
            this.N12,
            this.N13,
            this.N14,
            this.N15});
            this.dataGridView5.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView5.Location = new System.Drawing.Point(3, 3);
            this.dataGridView5.Name = "dataGridView5";
            this.dataGridView5.Size = new System.Drawing.Size(968, 473);
            this.dataGridView5.TabIndex = 0;
            // 
            // Name_Surname_M
            // 
            this.Name_Surname_M.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Name_Surname_M.HeaderText = "Name/Surname";
            this.Name_Surname_M.Name = "Name_Surname_M";
            this.Name_Surname_M.Width = 107;
            // 
            // ID_M
            // 
            this.ID_M.HeaderText = "ID";
            this.ID_M.Name = "ID_M";
            // 
            // N1
            // 
            this.N1.HeaderText = "1";
            this.N1.Name = "N1";
            // 
            // N2
            // 
            this.N2.HeaderText = "2";
            this.N2.Name = "N2";
            // 
            // N3
            // 
            this.N3.HeaderText = "3";
            this.N3.Name = "N3";
            // 
            // N4
            // 
            this.N4.HeaderText = "4";
            this.N4.Name = "N4";
            // 
            // N5
            // 
            this.N5.HeaderText = "5";
            this.N5.Name = "N5";
            // 
            // N6
            // 
            this.N6.HeaderText = "6";
            this.N6.Name = "N6";
            // 
            // N7
            // 
            this.N7.HeaderText = "7";
            this.N7.Name = "N7";
            // 
            // N8
            // 
            this.N8.HeaderText = "8";
            this.N8.Name = "N8";
            // 
            // N9
            // 
            this.N9.HeaderText = "9";
            this.N9.Name = "N9";
            // 
            // N10
            // 
            this.N10.HeaderText = "10";
            this.N10.Name = "N10";
            // 
            // N11
            // 
            this.N11.HeaderText = "11";
            this.N11.Name = "N11";
            // 
            // N12
            // 
            this.N12.HeaderText = "12";
            this.N12.Name = "N12";
            // 
            // N13
            // 
            this.N13.HeaderText = "13";
            this.N13.Name = "N13";
            // 
            // N14
            // 
            this.N14.HeaderText = "14";
            this.N14.Name = "N14";
            // 
            // N15
            // 
            this.N15.HeaderText = "15";
            this.N15.Name = "N15";
            // 
            // Positions
            // 
            this.Positions.FormattingEnabled = true;
            this.Positions.Location = new System.Drawing.Point(438, 486);
            this.Positions.Name = "Positions";
            this.Positions.Size = new System.Drawing.Size(236, 21);
            this.Positions.TabIndex = 8;
            this.Positions.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(439, 484);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(236, 21);
            this.comboBox3.TabIndex = 9;
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(438, 485);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(236, 21);
            this.comboBox4.TabIndex = 9;
            // 
            // HRview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 591);
            this.Controls.Add(this.HR_CMS);
            this.Name = "HRview";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.HRview_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.HR_CMS.ResumeLayout(false);
            this.Employee_List.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.Department_1.ResumeLayout(false);
            this.Department_1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.Department_2.ResumeLayout(false);
            this.Department_2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.Department_3.ResumeLayout(false);
            this.Department_3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.Schedule_Manager.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.Daily.ResumeLayout(false);
            this.Daily.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.Monthly.ResumeLayout(false);
            this.Monthly.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl HR_CMS;
        private System.Windows.Forms.TabPage Employee_List;
        private System.Windows.Forms.TabPage Schedule_Manager;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Department_1;
        private System.Windows.Forms.TabPage Department_2;
        private System.Windows.Forms.TabPage Department_3;
        private System.Windows.Forms.TabPage Daily;
        private System.Windows.Forms.TabPage Monthly;
        private System.Windows.Forms.ComboBox Search_Option;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox Search_Option2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.ComboBox Search_Option1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name_Surname;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Check_IN;
        private System.Windows.Forms.DataGridViewTextBoxColumn Check_Out;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hours_Worked;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.DataGridView dataGridView5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name_Surname_M;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_M;
        private System.Windows.Forms.DataGridViewTextBoxColumn N1;
        private System.Windows.Forms.DataGridViewTextBoxColumn N2;
        private System.Windows.Forms.DataGridViewTextBoxColumn N3;
        private System.Windows.Forms.DataGridViewTextBoxColumn N4;
        private System.Windows.Forms.DataGridViewTextBoxColumn N5;
        private System.Windows.Forms.DataGridViewTextBoxColumn N6;
        private System.Windows.Forms.DataGridViewTextBoxColumn N7;
        private System.Windows.Forms.DataGridViewTextBoxColumn N8;
        private System.Windows.Forms.DataGridViewTextBoxColumn N9;
        private System.Windows.Forms.DataGridViewTextBoxColumn N10;
        private System.Windows.Forms.DataGridViewTextBoxColumn N11;
        private System.Windows.Forms.DataGridViewTextBoxColumn N12;
        private System.Windows.Forms.DataGridViewTextBoxColumn N13;
        private System.Windows.Forms.DataGridViewTextBoxColumn N14;
        private System.Windows.Forms.DataGridViewTextBoxColumn N15;
        private System.Windows.Forms.TabPage Add_Employee;
        private System.Windows.Forms.ComboBox Positions;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox4;
    }
}

