using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace task_6
{
    internal class Program
    {
        static void Main(string[] args)
        {

            cars newCar = new cars("BMW", 2024, "SUV", 55000, "X5", "ABC123", "Black");
            
            newCar.Start();
            newCar.Stop();

            Bmw bmw = new Bmw("BMW", 2021, "Convertible", 62000, "x6", "PAL127", "red");
           
            bmw.Start();
            bmw.Stop();
        }
    }
}
