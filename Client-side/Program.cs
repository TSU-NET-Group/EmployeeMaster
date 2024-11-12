using GroupProject_v001;
using Registration;
using System;
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



            //Application.Run(new KeyCardCodeGenerator());
            //Application.Run(new RegistrationForm());
            Application.Run(new NewUserManagement());
        }
    }
}
