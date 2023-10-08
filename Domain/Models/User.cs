namespace Domain.Models;

public class User {
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Username { get; set; }
    public string Document { get; set; }
    public string Address { get; set; }
    public DateTime DateOfBirth { get; set; }
    public DateTime CreateAt { get; set; }
}