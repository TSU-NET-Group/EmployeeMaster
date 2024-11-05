using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        public string user_keycard;
        public string user_department;
        public string user_position;
    }

    public partial class NewUserManagement : Form
    {
        public static DataTable user_data_table;
        public static TextBox search_text_box;
        public static DataGridView user_data_grid_view;
        public static ComboBox search_option_combo_box;
        public static Button save_button;
        public static Button refresh_button;
        public static ComboBox sort_by_combo_box;

        public static DataGridView temp_data_grid_view;


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


            // data grid view to display search results
            temp_data_grid_view = new DataGridView();
            temp_data_grid_view.Size = new Size(600, 350);
            temp_data_grid_view.Location = new Point(10, 500);
            this.Controls.Add(temp_data_grid_view);

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


            // combo box for sorting
            sort_by_combo_box = new ComboBox();
            sort_by_combo_box.Location = new Point(640, 280);
            sort_by_combo_box.Size = new Size(100, 25);
            sort_by_combo_box.Items.AddRange(user_data_table.Columns
    .Cast<DataColumn>()
    .Select(column => column.ColumnName)
    .ToArray());
            sort_by_combo_box.SelectedIndex = 1;
            sort_by_combo_box.DropDownStyle = ComboBoxStyle.DropDownList;
            sort_by_combo_box.SelectedIndexChanged += sort_by_combo_box_SelectedIndex;
            this.Controls.Add(sort_by_combo_box);



            // save to table
            save_button = new Button();
            save_button.Size = new Size(100, 50);
            save_button.Location = new Point(650, 20);
            save_button.Text = "Save";
            save_button.Click += new EventHandler(save_button_click);
            this.Controls.Add(save_button);

            // refresh table display
            refresh_button = new Button();
            refresh_button.Size = new Size(100, 50);
            refresh_button.Location = new Point(650, 80);
            refresh_button.Text = "Refresh";
            refresh_button.Click += new EventHandler(refresh_button_click);
            this.Controls.Add(refresh_button);



            // create dummy data for testing
            user_struct user1 = new user_struct { id = 1, user_id = "555555", user_email = "sasa@gmail.com", user_phone = 45875489, user_name = "saba shengelia", user_keycard = "56412314", user_department = "dasuftaveba", user_position = "senior damlagebeli" };
            user_struct user2 = new user_struct { id = 2, user_id = "8945884", user_email = "soso@gmail.com", user_phone = 84578423, user_name = "soso wiqarishvili", user_keycard = "114235641", user_department = "software development", user_position = "junior backend developer" };
            user_struct user3 = new user_struct { id = 3, user_id = "47894652", user_email = "jemal@gmail.com", user_phone = 84578423, user_name = "jemal kandavili", user_keycard = "45618", user_department = "driver development", user_position = "manager" };
            user_struct user4 = new user_struct { id = 4, user_id = "594884", user_email = "nino@gmail.com", user_phone = 7859234, user_name = "nino bugadze", user_keycard = "456218", user_department = "KGB", user_position = "CLASSIFIED" };

            // add the dummy data to the data table
            add_to_user_table(user4, user2, user3, user1);

            // set the data source for grid view so we can visually see the data table
            user_data_grid_view.DataSource = user_data_table;
        }

        public static void initialize_data_tables()
        {
            // set up a user data table
            user_data_table = new DataTable();

            user_data_table.Columns.AddRange(EmployeeMaster.columns.column_names.ToArray());
        }


        public static void add_to_user_table(params user_struct[] _users)
        {
            // add every user to the data table
            foreach (user_struct _user in _users)
            {
                user_data_table.Rows.Add(
                    _user.id,
                    _user.user_id,
                    _user.user_email,
                    _user.user_phone,
                    _user.user_name,
                    _user.user_keycard,
                    _user.user_department,
                    _user.user_position);
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


        private void save_button_click(object sender, EventArgs e)
        {
            temp_data_grid_view.DataSource = user_data_table;
        }

        private void refresh_button_click(object sender, EventArgs e)
        {
            search_text_box.Text = string.Empty;
            search_text_box_TextChanged(sender, e);
        }

        private void sort_by_combo_box_SelectedIndex(object sender, EventArgs e)
        {
            user_data_grid_view.Sort(user_data_grid_view.Columns[sort_by_combo_box.Text], ListSortDirection.Ascending);
        }

    }
}