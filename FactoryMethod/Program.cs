using FactoryMethod.Domain;
using FactoryMethod.Factories;

class Program
{
    static void Main()
    {
        Console.WriteLine(">>> Welcome to FactoryMethod Club <<<\n");

        Console.WriteLine("> Enter the membership type you would like to create: ");

        Console.WriteLine("> G - Gym");
        Console.WriteLine("> P - Gym and Pool");
        Console.WriteLine("> T - Personal training");

        string membershipType = Console.ReadLine();

        MembershipFactory factory = GetFactory(membershipType);

        IMembership membership = factory.GetMembership();

        Console.WriteLine("\n> Membersip you've just created: \n");
        Console.WriteLine(
                $"\tName:\t\t{membership.Name}\n" +
                $"\tDescription:\t{membership.Description}\n" +
                $"\tPrice:\t\t{membership.GetPrice()}"
            );

        Console.ReadLine();
    }

    private static MembershipFactory GetFactory(string membershipType) =>
     membershipType.ToLower() switch
     {
         "g" => new GymMembershipFactory(100, "Basic membership"),
         "p" => new GymAndPoolMembershipFactory(250, "Good price membership"),
         "t" => new PersonalTrainingMembershipFactory(400, "Best for professionals"),
         _ => null
     };
}