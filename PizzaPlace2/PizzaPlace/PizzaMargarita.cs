using PizzaPlace.Enum;

namespace PizzaPlace
{
    public class PizzaMargarita : Pizza
    {
        public int TomatoCount { get; set; } = 1;

        public MargaritaPrice MargaritaPrice { get; set; }

        public override int Price => (int)MargaritaPrice;

        public override void PrintPreparation(int pizzaCount)
        {
            Console.WriteLine("Margarita preparing...");
            Console.WriteLine($"Pizza dough {pizzaCount}*{(int)PizzaSize} = {pizzaCount * (int)PizzaSize}gr");
            Console.WriteLine($"Tomatoes {TomatoCount}*{pizzaCount} = {TomatoCount * pizzaCount}");
            Console.WriteLine($"Total: ${Price * pizzaCount}");
            Console.WriteLine("-----------------------------");
        }
    }
}
