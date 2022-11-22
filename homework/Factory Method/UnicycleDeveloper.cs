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
        private string _name;

        public string Name { get => _name; set => _name = value; }

        public UnicycleDeveloper(string name)
        {
            Name = name;
        }

        public IVehicle Create()
        {
            return new Unicycle(_name);
        }
    }
}
//Наследник класса IDeveloper, определяющий свою реализацию метода Create().