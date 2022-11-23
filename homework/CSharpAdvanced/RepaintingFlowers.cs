
using System.Collections.Specialized;

namespace CSharpAdvanced
{
    public class RepaintingFlowers<T> where T : Flower
    {
        public string GetNewColor<T>(T flower, string paint) where T : Flower
        {
            flower.Color = paint;
            
            return $"New flower color: {flower.Color}";
        }

        public double GetNewPrice<T>(T flower) where T : Flower
        {
            return flower.Price * 1.15;
        }
    }
}
