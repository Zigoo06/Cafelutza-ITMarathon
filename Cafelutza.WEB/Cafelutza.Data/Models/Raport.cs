namespace Cafelutza.Data.Models;

public class Raport
{
    public int Id { get; set; }
    public string? Descrition { get; set; }
    public string Category { get; set; }
    public string Location { get; set; }
    public byte[] Image { get; set; }
}
