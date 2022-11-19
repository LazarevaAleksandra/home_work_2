using CSharpException;

Triangle triangle = new Triangle();
bool CheckingValuesForZero = false;
int firstLenght = 0;
int secondLenght = 0;
int thirtLenght = 0;
int number = 1;

//try
//{
//    Console.WriteLine("Enter the lengths of all sides:");

//    triangle.SideLengthCheck(triangle.OneLenght = int.Parse(Console.ReadLine()),
//        triangle.TwoLenght = int.Parse(Console.ReadLine()),
//       triangle.ThreeLenght = int.Parse(Console.ReadLine()));  
//}
//catch (FormatException ex)
//{
//    Console.WriteLine(ex.Message);
//}
//catch (ExceptionForTriangle ex)
//{
//    Console.WriteLine(ex.Message);
//}
//finally
//{
//    Console.WriteLine("End of the program!");
//}


do
{
    try
    {
        if (number == 1)
        {
            Console.WriteLine($"Enter the {number} length: ");
            firstLenght = triangle.CheckingValuesForZero(Console.ReadLine());
            number++;
        }
        if (number == 2)
        {
            Console.WriteLine($"Enter the {number} length: ");
            secondLenght = triangle.CheckingValuesForZero(Console.ReadLine());
            number++;
        }
        if (number == 3)
        {
            Console.WriteLine($"Enter the {number} length: ");
            thirtLenght = triangle.CheckingValuesForZero(Console.ReadLine());
            number++;
        }
        Console.WriteLine();
    }
    catch (ExceptionForTriangle ex)
    {
        CheckingValuesForZero = true;
        Console.WriteLine(ex.Message);
    }
    catch (FormatException ex)
    {
        CheckingValuesForZero = true;
        Console.WriteLine(ex.Message);
    }
} while (CheckingValuesForZero && number < int.MaxValue);

