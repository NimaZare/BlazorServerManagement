using System.ComponentModel.DataAnnotations;

namespace EndPoint.AdminUI.Entities;

public class Server
{
    public Server()
    {
        Random random = new();
        int rndNum = random.Next(0, 2);
        IsOnline = rndNum != 0;
    }

    public int Id { get; set; }
    public bool IsOnline { get; set; }

    [Required]
    public string? Name { get; set; }
    
    [Required]
    public string? City { get; set; }
}
