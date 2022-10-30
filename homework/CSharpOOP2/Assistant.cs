using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOP2
{
    public static class Assistant //Task_19
    {
        public static void Brand(string Brand, double DiskSize, double Price)
        {
            Console.WriteLine($"Brand {Brand}, DiskSize {DiskSize}, Price {Price}");
        } 
        public static string Color;
        public static void YearOfIssue (Car youngCar, int newYearOfIssue = 2000)
        {
            youngCar.YearOfIssue = newYearOfIssue;
            Console.WriteLine(newYearOfIssue);
        } 
        public static double DiskSize;
        public static void Price (Car oldcar, double newPrice = 10.000)
        {
            if (oldcar.Price == 10.000)
                Console.WriteLine($"Car is {oldcar.Brand}");
            else
                Console.WriteLine("Other car");
        }
    }
}
