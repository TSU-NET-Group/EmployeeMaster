using Department;
using GroupProject_v001;
using Registration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeMaster
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]

        static void Main()
        {
            // ავტორიზაციის პროგრამის გაშვება იწყება აქ, მთავარი მეთოდიდან


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);


            

            // example of how departments can be set up
            Departament department_1 = new Departament(
                "software development",
                new Position[]
                {
                    new Position("backend"),
                    new Position("frontend"),
                    new Position("UI"),
                    new Position("designer"),
                });

            All_Departments.Departments.Add(department_1);

      
            Application.Run(new Departments());
            //Application.Run(new NewUserManagement());
        }
    }
}
