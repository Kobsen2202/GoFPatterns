namespace FactoryMethod.Domain
{
    internal class GymAndPoolMembership : IMembership
    {
        private readonly string _name;
        private readonly decimal _price;

        public GymAndPoolMembership(decimal price)
        {
            _name = "Gym + Pool membership";
            _price = price;
        }

        public string Name => _name;

        public string Description { get; set; }
        public decimal GetPrice() => _price;
    }
}
