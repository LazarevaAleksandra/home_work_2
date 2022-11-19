using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpException
{
    public class ExceptionForTriangle : Exception
    {
        public double Value { get; }

        public ExceptionForTriangle() { }

        public ExceptionForTriangle(string message) : base(message) { }

        public ExceptionForTriangle(string message, Exception innerException) : base(message, innerException) { }

        public ExceptionForTriangle(string message, int value)
        {
            Value = value;
        }
    }
}
