namespace inheritance;

class Program
{
    static void Main(string[] args)
    {
        Employee employee = new("Pablo", new DateTime(1996, 6, 28), "Software Engineer");

        Console.WriteLine(employee.GetInfo());
    }
}

class Person(string name, DateTime birthDate)
{
    public string Name { get; } = name;
    private readonly DateTime _birthDate = birthDate;
    public int Age => (DateTime.Now - _birthDate).Days / 365;

    public string GetInfo() => $"{Name} was born on {_birthDate.ToShortDateString()} and is {Age} years old.";
}

class Employee(string name, DateTime birthDate, string jobTitle) : Person(name, birthDate)
{
    public string JobTitle { get; set; } = jobTitle;

    public new string GetInfo() => $"{base.GetInfo()} They work as a {JobTitle}.";
}
