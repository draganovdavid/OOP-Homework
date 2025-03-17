namespace Calculator
{
    class Currency
    {
        public string Name { get; set; } = null!;

        public decimal ConvertToBGN(decimal amount)
        {
            if (Name == "EUR")
            {
                amount *= 1.955320m;
            }
            else if (Name == "USD")
            {
                amount *= 1.797500m;
            }
            else if (Name == "GBP")
            {
                amount *= 2.325070m;
            }
            return amount -= amount * 0.02m;
        }

        public decimal ConvertFromBGN(decimal amount)
        {
            if (Name == "EUR")
            {
                amount /= 1.955320m;
            }
            else if (Name == "USD")
            {
                amount /= 1.797500m;
            }
            else if (Name == "GBP")
            {
                amount /= 2.325070m;
            }
            return amount -= amount * 0.02m;
        }
    }
}