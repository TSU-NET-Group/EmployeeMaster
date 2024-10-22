using System;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;


namespace Registration
{
    public partial class RegistrationForm : Form
    {
        // Get all country names
        string[] ALL_COUNTRIES = CultureInfo.GetCultures(CultureTypes.SpecificCultures)
            .Select(culture => new RegionInfo(culture.Name).EnglishName)
            .Distinct()
            .ToArray();



        private int spacing = 50;

        public Label ID_label;
        public TextBox ID_text_box;

        public Label password_label;
        public TextBox password_text_box;

        public Label email_label;
        public TextBox email_text_box;

        public Label name_label;
        public TextBox name_text_box;

        public Label lastname_label;
        public TextBox lastname_text_box;

        public Label phone_number_label;
        public TextBox phone_number_text_box;

        public Label ethnicity_label;
        public RadioButton georgian_radio_button;

        public RadioButton foreigner_radio_button;
        public Label department_label;

        public ComboBox department_combo_box;
        public Button image_upload_button;

        public PictureBox uploaded_image_picture_box;
        public Button register_button;

        public ComboBox Combobox_Language;
        public GroupBox groupbox = new GroupBox();




        public RegistrationForm()
        {
            InitializeComponent();

        }

        private void RegistrationForm_Load(object sender, EventArgs e)
        {

            //Manipulations with window settings 
            this.Size = new Size(800, 800);
            //this.MinimumSize = new Size(800, 800);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;



            //combobox for choosing languages
            Combobox_Language = new ComboBox();
            Combobox_Language.Location = new Point(620, spacing * 1);
            Combobox_Language.Size = new Size(50, 25);
            Combobox_Language.DropDownStyle = ComboBoxStyle.DropDownList;
            Combobox_Language.Items.Add("Eng");
            Combobox_Language.Items.Add("Geo");
            Combobox_Language.SelectedIndex = 0;
            this.Controls.Add(Combobox_Language);



            // ID_label
            ID_label = new Label();
            ID_label.Location = new Point(120, spacing * 1);
            ID_label.Text = "ID";
            ID_label.AutoSize = true;
            this.Controls.Add(ID_label);

            // ID_text_box
            ID_text_box = new TextBox();
            ID_text_box.Location = new Point(250, spacing * 1);
            ID_text_box.Location = new Point(250, spacing * 1);
            ID_text_box.Size = new Size(250, 25);
            ID_text_box.Enter += ID_text_box_Enter;
            this.Controls.Add(ID_text_box);


            // password_label
            password_label = new Label();
            password_label.Location = new Point(120, spacing * 2);
            password_label.Text = "Password";
            password_label.AutoSize = true;
            this.Controls.Add(password_label);

            // password_text_box
            password_text_box = new TextBox();
            password_text_box.Location = new Point(250, spacing * 2);
            password_text_box.Size = new Size(250, 25);
            password_text_box.Enter += password_text_box_Enter;
            this.Controls.Add(password_text_box);


            // email_label
            email_label = new Label();
            email_label.Location = new Point(120, spacing * 3);
            email_label.Text = "Email";
            email_label.AutoSize = true;
            this.Controls.Add(email_label);

            // email_text_box
            email_text_box = new TextBox();
            email_text_box.Location = new Point(250, spacing * 3);
            email_text_box.Size = new Size(250, 25);
            email_text_box.Enter += email_text_box_Enter;
            this.Controls.Add(email_text_box);


            // name_label
            name_label = new Label();
            name_label.Location = new Point(120, spacing * 4);
            name_label.Text = "Name";
            name_label.AutoSize = true;
            this.Controls.Add(name_label);

            // name_text_box
            name_text_box = new TextBox();
            name_text_box.Location = new Point(250, spacing * 4);
            name_text_box.Size = new Size(250, 25);
            name_text_box.Enter += name_text_box_Enter;
            this.Controls.Add(name_text_box);


            // lastname_label
            lastname_label = new Label();
            lastname_label.Location = new Point(120, spacing * 5);
            lastname_label.Text = "Last name";
            lastname_label.AutoSize = true;
            this.Controls.Add(lastname_label);

            // lastname_text_box
            lastname_text_box = new TextBox();
            lastname_text_box.Location = new Point(250, spacing * 5);
            lastname_text_box.Size = new Size(250, 25);
            lastname_text_box.Enter += lastname_text_box_Enter;
            this.Controls.Add(lastname_text_box);


            // lastname_label
            phone_number_label = new Label();
            phone_number_label.Location = new Point(120, spacing * 6);
            phone_number_label.Text = "Phone Number";
            phone_number_label.AutoSize = true;
            this.Controls.Add(phone_number_label);

            // phone_number_text_box
            phone_number_text_box = new TextBox();
            phone_number_text_box.Location = new Point(250, spacing * 6);
            phone_number_text_box.Size = new Size(250, 25);
            phone_number_text_box.Enter += phone_number_text_box_Enter;
            this.Controls.Add(phone_number_text_box);

            // TODO: THIS MIGHT BE USEFUL
            // ethnicity_label
            //Label ethnicity_label = new Label();
            //ethnicity_label.Location = new Point(120, spacing * 7);
            //ethnicity_label.Text = "Ethnicity";
            //ethnicity_label.AutoSize = true;
            //this.Controls.Add(ethnicity_label);

            // ethnicity_combo_box
            //ComboBox ethnicity_combo_box = new ComboBox();
            //ethnicity_combo_box.Location = new Point(350, spacing * 7);
            //ethnicity_combo_box.Size = new Size(200, 25);
            //ethnicity_combo_box.DropDownStyle = ComboBoxStyle.DropDownList;
            //ethnicity_combo_box.Items.Add("Ethnicity");
            //ethnicity_combo_box.Items.AddRange(ALL_COUNTRIES);
            //ethnicity_combo_box.SelectedIndex = 0;
            //this.Controls.Add(ethnicity_combo_box);


            // ethnicity_label
            ethnicity_label = new Label();
            ethnicity_label.Location = new Point(120, spacing * 7);
            ethnicity_label.Text = "Ethnicity";
            ethnicity_label.AutoSize = true;
            this.Controls.Add(ethnicity_label);

            // georgian_radio_button
            georgian_radio_button = new RadioButton();
            georgian_radio_button.Location = new Point(250, spacing * 7);
            georgian_radio_button.Text = "Georgian";
            georgian_radio_button.AutoSize = true;
            this.Controls.Add(georgian_radio_button);

            // foreigner_radio_button
            foreigner_radio_button = new RadioButton();
            foreigner_radio_button.Location = new Point(250 + georgian_radio_button.Right, spacing * 7);
            foreigner_radio_button.Text = "Foreigner";
            georgian_radio_button.AutoSize = true;
            this.Controls.Add(foreigner_radio_button);


            // department_label
            department_label = new Label();
            department_label.Location = new Point(120, spacing * 8);
            department_label.Text = "Department";
            department_label.AutoSize = true;
            this.Controls.Add(department_label);

            // department_combo_box
            department_combo_box = new ComboBox();
            department_combo_box.Location = new Point(250, spacing * 8);
            department_combo_box.Size = new Size(250, 25);
            department_combo_box.DropDownStyle = ComboBoxStyle.DropDownList;
            department_combo_box.Items.Add("Department");
            department_combo_box.SelectedIndex = 0;
            this.Controls.Add(department_combo_box);


            // upload image 
            image_upload_button = new Button();
            image_upload_button.Location = new Point(250, spacing * 9);
            image_upload_button.Size = new Size(100, 50);
            image_upload_button.Text = "Upload\nImage";
            image_upload_button.Click += new EventHandler(image_upload_button_Click);
            this.Controls.Add(image_upload_button);

            // Uploaded Image Picture Box
            uploaded_image_picture_box = new PictureBox();
            uploaded_image_picture_box.Location = new Point(250, spacing * 10);
            uploaded_image_picture_box.Size = new Size(200, 200);
            uploaded_image_picture_box.SizeMode = PictureBoxSizeMode.Zoom;
            uploaded_image_picture_box.Visible = false;
            uploaded_image_picture_box.Enabled = false;
            this.Controls.Add(uploaded_image_picture_box);


            // finish registration
            register_button = new Button();
            register_button.Location = new Point(500, spacing * 9);
            register_button.Size = new Size(100, 50);
            register_button.Text = "Register";
            register_button.Click += new EventHandler(register_button_Click);
            this.Controls.Add(register_button);


            //Group box 
            groupbox.Text = "Registration";
            groupbox.Font = new Font(groupbox.Font.FontFamily, 12);
            groupbox.Size = new Size(800, 1000);



            groupbox.Controls.Add(ID_label);
            groupbox.Controls.Add(ID_text_box);
            groupbox.Controls.Add(name_label);
            groupbox.Controls.Add(name_text_box);
            groupbox.Controls.Add(lastname_label);
            groupbox.Controls.Add(lastname_text_box);
            groupbox.Controls.Add(password_label);
            groupbox.Controls.Add(password_text_box);
            groupbox.Controls.Add(phone_number_label);
            groupbox.Controls.Add(phone_number_text_box);
            groupbox.Controls.Add(email_label);
            groupbox.Controls.Add(email_text_box);
            groupbox.Controls.Add(register_button);
            groupbox.Controls.Add(image_upload_button);
            groupbox.Controls.Add(uploaded_image_picture_box);
            groupbox.Controls.Add(department_label);
            groupbox.Controls.Add(department_combo_box);
            groupbox.Controls.Add(ethnicity_label);
            groupbox.Controls.Add(foreigner_radio_button);
            groupbox.Controls.Add(georgian_radio_button);


            this.Controls.Add(groupbox);
        }

        private void ID_text_box_Enter(object sender, EventArgs e)
        {
            if (ID_text_box.BackColor == Color.Red)
            {
                ID_text_box.BackColor = Color.White;
            }
        }

        private void password_text_box_Enter(object sender, EventArgs e)
        {
            if (password_text_box.BackColor == Color.Red)
            {
                password_text_box.BackColor = Color.White;
            }
        }

        private void email_text_box_Enter(object sender, EventArgs e)
        {
            if (email_text_box.BackColor == Color.Red)
            {
                email_text_box.BackColor = Color.White;
            }
        }

        private void name_text_box_Enter(object sender, EventArgs e)
        {
            if (name_text_box.BackColor == Color.Red)
            {
                name_text_box.BackColor = Color.White;
            }
        }

        private void lastname_text_box_Enter(object sender, EventArgs e)
        {
            if (lastname_text_box.BackColor == Color.Red)
            {
                lastname_text_box.BackColor = Color.White;
            }
        }

        private void phone_number_text_box_Enter(object sender, EventArgs e)
        {
            if (phone_number_text_box.BackColor == Color.Red)
            {
                phone_number_text_box.BackColor = Color.White;
            }
        }



        private void image_upload_button_Click(object sender, EventArgs e)
        {
            // allow suer to specify the image

            // set up an OpenFileDialog
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Select an Image";
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                MessageBox.Show("Selected file: " + filePath);
                uploaded_image_picture_box.Enabled = true;
                uploaded_image_picture_box.Visible = true;

                try
                {
                    // Load the image using a FileStream
                    using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
                    {
                        // Load into a Bitmap to handle image conversion
                        using (var bmp = new Bitmap(fs))
                        {
                            uploaded_image_picture_box.Image = new Bitmap(bmp);
                        }
                    }

                    uploaded_image_picture_box.Enabled = true;
                    uploaded_image_picture_box.Visible = true;
                }
                catch (OutOfMemoryException)
                {
                    MessageBox.Show("The selected image is too large or corrupted.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (ArgumentException)
                {
                    MessageBox.Show("The image format is not supported or the file is invalid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An unexpected error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void register_button_Click(object sender, EventArgs e)
        {
            bool passed_validation;

            passed_validation = check_id(ID_text_box.Text);

            passed_validation = check_password(password_text_box.Text);

            passed_validation = check_email(email_text_box.Text);

            passed_validation = check_name(name_text_box.Text);

            passed_validation = check_lastname(lastname_text_box.Text);

            passed_validation = check_phone_number(phone_number_text_box.Text);

            passed_validation = check_ethnicity();


        }



        // a helper methods to validate input fields

        private bool check_id(string _ID)
        {
            // TODO: IMPLEMENT MORE CHECKS
            if (_ID.Length == 0)
            {
                ID_text_box.BackColor = Color.Red;
                MessageBox.Show("ID is empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (georgian_radio_button.Checked)
            {
                if (_ID.Length != 11)
                {
                    ID_text_box.BackColor = Color.Red;
                    MessageBox.Show("ID must be 11 numbers long.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                if (Regex.IsMatch(_ID, @"\D"))
                {
                    ID_text_box.BackColor = Color.Red;
                    MessageBox.Show("ID must only contain numbers.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }

            return true;
        }

        private bool check_password(string _password)
        {
            // TODO: IMPLEMENT MORE CHECKS
            if (_password.Length == 0)
            {
                password_text_box.BackColor = Color.Red;
                MessageBox.Show("Password is empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }


            return true;
        }

        private bool check_email(string _email)
        {
            // TODO: IMPLEMENT MORE CHECKS
            if (_email.Length == 0)
            {
                email_text_box.BackColor = Color.Red;
                MessageBox.Show("Email is empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }


            return true;
        }

        private bool check_name(string _name)
        {
            // TODO: IMPLEMENT MORE CHECKS
            if (_name.Length == 0)
            {
                name_text_box.BackColor = Color.Red;
                MessageBox.Show("name is empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }


            return true;
        }

        private bool check_lastname(string _lastname)
        {
            // TODO: IMPLEMENT MORE CHECKS
            if (_lastname.Length == 0)
            {
                lastname_text_box.BackColor = Color.Red;
                MessageBox.Show("Last Name is empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }


            return true;
        }

        private bool check_phone_number(string _phone_number)
        {
            // TODO: IMPLEMENT MORE CHECKS
            if (_phone_number.Length == 0)
            {
                phone_number_text_box.BackColor = Color.Red;
                MessageBox.Show("Phone Number is empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }


            return true;
        }

        private bool check_ethnicity()
        {
            // TODO: IMPLEMENT MORE CHECKS
            if (!georgian_radio_button.Checked && !foreigner_radio_button.Checked)
            {
                ethnicity_label.BackColor = Color.Red;
                MessageBox.Show("Ethnicity not selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }


            return true;
        }

        private void RegistrationForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
            Application.Exit();
        }
    }
}
