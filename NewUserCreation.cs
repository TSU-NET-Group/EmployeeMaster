using System;
using System.Data;
using System.Windows.Forms;


namespace Registration
{
    // this struct can be used to save new user info
    public struct user_struct
    {
        public int id;
        public string user_id;
        public string user_email;
        public int user_phone;
        public string user_name;
    }

    public partial class NewUserCreation : Form
    {
        public static DataTable user_data_table;
        public static TextBox search_text_box;


        public NewUserCreation()
        {
            InitializeComponent();

        }

        private void RegistrationForm_Load(object sender, EventArgs e)
        {


        }

    }
}
