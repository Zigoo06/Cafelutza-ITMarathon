using System.ComponentModel.DataAnnotations.Schema;

namespace Cafelutza.Data.Models;

public class Raport
{
    public int Id { get; set; }
    public string? Description { get; set; }
    public string Category { get; set; }
    public string Location { get; set; }
    public string ImageURL { get; set; }
    public User User { get; set; }
}
