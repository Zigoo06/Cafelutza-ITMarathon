namespace Cafelutza.Data.Models;

public class User
{
    public string Id { get; set; }

    public string Name { get; set; }

    public string Email { get; set; }

    public string Role { get; set; }
    public ICollection<Raport> Raports { get; set; }
}
