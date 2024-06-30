using System;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Xml.Linq;
using task_3;

namespace task_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] ARR = { 1, 7, 9, 45 };/// change data type and comma and ;

            //string[] arr2 = { "Str", "alex", "moh" };/////[]+{}+,;

            //string[] arr3 = { "the", "fox", "over", "lazy", "dog" };/////[],{};


            //String[] fruits = { "Tomato", "Banana", "Watermelon" };/////index of tomato 0//index of banana 1
            //for (int i = 0; i < fruits.Length; i++)
            //{
            //    Console.WriteLine(fruits[i]);
            //}

            //string[] food = { "mansaf ", "seafood ", "kabseh ", "Fettuccine ", "burger" };
            //string[] sport = { "swimng ", "football ", "gym" };
            //string[] Movie = { "who am i ", "siccin ", "fast and furious " };
            //Console.WriteLine();
            //Console.WriteLine("fav food :");
            //foreach (string i in food)
            //{
            //    Console.Write(i);
            //}
            //Console.WriteLine();
            //Console.WriteLine("fav sport :");
            //foreach (string i in sport)
            //{
            //    Console.Write(i);
            //}
            //Console.WriteLine();
            //Console.WriteLine("fav movies:");
            //for (int i = 0; i < Movie.Length; i++)
            //{
            //    Console.Write(Movie[i]);
            //}
            //Console.WriteLine();

            //int[] num = new int[5];

            //for (int i = 0; i < num.Length; i++)
            //{
            //    num[i] = Convert.ToInt32(Console.ReadLine());

            //}
            //for (int i = 0; i < num.Length; i++)
            //{
            //    Console.Write(num[i] + ",");

            //}
            //Console.WriteLine();
            //Console.WriteLine(num.Sum());


            //////////q4///////////

            //int result = Console.ReadLine().Split(',').Select(item => int.Parse(item)).Sum();
            //Console.Write(result);
            //Console.ReadKey();


            //int sum = 0;
            //for (int i = 0; i < 100; i++)
            //{
            //    if (i % 2 == 1)
            //    {
            //        Console.Write(i + " ");
            //        sum += i;

            //    }

            //}
            //Console.WriteLine("\nThe Sum of odd Numbers is: " + sum);
            //for (int i = 1; i <= 4; i++)
            //{

            //    for (int j = 1; j <= 4 - i; j++)
            //    {
            //        Console.Write(" ");
            //    }


            //    for (int k = 1; k <= i; k++)
            //    {
            //        Console.Write("*" + " ");

            //    }

            //    Console.WriteLine();


            //}


            //int number = 1;

            //for (int i = 1; i <= 4; i++)
            //{

            //    for (int j = 1; j <= 4 - i; j++)
            //    {
            //        Console.Write(" ");
            //    }

            //    for (int k = 1; k <= i; k++)
            //    {
            //        Console.Write(number + " ");
            //        number++;
            //    }

            //    Console.WriteLine();



            //}

            //StudantInformation myObj = new StudantInformation();
            //myObj.getavarge("mustafa ", 85, 96, 99);

            //your_name();

            //multiply(10, 10);
            int[] array = new int[10];
            sum(array);
            cube();

            Numyears obj2 = new Numyears();
            obj2.getYears(obj2.years);
            oldYear(27);

            peson obj3=new peson();
            obj3.getperson();
           


        }






        //static void your_name()
        //{
        //    string name = Console.ReadLine();
        //    Console.WriteLine(name);
        //}
        //static void multiply(int x, int y)
        //{

        //    Console.WriteLine(x * y);
        //}

        ///q1
        static void sum(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("The sum of 10 no is : " + array.Sum());
            Console.WriteLine("The Average is : " + array.Average());
        }
        /////////q2/////
        static void cube()
        {
            Console.WriteLine("Input number of terms : ");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Number is : {i} and cube of the {i} is :{Math.Pow(i, 3)}");
            }
        }
        static void oldYear(int old)
        {
            int Old = old * 365;
            Console.WriteLine($"old in day {Old}");
        }



    }
}
