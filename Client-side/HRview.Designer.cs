
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
            this.All = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Search_Option = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Positions_in_Department = new System.Windows.Forms.ComboBox();
            this.Departments = new System.Windows.Forms.TabControl();
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
            this.N16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.N17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.N18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.N19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.N20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.N21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.N22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.N23 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.N24 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.N25 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.N26 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.N27 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.N28 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.N29 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.N30 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.N31 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HR_CMS.SuspendLayout();
            this.Employee_List.SuspendLayout();
            this.Schedule_Manager.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.Daily.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.Monthly.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).BeginInit();
            this.All.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.Departments.SuspendLayout();
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
            this.Employee_List.Controls.Add(this.Positions_in_Department);
            this.Employee_List.Controls.Add(this.Departments);
            this.Employee_List.Controls.Add(this.textBox1);
            this.Employee_List.Controls.Add(this.Search_Option);
            this.Employee_List.Location = new System.Drawing.Point(4, 22);
            this.Employee_List.Name = "Employee_List";
            this.Employee_List.Padding = new System.Windows.Forms.Padding(3);
            this.Employee_List.Size = new System.Drawing.Size(988, 541);
            this.Employee_List.TabIndex = 1;
            this.Employee_List.Text = "Employee List";
            this.Employee_List.UseVisualStyleBackColor = true;
            this.Employee_List.Click += new System.EventHandler(this.Department_1_Click);
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
            this.N15,
            this.N16,
            this.N17,
            this.N18,
            this.N19,
            this.N20,
            this.N21,
            this.N22,
            this.N23,
            this.N24,
            this.N25,
            this.N26,
            this.N27,
            this.N28,
            this.N29,
            this.N30,
            this.N31});
            this.dataGridView5.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView5.Location = new System.Drawing.Point(3, 3);
            this.dataGridView5.Name = "dataGridView5";
            this.dataGridView5.Size = new System.Drawing.Size(968, 473);
            this.dataGridView5.TabIndex = 0;
            this.dataGridView5.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView5_CellContentClick);
            // 
            // All
            // 
            this.All.Controls.Add(this.dataGridView1);
            this.All.Location = new System.Drawing.Point(4, 22);
            this.All.Name = "All";
            this.All.Padding = new System.Windows.Forms.Padding(3);
            this.All.Size = new System.Drawing.Size(974, 488);
            this.All.TabIndex = 2;
            this.All.Text = "All";
            this.All.UseVisualStyleBackColor = true;
            this.All.Click += new System.EventHandler(this.Department_3_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 517);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(224, 20);
            this.textBox1.TabIndex = 3;
            // 
            // Search_Option
            // 
            this.Search_Option.FormattingEnabled = true;
            this.Search_Option.Items.AddRange(new object[] {
            "Name/Surname",
            "ID",
            "Email"});
            this.Search_Option.Location = new System.Drawing.Point(236, 516);
            this.Search_Option.Name = "Search_Option";
            this.Search_Option.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Search_Option.Size = new System.Drawing.Size(199, 21);
            this.Search_Option.TabIndex = 4;
            this.Search_Option.Tag = "";
            this.Search_Option.Text = "Search by:";
            this.Search_Option.SelectedIndexChanged += new System.EventHandler(this.Search_Option_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(968, 482);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Positions_in_Department
            // 
            this.Positions_in_Department.FormattingEnabled = true;
            this.Positions_in_Department.Items.AddRange(new object[] {
            "All"});
            this.Positions_in_Department.Location = new System.Drawing.Point(441, 516);
            this.Positions_in_Department.Name = "Positions_in_Department";
            this.Positions_in_Department.Size = new System.Drawing.Size(236, 21);
            this.Positions_in_Department.TabIndex = 9;
            this.Positions_in_Department.SelectedIndexChanged += new System.EventHandler(this.comboBox4_SelectedIndexChanged);
            // 
            // Departments
            // 
            this.Departments.Controls.Add(this.All);
            this.Departments.Dock = System.Windows.Forms.DockStyle.Top;
            this.Departments.Location = new System.Drawing.Point(3, 3);
            this.Departments.Margin = new System.Windows.Forms.Padding(0);
            this.Departments.Name = "Departments";
            this.Departments.SelectedIndex = 0;
            this.Departments.Size = new System.Drawing.Size(982, 514);
            this.Departments.TabIndex = 0;
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
            // N16
            // 
            this.N16.HeaderText = "16";
            this.N16.Name = "N16";
            // 
            // N17
            // 
            this.N17.HeaderText = "17";
            this.N17.Name = "N17";
            // 
            // N18
            // 
            this.N18.HeaderText = "18";
            this.N18.Name = "N18";
            // 
            // N19
            // 
            this.N19.HeaderText = "19";
            this.N19.Name = "N19";
            // 
            // N20
            // 
            this.N20.HeaderText = "20";
            this.N20.Name = "N20";
            // 
            // N21
            // 
            this.N21.HeaderText = "21";
            this.N21.Name = "N21";
            // 
            // N22
            // 
            this.N22.HeaderText = "22";
            this.N22.Name = "N22";
            // 
            // N23
            // 
            this.N23.HeaderText = "23";
            this.N23.Name = "N23";
            // 
            // N24
            // 
            this.N24.HeaderText = "24";
            this.N24.Name = "N24";
            // 
            // N25
            // 
            this.N25.HeaderText = "25";
            this.N25.Name = "N25";
            // 
            // N26
            // 
            this.N26.HeaderText = "26";
            this.N26.Name = "N26";
            // 
            // N27
            // 
            this.N27.HeaderText = "27";
            this.N27.Name = "N27";
            // 
            // N28
            // 
            this.N28.HeaderText = "28";
            this.N28.Name = "N28";
            // 
            // N29
            // 
            this.N29.HeaderText = "29";
            this.N29.Name = "N29";
            // 
            // N30
            // 
            this.N30.HeaderText = "30";
            this.N30.Name = "N30";
            // 
            // N31
            // 
            this.N31.HeaderText = "31";
            this.N31.Name = "N31";
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
            this.Employee_List.PerformLayout();
            this.Schedule_Manager.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.Daily.ResumeLayout(false);
            this.Daily.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.Monthly.ResumeLayout(false);
            this.Monthly.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).EndInit();
            this.All.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.Departments.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl HR_CMS;
        private System.Windows.Forms.TabPage Employee_List;
        private System.Windows.Forms.TabPage Schedule_Manager;
        private System.Windows.Forms.TabPage Daily;
        private System.Windows.Forms.TabPage Monthly;
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
        private System.Windows.Forms.TabPage Add_Employee;
        private System.Windows.Forms.TabControl Departments;
        private System.Windows.Forms.TabPage All;
        private System.Windows.Forms.ComboBox Positions_in_Department;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox Search_Option;
        private System.Windows.Forms.TextBox textBox1;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn N16;
        private System.Windows.Forms.DataGridViewTextBoxColumn N17;
        private System.Windows.Forms.DataGridViewTextBoxColumn N18;
        private System.Windows.Forms.DataGridViewTextBoxColumn N19;
        private System.Windows.Forms.DataGridViewTextBoxColumn N20;
        private System.Windows.Forms.DataGridViewTextBoxColumn N21;
        private System.Windows.Forms.DataGridViewTextBoxColumn N22;
        private System.Windows.Forms.DataGridViewTextBoxColumn N23;
        private System.Windows.Forms.DataGridViewTextBoxColumn N24;
        private System.Windows.Forms.DataGridViewTextBoxColumn N25;
        private System.Windows.Forms.DataGridViewTextBoxColumn N26;
        private System.Windows.Forms.DataGridViewTextBoxColumn N27;
        private System.Windows.Forms.DataGridViewTextBoxColumn N28;
        private System.Windows.Forms.DataGridViewTextBoxColumn N29;
        private System.Windows.Forms.DataGridViewTextBoxColumn N30;
        private System.Windows.Forms.DataGridViewTextBoxColumn N31;
    }
}

