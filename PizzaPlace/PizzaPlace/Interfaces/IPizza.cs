namespace PizzaPlace.Interfaces
{
    public interface IPizza
    {
        string Name { get; }
        int DoughWeight { get; }
        int Price { get; }
        void PrintPreparation();
    }

}
