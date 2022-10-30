using CSharpOOP2;
using System.Diagnostics;

Car youngCar = new Car  //Task_4
{
    Brand = "BMW",
    Color = "Black",
    YearOfIssue = 2022,
    DiskSize = 5,
    Price = 20.000
};

Car oldCar = new Car { Brand = "Audi", Color = "Red", YearOfIssue = 2020, DiskSize = 3, Price = 10.000 };  //Task_5
oldCar.CheckBrand();  //Task_10

Car perfectCar = new Car("Lamborghini", "Gold", 2020, 10, 50.000); //Task_9

perfectCar.CheckYearOfIssue();  //Task_11
///*perfectCar.CheckPrice(); */ //Task_11  //Error Line

//Car overCar = new Car { Color = "White", YearOfIssue = 2018, DiskSize = 7, Price = 30.000 };
///*overCar.CheckBrand();*/  // Task_12  //Error Line

Car defaultItem = new Car { Brand = "BMW", Color = "Black", YearOfIssue = 2022, DiskSize = 5 }; //Task_13
defaultItem.Price = 30.000;
Console.WriteLine($"Car cost: {defaultItem.Price}");

//Console.WriteLine($"{defaultItem.YearOfIssue}, {defaultItem.DiskSize}"); //Task_15  //Error Line

var type = Car.Type; //Task_17
Car.GreetCar(); //Task_18

Assistant.Brand("BMW", 5, 20.000); //Task_20
Assistant.YearOfIssue(youngCar);
Assistant.Price(oldCar);