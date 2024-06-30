using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_3
{
    public class Numyears
    {
        public int[] years;
        public Numyears()
        {
            years =new int[] { 1763, 1972, 1925, 1916, 1984, 1124, 1950, 2020 };
        }

        public void getYears(int []years)
        {

            for (int i = 0; i < years.Length; i++)
            {
                if (years[i] >= 1950)
                {
                    Console.WriteLine(years[i]);
                }
            }
        }

    }
}
