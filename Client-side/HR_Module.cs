using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
//using System.Windows.Forms;

using Registration;


namespace EmployeeMaster
{
    //all column names/types that exist in the structure
    public static class columns
    {
        public static List<DataColumn> column_names = new List<DataColumn> { 
            new DataColumn("id",typeof(int)),
            new DataColumn("user_personal_id",typeof(string)),
            new DataColumn("user_mail",typeof(string)),
            new DataColumn("user_phone",typeof(string)),
            new DataColumn("user_name",typeof(string)),
            new DataColumn("user_keycard",typeof(string)),
            new DataColumn("user_department",typeof(string)),
            new DataColumn("user_position",typeof(string)),
            };    
    }

    


    public class HR_module
    {

        //DataTable Employees;

        public DataTable Employee_Table;
        public DataTable Department_Table;
        public DataTable Position_Table;
        public DataTable Result_Table;



        //List<Tuple<string,Type>> Column_Type;
        public List<DataColumn> Column_Type;

        //droibiti svetebis inicializaciis metodi
        public void Column_Type_Init(List<DataColumn> Column_type)
        {
            Column_Type = Column_type;

        }

        


        //inicializacia table-is


        //needs departments list to be fully complete
        public void Table_Init(string department_name="all", string position_name="all")
        {


            Employee_Table = new DataTable();
            Position_Table = new DataTable();
            Department_Table= new DataTable();
            Result_Table= new DataTable();


            /*
            for (int i = 0; i < Column_Type.Count; i++)
            {
                if (Column_Type[i].Item2 == typeof(string))
                {
                    Employee_Table.Columns.Add(Column_Type[i].Item1, typeof(string));
                    //Employee_Table.Columns.Add("saxeli", typeof(string));
                } else if (Column_Type[i].Item2 == typeof(int))
                {
                    Employee_Table.Columns.Add(Column_Type[i].Item1, typeof(int));
                }
            }
            */

            throw new NotImplementedException();

            for (int i = 0; i < Column_Type.Count; i++)
            { 
                Employee_Table.Columns.Add(Column_Type[i]);
                
            }
             

            //TODO: SHENGE FIX THIS !!!!!!!!!!


            // -- shenge:
            //needs data base of users to already exist,
            //without it will always result in an error since there is no user database to work with
            //also i need department list, so that ican load it by department
            //right now this just throws in all employees


            //Employees = NewUserManagement.user_data_table;

            for (int i = 0; i < NewUserManagement.user_data_table.Rows.Count; i++)
            {
                //if (Employees.Rows[i].) 
                    Employee_Table.Rows.Add(NewUserManagement.user_data_table.Rows[i]);
            }

            Load_By_Department(department_name);
            Load_By_Position(position_name);

            Result_Table = Position_Table;

        }

        //daumtavrebeli dzebnis algoritmi
        public void Table_Search(string Key_Word, DataColumn Target_Column)
        {
            //for (int i = 0; i < columns.column_names.Count; i++)
            //{
            //    if (Target_Column.ColumnName == Column_Type[i].ColumnName)
            //    {
            //        if (Column_Type[i].DataType == typeof(int)) {
            //            bool Conversion = Int32.TryParse(Key_Word, out int number);

            //            for (int k = 0; k < Position_Table.Rows.Count; k++)
            //            {

            //            }

            //        }
            //        else
            //        {


            //        }
            //    }
            //}
            int column_index=-1;
            DataTable temp_table=new DataTable();
            for (int i = 0; i < Column_Type.Count; i++)
            {
                if (Target_Column == Column_Type[i]) column_index = i;
            }
            for (int i = 0; i < Position_Table.Rows.Count; i++)
            {
                if (column_index == -1) throw new Exception("attempting to search in invalid column");
                if (Key_Word == Position_Table.Rows[i][column_index].ToString())
                {
                    temp_table.Rows.Add(Position_Table.Rows[i]);
                }
            }
            Result_Table = temp_table;
        }

        // in order for final table to be loaded these functions will be called in the following order:
        // 1) table_init 2) Load_By_department 3) Load_By_Position
        // both department and position will have a  member called "all" so that if needed you can view
        // all employyes in a single datatable

        public void Load_By_Position(string position)
        {
            int column_index = -1;
            DataTable temp_table = new DataTable();
            for (int i = 0; i < Column_Type.Count; i++)
            {
                if ("user_position" == Column_Type[i].Caption) column_index = i;
            }

            for (int i = 0; i < Department_Table.Rows.Count; i++)
            {
                if (column_index == -1) throw new Exception("attempting to search in invalid column");
                if (position == Department_Table.Rows[i][column_index].ToString())
                {
                    temp_table.Rows.Add(Position_Table.Rows[i]);
                }
            }

            Position_Table = temp_table;
        }

        public void Load_By_Department(string department_name)
        {

            int column_index = -1;
            DataTable temp_table = new DataTable();
            for (int i = 0; i < Column_Type.Count; i++)
            {
                if ("user_department" == Column_Type[i].Caption) column_index = i;
            }

            for (int i = 0; i < Employee_Table.Rows.Count; i++)
            {
                if (column_index == -1) throw new Exception("attempting to search in invalid column");
                if (department_name == Employee_Table.Rows[i][column_index].ToString())
                {
                    temp_table.Rows.Add(Position_Table.Rows[i]);
                }
            }
            Department_Table = temp_table;
        }


        


    }


    //these two classes may not be needed since i have been
    //basically putting all the function in the parent class
    //who needs hierarchy anyway???
    class Hr_Emp_CMS : HR_module
    {
        //module for managing employees
    }

    class Hr_Schedule_module : HR_module
    {

        DataTable time_table;

        public Hr_Schedule_module()
        {
            time_table.Columns.Add("name/surname", typeof(string));
            time_table.Columns.Add("id", typeof(int));
            time_table.Columns.Add("check in time", typeof(string));
            time_table.Columns.Add("check out time", typeof(string));
            time_table.Columns.Add("time worked", typeof(string));

            //this will be modified so i am not gonna bother with
            //putting too much effort in this part of the code for now
            for (int i=0;i< Employee_Table.Rows.Count;i++)
            {
                //DataRow temp = new DataRow(Employee_Table.Rows[i][0], Employee_Table.Rows[i][1]);
                DataRow temp = time_table.NewRow();
                temp["name/surname"] = Employee_Table.Rows[i][0];
                temp["id"] = Employee_Table.Rows[i][1];
                //to do later when database is made
                temp["check in time"] = "";
                temp["check in time"] = "";
                temp["check in time"] = "";
                time_table.Rows.Add(temp);
            }
            
        }

        void time_manager(int id)
        {
            //this will be recieved from the database
            Schedule temp_schedule = new Schedule(new int[,] { });

            int index=-1;
            for (int i = 0; i < time_table.Rows.Count; i++)
            {
                if ((int)time_table.Rows[i][1] == id)
                {
                    index = id;
                }
            }
            //this will be recieved from the check in/check out device
            int[] work_time = new int[4];




            if (work_time[0] > temp_schedule.schedule[(int)DateTime.Now.DayOfWeek, 0] &&
                work_time[1] > temp_schedule.schedule[(int)DateTime.Now.DayOfWeek, 1])
            {
                if (index != -1)
                {
                    //is on time
                    
                }
                
            }

            if (work_time[2] > temp_schedule.schedule[(int)DateTime.Now.DayOfWeek, 2] &&
                work_time[3] > temp_schedule.schedule[(int)DateTime.Now.DayOfWeek, 3])
            {
                if (index != -1)
                {
                    //left on time

                }

            }
        }
    }

  

}
