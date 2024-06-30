using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_3
{
    internal class StudantInformation 
    {
        string studant_name;
        int Firstgrade;
        int secondgrade;
        int finalgraid;
      public void getavarge(string studant_name, int Firstgrade,int secondgrade,int finalgraid)
        {
           int avg= (Firstgrade + secondgrade + finalgraid )/ 3;
            Console.WriteLine($"name: {studant_name} {avg}");
        }
    }
}
