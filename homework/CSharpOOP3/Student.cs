using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOP3
{
    internal class Student
    {
    }
}
struct Student
{
    public string Name;
    public int Age;

    public Student(string name, int age)
    {
        Name = name;
        Age = age;
    }
    public void InfoOfStudent()
    {
        Console.WriteLine($"Name: {Name}, age: {Age}");
    }
}
