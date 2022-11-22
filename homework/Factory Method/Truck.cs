using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class Truck : IVehicle
    {
        private string _name;

        public string Name { get => _name; set => _name = value; }

        public Truck(string name)
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