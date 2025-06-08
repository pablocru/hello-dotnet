var userList = new[]
{
    new { Name = "Pablo", BirthDate = new DateTime(1996, 6, 28) },
    new { Name = "Alice", BirthDate = new DateTime(1995, 5, 15) },
    new { Name = "Bob", BirthDate = new DateTime(1994, 4, 10) }
};

Console.WriteLine("User information:");
foreach (var user in userList)
{
    Console.WriteLine($"{user.Name} was born in {user.BirthDate.ToShortDateString()}.");
}
