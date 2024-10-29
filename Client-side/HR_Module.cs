using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

using Registration;


namespace EmployeeMaster
{
    //all column names/types that exist in the structure
    public static class columns
    {
        public static List<DataColumn> column_names = new List<DataColumn> { new DataColumn("id",typeof(int)),
            new DataColumn("user_personal_id",typeof(string)),
            new DataColumn("user_mail",typeof(string)),
            new DataColumn("user_phone",typeof(string)),
            new DataColumn("user_name",typeof(string)),
            new DataColumn("user_department",typeof(string)),
            new DataColumn("user_position",typeof(string)),
            };    
    }

    


    class HR_module
    {

        DataTable Employees;

        public DataTable Employee_Table;
        DataTable Result_Table;



        //List<Tuple<string,Type>> Column_Type;
        List<DataColumn> Column_Type;

        //droibiti svetebis inicializaciis metodi
        public void Column_Type_Init(List<DataColumn> Column_type)
        {
            Column_Type = Column_type;
        }

        


        //inicializacia table-is
        public void Table_Init()
        {
            Employee_Table = new DataTable();
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
            for (int i = 0; i < Column_Type.Count; i++)
            {
                
                Employee_Table.Columns.Add(Column_Type[i]);
            }


            //TODO: SHENGE FIX THIS !!!!!!!!!!
            Employees = NewUserManagement.user_data_table;

            for (int i = 0; i < Employees.Rows.Count; i++)
            {
                //if (Employees.Rows[i].) 
                    Employee_Table.Rows.Add(Employees.Rows[i]);
            }




        }

        //daumtavrebeli dzebnis algoritmi
        public void Table_Search(string Key_Word, DataColumn Target_Column)
        {
            for (int i = 0; i < columns.column_names.Count; i++)
            {
                if (Target_Column.ColumnName == Column_Type[i].ColumnName)
                {
                    if (Column_Type[i].DataType == typeof(int)) {
                        bool Conversion = Int32.TryParse(Key_Word, out int number);



                    }
                    else
                    {


                    }
                }
            }
        }

        //needs row inserter method for adding employees to tables, may require employee class first
        

    }

    class Hr_Emp_CMS : HR_module
    {
        //module for managing employees
    }

    class Hr_Schedule_module : HR_module
    {
        //module for managing schedule for employees

        
    }

  

}
