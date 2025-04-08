using PizzaPlace.Enum;

namespace PizzaPlace
{
    public class Program
    {
        static void Main()
        {
            string input;
            Dictionary<string, DailyReport> cashRegister = new Dictionary<string, DailyReport>();

            while ((input = Console.ReadLine()!) != "end")
            {
                string[] tokens = input.Split();

                string pizzaName = tokens[1].ToLower();
                int pizzaCount = int.Parse(tokens[2]);
                string pizzaSize = tokens[3].ToLower();
                string orderDate = DateTime.Parse(tokens[4]).ToString("dd.MM.yyyy");

                if (pizzaName == "margarita")
                {
                    PizzaMargarita pizzaMargarita = new PizzaMargarita()
                    {
                        DoughCount = pizzaCount,
                        PizzaSize = GetPizzaSize(pizzaSize),
                        MargaritaPrice = GetMargaritaPrice(pizzaSize),
                        TomatoCount = pizzaCount
                    };

                    pizzaMargarita.PrintPreparation(pizzaCount);

                    if (!cashRegister.ContainsKey(orderDate))
                        cashRegister[orderDate] = new DailyReport();

                    cashRegister[orderDate].MargaritaCount += pizzaCount;
                    cashRegister[orderDate].TotalIncome += pizzaMargarita.Price * pizzaCount;
                }
                else
                {
                    BossPizza bossPizza = new BossPizza()
                    {
                        DoughCount = pizzaCount,
                        PizzaSize = GetPizzaSize(pizzaSize),
                        BossPizzaPrice = GetBossPizzaPrice(pizzaSize)
                    };

                    bossPizza.PrintPreparation(pizzaCount);

                    if (!cashRegister.ContainsKey(orderDate))
                        cashRegister[orderDate] = new DailyReport();

                    cashRegister[orderDate].BossPizzaCount += pizzaCount;
                    cashRegister[orderDate].TotalIncome += bossPizza.Price * pizzaCount;
                }
            }

            CashRegisterReset();

            foreach (var register in cashRegister)
            {
                string date = register.Key;
                DailyReport report = register.Value;
                int totalPizzas = report.MargaritaCount + report.BossPizzaCount;

                CashRegisterReport(report, date, totalPizzas);
            }
        }

        public static PizzaSize GetPizzaSize(string pizzaSize)
        {
            return pizzaSize.ToLower() switch
            {
                "small" => PizzaSize.Small,
                "medium" => PizzaSize.Medium,
                "large" => PizzaSize.Large,
                _ => throw new ArgumentException("Invalid pizza size.")
            };
        }

        public static MargaritaPrice GetMargaritaPrice(string pizzaSize)
        {
            return pizzaSize.ToLower() switch
            {
                "small" => MargaritaPrice.Small,
                "medium" => MargaritaPrice.Medium,
                "large" => MargaritaPrice.Large,
                _ => throw new ArgumentException("Invalid pizza size.")
            };
        }

        public static BossPizzaPrice GetBossPizzaPrice(string pizzaSize)
        {
            return pizzaSize.ToLower() switch
            {
                "small" => BossPizzaPrice.Small,
                "medium" => BossPizzaPrice.Medium,
                "large" => BossPizzaPrice.Large,
                _ => throw new ArgumentException("Invalid pizza size.")
            };
        }

        public static void CashRegisterReport(DailyReport report, string date, int totalPizzas)
        {
            Console.WriteLine($"Date: {date}");
            Console.WriteLine($"Total pizzas: {totalPizzas}");
            Console.WriteLine($"Margarita: {report.MargaritaCount}");
            Console.WriteLine($"Boss`s Pizza: {report.BossPizzaCount}");
            Console.WriteLine($"Total Income = ${report.TotalIncome}");
            Console.WriteLine("-----------------------------");
        }

        public static void CashRegisterReset()
        {
            Console.WriteLine();
            Console.WriteLine("Cash register reset:");
            Console.WriteLine("-----------------------------");
        }
    }
}
