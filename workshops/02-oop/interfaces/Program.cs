namespace interfaces;

class Program
{
    static void Main(string[] args)
    {
        Employee[] employees = [
            new("Pablo", "Software Engineer"),
            new("Pedro", "Data Scientist"),
            new("Miguel", "Product Manager")
        ];

        foreach (var employee in employees)
        {
            Console.WriteLine(employee.Work());
        }
    }
}

public interface INamable
{
    string Name { get; }
}

public interface IWorkable
{
    string JobTitle { get; }
    string Work();
}

public interface IPerson : INamable { }

public interface IEmployee : IPerson, IWorkable { }

public class Person(string name) : IPerson
{
    public string Name { get; } = name;
}

public class Employee(string name, string jobTitle) : Person(name), IEmployee
{
    public string JobTitle { get; } = jobTitle;

    public string Work() => $"{Name} is working as a {JobTitle}.";
}
