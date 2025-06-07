namespace conditional_branching;

class Program
{
    static void Main(string[] args)
    {
        string AUTHORIZATION_MESSAGE = "You are authorized to pass.";
        string NOT_AUTHORIZED_MESSAGE = "You are not authorized to pass.";
        bool isAdult = true;
        bool hasAuthorization = false;

        if (isAdult || hasAuthorization)
        {
            Console.WriteLine(AUTHORIZATION_MESSAGE);
        }
        else
        {
            Console.WriteLine(NOT_AUTHORIZED_MESSAGE);
        }

        string userRole = "admin";

        switch (userRole)
        {
            case "admin":
                Console.WriteLine("Welcome, Admin!");
                break;
            case "user":
                Console.WriteLine("Welcome, User!");
                break;
            case "guest":
                Console.WriteLine("Welcome, Guest!");
                break;
            default:
                Console.WriteLine("Unknown role.");
                break;
        }

        int userAge = 20;

        switch (userAge)
        {
            case < 18:
                Console.WriteLine("You are a minor.");
                break;
            case >= 18 and < 65:
                Console.WriteLine("You are an adult.");
                break;
            case >= 65:
                Console.WriteLine("You are a senior citizen.");
                break;
            default:
                Console.WriteLine("Invalid age.");
                break;
        }
    }
}
