#region Task_1
//Random random = new Random();
//int[] array = new int[10];

//Console.WriteLine("Array:");

//for (int i = 0; i < array.Length; i++)
//{
//    array[i] = random.Next(1, 9);
//    Console.Write("{0} ", array[i]);
//}

//Array.Sort(array);

//Console.WriteLine("\nArray of even numbers");

//for (int i = 0; i < array.Length; i++)
//{
//    if (array[i] % 2 == 0)
//    {
//        Console.Write("{0} ", array[i]);
//    }
//}

//Console.WriteLine("\nArray of odd numbers");

//for (int i = 0; i < array.Length; i++)
//{
//    if (array[i] % 2 != 0)
//    {
//        Console.Write("{0} ", array[i]);
//    }
//}
#endregion
#region Task_2
//using System.Linq;

//Random random = new Random();
//int[] array = new int[10];

//Console.WriteLine("Array:");

//for (int i = 0; i < array.Length; i++)
//{
//    array[i] = random.Next(-20, 20);
//    Console.Write("{0} ", array[i]);
//}

//Console.WriteLine();

//int max = array.Max();
//int min = array.Min();
//int difference = max - min;
//Console.WriteLine($"Max = {max}");
//Console.WriteLine($"Min = {min}");
//Console.WriteLine($"Difference = {difference}");
#endregion
#region Task_3
//string[] surname = new string[] { "Peterson", "Morales", "Jones", "Morgan", "Lamb", "Collins",
//    "Burgess", "Perez", "Ruiz", "Johnston" };

//var surnameList = new List<string>();
//surnameList.AddRange(surname);

//surnameList.Sort();

//Console.WriteLine("List in sorted order: ");
//foreach (var name in surnameList)
//    Console.Write("{0} ", name);

//Console.WriteLine();
#endregion
#region Task_4
//using System.Collections.Generic;
//using System.Data;

//public class Citizen
//{
//    public string? Name;
//    public string? Surname;
//    public string? Street;
//    public int Home;
//    public DateTime birthDate = new DateTime();

//    static void Main(string[] args)
//    {
//        List<Citizen> list = new List<Citizen>();

//        list.Add(new Citizen() { Name = "Brian", Surname = "Crawford", Street = "Belskogo", Home = 39, birthDate = new DateTime(1994, 5, 2) });
//        list.Add(new Citizen() { Name = "Larry", Surname = "Bryant", Street = "Yankovskogo", Home = 11, birthDate = new DateTime(1984, 11, 20) });
//        list.Add(new Citizen() { Name = "Andre", Surname = "Murphy", Street = "Mavra", Home = 5, birthDate = new DateTime(1998, 4, 13) });
//        list.Add(new Citizen() { Name = "Peter", Surname = "Mendoza", Street = "Lobanka", Home = 89, birthDate = new DateTime(1996, 5, 10) });
//        list.Add(new Citizen() { Name = "Daniel", Surname = "Park", Street = "Yankovskogo", Home = 11, birthDate = new DateTime(2010, 1, 15) });
//        list.Add(new Citizen() { Name = "Charles", Surname = "Ray", Street = "Belskogo", Home = 39, birthDate = new DateTime(2006, 2, 8) });
//        list.Add(new Citizen() { Name = "Matthew", Surname = "Wolfe", Street = "Mazurova", Home = 6, birthDate = new DateTime(1997, 7, 7) });
//        list.Add(new Citizen() { Name = "Christian", Surname = "Lawrence", Street = "Mavra", Home = 5, birthDate = new DateTime(2000, 9, 14) });

//        list.Sort(delegate (Citizen street1, Citizen street2)
//        { return street1.Street.CompareTo(street2.Street); });

//        Console.WriteLine("List of voters:");
//        foreach (Citizen i in list)
//        {
//            int age = DateTime.Now.Year - i.birthDate.Year;
//            if (age > 18)
//            {
//                Console.WriteLine($"{i.Name} {i.Surname}, {i.Street}, {i.Home}, {i.birthDate}");
//            }
//        }
//    }
//}
#endregion
#region Task_5
//Console.WriteLine("Enter 5 countries and their capitals");
//string oneCountry = Console.ReadLine();
//string oneCapital = Console.ReadLine();
//string twoCountry = Console.ReadLine();
//string twoCapital = Console.ReadLine();
//string threeCountry = Console.ReadLine();
//string threeCapital = Console.ReadLine();
//string fourCountry = Console.ReadLine();
//string fourCapital = Console.ReadLine();
//string fiveCountry = Console.ReadLine();
//string fiveCapital = Console.ReadLine();

//Dictionary<string, string> country = new Dictionary<string, string>();

//country.Add(oneCountry, oneCapital);
//country.Add(twoCountry, twoCapital);
//country.Add(threeCountry, threeCapital);
//country.Add(fourCountry, fourCapital);
//country.Add(fiveCountry, fiveCapital);

//Console.WriteLine("Source Dictionary:");
//foreach (var i in country)
//Console.WriteLine($"{i.Key} : {i.Value}");

//var countrySwap = country.ToDictionary(x => x.Value, x => x.Key).ToList();
//Console.WriteLine("Resulting Dictionary:");

//foreach (var j in countrySwap)
//Console.WriteLine($"{j.Key} : {j.Value}");
#endregion
