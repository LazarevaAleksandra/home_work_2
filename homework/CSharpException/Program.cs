using CSharpException;

Triangle triangle = new Triangle();
try
{
    Console.WriteLine("Enter the lengths of all sides:");
    triangle.OneLength = int.Parse(Console.ReadLine());
    triangle.TwoLenght = int.Parse(Console.ReadLine());
    triangle.ThreeLenght = int.Parse(Console.ReadLine());

    triangle.SideLengthCheck(triangle.OneLength, triangle.TwoLenght, triangle.ThreeLenght);
}
catch (FormatException ex)
{
    Console.WriteLine(ex.Message);
}
catch (NullReferenceException ex)
{
    Console.WriteLine(ex.Message);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
finally
{
    Console.WriteLine("End of the program!");
}

try
{   
    triangle.CheckingValuesForZero(triangle.OneLength, triangle.TwoLenght, triangle.ThreeLenght);
}
catch (FormatException ex)
{
    Console.WriteLine(ex.Message);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}


