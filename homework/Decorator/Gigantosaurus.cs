using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class Gigantosaurus : IGigantosaurus
    {
        public string Roar() => "Roar!";
    }
}
//Реализация компонента, в которую с помощью декоратора добавляется новая функциональность.