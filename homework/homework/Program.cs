using System.Runtime.Intrinsics.X86;

new Homework_2().Task_10();
class Homework
{
    public void Task_1()
    {
        int i = 5;
        double d = 5.32;
        char c = 'C';
        bool b = false;
        string s = "hello";
        Console.WriteLine(i);
        Console.WriteLine(d);
        Console.WriteLine(c);
        Console.WriteLine(b);
        Console.WriteLine(s);
    }
    public void Task_2()
    {
        int a = 5;
        int b = 5;
        bool c = a == b;
        var d = a.Equals(b);
        Console.WriteLine($"Value for == is [{c}]");
        Console.WriteLine($"Value for Equals is [{d}]");

        object a1 = 5;
        object b1 = 5;
        bool c1 = a1 == b1;
        var d1 = a1.Equals(b1);
        Console.WriteLine($"Value for == is [{c1}]");
        Console.WriteLine($"Value for Equals is [{d1}]");
    }
    public void Task_3()
    {
        Console.WriteLine("Enter you name and last name");
        var name = Console.ReadLine();
        Console.WriteLine("Enter you age");
        var age = Console.ReadLine();
        string s = "\"How old are you\",-policemen asked.";
        Console.WriteLine('"' + age + '"' + ',' + '-' + name + " answered.");
    }
    public void Task_4()
    {
        string a = "Reach";
        string b = "out";
        string c = "touch";
        string d = "faith";
        string f = a + " " + b + " " + c + " " + d;
        string con = string.Concat(f);
        Console.WriteLine(con);
        string[] j = new string[] { a, b, c, d };
        string j1 = string.Join(" ", j);
        Console.WriteLine(j1);
    }
    public void Task_5()
    {
        string text = "Good day";
        string text2;
        text = text.Substring(2);
        text2 = text.Substring(1);
        string[] j = new string[] { text, text2 };
        string j1 = string.Join(" ", j);
        Console.WriteLine(j1);

    }
    public void Task_6()
    {
        string a = "I'm reading a fascinating story";
        a = a.Replace("fascinating", "boring");
        Console.WriteLine(a);

    }
    public void Task_7()
    {
        string a = Console.ReadLine();
        Console.WriteLine(a.ToUpper());
    }
}
class Homework_2
{
    public void Task_1()
    {
        Console.WriteLine("Введите целое число");
        string s = Console.ReadLine();
        Console.WriteLine("Введите целое число");
        string s1 = Console.ReadLine();
        Console.WriteLine("Введите символ");
        string s2 = Console.ReadLine();
        Console.WriteLine("Введите вещественное число");
        string s3 = Console.ReadLine();
        int i = Convert.ToInt32(s);
        byte d = Convert.ToByte(s1);
        char c = Convert.ToChar(s2);
        double b = Convert.ToDouble(s3);

        Console.WriteLine(i);
        Console.WriteLine(d);
        Console.WriteLine(c);
        Console.WriteLine(b);

    }
    public void Task_2()
    {
        Console.WriteLine("Введите первое число");
        string a = Console.ReadLine();
        Console.WriteLine("Введите второе число");
        string b = Console.ReadLine();
        int c = int.Parse(a);
        double d = double.Parse(b);
        Console.WriteLine(c);
        Console.WriteLine(d);
    }
    public void Task_3()
    {
        Console.WriteLine("Введите число");
        string a = Console.ReadLine();
        bool b = int.TryParse(a, out var c);
        if (b == true)
            Console.WriteLine($"Преобразование прошло успешно. Число: {c}");
        else
            Console.WriteLine("Преобразование завершилось неудачно");

    }
    public void Task_4()
    {
        int a = 5;
        int b = a + 3;
        int c = a + b;
        Console.WriteLine($"Сумма чисел равна: {c}");
    }
    public void Task_5()
    {
        string m = "milk", b = "bread", e = "eggs", me = "meat", c = "cookie";
        int milk = 2, bread = 1, eggs = 10, meat = 3, cookie = 4;
        double m1 = 1.50, b1 = 2.50, e1 = 3, me1 = 3.50, c1 = 4.50;
        double chek = milk * m1 + bread * b1 + eggs * e1 + meat * me1 + cookie * c1;
        double discount = chek / 100 * 15;
        double finalchek = chek - discount;
        Console.WriteLine(m + "  " + milk + "  " + m1);
        Console.WriteLine(b + "  " + bread + "  " + b1);
        Console.WriteLine(e + "  " + eggs + "  " + e1);
        Console.WriteLine(me + "  " + meat + "  " + me1);
        Console.WriteLine(c + "  " + cookie + "  " + c1);
        Console.WriteLine($"Итоговый чек: {chek}");
        Console.WriteLine($"Скидка 15%: {discount}");
        Console.WriteLine($"Итого к оплате: {finalchek}");
    }
    public void Task_6()
    {
        int a = 14;
        int b = 8;
        double c = a++ - b / 2;
        // 1) b/2 = 8/2 = 4
        // 2) a++ = 14
        // 3) a-b/2 = 14-4 = 10
        double c1 = ++a + b * 2;
        // 1) b*2 = 8*2 = 16
        // 2) ++a = 14+1 = 15
        // 3) a+b*2 = 15+16 = 31
        Console.WriteLine(c);
        Console.WriteLine(c1);
    }
    public void Task_7()
    {
        int a = 1, b = 1, c = 1;
        bool a1 = a == b;
        bool a2 = a == b && b ==c;
        bool a3 = a >= c || b >= c;
        bool a4 = a >= b;
        bool a5 = a <= b;
        Console.WriteLine($"{a1},{a2},{a3},{a4},{a5}");
        bool b1 = a != b;
        bool b2 = a < b && b != c;
        bool b3 = a != c || b > c;
        bool b4 = a > b;
        bool b5 = a < b;
        Console.WriteLine($"{b1},{b2},{b3},{b4},{b5}");
        bool c1 = a <= 5;
        bool c2 = b == 3;
        Console.WriteLine($"{c1},{c2}");
    }
    public void Task_8()
    {
        int i = 5;
        object o = i;
        int i1 = (int)o;
    }
    public void Task_9()
    {
        byte b = 25;
        int i = 15;
        int i1 = b;
        short s = (short)i;
    }
    public void Task_10()
    {
        Console.WriteLine("Traffic Ligts");
        var color = Console.ReadLine();
        if (color == "green")
        {
            Console.WriteLine("Go!");
        }
        else if (color == "yellow")
        {
            Console.WriteLine("Wait");
        }
        else if (color == "red")
        {
            Console.WriteLine("Stop");
        }
        else
            Console.WriteLine("Stop!");
    }
}
