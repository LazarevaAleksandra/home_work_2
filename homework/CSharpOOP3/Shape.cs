using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOP3
{
    abstract class Shape
    {
        public string _name;

        public Shape(string name) => _name = name;

        public abstract double GetVolume();

        public virtual void GetShape() => Console.WriteLine();
    }
}
