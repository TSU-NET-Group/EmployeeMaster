using System;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
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

        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void RegistrationForm_Load(object sender, EventArgs e)
        {
            // ID_label
            Label ID_label = new Label();
            ID_label.Location = new Point(120, spacing * 1);
            ID_label.Text = "ID";
            ID_label.AutoSize = true;
            this.Controls.Add(ID_label);

            // ID_text_box
            TextBox ID_text_box = new TextBox();
            ID_text_box.Location = new Point(250, spacing * 1);
            ID_text_box.Location = new Point(250, spacing * 1);
            ID_text_box.Size = new Size(250, 25);
            this.Controls.Add(ID_text_box);


            // paswword_label
            Label password_label = new Label();
            password_label.Location = new Point(120, spacing * 2);
            password_label.Text = "Password";
            password_label.AutoSize = true;
            this.Controls.Add(password_label);

            // password_text_box
            TextBox password_text_box = new TextBox();
            password_text_box.Location = new Point(250, spacing * 2);
            password_text_box.Size = new Size(250, 25);
            this.Controls.Add(password_text_box);


            // email_label
            Label email_label = new Label();
            email_label.Location = new Point(120, spacing * 3);
            email_label.Text = "Email";
            email_label.AutoSize = true;
            this.Controls.Add(email_label);

            // email_text_box
            TextBox email_text_box = new TextBox();
            email_text_box.Location = new Point(250, spacing * 3);
            email_text_box.Size = new Size(250, 25);
            this.Controls.Add(email_text_box);


            // name_label
            Label name_label = new Label();
            name_label.Location = new Point(120, spacing * 4);
            name_label.Text = "Name";
            name_label.AutoSize = true;
            this.Controls.Add(name_label);

            // name_text_box
            TextBox name_text_box = new TextBox();
            name_text_box.Location = new Point(250, spacing * 4);
            name_text_box.Size = new Size(250, 25);
            this.Controls.Add(name_text_box);


            // lastname_label
            Label lastname_label = new Label();
            lastname_label.Location = new Point(120, spacing * 5);
            lastname_label.Text = "Last name";
            lastname_label.AutoSize = true;
            this.Controls.Add(lastname_label);

            // lastname_text_box
            TextBox lastname_text_box = new TextBox();
            lastname_text_box.Location = new Point(250, spacing * 5);
            lastname_text_box.Size = new Size(250, 25);
            this.Controls.Add(lastname_text_box);


            // lastname_label
            Label phone_number_label = new Label();
            phone_number_label.Location = new Point(120, spacing * 6);
            phone_number_label.Text = "Phone Number";
            phone_number_label.AutoSize = true;
            this.Controls.Add(phone_number_label);

            // lastname_text_box
            TextBox phone_number_text_box = new TextBox();
            phone_number_text_box.Location = new Point(250, spacing * 6);
            phone_number_text_box.Size = new Size(250, 25);
            this.Controls.Add(phone_number_text_box);

            /* TODO: THIS MIGHT BE USEFUL
            // ethnicity_label
            Label ethnicity_label = new Label();
            ethnicity_label.Location = new Point(120, spacing * 7);
            ethnicity_label.Text = "Ethnicity";
            ethnicity_label.AutoSize = true;
            this.Controls.Add(ethnicity_label);

            // ethnicity_combo_box
            ComboBox ethnicity_combo_box = new ComboBox();
            ethnicity_combo_box.Location = new Point(250, spacing * 7);
            ethnicity_combo_box.Size = new Size(250, 25);
            ethnicity_combo_box.DropDownStyle = ComboBoxStyle.DropDownList;
            ethnicity_combo_box.Items.Add("Ethnicity");
            ethnicity_combo_box.Items.AddRange(ALL_COUNTRIES);
            ethnicity_combo_box.SelectedIndex = 0;
            this.Controls.Add(ethnicity_combo_box);
            */

            // ethnicity_label
            Label ethnicity_label = new Label();
            ethnicity_label.Location = new Point(120, spacing * 7);
            ethnicity_label.Text = "Ethnicity";
            ethnicity_label.AutoSize = true;
            this.Controls.Add(ethnicity_label);

            // georgian_radio_button
            RadioButton georgian_radio_button = new RadioButton();
            georgian_radio_button.Location = new Point(250, spacing * 7);
            georgian_radio_button.Text = "Geogian";
            georgian_radio_button.AutoSize = true;
            this.Controls.Add(georgian_radio_button);

            // foreigner_radio_button
            RadioButton foreigner_radio_button = new RadioButton();
            foreigner_radio_button.Location = new Point(250 + georgian_radio_button.Right, spacing * 7);
            foreigner_radio_button.Text = "Foreigner";
            georgian_radio_button.AutoSize = true;
            this.Controls.Add(foreigner_radio_button);


            // department_label
            Label department_label = new Label();
            department_label.Location = new Point(120, spacing * 8);
            department_label.Text = "Department";
            department_label.AutoSize = true;
            this.Controls.Add(department_label);

            // department_combo_box
            ComboBox department_combo_box = new ComboBox();
            department_combo_box.Location = new Point(250, spacing * 8);
            department_combo_box.Size = new Size(250, 25);
            department_combo_box.DropDownStyle = ComboBoxStyle.DropDownList;
            department_combo_box.Items.Add("Department");
            department_combo_box.SelectedIndex = 0;
            this.Controls.Add(department_combo_box);


            // upload image 
            Button image_upload_button = new Button();
            image_upload_button.Location = new Point(250, spacing * 9);
            image_upload_button.Size = new Size(50, 50);
            image_upload_button.Text = "Upload\nImage";
            this.Controls.Add(image_upload_button);



        }
    }
}
