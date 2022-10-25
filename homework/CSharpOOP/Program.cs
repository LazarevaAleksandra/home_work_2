#region Task_1
//Console.WriteLine("Введите количество предметов, цену за единицу и скидку");
//var numberOfItems = double.Parse(Console.ReadLine());
//var price = double.Parse(Console.ReadLine());
//var discount = double.Parse(Console.ReadLine());
//var totalPrice = new Homework_1().GetDiscount(numberOfItems, price, discount);
//Console.WriteLine($"Итоговая стоимость: {totalPrice}");
#endregion
#region Task_2
//Console.WriteLine("Введите товар, его количество и цену за единицу");
//string firstItem = Console.ReadLine();
//var firstNumber = double.Parse(Console.ReadLine());
//var firstPrice = double.Parse(Console.ReadLine());
//Console.WriteLine("Введите товар, его количество и цену за единицу");
//string secondItem = Console.ReadLine();
//var secondNumber = double.Parse(Console.ReadLine());
//var secondPrice = double.Parse(Console.ReadLine());
//Console.WriteLine("Введите товар, его количество и цену за единицу");
//string thirdItem = Console.ReadLine();
//var thirdNumber = double.Parse(Console.ReadLine());
//var thirdPrice = double.Parse(Console.ReadLine());
//Console.WriteLine("Введите скидку");
//var discount = double.Parse(Console.ReadLine());
//var totalfirst = firstNumber * firstPrice - ((firstNumber * firstPrice) * discount / 100);
//var totalsecond = secondNumber * secondPrice - ((secondNumber * secondPrice) * discount / 100);
//var totalthird = thirdNumber * thirdPrice - ((thirdNumber * thirdPrice) * discount / 100);
//var firstMetod = new Homework_1().SeveralItems(firstItem, firstPrice, discount, 5);
//var secondMetod = new Homework_1().SeveralItems(secondItem, secondPrice, discount, 5);
//var thirdMetod = new Homework_1().SeveralItems(thirdItem, thirdPrice, discount, 5);
//var totalPrice = totalfirst + totalsecond + totalthird;
//Console.WriteLine(firstMetod);
//Console.WriteLine(secondMetod);
//Console.WriteLine(thirdMetod);
//Console.WriteLine($"Итого к оплате: {totalPrice}");
#endregion
#region Task_3

//var optionalFirst = new Homework_1().SeveralItems(firstItem, firstPrice, discount, 5);
//var optionalSecond = new Homework_1().SeveralItems(secondItem, secondPrice, discount, 5);
//var optionalThird = new Homework_1().SeveralItems(thirdItem, thirdPrice, discount, 5);
//var requiredFirst = new Homework_1().SeveralItems(firstItem, firstNumber, firstPrice, discount);
//var requiredSecond = new Homework_1().SeveralItems(secondItem, secondNumber, secondPrice, discount);
//var requiredThird = new Homework_1().SeveralItems(thirdItem, thirdNumber, thirdPrice, discount);
#endregion
#region Task_4
//Console.WriteLine("Введите длину первого катета");
//var firstLeg = double.Parse(Console.ReadLine());
//Console.WriteLine("Введите длинну второго катета");
//var secondLeg = double.Parse(Console.ReadLine());
//Console.WriteLine("Введите высоту");
//var height = double.Parse(Console.ReadLine());
//var Area = new Homework_1().Area(firstLeg, secondLeg, height, out double triangleArea, out double quadrilateralArea, out double pentagonArea);
//Console.WriteLine($"Площадь треугольника: {triangleArea}");
//Console.WriteLine($"Площадь четырехугольника: {quadrilateralArea}");
//Console.WriteLine($"Площадь пятиугольника: {pentagonArea}");

#endregion
#region Task_5
//Console.WriteLine("Введите длину первого катета");
//var firstLeg = int.Parse(Console.ReadLine());
//Console.WriteLine("Введите длинну второго катета");
//var secondLeg = int.Parse(Console.ReadLine());
//Console.WriteLine("Введите радиус");
//var radius = double.Parse(Console.ReadLine());
//double pi = Math.PI;
//var areaTriangl = new Homework_1().AreaOfTriangleAndCircle(firstLeg, secondLeg);
//var areaCicle = new Homework_1().AreaOfTriangleAndCircle(radius, pi);
//Console.WriteLine($"Площадь треугольника: {areaTriangl}");
//Console.WriteLine($"Площадь окружности: {areaCicle}");

#endregion
#region Task_6
//Инкапсуляция:
//    Ребенка очень строго воспитывают в семье, но он не рассказывает об этом окружающим.
//Наследование:
//    Ребенок унаследовал цвет волос и глаз от родителей, но характер - его собственный.
//Полиморфизм:
//     Я однажды получила штраф за то, что под моими ФИО попал в дтп другой человек. 
//     У того человека были поддельные права на мое имя. А у меня прав не было на тот момент.
//Абстрагирование:
//    Ребенок рисует дом. Стены и крышу. Но не прорисовывает мелкие детали (дверь, окна).

#endregion
public class Homework_1
{

    //public double GetDiscount(double numberOfItems, double price, double discount)
    //{
    //    var itemsPrice = numberOfItems * price;
    //    var totalPrice = itemsPrice - (itemsPrice * discount / 100);
    //    return totalPrice;
    //}
    //public string SeveralItems(string firstItem, double firstNumber, double firstPrice, double discount)
    //{
    //    var firstChek = firstNumber * firstPrice;
    //    var totalFirst = firstChek - (firstChek * discount / 100);
    //    return $" Наименование:{firstItem}, количество:{firstNumber}, цена:{firstPrice}, цена со скидкой:{totalFirst}";
    //}
    //public string SeveralItems(string firstItem, double firstPrice, double discount, double firstNumber = 5)
    //{
    //    var firstChek = firstNumber * firstPrice;
    //    var totalFirst = firstChek - (firstChek * discount / 100);
    //    return $" Наименование:{firstItem}, количество:{firstNumber}, цена:{firstPrice}, цена со скидкой:{totalFirst}";
    //}

    //public double Area (double firstLeg, double secondLeg, double height, out double triangleArea, out double quadrilateralArea, out double pentagonArea)
    //{
    //    triangleArea = firstLeg * secondLeg / 2;
    //    quadrilateralArea = firstLeg * 4;
    //    pentagonArea = triangleArea * 5;
    //    return triangleArea;
    //    return quadrilateralArea;
    //    return pentagonArea;
    //}
    
    //public double AreaOfTriangleAndCircle (int firstLeg, int secondLeg)
    //{
    //    var triangleArea = firstLeg * secondLeg / 2;
    //    return triangleArea;
    //}
    //public double AreaOfTriangleAndCircle (double radius, double pi)
    //{
    //    var cicleArea = radius * 2 * pi;
    //    return cicleArea;
           
    //}


}




