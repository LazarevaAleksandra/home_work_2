using CSharpAdvanced;
using CSharpOOP2;

#region Task_1

GenericMetod genericMetod = new GenericMetod();

int[] intItems = new int[] { 1, 2, 3, 4, 5 };
double[] doubleItems = new double[] { 1.1, 2, 2, 3.3, 4.4, 5.5 };
string[] stringItems = new string[] { "Hello", "world" };

genericMetod.GetFirstItem(intItems);
genericMetod.GetFirstItem(doubleItems);
genericMetod.GetFirstItem(stringItems);

#endregion

#region Task_2

Flower rose = new Rose("Rose", "Black", 10);
Flower chamomile = new Chamomile("Chamomile", "White", 5);

Console.WriteLine("Enter the number of rose flowers:");
int numberOfRose = int.Parse(Console.ReadLine());

Console.WriteLine("Enter the number of chamomile flowers:");
int numberOfChamomile = int.Parse(Console.ReadLine());

Console.WriteLine($"Final chek:");

Console.WriteLine($"Name: {rose.Name}; Color: {rose.Color}; Price: {rose.Price}; " +
    $"BouquetPrice: {GetPrice(rose, numberOfRose)}");

Console.WriteLine($"Name: {chamomile.Name}; Color: {chamomile.Color}; Price: {chamomile.Price}; " +
    $"BouquetPrice: {GetPrice(chamomile, numberOfChamomile)}");

Console.WriteLine($"Total payable: {FinalCheck(GetPrice(rose, numberOfRose), GetPrice(chamomile, numberOfChamomile))}");

double GetPrice<T>(T flower, int number) where T : Flower
{
    return flower.Price * number;
}

double FinalCheck<T>(T flower, T number)
{
    return GetPrice(rose, numberOfRose) + GetPrice(chamomile, numberOfChamomile);
}

#endregion

#region Task_3

Flower newRose = new Rose("Rose", "Black", 10);
Flower newChamomile = new Chamomile("Chamomile", "White", 5);

Console.WriteLine("Enter a color to repaint the rose:");
var colorOfRose = Console.ReadLine();

Console.WriteLine("Enter a color to repaint the chamomile:");
var colorOfChamomile = Console.ReadLine();

var printNewColorRose = new RepaintingFlowers<Rose>();
Console.WriteLine(printNewColorRose.GetNewColor(newRose, colorOfRose));

var printNewColorChamomile = new RepaintingFlowers<Chamomile>();
Console.WriteLine(printNewColorChamomile.GetNewColor(newChamomile, colorOfChamomile));

Console.WriteLine($"Final chek:");

Console.WriteLine($"Name: {newRose.Name}; {printNewColorRose.GetNewColor(newRose, colorOfRose)}; " +
    $"Price after repaint: {printNewColorRose.GetNewPrice(newRose)}");

Console.WriteLine($"Name: {newChamomile.Name}; {printNewColorChamomile.GetNewColor(newChamomile, colorOfChamomile)}; " +
    $"Price after repaint: {printNewColorChamomile.GetNewPrice(newChamomile)}");

#endregion

#region Task_4

Car oneCar = new Car("BMW", "Black", 2022, 10, 50.000);
Car twoCar = new Car("Audi", "White", 2000, 5, 30.000);
Car threeCar = new Car("VW", "Blue", 1996, 3, 15.000);

oneCar.PrintYearOfIssue();
oneCar.PrintPrice();
oneCar.PrintBrand();

var carList = new List<Car>() { oneCar, twoCar, threeCar };
carList.GetCarBrand();

#endregion

