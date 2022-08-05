using FactoryMethod.Domain;

namespace FactoryMethod.Factories
{
    internal class GymAndPoolMembershipFactory : MembershipFactory
    {
        private readonly decimal _price;
        private readonly string _description;

        public GymAndPoolMembershipFactory(decimal price, string description)
        {
            _price = price;
            _description = description;
        }

        public override IMembership GetMembership()
        {
            GymAndPoolMembership membership = new(_price)
            {
                Description = _description
            };

            return membership;
        }
    }
}
