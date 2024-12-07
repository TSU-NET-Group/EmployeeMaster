using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EmployeeMaster
{
    internal class schedule
    {
        public string Schedule_Group_Name;
        public bool[] workdays = new bool[7];
        public Tuple<int, int> shift_hours;

        public schedule(string schedule_Group_Name, bool[] workdays, string shift_s, string shift_e)
        {
            Schedule_Group_Name = schedule_Group_Name;
            this.workdays = workdays;



            int s = ((int)shift_s[0] - '0') * 1000 + ((int)shift_s[1] - '0') * 100 + ((int)shift_s[3] - '0') * 10 + ((int)shift_s[4] - '0');
            int e = ((int)shift_e[0] - '0') * 1000 + ((int)shift_e[1] - '0') * 100 + ((int)shift_e[3] - '0') * 10 + ((int)shift_e[4] - '0');

            shift_hours = new Tuple<int, int>(s, e);

        }
    }
}
