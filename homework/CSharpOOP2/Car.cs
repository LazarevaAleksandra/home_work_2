using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOP2
{
    public class Car //Task_1
    {
        public string Brand; //Task_2
        public string _Color;
        public int YearOfIssue;
        public double _DiskSize;
        public double _Price;
        public static string Type { get; } ="Transport";  //Task_17

        public static void GreetCar() => Console.WriteLine("Hello!"); //Task_18

        public double _defaultPrice = 30.000;  //Task_13
        public double Price
        {
            get
            {
                return _Price;
            }
            set
            {
                _Price = _defaultPrice;
            }
        }
        /*public double YearOfIssue { get => _YearOfIssue = 2000; } *///Task_14
        public double DiskSize { set => _DiskSize = 7; }   //Task_14

        public string Color { get; internal set; } //Task_16


        public void CheckBrand() //Task_3
        {
            if (Brand.Equals("BMW"))
            {
                Console.WriteLine("Car brand - BMW");
            }
            else if (Brand.Equals("Audi"))
            {
                Console.WriteLine("Car brand - Audi");
            }
            else
            {
                Console.WriteLine("Other car brand");
            }
        }
        public Car(string brand, string color, int yearofissue, double diskSize, double price) //Task_6
        {
            Brand = brand;
            Color = color;
            YearOfIssue = yearofissue;
            DiskSize = diskSize;
            Price = price;
        }
        public Car() //Task_7
        {
        }
        public Car(string brand, int yearofissue) //Task_8
        {
            Brand = brand;
            YearOfIssue = yearofissue;
        }
        internal void CheckYearOfIssue() //Task_11
        {
            if (YearOfIssue <= 2020)
            {
                Console.WriteLine("Car is old");
            }
            else
            {
                Console.WriteLine("Car is young");
            }
        }
        private void CheckPrice() //Task_11
        {
            if (Price <= 20.000)
            {
                Console.WriteLine("The car is cheap");
            }
            else
            {
                Console.WriteLine("Expensive car");
            }
        }
    }

}
