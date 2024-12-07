using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Registration;
using System.Windows.Forms;
using Spire.Xls;

namespace EmployeeMaster
{
    public partial class HRview : Form
    {

        List<schedule> groups = new List<schedule>();

        //emps is datatable that will be read from excel
        //emps_schedule is datatable that will be exported to excel
        DataTable emps = new DataTable();
        DataTable emps_schedule = new DataTable();

        // this is for reading the excel file
        Workbook wb = new Workbook();
        Worksheet sheet;


        //temporary string needed for writing in excel
        string[] temp = new string[3];



        public HRview()
        {
            InitializeComponent();
            HR_module module=new HR_module();

            module.Column_Type_Init(
                columns.column_names
                ) ;

            
            //Search_Option
            
            dataGridView1.DataSource = module.Result_Table;

            List<System.Windows.Forms.DataGridView> data_grids=new List<DataGridView>();

            for (int i = 0; i < module.Column_Type.Count; i++)
            {
                Search_Option.Items.Add(module.Column_Type[0]);
            }


            for (int i = 0; i < All_Departments.Departments.Count; i++)
            {
                Departments.TabPages.Add(All_Departments.Departments[i].Name);

                DataGridView temp = new DataGridView();
                temp.Parent = Departments.TabPages[i];
                temp.Dock = DockStyle.Fill;


                data_grids.Add(new DataGridView());

            }


            //for (int i = 0; i < All_Departments.Departments[Departments.TabIndex].Positions.Length; i++)
            //{
            //    Positions_in_Department.Items.Add(All_Departments.Departments[Departments.TabIndex].Positions[i].Name);
            //}

            module.Table_Init(Departments.TabPages[Departments.SelectedIndex].Name);

            data_grids[Departments.TabIndex].DataSource = module.Result_Table;




            //this is the default schedule group
            schedule def = new schedule("default", new bool[7] { true, true, true, true, true, false, false }, "09:00", "18:00");
            groups.Add(def);

            //initialize schedule groups
            for (int i = 0; i < groups.Count; i++)
            {
                comboBox3.Items.Add(groups[i].Schedule_Group_Name);
            }

            Workbook wb2 = new Workbook();

            //loading this so the previously added users arent lost
            wb2.LoadFromFile(@".\emps.xlsx");
            Worksheet sheet2 = wb2.Worksheets[0];


            //this are the columns that will be exported
            emps_schedule.Columns.Add(new DataColumn("name/surname", typeof(string)));
            emps_schedule.Columns.Add(new DataColumn("Id", typeof(int)));
            emps_schedule.Columns.Add(new DataColumn("Schedule group", typeof(string)));

            //to save previously added users
            emps_schedule = sheet2.ExportDataTable();

            //loading employers file where employees with be imported from
            wb.LoadFromFile(@".\Employers.xlsx");
            Worksheet sheet = wb.Worksheets[0];

            emps = sheet.ExportDataTable();

            //selects default,which currrently means nothing

            //set the default group as default option
            comboBox3.SelectedIndex = 0;



        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click_1(object sender, EventArgs e)
        {

        }

        private void Department_1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click_2(object sender, EventArgs e)
        {

        }

        private void Monthly_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Search_Option_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Department_2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Department_3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void HRview_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
            Application.Exit();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView5_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

            //whenever id is written this code searches all personal
            //in datatable that was imported from excel and displays it on coresponding label

            for (int i = 0; i < emps.Rows.Count; i++)
            {
                if (emps.Rows[i][emps.Columns[2]].ToString() == textBox1.Text)
                {
                    string t = emps.Rows[i][emps.Columns[0]].ToString();
                    label4.Text = emps.Rows[i][emps.Columns[0]].ToString();

                    temp = new string[] { emps.Rows[i][emps.Columns[0]].ToString(), emps.Rows[i][emps.Columns[2]].ToString(), comboBox1.Items[comboBox1.SelectedIndex].ToString() };

                    return;
                }
            }
            //if there is no personal with that id, then label is empty
            label4.Text = "";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (temp.Length != 0)
            {
                //whenever button is clicked
                //new member is added to emp_schedule and 
                //export excel file is updated with this new
                //entry

                emps_schedule.Rows.Add(temp[0], temp[1], temp[2]);



                Workbook wb1 = new Workbook();
                Worksheet sheet1 = wb1.Worksheets[0];

                //note: this function creates 4 sheets by default and when you open excel you are on the last one
                //move to the first sheet to see the added rows
                sheet1.InsertDataTable(emps_schedule, true, 1, 1);
                wb1.SaveToFile("emps.xlsx");

                temp = new string[] { };

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //this code simply adds new schedule group
            //it takes values from text boxes and check lists and puts them in the constuctor
            bool[] t = new bool[7];
            for (int i = 0; i < 7; i++)
            {
                if (checkedListBox1.CheckedItems.Contains(checkedListBox1.Items[i]))
                    t[i] = true;
            }
            schedule temp = new schedule(textBox2.Text, t, textBox3.Text, textBox4.Text);

            groups.Add(temp);

            comboBox1.Items.Add(temp.Schedule_Group_Name);
        }
    }
}
