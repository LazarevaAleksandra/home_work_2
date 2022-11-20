
namespace CSharpException
{
    public class Triangle
    {
        private int _oneLenght;
        private int _twoLenght;
        private int _threeLenght;

        public int OneLenght { get => _oneLenght; set => _oneLenght = value; }

        public int TwoLenght { get => _twoLenght; set => _twoLenght = value; }

        public int ThreeLenght { get => _threeLenght; set => _threeLenght = value; }

        public void SideLengthCheck(int OneLength, int TwoLenght, int ThreeLenght)
        {
            if (OneLength < TwoLenght + ThreeLenght
                || TwoLenght < OneLength + ThreeLenght
                || ThreeLenght < OneLength + TwoLenght) 
            {
                throw new ExceptionForTriangle("The length of a side is greater than the sum of the other two!");
            }
            else
            {
                Console.WriteLine("The length of a side is less than the sum of the other two!");
            }
        }

        public int CheckingValuesForZero(string value)
        {
            if (int.Parse(value) == 0)
            {
                throw new ExceptionForTriangle("The side length is zero!");
            }
            else
            {
                return int.Parse(value);
            }
        }      
    }
}
