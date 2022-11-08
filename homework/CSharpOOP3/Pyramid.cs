using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOP3
{
    internal class Pyramid : Shape
    {
        private double _height;
        private double _s;

        public Pyramid(string name, double height, double s) : base(name)
        {
            _name = name;
            _height = height;
            _s = s;
        }

        public override double GetVolume()
        {
            double pyramidVolume = (_height * _s) /3 ;
            return pyramidVolume;
        }

        public override void GetShape()
        {
            Console.WriteLine($"Name of shape: {_name}, volume = {GetVolume()}");
        }
    }
}
