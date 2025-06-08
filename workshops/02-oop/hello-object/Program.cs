using System.Text.Json;
using System.Text.Json.Serialization;

Person person = new("Pablo", new DateTime(1996, 6, 28));
Console.WriteLine(person.GetInfo());

var serializePerson = JsonSerializer.Serialize(person);
Console.WriteLine(serializePerson);

var deserializedPerson = JsonSerializer.Deserialize<Person>(serializePerson)!;
Console.WriteLine(deserializedPerson.GetInfo());

class Person(string name, DateTime birthDate)
{
    public string Name { get; } = name;

    [JsonInclude]
    private DateTime BirthDate = birthDate;

    // - Traditional constructor
    // public Person(string name, DateTime birthDate)
    // {
    //     Name = name;
    //     BirthDate = birthDate;
    // }

    public int GetAge() => (DateTime.Now - BirthDate).Days / 365;

    public string GetInfo() => $"{Name} is {GetAge()} years old.";
}
