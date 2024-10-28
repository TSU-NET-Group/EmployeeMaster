using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
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

    public partial class NewUserManagement : Form
    {
        public static DataTable user_data_table;
        public static TextBox search_text_box;
        public static DataGridView user_data_grid_view;
        public static ComboBox search_option_combo_box;

        public NewUserManagement()
        {
            InitializeComponent();
        }


        public void NewUserManagement_Load(object sender, EventArgs e)
        {
            InitializeComponent();

            // Search box and DataGridView setup
            search_text_box = new TextBox();
            search_text_box.Location = new Point(640, 220);
            search_text_box.Size = new Size(150, 25);
            search_text_box.TextChanged += search_text_box_TextChanged;
            this.Controls.Add(search_text_box);


            // data grid view to display search results
            user_data_grid_view = new DataGridView();
            user_data_grid_view.Size = new Size(600, 350);
            user_data_grid_view.Location = new Point(10, 10);
            this.Controls.Add(user_data_grid_view);


            initialize_data_tables(); // set up all the data tables


            // set up combo box for searching bu specific type
            search_option_combo_box = new ComboBox();
            search_option_combo_box.Location = new Point(640, 250);
            search_option_combo_box.Size = new Size(100, 25);
            search_option_combo_box.DropDownStyle = ComboBoxStyle.DropDownList;
            this.Controls.Add(search_option_combo_box);

            search_option_combo_box.Items.AddRange(user_data_table.Columns
    .Cast<DataColumn>()
    .Select(column => column.ColumnName)
    .ToArray());

            search_option_combo_box.SelectedIndex = 0;




            // create dummy data for testing
            user_struct user1 = new user_struct { id = 1, user_id = "555555", user_email = "sasa@gmail.com", user_phone = 45875489, user_name = "saba shengelia" };
            user_struct user2 = new user_struct { id = 2, user_id = "8945884", user_email = "soso@gmail.com", user_phone = 84578423, user_name = "soso wiqarishvili" };
            user_struct user3 = new user_struct { id = 3, user_id = "47894652", user_email = "jemal@gmail.com", user_phone = 84578423, user_name = "jemal kandavili" };
            user_struct user4 = new user_struct { id = 4, user_id = "594884", user_email = "nino@gmail.com", user_phone = 7859234, user_name = "nino bugadze" };

            // add the dummy data to the data table
            add_to_user_table(user1, user2, user3, user4);

            // set the data source for grid view so we can visually see the data table
            user_data_grid_view.DataSource = user_data_table;
        }

        public static void initialize_data_tables()
        {
            // set up a user data table
            user_data_table = new DataTable();
            /*
            user_data_table.Columns.Add("id", typeof(int));
            user_data_table.Columns.Add("user_personal_id", typeof(string));
            user_data_table.Columns.Add("user_mail", typeof(string));
            user_data_table.Columns.Add("user_phone", typeof(string));
            user_data_table.Columns.Add("user_name", typeof(string));
            */

            user_data_table.Columns.AddRange(EmployeeMaster.columns.column_names.ToArray());
        }

        public static void add_to_user_table(params user_struct[] _users)
        {
            // add every user to the data table
            foreach (user_struct _user in _users)
            {
                user_data_table.Rows.Add(_user.id,
                    _user.user_id,
                    _user.user_email,
                    _user.user_phone,
                    _user.user_name);
            }
        }



        private void search_text_box_TextChanged(object sender, EventArgs e)
        {
            string searchTerm = search_text_box.Text.ToLower();
            string searchColumn = search_option_combo_box.Text;

            try
            {
                IEnumerable<DataRow> filteredRows;

                // Check the column type to apply the correct filtering logic
                if (user_data_table.Columns[searchColumn].DataType == typeof(int))
                {
                    // Attempt to parse the input as an integer for exact matches
                    if (int.TryParse(searchTerm, out int searchValue))
                    {
                        // Filter rows that match the exact integer value
                        filteredRows = user_data_table.AsEnumerable()
                            .Where(row => row.Field<int>(searchColumn) == searchValue);
                    }
                    else
                    {
                        // If the input is not a valid integer, show no results
                        filteredRows = Enumerable.Empty<DataRow>();
                    }
                }
                else
                {
                    // For string columns, use case-insensitive search
                    filteredRows = user_data_table.AsEnumerable()
                        .Where(row => row.Field<string>(searchColumn).ToLower().Contains(searchTerm));
                }

                // Check if any rows match the filter
                if (filteredRows.Any())
                {
                    // If there are matches, update the DataGridView
                    user_data_grid_view.DataSource = filteredRows.CopyToDataTable();
                }
                else
                {
                    // If no matches, clear the DataGridView or show all rows
                    user_data_grid_view.DataSource = user_data_table;
                }
            }
            catch
            {
                // Handle any exceptions gracefully, for example, reset the DataGridView
                user_data_grid_view.DataSource = user_data_table;
            }
        }
    }
}