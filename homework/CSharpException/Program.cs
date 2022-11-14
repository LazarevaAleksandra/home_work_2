using CSharpException;

Triangle triangle = new Triangle();

//Task_1
//try
//{
//    Console.WriteLine("Enter the lengths of all sides:");
//    triangle.OneLength = int.Parse(Console.ReadLine());
//    triangle.TwoLenght = int.Parse(Console.ReadLine());
//    triangle.ThreeLenght = int.Parse(Console.ReadLine());

//    triangle.SideLengthCheck();
//}
//catch (FormatException ex)
//{
//    Console.WriteLine(ex.Message);
//}
//catch(Exception ex)
//{
//    Console.WriteLine(ex.Message);
//}
//finally
//{
//    Console.WriteLine("Condition violation!");
//}

//Task_2
try
{
    Console.WriteLine("Enter the lengths of all sides:");
    triangle.OneLength = int.Parse(Console.ReadLine());
    triangle.TwoLenght = int.Parse(Console.ReadLine());
    triangle.ThreeLenght = int.Parse(Console.ReadLine());

    triangle.CheckingValuesForZero();
}
catch (FormatException ex)
{
    Console.WriteLine(ex.Message);  
}
catch(Exception ex)
{
    Console.WriteLine(ex.Message);
}