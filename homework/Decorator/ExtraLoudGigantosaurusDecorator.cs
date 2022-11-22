using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class ExtraLoudGigantosaurusDecorator : IGigantosaurusDecorator
    {
        private IGigantosaurus _gigantosaurus;

        public ExtraLoudGigantosaurusDecorator(IGigantosaurus gigantosaurus)
        {
            _gigantosaurus = gigantosaurus;
        }

        public string Roar() => $"Exstra Loud {_gigantosaurus.Roar()}";
    }
}
//Класс добавляет новый функционал.