using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Department
{
    public class Department
    {
        public string department_name;
        private ulong department_id;

        public ulong Department_id {  get => department_id; private set => department_id = value; }

    }
}
