using PizzaPlace.Services;

namespace PizzaPlace
{
    public class Program
    {
        static void Main()
        {
            string input;
            var factory = new PizzaFactory();
            var reportService = new DailyReportService();

            while ((input = Console.ReadLine()!) != "end")
            {
                var tokens = input.Split();

                string name = tokens[1];
                int count = int.Parse(tokens[2]);
                string size = tokens[3];
                string date = DateTime.Parse(tokens[4]).ToString("dd.MM.yyyy");

                var pizza = factory.CreatePizza(name, count, size);
                pizza.PrintPreparation();
                reportService.AddOrder(date, pizza, count);
            }

            reportService.PrintReports();
        }
    }
}
