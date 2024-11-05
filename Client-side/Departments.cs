using Registration;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Department
{
    public partial class Departments : Form
    {
        public int index = 0;



        //Depertments controls
        public Button Departmentadd;
        public Button Departmentsub;
        public Label Departmentplus;
        public Label Departmentminus;
        public static List<TextBox> position_text_boxes = new List<TextBox>();


        public TextBox input;
        public Label Errorlabel;

        public Label InputLabel;


        public Departments()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Departments_Load(object sender, EventArgs e)
        {
            //groupbox1 settings
            groupBox1.Text = "Departments";
            groupBox1.Size = new Size(800, 600);
            groupBox1.Font = new Font(groupBox1.Font.FontFamily, 12);

            //window settings
            this.Size = new Size(800, 600);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            //button to add department
            Departmentadd = new Button();
            Departmentadd.Text = "+";
            Departmentadd.Location = new Point(50, 50);
            Departmentadd.Size = new Size(50, 50);
            Departmentadd.Click += Departmentadd_Click;
            this.Controls.Add(Departmentadd);
            groupBox1.Controls.Add(Departmentadd);
            //label for information adding 
            Departmentplus = new Label();
            Departmentplus.Text = "Add department";
            Departmentplus.Location = new Point(48, 34);
            Departmentplus.Size = new Size(200, 50);
            this.Controls.Add(Departmentplus);
            groupBox1.Controls.Add(Departmentplus);
            //button to remove department
            Departmentsub = new Button();
            Departmentsub.Text = "-";
            Departmentsub.Location = new Point(50, 118);
            Departmentsub.Size = new Size(50, 50);
            Departmentsub.Click += Departmentsub_Click;
            this.Controls.Add(Departmentsub);
            groupBox1.Controls.Add(Departmentsub);
            //label for information removing
            Departmentminus = new Label();
            Departmentminus.Text = "Remove Department";
            Departmentminus.Location = new Point(48, 100);
            Departmentminus.Size = new Size(200, 50);
            this.Controls.Add(Departmentminus);
            groupBox1.Controls.Add(Departmentminus);
            groupBox1.Controls.Add(dataGridView1);




            //text box to enter your department or positions
            input = new TextBox();
            input.Location = new Point(48, 325);
            input.Size = new Size(200, 50);
            input.TextChanged += Input_TextChanged;
            this.Controls.Add(input);
            groupBox1.Controls.Add(input);
            //label for inputbox
            InputLabel = new Label();
            InputLabel.Location = new Point(48, 295);
            InputLabel.Size = new Size(200, 50);
            InputLabel.Text = "input Department Name";
            this.Controls.Add(InputLabel);
            groupBox1.Controls.Add(InputLabel);

            // label for any errors
            Errorlabel = new Label();
            Errorlabel.ForeColor = Color.Red;
            Errorlabel.Location = new Point(48, 400);
            Errorlabel.Size = new Size(200, 50);
            this.Controls.Add(Errorlabel);
            groupBox1.Controls.Add(Errorlabel);


        }
        private void Departments_FormClosed(object sender, FormClosedEventArgs e)
        {

        }




        private void Input_TextChanged(object sender, EventArgs e)
        {
            // function for validation in textbox typing
            string userinput = input.Text;

            if (int.TryParse(userinput, out int result)
                || double.TryParse(userinput, out double result1))
            {
                Errorlabel.Text = "enter only alphabetic symbols";
                Departmentadd.Enabled = false;
                Departmentsub.Enabled = false;

            }
            else
            {
                Errorlabel.Text = string.Empty;
                Departmentadd.Enabled = true;
                Departmentsub.Enabled = true;

            }

        }
        // to remove department 
        private void Departmentsub_Click(object sender, EventArgs e)
        {
            int index1;
            string departmentname = input.Text;

            if (!string.IsNullOrEmpty(departmentname))
            {
                //delere wiht textbox 
                DataGridViewColumn columnToRemove = dataGridView1.Columns[departmentname];
                if (columnToRemove != null)
                {
                    index1 = columnToRemove.Index;
                    dataGridView1.Columns.RemoveAt(index1);
                }
                else
                {
                    MessageBox.Show($"Column '{departmentname}' does not exist.");
                    Errorlabel.Text = "selected column not exists";
                }
            }
            else
            {
                if (dataGridView1.CurrentCell != null)
                {
                    //with mouse deleting
                    index = dataGridView1.CurrentCell.ColumnIndex;
                    dataGridView1.Columns.RemoveAt(index);
                }
                else { MessageBox.Show($"enter valid '{departmentname}' "); }

            }

            


            Departament newDep = new Departament(input.Text, null);
        }
        //adding some depetments 
        private void Departmentadd_Click(object sender, EventArgs e)
        {

            Departament newDep = new Departament(input.Text, null);
            DataGridViewTextBoxColumn textColumn = new DataGridViewTextBoxColumn();

            if (!string.IsNullOrEmpty(newDep.Name))
            {
                if (dataGridView1.Columns.Contains(newDep.Name))
                {
                    Errorlabel.Text = "this Department already exists type different name";
                    return;
                }

                Errorlabel.Text = string.Empty;
                textColumn.HeaderText = newDep.Name;
                textColumn.Name = newDep.Name;

                // Add the column to the DataGridView

            }
            else
            {
                MessageBox.Show("input valid Department name");
                return;
            }


            dataGridView1.Columns.Add(textColumn);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }



    }
}
