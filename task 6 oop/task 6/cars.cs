using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_6
{
    public class cars
    {

        //fields 
        private string make;
        private int year;
        private string type;
        private double price;
        private string model;
        private string palletNo;
        private string color;
        //properties
        public string Make { set { make = value; } get { return make; } }
        public int Year { set { year = value; } get { return year; } }
        public string Type { set { type = value; } get { return type; } }
        public double Price { set { price = value; } get { return price; } }
        public string Model { set { model = value; } get { return model; } }
        public string PalletNo { set { palletNo = value; } get { return palletNo; } }
        public string Color { set { color = value; } get { return color; } }

        public cars (string Make, int Year, string Type, double Price, string Model, string PalletNo, string Color)
        {
            this.Make = Make;
            this.Year = Year;
            this.Type = Type;
            this.Price = Price;
            this.Model = Model;
            this.PalletNo = PalletNo;
            this.Color = Color;
            Console.WriteLine($"Make: {Make}, Year: {Year}, Type: {Type}, Price: {Price:C}, Model: {Model}, Pallet No: {PalletNo}, Color: {Color}");
        }
        public void Start()
        {
            Console.WriteLine($"Starting the Car !");
        }
        public void Stop()
        {
            Console.WriteLine($"Stoping the Car !");
        }
        public string print()
        {

            return $"Make: {Make}, Year: {Year}, Type: {Type}, Price: {Price:C}, Model: {Model}, Pallet No: {PalletNo}, Color: {Color}";
        }
    }
   


}
