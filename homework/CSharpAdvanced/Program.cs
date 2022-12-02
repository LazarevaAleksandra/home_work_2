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

Rose rose = new Rose("Rose", "Black", 10);
Chamomile chamomile = new Chamomile("Chamomile", "White", 5);

Console.WriteLine("Enter the number of rose flowers:");
int numberOfRose = int.Parse(Console.ReadLine());

Console.WriteLine("Enter the number of chamomile flowers:");
int numberOfChamomile = int.Parse(Console.ReadLine());

Dictionary<Flower, int> flowers = new Dictionary<Flower, int>();
flowers.Add(rose, numberOfRose);
flowers.Add(chamomile, numberOfChamomile);
var totalprice = new RepaintingFlowers<Rose>();

Console.WriteLine($"Final chek:");

Console.WriteLine(StringCheck(rose));
Console.WriteLine(StringCheck(chamomile));

Console.WriteLine($"Total payable: {totalprice.FinalCheck(flowers)}");

string StringCheck<T>(T flower) where T : Flower
{
    return $"Name: {flower.Name}; Color: {flower.Color}; Price: {flower.Price};" +
        $"BouquetPrice: {GetPrice(flower, numberOfRose)}";
}

double GetPrice<T>(T flower, int number) where T : Flower
{
    return flower.Price * number;
}

#endregion

#region Task_3

Rose newRose = new Rose("Rose", "Black", 10);
Chamomile newChamomile = new Chamomile("Chamomile", "White", 5);

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

oneCar.PrintYearOfIssue();
oneCar.PrintPrice();
oneCar.PrintBrand();
oneCar.GetCarBrand();

#endregion
