using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Department
{
   
        class Departament
        {
            private string name;


            public Departament(string n, string p, int c)
            {

                this.name = n;

            }
            public Departament()
            {

            }
            public string get_name() { return name; }


            public void set_name(string n) { this.name = n; }

        }
    
}
