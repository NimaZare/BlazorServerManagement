namespace EndPoint.ToDoUI.Models;

public class ToDoItem
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public bool IsCompleted { get; set; }
    public DateTime DateCompleted { get; set; }
}
