using PizzaPlace.Enum;

namespace PizzaPlace
{
    public class BossPizza : Pizza
    {
        public int HamWeight { get; set; } = 100;

        public BossPizzaPrice BossPizzaPrice { get; set; }

        public override int Price => (int)BossPizzaPrice;

        public override void PrintPreparation(int pizzaCount)
        {
            Console.WriteLine("Boss`s Pizza preparing...");
            Console.WriteLine($"Pizza dough {pizzaCount}*{(int)PizzaSize} = {pizzaCount * (int)PizzaSize}gr");
            Console.WriteLine($"Ham {pizzaCount}*{HamWeight} = {pizzaCount * HamWeight}gr");
            Console.WriteLine($"Total: ${pizzaCount * Price}");
            Console.WriteLine("-----------------------------");
        }
    }
}
