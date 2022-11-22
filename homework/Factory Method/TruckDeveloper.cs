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
        public TruckDeveloper(string name) : base() { }

        public IVehicle Create()
        {
            return new Truck("Truck");
        }
    }
}
//Наследник класса IDeveloper, определяющий свою реализацию метода Create().