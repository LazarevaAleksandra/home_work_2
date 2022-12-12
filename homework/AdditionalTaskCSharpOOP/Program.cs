using AdditionalTaskCSharpOOP;

AdditionalTasks additional = new AdditionalTasks();

//Task_1
additional.GetABankTransaction(100, "USD", 2.5);
additional.GetABankTransaction(100, "EUR", 3.5);

//Task_2
additional.GetNumbers(1);
additional.GetNumbers(1, 2);
additional.GetNumbers(1, 2, 3);
additional.GetNumbers(1, numberThree: 1);

//Task_3
Console.WriteLine("Enter chars");
char one = char.Parse(Console.ReadLine());
char two = char.Parse(Console.ReadLine());
char three = char.Parse(Console.ReadLine());
char four = char.Parse(Console.ReadLine());
char five = char.Parse(Console.ReadLine());

additional.GetChars(one, two, three, four, five);
