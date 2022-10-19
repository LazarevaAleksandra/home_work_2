new Homework_3().Task_3();
class Homework_3
{
    public void Task_1()
    {
        Console.WriteLine("Enter number");
        string youNumber = Console.ReadLine();
        int number = int.Parse(youNumber);
        if (number % 2 == 0 && number % 5 == 0)
        {
            Console.WriteLine("tutti-frutti");
        }
        else if (number % 2 == 0)
        {
            Console.WriteLine("tutti");
        }
        else if (number % 5 == 0)
        {
            Console.WriteLine("frutti");
        }
        else
        {
            Console.WriteLine("Error");
        }
    }
    public void Task_2()
    {
        Console.WriteLine("Enter number");
        string firstNumber = Console.ReadLine();
        int number = int.Parse(firstNumber);
        Console.WriteLine("Enter a number greater than the first number");
        string nextNumber = Console.ReadLine();
        int greaterNumber = int.Parse(nextNumber);
        for (; number <= greaterNumber; number++)
        {
            if (number % 2 == 0 && number % 5 == 0)
            {
                Console.WriteLine("tutti-frutti");
            }
            else if (number % 2 == 0)
            {
                Console.WriteLine("tutti");
            }
            else if (number % 5 == 0)
            {
                Console.WriteLine("frutti");
            }
            else
            {
                Console.WriteLine($"Number {number} can’t be divided on 2 or 5");
            }

        }
        
    }
    public void Task_3()
    {
        Console.WriteLine("Enter number");
        string firstNumber = Console.ReadLine();
        int number = int.Parse(firstNumber);
        Console.WriteLine("Enter next number");
        string newNumber = Console.ReadLine();
        int nextNumber = int.Parse(newNumber);
        int min = Math.Min(number, nextNumber);
        int max = Math.Max(number, nextNumber);
        while (min < max)
        {
            min++;
            if (min % 2 == 0 && min % 5 == 0)
            {
                Console.WriteLine("tutti-frutti");
            }
            else if (min % 2 == 0)
            {
                Console.WriteLine("tutti");
            }
            else if (min % 5 == 0)
            {
                Console.WriteLine("frutti");
            }
            else
            {
                Console.WriteLine($"Number {min} can’t be divided on 2 or 5");
            }
        }
    }
}
