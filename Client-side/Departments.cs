using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

using EmployeeMaster;
using System.IO;
using System.Xml;
using System.Data.Common;

namespace GroupProject_v001
{
    public partial class Departments : Form
    {
        public int index = 0;



        //Depertments controls
        public Button Departmentadd;
        public Button Departmentsub;
        public Label Departmentplus;
        public Label Departmentminus;


        public TextBox input;
        public Label Errorlabel;

        public Button Savebutton;

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

            // label for any errors
            Errorlabel = new Label();
            Errorlabel.ForeColor = Color.Red;
            Errorlabel.Location = new Point(48, 400);
            Errorlabel.Size = new Size(200, 50);
            this.Controls.Add(Errorlabel);
            groupBox1.Controls.Add(Errorlabel);

           
            string path = Application.StartupPath + @"\MyGrid.xml";

            // Ensure the file exists before attempting to read
            if (!File.Exists(path))
            {
                // Create the file if it doesn't exist
                using (File.Create(path)) { }
            }
            try
            {
                if (dataGridView1 != null)
                {
                    FileReader(dataGridView1);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}");
            }
        }
        private void Departments_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (dataGridView1.Columns.Count > 0)
            {
                FileWriter(dataGridView1);
            }
            else
            {
                MessageBox.Show("no columns saved");
            }
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
            int index1 = 0;
            string DepartmentName = input.Text;

            if (!string.IsNullOrEmpty(DepartmentName))
            {
                //delere wiht textbox 
                DataGridViewColumn columnToRemove = dataGridView1.Columns[DepartmentName];
                if (columnToRemove != null)
                {
                    index1 = columnToRemove.Index;
                    dataGridView1.Columns.RemoveAt(index1);
                }
                else
                {
                    MessageBox.Show($"Column '{DepartmentName}' does not exist.");
                }

                if (dataGridView1.CurrentCell != null)
                {
                    //with mouse deleting
                    index = dataGridView1.CurrentCell.ColumnIndex;
                    dataGridView1.Columns.RemoveAt(index);
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
                else { MessageBox.Show($"enter valid '{DepartmentName}' "); }

            }
        }
        //adding some depetments 
        private void Departmentadd_Click(object sender, EventArgs e)
        {

            string DepartmentName = input.Text;

            if (!string.IsNullOrEmpty(DepartmentName))
            {
                if (dataGridView1.Columns.Contains(DepartmentName))
                {
                    Errorlabel.Text = "this Department already exists type different name";
                    return;
                }

                Errorlabel.Text = string.Empty;
                DataGridViewTextBoxColumn textColumn = new DataGridViewTextBoxColumn();
                textColumn.HeaderText = DepartmentName;
                textColumn.Name = DepartmentName;

                // Add the column to the DataGridView
                dataGridView1.Columns.Add(textColumn);

            }
            else
            {
                MessageBox.Show("input valid Department name");
                return;
            }


        }

        
        private void FileReader(DataGridView dgv)
        {

            //making xml document  
            XmlDocument xmlDocument = new XmlDocument();

            //filepath that eveyone have
            string filePath = Application.StartupPath + @"\MyGrid.xml";

            if (!File.Exists(filePath))
            {
                MessageBox.Show("File not found.");
                return;
            }
            //reading from file 
            using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            {
                xmlDocument.Load(fs);
                XmlNodeList xmlColumnNodes = xmlDocument.GetElementsByTagName("column");
                XmlNodeList xmlRowNodes = xmlDocument.GetElementsByTagName("Row");
                //checking each column
                for (int i = 0; i < xmlColumnNodes.Count; i++)
                {
                    //checking some nodes from xml which is already typed there 
                    string columnName = xmlColumnNodes[i]["Name"]?.InnerText.Trim();
                    string headerText = xmlColumnNodes[i]["Headertext"]?.InnerText.Trim();
                    int displayIndex = int.Parse(xmlColumnNodes[i]["displayindex"]?.InnerText.Trim() ?? "0");
                    bool visible = Convert.ToBoolean(xmlColumnNodes[i]["visible"]?.InnerText.Trim());

                    // Check if the column already exists
                    DataGridViewColumn column = dgv.Columns[columnName];
                    if (column == null)
                    {
                        // Create a new column if it doesn't exist
                        column = new DataGridViewTextBoxColumn
                        {
                            Name = columnName,
                            HeaderText = headerText,
                            Visible = visible
                        };
                        dgv.Columns.Add(column);
                    }
                    else
                    {
                        // Update existing column properties
                        column.HeaderText = headerText;
                        column.Visible = visible;
                    }

                    // Set display index
                    column.DisplayIndex = displayIndex;

                    

                    
                }
                //checking each cellnode from rows  
                foreach (XmlNode rowNode in xmlRowNodes)
                {
                    // Create a new row in the DataGridView
                    int rowIndex = dgv.Rows.Add();
                    DataGridViewRow dgvRow = dgv.Rows[rowIndex];// Get the newly added row to set its cells

                    foreach (XmlNode cellNode in rowNode.ChildNodes) // For each cell element in XML
                    {
                        // Check if the column exists in the DataGridView
                        string columnName = cellNode.Name;
                        if (dgv.Columns.Contains(columnName))
                        {
                            dgvRow.Cells[columnName].Value = cellNode.InnerText.Trim();// Check if this column exists in the DataGridView
                        }
                    }

                    // Set row-level properties if needed 
                    bool rowVisible = Convert.ToBoolean(rowNode["visible"]?.InnerText.Trim() ?? "true");
                    // Set cell value from XML data
                    dgvRow.Visible = rowVisible;
                }
            }
        }
    
        // writing to file 
        private void FileWriter(DataGridView dgv)
        {

            string filePath = Application.StartupPath + @"\MyGrid.xml";

            using (XmlTextWriter writer = new XmlTextWriter(filePath, null))
            {

                //formatin file for readability 
                writer.Formatting = Formatting.Indented;
                writer.WriteStartDocument();
                writer.WriteStartElement("DataGridView");

                foreach (DataGridViewColumn column in dgv.Columns)
                {
                    writer.WriteStartElement("column");

                    writer.WriteElementString("Name", column.Name);
                    writer.WriteElementString("Headertext", column.HeaderText);
                    writer.WriteElementString("displayindex", column.DisplayIndex.ToString());
                    writer.WriteElementString("visible", column.Visible.ToString());

                    writer.WriteEndElement();


                }

                foreach (DataGridViewRow row in dgv.Rows)
                {
                    //to skip empty cell after every editing
                    if (row.IsNewRow) continue;

                    writer.WriteStartElement("Row");
                    //each cell within its department or column will be filled 
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        string columnName = dgv.Columns[cell.ColumnIndex].Name;
                        writer.WriteElementString(columnName, cell.Value?.ToString() ?? string.Empty);

                    }


                    writer.WriteElementString("displayIndex", row.Index.ToString());
                    writer.WriteElementString("visible", row.Visible.ToString());

                    writer.WriteEndElement();
                }

                writer.WriteEndElement();
                writer.WriteEndDocument();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    
        

    }
}
