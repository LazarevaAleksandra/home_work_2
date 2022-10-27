#region Task_1
//Console.WriteLine("Введите количество предметов, цену за единицу и скидку");
//var numberOfItems = double.Parse(Console.ReadLine());
//var price = double.Parse(Console.ReadLine());
//var discount = double.Parse(Console.ReadLine());
//var totalPrice = new Homework_1().GetDiscount(numberOfItems, price, discount);
//Console.WriteLine($"Итоговая стоимость: {totalPrice}");
#endregion
#region Task_2
using System.Diagnostics;

//Console.WriteLine("Enter the product, its quantity and unit price");
//string Item = Console.ReadLine();
//var Number = double.Parse(Console.ReadLine());
//var Price = double.Parse(Console.ReadLine());
//Console.WriteLine("Enter the product, its quantity and unit price");
//string secondItem = Console.ReadLine();
//var secondNumber = double.Parse(Console.ReadLine());
//var secondPrice = double.Parse(Console.ReadLine());
//Console.WriteLine("Enter the product, its quantity and unit price");
//string thirdItem = Console.ReadLine();
//var thirdNumber = double.Parse(Console.ReadLine());
//var thirdPrice = double.Parse(Console.ReadLine());
//Console.WriteLine("Enter discount");
//var discount = double.Parse(Console.ReadLine());
//Console.WriteLine(new Homework_1().GetDiscountForNamedItem(Item, Price, discount));
//Console.WriteLine(new Homework_1().GetDiscountForNamedItem(secondItem, secondPrice, discount););
//Console.WriteLine(new Homework_1().GetDiscountForNamedItem(thirdItem, thirdPrice, discount););
//Console.WriteLine($"Total payable: {new Homework_1().GetDiscountItem(Number, Price, secondNumber, secondPrice, thirdNumber, thirdPrice, discount)}");
#endregion
#region Task_3

//var optionalFirst = new Homework_1().SeveralItems(Item, Price, discount);
//var optionalSecond = new Homework_1().SeveralItems(secondItem, secondPrice, discount);
//var optionalThird = new Homework_1().SeveralItems(thirdItem, thirdPrice, discount);
//var requiredFirst = new Homework_1().SeveralItems(Item, Number, Price, discount);
//var requiredSecond = new Homework_1().SeveralItems(secondItem, secondNumber, secondPrice, discount);
//var requiredThird = new Homework_1().SeveralItems(thirdItem, thirdNumber, thirdPrice, discount);
#endregion
#region Task_4
//Console.WriteLine("Enter 5 numbers");
//var numberOne = double.Parse(Console.ReadLine());
//var numberTwo = double.Parse(Console.ReadLine());
//var numberThree = double.Parse(Console.ReadLine());
//var numberFour = double.Parse(Console.ReadLine());
//var numberFive = double.Parse(Console.ReadLine());
//Console.WriteLine($"Perimeter of a triangle = {new Homework_1().GetPerimeter(numberOne, numberTwo, numberThree)}");
//Console.WriteLine($"Perimeter of a quadrilateral = {new Homework_1().GetPerimeter(numberOne, numberTwo, numberThree, numberFour)}");
//Console.WriteLine($"Perimeter of a pentagon = {new Homework_1().GetPerimeter(numberOne, numberTwo, numberThree, numberFour, numberFive)}");
#endregion
#region Task_5
//Console.WriteLine("Enter the length of the first leg");
//var firstLeg = double.Parse(Console.ReadLine());
//Console.WriteLine("Enter the length of the second leg");
//var secondLeg = double.Parse(Console.ReadLine());
//Console.WriteLine("Enter radius");
//var radius = double.Parse(Console.ReadLine());
//Console.WriteLine($"Area of ​​a triangle = {new Homework_1().GetAreaOfTriangleAndCircle(firstLeg, secondLeg)}");
//Console.WriteLine($"Area of ​​a circle: {new Homework_1().GetAreaOfTriangleAndCircle(radius)}");

#endregion
#region Task_6
//Инкапсуляция:
//    Ребенка очень строго воспитывают в семье, но он не рассказывает об этом окружающим.
//    Телефон, у которого есть функция "позвонить(номер телефона)" пользователю, не обязательно знать,
//    как "летают" электроны внутри, он пользуется готовой функцией.
//Наследование:
//    Ребенок унаследовал цвет волос и глаз от родителей, но характер - его собственный.
//Полиморфизм:
//     Я однажды получила штраф за то, что под моими ФИО попал в дтп другой человек. 
//     У того человека были поддельные права на мое имя. А у меня прав не было на тот момент.
//     Актер в театре может примерять на себя много ролей - или принимать "много форм".
//Абстрагирование:
//    Ребенок рисует дом. Стены и крышу. Но не прорисовывает мелкие детали (дверь, окна).

#endregion
public class Homework_1
{
    //public double GetDiscount(double numberOfItems, double price, double discount)
    //{
    //    var totalChek = numberOfItems * price - ((numberOfItems * price) * discount / 100);
    //    return totalChek;
    //}

    //public double GetDiscountItem(double Number, double Price, double secondNumber, double secondPrice, double thirdNumber, double thirdPrice, double discount)
    //{
    //    var totalfirst = new Homework_1().GetDiscount(Number, Price, discount);
    //    var totalsecond = new Homework_1().GetDiscount(secondNumber, secondPrice, discount);
    //    var totalthird = new Homework_1().GetDiscount(thirdNumber, thirdPrice, discount);
    //    var totalPrice = totalfirst + totalsecond + totalthird;
    //    return totalPrice;
    //}
    //public string GetDiscountForNamedItem(string Item, double Price, double discount, double Number = 5)
    //{
    //    var totalFirst = new Homework_1().GetDiscount(Number, Price, discount);
    //    return $" Наименование:{Item}, количество:{Number}, цена:{Price}, цена со скидкой:{totalFirst}";
    //}


    //public double GetPerimeter(params double[] numberLenght)
    //{
    //    double perimeter = 0;
    //    foreach (double number in numberLenght)
    //    {
    //    perimeter += number;
    //    }
    //    return perimeter;
    //}

    //public double GetAreaOfTriangleAndCircle(double firstLeg, double secondLeg)
    //{
    //    var triangleArea = firstLeg * secondLeg / 2;
    //    return triangleArea;
    //}
    //public double GetAreaOfTriangleAndCircle(double radius)
    //{
    //    var cicleArea = radius * 2 * Math.PI;
    //    return cicleArea;

    //}


}




