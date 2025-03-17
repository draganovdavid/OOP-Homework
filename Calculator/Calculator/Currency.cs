namespace Calculator
{
    public interface ICurrencyConverter
    {
        decimal ConvertToBGN(decimal amount, string currency);
        decimal ConvertFromBGN(decimal amount, string currency);
    }

    public class CurrencyConverter : ICurrencyConverter
    {
        private readonly Dictionary<string, decimal> exchangeRates = new()
        {
            {"EUR", 1.955320m},
            {"USD", 1.797500m},
            {"GBP", 2.325070m}
        };

        public decimal ConvertToBGN(decimal amount, string currency)
        {
            if (exchangeRates.ContainsKey(currency))
            {
                amount *= exchangeRates[currency];
            }
            return amount * 0.98m;
        }

        public decimal ConvertFromBGN(decimal amount, string currency)
        {
            if (exchangeRates.ContainsKey(currency))
            {
                amount /= exchangeRates[currency];
            }
            return amount * 0.98m;
        }
    }
}