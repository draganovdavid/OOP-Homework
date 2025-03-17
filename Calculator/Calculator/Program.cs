namespace MyApp
{
    using Calculator;
    public class Program
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

            if (firstCurrency == "BGN")
            {
                Currency currency = new Currency { Name = secondCurrency };
                Console.WriteLine(currency.ConvertFromBGN(amount).ToString("F2"));
            }
            else if (secondCurrency == "BGN")
            {
                Currency currency = new Currency { Name = firstCurrency };
                Console.WriteLine(currency.ConvertToBGN(amount).ToString("F2"));
            }
            else
            {
                Console.WriteLine("Vuvedena e nevalidna valuta!");
                return;
            }

            Console.WriteLine();

            User user = new User { Name = "David", Balance = 2790.43 };
            SpecialUser specialUser = new SpecialUser { Name = "David", Balance = 2790.43 };

            Console.WriteLine(user.UserInfo());
            Console.WriteLine(specialUser.UserInfo());
        }
    }
}