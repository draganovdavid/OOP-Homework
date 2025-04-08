using PizzaPlace.Enum;

namespace PizzaPlace
{
    public abstract class Pizza
    {
        public int DoughCount { get; set; }

        public PizzaSize PizzaSize { get; set; }

        public abstract int Price { get; }

        public abstract void PrintPreparation(int pizzaCount);
    }
}
