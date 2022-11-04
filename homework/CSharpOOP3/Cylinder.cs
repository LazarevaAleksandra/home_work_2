using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOP3
{
    internal class Cylinder : Shape
    {
        private double _height;
        private double _ragius;

        public Cylinder(string name, double height, double ragius) : base(name)
        {
            _name = name;
            _height = height;
            _ragius = ragius;
        }

        public override double GetVolume()
        {
            double cylinderVolume = Math.PI * Math.Pow(_ragius, 2) * _height;
            return cylinderVolume;
        }

        public override void GetShape()
        {
            Console.WriteLine($"Name of shape: {_name}, volume = {GetVolume()}");
        }
    }
}
