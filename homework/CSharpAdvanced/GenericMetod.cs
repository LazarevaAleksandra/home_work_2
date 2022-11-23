
namespace CSharpAdvanced
{
    public class GenericMetod
    {
        public void GetFirstItem<T>(T[] array)
        {
            Console.WriteLine(array[0]);
        }
    }
}
