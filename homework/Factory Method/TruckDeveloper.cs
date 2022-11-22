using FactoryMethod;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class TruckDeveloper : IDeveloper
    {
        private string _name;

        public string Name { get => _name; set => _name = value; }

        public TruckDeveloper(string name)
        {
            Name = name;
        }

        public IVehicle Create()
        {
            return new Truck(_name);
        }
    }
}
//Наследник класса IDeveloper, определяющий свою реализацию метода Create().