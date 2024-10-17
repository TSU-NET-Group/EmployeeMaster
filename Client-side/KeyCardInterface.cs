using EmployeeMaster;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;

namespace GroupProject_v001
{
    public partial class KeyCardInterface : Form
    {
        public TextBox KeyCardCodes;
        public ComboBox ID;
        public GroupBox grouped;
        public Label User_Names;
        public Label Id_Label;
        public Label KeyCard_Label;
        public Label User_Name_Label;
        public Button Verify;
        // auto complete rom interactiulad movdzebnot useris id
        AutoCompleteStringCollection data = new AutoCompleteStringCollection();
        /// <summary>
        /// magalitebi rom dametesta codi 
        /// listebi, romlebic sheicaven informacia useris shesaxeb  
        /// </summary>
        List<long> KeyCard_List =
            new List<long>{ 12345678910,
                            12323478910,
                            12366778910,
                            12345678910,
                            12345676549,
                            45671239102 };
        // example list of usernames
        List<string> User_Name_List =
            new List<string>
            {
                "Malxazi22",
                "saba228",
                "vakvardi",
                "shengelashvili13",
                "BOB",
                "ROss"
            };
        //magalitistvis gavakete pseudo database is listi
        List<string> DB = new List<string>();
                                                  
        public KeyCardInterface()                 
        {                                         
            InitializeComponent();                           
        }
        // vavseb informaciit comboboxs da aseve arrays ritic shemdegshi vawtob interactiul searchs
        private void fillTheCombobox()
        {
            if (KeyCard_List.Count == 0)
            {
                throw new Exception("List is null");
            }
            foreach (long i in KeyCard_List)
            {
                ID.Items.Add(i);
                data.Add(Convert.ToString(i));
            }
        }
        /// <summary>
        ///  es kodi yovel gashvebaze axal fails qmnis da shignit wers 
        ///  garkveul informacias user is shesaxeb ... Mydocument fileshi 
        ///  ase davarqvi radgan yvelas windows is users aqvs es faili 
        /// </summary>
        private void filewriter()
        {
            try
            {
                string docPath =
                          Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

                
                using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, "WriteLines.txt")))
                {
                    foreach (string line in DB)
                        outputFile.WriteLine(line);
                }

            }
            catch (FileNotFoundException ex) { MessageBox.Show($"{ex.Message}"); }
            catch (Exception ex) { MessageBox.Show($"{ex.Message}"); }
        }
       /// <summary>
       /// vawyob martiv designs da aseve vamatabeb garkveul funqciebs garkveul moqmedebebze 
       /// romlebic sheidzleba gaaketos userma 
       /// </summary>
       /// <param name="sender"></param>
       /// <param name="e"></param>
        private void KeyCardInterface_Load(object sender, EventArgs e)
        {
            //Keycodis chaweris textboxi 
            KeyCardCodes = new TextBox();
            KeyCardCodes.Location = new Point(120, 50 * 2);
            KeyCardCodes.Size = new Size(200, 50);
            KeyCardCodes.TextChanged += KeyCardCodes_TextChanged;
            this.Controls.Add(KeyCardCodes);

            //id is chasaweri inteface tavisi interactiuli searchit 
            ID = new ComboBox();
            ID.Location = new Point(450, 50 * 2);
            ID.Size = new Size(200, 50);

            ID.AutoCompleteSource = AutoCompleteSource.CustomSource;
            ID.AutoCompleteMode = AutoCompleteMode.SuggestAppend;

            try
            {
                fillTheCombobox();
                //shqmnili data sadac is chavweret rac comboxhsi shegvyavs aqac 
                ID.AutoCompleteCustomSource = data;

            }
            catch (Exception ex) 
            {
                MessageBox.Show($"Error with list(id){ex.Message}","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                fillTheCombobox();
            }
            ID.TextChanged += ID_TextChanged;
            ID.SelectedIndexChanged += ID_SelectedIndexChanged;
            this.Controls.Add(ID);
            //labeli  usernamestvis
            User_Names = new Label();
            User_Names.Location = new Point(700, 100);
            User_Names.Size = new Size(200, 50);
            User_Names.Text = "...";         
            this.Controls.Add(User_Names);

            //programis fanjris zomebis formatireba 
            this.Size = new Size(1000, 200);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;


            //lablebi tvalsachinoebistvis 
            Id_Label = new Label();
            Id_Label.Location = new Point(450, 70);
            Id_Label.Text = "ID";
            this.Controls.Add(Id_Label);

            KeyCard_Label = new Label();
            KeyCard_Label.Location = new Point(120, 70);
            KeyCard_Label.Text = "KeyCard Code";
            KeyCard_Label.AutoSize = true;
            this.Controls.Add(KeyCard_Label);

            User_Name_Label = new Label();
            User_Name_Label.Location = new Point(700, 70);
            User_Name_Label.Text = "Username";
            this.Controls.Add(User_Name_Label);


            // ghilaki rom verifikacia moxdes useris da misi keycardis
            Verify = new Button();
            Verify.Location = new Point(850, 25);
            Verify.Size = new Size(75, 50);
            Verify.Text = "Verify";
            Verify.MouseClick += Verify_MouseClick;
            this.Controls.Add(Verify);
            //design is componentebs  vajgufeb
            grouped = new GroupBox();
            grouped.Text = "KeyCardCodes";
            grouped.Size = new Size(1000, 200);
            grouped.Controls.Add(ID);
            grouped.Controls.Add(KeyCardCodes);
            grouped.Controls.Add(Id_Label);
            grouped.Controls.Add(KeyCard_Label);
            grouped.Controls.Add(Verify);
            grouped.Controls.Add(User_Names);
            grouped.Controls.Add(User_Name_Label);
            grouped.Font = new Font(grouped.Font.FontFamily, 12);
            this.Controls.Add(grouped);
        }
        //roca id comboboxis items movnishnavt 
        //chvens mier monishnul itemis index gaigebs da amis mixedvit airchevs usernames sxva listidan
        // es kodi aris codis dasatestad mogonili da validuria mxolod am kontextshi wesieri bazis mowyobis 
        // shemdeg unda gadaketdes 
        private void ID_SelectedIndexChanged(object sender, EventArgs e)
        {
            int Indexofselecteditem = 0;
           
            if (ID.SelectedItem != null)
            {
                
                Indexofselecteditem = ID.SelectedIndex;
                
                User_Names.Text = User_Name_List[Indexofselecteditem];
            }

        }
        //useris mier mowodebuli informacia mowmdeba da iwereba fileshi 
        private void Verify_MouseClick(object sender, MouseEventArgs e)
        {
            string KEY = string.Empty;
            string user_id = string.Empty;
            string user_name = string.Empty;
            try
            {
                if (KeyCardCodes.Text == string.Empty 
                    || user_name == "..." ||ID.SelectedItem == null)
                {
                    MessageBox.Show("Some information isnot added!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                KEY = KeyCardCodes.Text;
                user_id = ID.SelectedItem.ToString();
                user_name = User_Names.Text;
                if (e.Button == MouseButtons.Left)
                {
                    //chavwerot yvelaferi listshi
                    //validacia tu ras da rogor sheiybans useri
                    if (!DB.Contains(KEY) && !DB.Contains(user_id) && !DB.Contains(user_name)
                         && KEY != null && user_id != null && user_name != "..."&& KEY.Length == 11 )
                    {

                        DB.Add(KEY);
                        DB.Add(user_id);
                        DB.Add(user_name);
                        filewriter();
                        MessageBox.Show("succesfuly passed verfication!", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("information is already assigned!/not typed properly!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }


                }
                
            }
            catch (Exception ex)
            {
                
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        //
        private void KeyCardCodes_TextChanged(object sender, EventArgs e)
        {
            string UserInput = KeyCardCodes.Text;
            if(long.TryParse(UserInput,out long value))
            {

            }else if(UserInput == string.Empty)
            {
                KeyCardCodes.BackColor = Color.White;
            }
            else if(!long.TryParse(UserInput, out long value1))
            {
                KeyCardCodes.BackColor = Color.Red;
                MessageBox.Show("input 11 digits", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                KeyCardCodes.BackColor = Color.White;
            }
        }
        /// <summary>
        /// inputis validacia rom searchi gamartivdes airchevs im variants romlis cifrebic daemtxveva 
        /// da shemdeg vamowmeb ramdenad sworad sheiyvana userma informacia
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ID_TextChanged(object sender, EventArgs e)
        {
            string input = ID.Text;
            
            if(long.TryParse(input,out long value))
            {
                while (value > 0)
                {
                    var digit = value % 10;
                    value/= 10;
                    
                    string digitString = digit.ToString();

                    if (ID.Items.Contains(digitString))
                    {
                        ID.SelectedItem = digitString;

                    }

                    
                }
            }else if(input == string.Empty)
            {
                ID.BackColor = Color.White;
            }
            else if(!long.TryParse(input, out long value1))
            {
                ID.BackColor = Color.Red;
                MessageBox.Show("input 11 digits", "Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                ID.BackColor = Color.White;
            }
        }

        

        private void KeyCardInterface_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
            Application.Exit();
        }

       
    }
}
