using PizzaPlace.Interfaces;

namespace PizzaPlace.Models
{
    public class BossPizza : IPizza
    {
        private readonly int _count;
        private readonly PizzaSize _size;
        private readonly int _unitPrice;

        public BossPizza(int count, PizzaSize size)
        {
            _count = count;
            _size = size;
            _unitPrice = size.Name switch
            {
                "small" => 20,
                "medium" => 25,
                "large" => 30,
                _ => throw new ArgumentException("Invalid size")
            };
        }

        public string Name => "Boss";
        public int DoughWeight => _count * _size.DoughWeight;
        public int Price => _count * _unitPrice;

        public void PrintPreparation()
        {
            Console.WriteLine("Boss's Pizza is preparing...");
            Console.WriteLine($"Pizza dough {_count} * {_size.DoughWeight} = {DoughWeight}gr");
            Console.WriteLine($"Ham: {_count * 100}gr");
            Console.WriteLine($"Total: ${Price}");
            Console.WriteLine("-----------------------------");
        }
    }
}
