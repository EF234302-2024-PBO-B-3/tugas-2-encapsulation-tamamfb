using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation.Calendar
{
    public class Date
    {
        public int Month { get; private set; }
        public int Day { get; private set; }
        public int Year { get; private set; }

        public Date(int month, int day, int year)
        {
            if (month < 1 || month > 12)
            {
                Month = 1;
            }
            else
            {
                Month = month;
            }

            if (day < 1 || day > 31)
            {
                Day = 1;
            }
            else
            {
                Day = day;
            }

            Year = year;

            if (month < 1 || month > 12 || day < 1 || day > 31)
            {
                Month = 1;
                Day = 1;
                Year = 1970;
            }
        }

        public void DisplayDate()
        {
            Console.WriteLine($"{Month}/{Day}/{Year}");
        }
    }

}


