using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOP3
{
    internal class Ball : Shape
    {
        private double _radius;

        public Ball(string name, double radius) : base(name)
        {
            _name = name;
            _radius = radius;
        }

        public override double GetVolume()
        {
            double ballVolume = ((4 * Math.PI * Math.Pow(_radius, 3)) / 3);
            return ballVolume;
        }

        public override void GetShape()
        {
            Console.WriteLine($"Name of shape: {_name}, volume = {GetVolume()}");
        }
    }
}
