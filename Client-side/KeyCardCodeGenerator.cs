using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Deployment.Application;
using System.Drawing;
using System.Linq;

using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace GroupProject_v001
{
    public partial class KeyCardCodeGenerator : Form
    {
        public Button generatebutton;
        public Label label_generate;
        public Label label_KeyCodes;
        public Label VisibleErrors;

        private HashSet<long> KeyCodes = new HashSet<long>();
        public KeyCardCodeGenerator()
        {
            InitializeComponent();
        }

        private void KeyCardCodeGenerator_Load(object sender, EventArgs e)
        {
            //Groupbox
            GroupBox groupBox = new GroupBox();
            groupBox.Text = "KeyCardCodeGenerator";
            groupBox.Location = new Point(0,0);
            groupBox.Size = new Size(800, 450);
            groupBox.Font = new Font(groupBox.Font.FontFamily, 12);
            this.Controls.Add(groupBox);
            //window settings
            this.Size = new Size(800, 400);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            //button
            generatebutton = new Button();
            generatebutton.Location = new Point(600, 250);
            generatebutton.Size = new Size(100, 50);
            generatebutton.Text = "Generate";
            generatebutton.Click += Generatebutton_Click;
            this.Controls.Add(generatebutton);
            groupBox.Controls.Add(generatebutton);
            //label for generator button
            label_generate = new Label();
            label_generate.Text = "Click to generate code";
            label_generate.Location = new Point(570, 200);
            label_generate.Size = new Size(200, 50);
            this.Controls.Add(label_generate);
            groupBox.Controls.Add(label_generate);  
            //label for errors
            VisibleErrors = new Label();
            VisibleErrors.Text = "";
            VisibleErrors.ForeColor = Color.Red;
            VisibleErrors.Location = new Point(570, 100);
            VisibleErrors.Size = new Size(200, 50);
            this.Controls.Add(VisibleErrors);
            groupBox.Controls.Add(VisibleErrors);
            //label for keycodes
            label_KeyCodes = new Label();
            label_KeyCodes.Text = "12345678910";
            label_KeyCodes.Location = new Point(100,100);
            label_KeyCodes.Size = new Size(200, 50);
            label_KeyCodes.Font = new Font(label_KeyCodes.Font.FontFamily, 16, label_KeyCodes.Font.Style);
            label_KeyCodes.ForeColor = Color.Green;
            this.Controls.Add(label_KeyCodes);
            groupBox.Controls.Add(label_KeyCodes);


        }

        private void Generatebutton_Click(object sender, EventArgs e)
        {
            // genearate code long 
            Random random = new Random();
            

            //write it into the set
            for (int i = 0; i < 10; i++) 
            {
                long Code = (long)(random.Next(1000000000, 2000000000)) * 10 + random.Next(0, 10);
               
                KeyCodes.Add(Code);
            }

            
           
            //give this value to label_keycodes
            int value_at_index =random.Next(1, KeyCodes.Count);
            List<long> values = KeyCodes.ToList();
            // randomly choose it from the set
            long somevalue = KeyCodes.ElementAt(value_at_index);
            // assign it to the label;
            label_KeyCodes.Text = somevalue.ToString();




            
        }
    }
}
