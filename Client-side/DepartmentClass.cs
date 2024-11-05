

using System.Collections.Generic;

namespace Registration
{
    public static class All_Departments
    {
        public static List<Departament> Departments = new List<Departament>();


        public static List<string> Department_Names()
        {
            List<string> names = new List<string>();
            foreach (Departament departament in Departments)
            {
                names.Add(departament.Name);
            }

            return names;
        }
    }

    public class Departament
    {
        private string department_name;
        private Position[] positions;



        public Departament(string name, Position[] positions)
        {
            this.department_name = name;
            this.positions = positions;
            All_Departments.Departments.Add(this);
        }

        public string Name { get { return this.department_name; } set { this.department_name = value; } }
        public Position[] Positions { get { return this.positions; } set { positions = value; } }


        public override string ToString()
        {
            return this.department_name;
        }
    }
}
