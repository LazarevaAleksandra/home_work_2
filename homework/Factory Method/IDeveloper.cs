using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public interface IDeveloper
    {
        public IVehicle Create();    
    }
}
//Определяет фабричный метод Create(), который возвращает объект IVehicle.