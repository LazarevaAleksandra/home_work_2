
using CSharpAdvanced;

namespace CSharpAdvanced
{
    public class RepaintingFlowers<T> where T : Flower
    {
        public string GetNewColor(T flower, string paint) 
        {
            if (flower.Color != paint)
            {
                flower.Color = paint;
                GetNewPrice(flower);                
            }
            return $"New flower color: {flower.Color}";
        }

        public double GetNewPrice(T flower)
        {
            return flower.Price * 1.15;
        }

        public double FinalCheck(Dictionary<Flower, int> flowers)
        {
            double totalPrice = 0;
            foreach (var flower in flowers)
            {
                var flowerPrice = flower.Key;
                totalPrice += flowerPrice.Price * flower.Value;
            }
            return totalPrice;
        }
    }
}
