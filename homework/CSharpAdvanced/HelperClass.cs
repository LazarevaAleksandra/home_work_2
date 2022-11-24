using CSharpOOP2;
namespace CSharpAdvanced
{
    public static class HelperClass
    {
        public static void PrintBrand(this Car youngCar, double DiskSize = 5, double Price = 20.000)
        {
            Console.WriteLine($"DiskSize {DiskSize}, Price {Price}");
        }

        public static void PrintYearOfIssue(this Car youngCar, int newYearOfIssue = 2000)
        {
            youngCar.YearOfIssue = newYearOfIssue;
            Console.WriteLine(newYearOfIssue);
        }

        public static void PrintPrice(this Car oldcar, double newPrice = 10.000)
        {
            if (oldcar.Price == 10.000)
            {
                Console.WriteLine($"Car is {oldcar.Brand}");
            }
            else
            {
                Console.WriteLine("Other car");
            }
        }

        public static List<T> GetCarBrand<T>(this List<T> cars) where T : Car
        {
            return cars.Where(x => x.Brand.Length > 2).ToList();

        }
    }
}
