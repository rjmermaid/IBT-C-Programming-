using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter09ProgramClassDesign.zip
{
    class clsDates
    {
        private static int[] daysInMonth =
        {
             0, 31, 28, 31, 30, 31, 30, 31,
            31, 30, 31, 30, 31
        };
        private int day;
        private int month;
        private int year;
        private int leapYear;
        private DateTime current;
        public clsDates()
        {
            current = DateTime.UtcNow;
        }
        public int getLeapYear(int year)
        {
            if (year % 4 == 0 && year % 100 != 0 || year % 400 == 0)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        public string getEaster(int year)
        {
            int offset;
            int leap;
            int day;
            int temp1;
            int temp2;
            int total;
            offset = year % 19;
            leap = year % 4;
            day = year % 7;
            temp1 = (19 * offset + 24) % 30;
            temp2 = (2 * leap + 4 * day + 5) % 7;
            total = 22 + temp2 + temp1;
            if (total > 31)
            {
                month = 4;
                day = total - 31;
            }
            else
            {
                month = 3;
                day = total;
            }
            DateTime myDT = new DateTime(year, month, day);
            return myDT.ToLongDateString();
        }
    }
}
