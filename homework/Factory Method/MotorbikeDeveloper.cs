﻿using FactoryMethod;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class MotorbikeDeveloper : IDeveloper
    {
        public MotorbikeDeveloper(string name) : base() { }

        public IVehicle Create()
        {
            return new Motorbike("Motorbike");
        }
    }
}
//Наследник класса IDeveloper, определяющий свою реализацию метода Create().