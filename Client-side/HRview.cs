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

namespace EmployeeMaster
{
    public partial class HRview : Form
    {
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

        private void textBox1_TextChanged(object sender, EventArgs e)
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
    }
}
