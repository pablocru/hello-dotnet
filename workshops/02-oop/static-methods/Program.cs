namespace static_methods;

class Program
{
    static void Main(string[] args)
    {
        Person[] people = [new("Pablo"), new("Pedro"), new("Miguel")];
        foreach (var person in people)
        {
            Console.WriteLine($"{person.Name} has the identifier {person.IDENTIFIER}.");
        }
        Console.WriteLine($"There are {Person.InstanceCount()} instances of Person created so far.");
    }
}

class Person(string name)
{
    private static int _instanceCount = 0;
    public readonly int IDENTIFIER = ++_instanceCount;
    public string Name { get; } = name;

    public static int InstanceCount() => _instanceCount;
}
