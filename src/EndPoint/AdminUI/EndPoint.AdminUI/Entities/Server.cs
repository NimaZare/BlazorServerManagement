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
    public string? Name { get; set; }
    public string? City { get; set; }
}
