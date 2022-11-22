using FactoryMethod;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace FactoryMethod
{
    public class UnicycleDeveloper : IDeveloper
    {
        public UnicycleDeveloper(string name) : base() { }
        public IVehicle Create()
        {
            return new Unicycle("Unicycle");
        }
    }
}
//Наследник класса IDeveloper, определяющий свою реализацию метода Create().