using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;




namespace EmployeeMaster
{

    // employee class prototype
    /*
    enum Department
    {

    }
    enum Ethnicity
    {

    }
    class Employee
    {
        int ID, Phone_Number;
        String Password, Email, Name, Last_Name;
        Department Department_Member;
        Ethnicity EMployee_Ethnicity;
        string Image_Link;

    }
    */
    //List<string> Column_Names {"piradi nomeri","saxeli/gvari"};

    class HR_module
    {
        //needs employee class to create an employee list

        public DataTable Employee_Table;
        DataTable Result_Table;

        //all column names/types that exist in the structure, this is temporary
        public static List<string> Column_Names= new List<string> {"ID","saxeli/gvari"};


        List<Tuple<string,Type>> Column_Type;


        //droibiti svetebis inicializaciis metodi
        public void Column_Type_Init(List<Tuple<string,Type>> Column_type)
        {
            Column_Type = Column_type;
        }

        


        //inicializacia table-is
        public void Table_Init()
        {
            Employee_Table = new DataTable();
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







        }

        //daumtavrebeli dzebnis algoritmi
        public void Table_Search(string Key_Word, string Target_Column)
        {
            for (int i = 0; i < Column_Names.Count; i++)
            {
                if (Target_Column == Column_Type[i].Item1)
                {
                    if (Column_Type[i].Item2 == typeof(int)) {
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
