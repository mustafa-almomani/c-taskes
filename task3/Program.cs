 using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = Convert.ToInt16(Console.ReadLine());
            int num2 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("the minimum number is : " + Math.Min(num1, num2));
            string num3 = Console.ReadLine();

            Console.WriteLine(num3[0]);




            int[] arr = { 4, 0, -1 };
            Array.Sort(arr);

            Console.WriteLine($"The numbers in ascending order are: {arr[0]}, {arr[1]}, {arr[2]}");

            int[] array = { -5, -2, -6, 0, -1 };
            Console.WriteLine(array.Max());

            Console.WriteLine("Input kilometers per hour: ");
            double kmh = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(kmh / 1.609344 + " miles per hour");

            Console.WriteLine("Input hours:");
            int houres = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input minutes:");
            int min = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(houres * 60 + min);
            Console.WriteLine("Input minutes:");

            int totalmin = Convert.ToInt32(Console.ReadLine());
            int houre = totalmin / 60;
            int minutes = totalmin % 60;
            Console.WriteLine(houre + ":" + minutes);

            string[] array2 = { "hello word","my name is mustafa ","i'm training in ","orange coding academy","and i'm happy" };
            Console.WriteLine($"{array2[0]} {array2[1]}{array2[2]}{array2[3]} {array2[4]}");
            Console.WriteLine($"lenght of index 0:{array2[0].Length}\n lenght of index 1: {array2[1].Length}\nlenght of index 2:{array2[2].Length}\nlenght of index 3:{array2[3].Length}\nlenght of index 4 :{array2[4].Length}");





        }
    }
}
