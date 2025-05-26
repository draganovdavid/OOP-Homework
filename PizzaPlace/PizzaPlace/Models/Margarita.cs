using PizzaPlace.Interfaces;

namespace PizzaPlace.Models
{
    public class Margarita : IPizza
    {
        private readonly int _count;
        private readonly PizzaSize _size;
        private readonly int _unitPrice;

        public Margarita(int count, PizzaSize size)
        {
            _count = count;
            _size = size;
            _unitPrice = size.Name switch
            {
                "small" => 5,
                "medium" => 10,
                "large" => 15,
                _ => throw new ArgumentException("Invalid size")
            };
        }

        public string Name => "Margarita";
        public int DoughWeight => _count * _size.DoughWeight;
        public int Price => _count * _unitPrice;

        public void PrintPreparation()
        {
            Console.WriteLine("Margarita is preparing...");
            Console.WriteLine($"Pizza dough {_count} * {_size.DoughWeight} = {DoughWeight}gr");
            Console.WriteLine($"Tomatoes: {_count}");
            Console.WriteLine($"Total: ${Price}");
            Console.WriteLine("-----------------------------");
        }
    }
}
