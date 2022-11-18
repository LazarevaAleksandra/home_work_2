
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

        public void SideLengthCheck(int OneLength, int TwoLenght, int ThreeLenght)
        {
            if (OneLength < TwoLenght + ThreeLenght
                || TwoLenght < OneLength + ThreeLenght
                || ThreeLenght < OneLength + TwoLenght)
            {
                throw new Exception("The length of a side is greater than the sum of the other two!");
            }
            else
            {
                Console.WriteLine("The length of a side is less than the sum of the other two!");
            }
        }

        public void CheckingValuesForZero(int OneLength, int TwoLenght, int ThreeLenght)
        {
            do
            {
                Console.WriteLine("Enter the lengths of all sides:");
                OneLength = int.Parse(Console.ReadLine());
                TwoLenght = int.Parse(Console.ReadLine());
                ThreeLenght = int.Parse(Console.ReadLine());

                if (OneLength == 0 || TwoLenght == 0 || ThreeLenght == 0)
                {
                    throw new Exception("The side length is zero!");
                }               
            }
            while (true);
        }
    }
}
