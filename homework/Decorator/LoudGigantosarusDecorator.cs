using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class LoudGigantosarusDecorator : GigantosaurusDecorator
    {
        private IGigantosaurus _gigantosaurus;

        public LoudGigantosarusDecorator (IGigantosaurus gigantosaurus)
        {
            _gigantosaurus = gigantosaurus;
        }

        public string Roar() => $"Loud {_gigantosaurus.Roar()}";     
    }
}
//Класс добавляет новый функционал.