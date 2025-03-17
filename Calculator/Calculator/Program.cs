namespace MyApp
{
    using Calculator;
    using System;

    public class Program : CurrencyConverter
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Primerni valuti: BGN/EUR, EUR/BGN, BGN/USD, USD/BGN, BGN/GBP, GBP/BGN");
            Console.Write("Vuvedete valuta za preobrazuvane: ");

            string[] input = Console.ReadLine()!
                .ToUpper()
                .Split("/")
                .ToArray();

            Console.Write("Vuvedete suma za preobrazuvane: ");
            decimal amount = decimal.Parse(Console.ReadLine()!.Trim());

            string firstCurrency = input[0];
            string secondCurrency = input[1];

            ICurrencyConverter converter = new CurrencyConverter();

            if (firstCurrency == "BGN")
            {
                decimal convertedAmount = converter.ConvertFromBGN(amount, secondCurrency);
                string convertedResult = convertedAmount.ToString("F2");
                switch (secondCurrency)
                {
                    case "EUR":
                        Console.WriteLine($"{convertedResult}(€)");
                        break;
                    case "USD":
                        Console.WriteLine($"{convertedResult}($)");
                        break;
                    case "GBP":
                        Console.WriteLine($"{convertedResult}(£)");
                        break;
                    default:
                        break;
                }
            }
            else if (secondCurrency == "BGN")
            {
                decimal convertedAmount = converter.ConvertToBGN(amount, firstCurrency);
                string convertedResult = convertedAmount.ToString("F2");
                Console.WriteLine($"{convertedResult}(lv.)");
            }
            else
            {
                Console.WriteLine("Vuvedena e nevalidna valuta!");
                return;
            }

            Console.WriteLine("----------------------------");

            User user = new User { Name = "David", Balance = 2790.43 };
            SpecialUser specialUser = new SpecialUser { Name = "David Draganov", Balance = 3563.63 };

            Console.WriteLine(user.UserInfo());
            Console.WriteLine(specialUser.UserInfo());
        }
    }
}