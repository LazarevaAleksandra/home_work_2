
using Microsoft.CSharp.RuntimeBinder;
using System.Runtime.Intrinsics.X86;
new Homework().Task_5();
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
        Console.WriteLine(s);
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
        string text1;
        string text2;
        text1 = text.Substring(0,3);
        text2 = text.Substring(text.Length -5);
        string[] j = new string[] { text1, text2 };
        string j1 = string.Join("",j);
        Console.WriteLine(j1);

    }
    public void Task_6()
    {
        string a = Console.ReadLine();
        string epitet1 = "facsionality";
        string epitet2 = "boring";
        var d = a.Replace(epitet1, epitet2);
        Console.WriteLine(a);

    }
    public void Task_7()
    {
        string a = Console.ReadLine();
        Console.WriteLine(a.ToUpper());
    }
}


