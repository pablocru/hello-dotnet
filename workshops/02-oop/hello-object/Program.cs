Person person = new("Pablo", new DateTime(1996, 6, 28));
Console.WriteLine($"{person.Name} is {person.GetAge()} years old.");

class Person(string name, DateTime birthDate)
{
    public string Name { get; } = name;
    private DateTime BirthDate = birthDate;

    // - Traditional constructor
    // public Person(string name, DateTime birthDate)
    // {
    //     Name = name;
    //     BirthDate = birthDate;
    // }

    public int GetAge()
    {
        return (DateTime.Now - BirthDate).Days / 365;
    }
}
