namespace Calculator
{
    class User
    {
        public string Name { get; set; } = null!;

        public double Balance { get; set; }

        public virtual string UserInfo()
        {
            return $"User: {Name}, Balance: {Balance}";
        }
    }
}