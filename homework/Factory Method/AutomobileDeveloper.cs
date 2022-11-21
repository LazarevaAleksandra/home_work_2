using FactoryMethod;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class AutomobileDeveloper : IDeveloper
    {
        public AutomobileDeveloper(string name) : base() { }

        public IVehicle Create()
        {
            return new Automobile("Automobile");
        }
    }
}
//Наследник класса IDeveloper, определяющий свою реализацию метода Create().
