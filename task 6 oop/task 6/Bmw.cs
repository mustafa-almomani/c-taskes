using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace task_6
{
    class Bmw :cars
    {
        public Bmw (string Make, int Year, string Type, double Price, string Model, string PalletNo, string Color)
        : base(Make, Year, Type, Price, Model, PalletNo, Color)
        {
        }
    }
}
