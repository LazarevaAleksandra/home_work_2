using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace FactoryMethod
{
    public class Unicycle : IVehicle
    {
        private string _name;

        public string Name { get => _name; set => _name = value; }

        public Unicycle(string name)
        {
            Name = name;
        }

        public void TransportInformation()
        {
            Console.WriteLine($"This vehicle is {_name}");
        }
    }
}
//Реализация интерфейса IVehicle.