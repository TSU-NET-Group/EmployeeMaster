

using System.Collections.Generic;

namespace Registration
{
    public static class All_Departments
    {
        public static List<Departament> Departments = new List<Departament>();
    }

    public class Departament
    {
        private string department_name;
        private Position[] positions;



        public Departament(string name, Position[] positions)
        {
            this.department_name = name;
            this.positions = positions;
        }

        public string Name { get { return this.department_name; } set { this.department_name = value; } }
        public Position[] Positions { get { return this.positions; } }


        public override string ToString()
        {
            return this.department_name;
        }
    }
}
