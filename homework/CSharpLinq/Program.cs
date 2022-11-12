#region Task_1
//var numbers = new List<int> { 12, 56, 84, 76, 15, 5, 99, 23, 6, 35 };

//var newList = from n in numbers where n % 3 == 0 select n;

//Console.WriteLine("Resulting collection:");

//foreach (int number in newList)
//{
//    Console.Write("{0} ", number);
//}
#endregion
#region Task_2
//var numbers = new List<int> { 7, -7, 8, -9, 10, 11, -12, -13, 14, -15 };

//var newList = numbers.Where(x => x < 10).ToList();

//Console.WriteLine("Resulting collection:");

//foreach (int number in newList)
//{
//    Console.Write("{0} ", number);
//}
#endregion
#region Task_3
//var names = new List<string> { "Peterson", "Morales", "Jones", "Morgan", "Lamb" };

//var newList = from n in names where n.Length % 2 == 0 orderby n select n;

//Console.WriteLine("Resulting collection:");

//foreach (string name in newList)
//{
//    Console.Write("{0}  ", name);
//}
#endregion
#region Task_4
//var cities = new List<string> { "Minsk", "Brest", "Gomel", "Mogilev", "Grodno", "Vitebsk" };

//var newList = cities.Where(n => n.ToUpper().StartsWith('M'));

//var secondList = newList.Where(i => i.ToLower().EndsWith('k'));

//Console.WriteLine("Resulting collection:");

//foreach (string city in secondList)
//{
//    Console.WriteLine(city);
//}
#endregion
#region Task_5
//Console.WriteLine("Enter the string");
//string newString = Console.ReadLine();

//var list = new List<string>(newString.Split(" ".ToCharArray()));

//var newList = list.Where(l =>l.Contains(l.ToUpper()));

//Console.WriteLine("Resulting collection:");

//foreach (string s in newList)
//{
//    Console.Write("{0} ", s);
//}
#endregion
#region Task_6
//var numbers = new List<int> { 7, 6, 3, 7, 5, 3, 1, 4, 6, 1 };

//var chekNumbers = numbers.Distinct().OrderByDescending(n => n);

//Console.WriteLine("Resulting collection:");

//foreach (int number in chekNumbers)
//{
//    Console.Write("{0} ", number);
//}
#endregion
#region Task_7
//var numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
//Console.WriteLine($"If your number is in the collection, it will display \"True\", otherwise - \"False\"");
//Console.WriteLine("Enter number:");
//int number = int.Parse(Console.ReadLine());

//bool chekNumber = numbers.Any(n => n == number);

//Console.WriteLine(chekNumber);
#endregion
#region Task_8
//var strings = new List<string> { "Peterson", "Morales", "Jones", "Morgan", "Lamb" };

//var summa = strings.Sum(s => s.Length).ToString();
//Console.WriteLine($"The sum of the lengths of all elements of the collection: {summa}");

//if (summa.Length > 5)
//{
//    var firstItem = strings.First();
//    var lastItem = strings.Last();
//    Console.WriteLine($"{firstItem}, {lastItem}");
//}
//else
//{
//    Console.WriteLine("Sum less than 5 items.");
//}
#endregion
#region Task_9
//using CSharpOOP2;

//Car bmw = new Car("BMW", 2022);
//Car audi = new Car("Audi", 2020);
//Car lamborghini = new Car("Lamborghini", 2021);

//var cars = new List<string> { "BMW", "Audi", "Lamborghini" };

//var newCar = cars.Select(c => new Car("VW", 2022)).ToList();
#endregion
#region Task_10
//using CSharpOOP2;

//Car bmw = new Car("BMW", 2022);
//Car audi = new Car("Audi", 2020);
//Car lamborghini = new Car("Lamborghini", 2021);

//var cars = new List<Car> { bmw, audi, lamborghini };

//var brands = cars.Select(b => b.Brand).ToList();
//foreach (var brand in brands)
//{
//    Console.WriteLine(brand);
//}
#endregion

