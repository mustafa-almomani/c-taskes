using Car;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car
{
    class Cars
    {
        int Make { get; set; }
        int Year { get; set; }
        string Type { get; set; }
        double Price { get; set; }
        string Model { get; set; }
        int PalletNo { get; set; }
        string Color { get; set; }
        public void DisplayInfo(int make, int year)
        {
            Make = make;
            Year = year;
            Console.WriteLine($"Make: {make}, Year: {year}");
        }
        public void DisplayInfo(int make)
        {

            Make = make;
            Console.WriteLine($"Make: {make}");
        }
        public virtual void Display()
        {
            Console.WriteLine("Welcome Car");
        }
    }
    class BMW : Cars
    {
        public override void Display()
        {
            Console.WriteLine("Welcome BMW");
        }
    }



}
//////task 2
interface ISound ////interface
{
    void MakeSound();

}
public abstract class Animal ///abstract class animal perant 
{
    public string Name { get; set; }
   public Animal(string name)
    {
        Name = name;
    }
    public abstract void  Eat();
    public void Sleep()
    {
        Console.WriteLine($"{Name} is sleep ZzZzZzZzZz");
    }
}
public class Dog : Animal, ISound ////////class dog child 
{
    public Dog(string name) : base(name) { }
    public override void Eat()
    {
        Console.WriteLine($"{Name} is eating chicken");
    }
    public void MakeSound()
    {
        Console.WriteLine($"{Name} voice: Woof");
    }
}
class Cat : Animal, ISound // class cat child 
{
    public Cat(string name) : base(name) { }
    public override void Eat()
    {
        Console.WriteLine($"{Name} is eating meat");
    }
    public  void MakeSound()
    {
        Console.WriteLine($"{Name} voice: Meow");
    }
}





internal class Program
    {
        static void Main(string[] args)
        {
        //Cars mycar = new Cars();
        //Cars Bmw = new BMW();
        //Bmw.Display();
        //mycar.Display();
        Cat cat = new Cat("cat");
        Dog dog = new Dog("Dog");
        cat.Eat();
        cat.Sleep();
        cat.MakeSound();
        dog.Eat();
        dog.Sleep();
        dog.MakeSound();


    }
    }


