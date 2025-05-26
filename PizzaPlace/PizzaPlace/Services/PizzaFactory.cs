using PizzaPlace.Interfaces;
using PizzaPlace.Models;

namespace PizzaPlace.Services
{
    public class PizzaFactory
    {
        public IPizza CreatePizza(string name, int count, string size)
        {
            PizzaSize pizzaSize = size.ToLower() switch
            {
                "small" => new PizzaSize("small", 300),
                "medium" => new PizzaSize("medium", 500),
                "large" => new PizzaSize("large", 800),
                _ => throw new ArgumentException("Invalid size")
            };

            return name.ToLower() switch
            {
                "margarita" => new Margarita(count, pizzaSize),
                "boss" => new BossPizza(count, pizzaSize),
                _ => throw new ArgumentException("Invalid pizza name")
            };
        }
    }
}