using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpException
{
    public class Triangle
    {
        public int OneLength { get; set; }
        public int TwoLenght { get; set; }
        public int ThreeLenght { get; set; }

        public Triangle()
        {
        }
        public Triangle(int oneLength, int twoLenght, int threeLenght)
        {
            OneLength = oneLength;
            TwoLenght = twoLenght;
            ThreeLenght = threeLenght;
        }

        public void SideLengthCheck()
        {
            if (OneLength < TwoLenght + ThreeLenght
                || TwoLenght < OneLength + ThreeLenght 
                || ThreeLenght < OneLength + TwoLenght) 
            {
                throw new Exception("The length of a side is greater than the sum of the other two!");
            }
        }

        public void CheckingValuesForZero()
        {
            if (OneLength != 0
                || TwoLenght != 0
                || ThreeLenght != 0)
            {
                throw new Exception("The side length is zero!");
            }
        }
    }
}
