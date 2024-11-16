using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EmployeeMaster
{
    public class Schedule
    {

        // each day consists of 4 numbers
        // fist number is check in hour, second number is check in minute 
        // third  number is check out hour and forth number is check out minute

        public int[,] schedule = new int[7,4];
        
        public Schedule(int[,] schedule_table)
        {
            if (schedule_table.Length == 7)
            {
                for (int i = 0; i < 7; i++)
                {
                    //-1 indicates day off
                    if(schedule_table[i, 1]<25 && schedule_table[i, 1] >= -1 &&
                       schedule_table[i, 2] < 25 && schedule_table[i, 2] >= -1)
                    {
                        continue;
                    }
                    else
                    {
                        throw new Exception("invalid hour/minute values");
                    }
                }
                this.schedule = schedule_table;
            }
            else
            {
                throw new Exception("invalid schedula table size, must be 7 days");
            }  
        }


        
    }
}
