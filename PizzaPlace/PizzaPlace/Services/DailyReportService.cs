using PizzaPlace.Interfaces;
using PizzaPlace.Models;

namespace PizzaPlace.Services
{
    public class DailyReportService
    {
        private readonly Dictionary<string, DailyReport> _reports = new();

        public void AddOrder(string date, IPizza pizza, int count)
        {
            if (!_reports.ContainsKey(date))
                _reports[date] = new DailyReport();

            var report = _reports[date];
            report.TotalIncome += pizza.Price;

            if (pizza.Name.ToLower() == "margarita")
                report.MargaritaCount += count;
            else if (pizza.Name.ToLower() == "boss")
                report.BossPizzaCount += count;
        }

        public void PrintReports()
        {
            Console.WriteLine();
            Console.WriteLine("Cash register reset:");
            Console.WriteLine("-----------------------------");

            foreach (var pair in _reports)
            {
                var date = pair.Key;
                var report = pair.Value;
                int total = report.MargaritaCount + report.BossPizzaCount;

                Console.WriteLine($"Date: {date}");
                Console.WriteLine($"Total pizzas: {total}");
                Console.WriteLine($"Margarita: {report.MargaritaCount}");
                Console.WriteLine($"Boss Pizza: {report.BossPizzaCount}");
                Console.WriteLine($"Total Income = ${report.TotalIncome}");
                Console.WriteLine("-----------------------------");
            }
        }
    }

}
