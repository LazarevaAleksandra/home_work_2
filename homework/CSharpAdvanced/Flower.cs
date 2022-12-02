
namespace CSharpAdvanced
{
    public class Flower
    {
        private string _name;
        private string _color;
        private double _price;

        public Flower(string name, string color, double price)
        {
            _name = name;
            _color = color;
            _price = price;
        }

        public string Name { get => _name; set => _name = value; }
        public string Color { get => _color; set => _color = value; }
        public double Price { get => _price; set => _price = value; }
    }
}
