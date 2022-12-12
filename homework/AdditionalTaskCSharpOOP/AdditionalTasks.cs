
namespace AdditionalTaskCSharpOOP
{
    public class AdditionalTasks
    {
        //Task_1
        public double ConvertCurrency(double byn, double exchangeRate)
        {
            return byn / exchangeRate;
        }

        public void GetABankTransaction(double byn, string currency, double exchangeRate)
        {
            Console.WriteLine($"Conversion result {currency}: {byn}BYN in {currency}: " +
                $"{ConvertCurrency(byn, exchangeRate)}{currency}");
        }

        //Task_2
        public void GetNumbers(double numberOne, double numberTwo = 5, double numberThree = 2)
        {
            Console.WriteLine((numberOne / numberTwo) + numberThree);
        }

        //Task_3
        public void GetChars(params char[] chars)
        {
            foreach(char c in chars)
            {
                Console.Write(c);
            }
        }
    }
}

