namespace loops;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Looping Workshop!");
        string[] names = ["Alice", "Bob", "Charlie", "Diana"];

        foreach (string name in names)
        {
            Console.WriteLine($"Hello, {name}!");
        }
        Console.WriteLine("All greetings have been printed.");

        Console.WriteLine("Now using a for loop to print greetings:");
        for (int i = 0; i < names.Length; i++)
        {
            Console.WriteLine($"Greeting {i + 1}: {names[i]}");
        }

        Console.WriteLine("Using a while loop to print numbers from 1 to 5:");
        int count = 1;
        while (count <= 5)
        {
            Console.WriteLine($"Count: {count}");
            count++;
        }

        Console.WriteLine("Using a do-while loop to print numbers from 5 to 1:");
        int reverseCount = 5;
        do
        {
            Console.WriteLine($"Reverse Count: {reverseCount}");
            reverseCount--;
        } while (reverseCount >= 1);
    }
}
