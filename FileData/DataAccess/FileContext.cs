using System.Text.Json;
using Domain.Models;

namespace FileData.DataAccess;

public class FileContext
{
    private string todoFilePath = "todos.json";
    public ICollection<Todo> Todos { get; private set; }

    public FileContext()
    {
        if (!File.Exists(todoFilePath))
        {
            Seed();
        }
        LoadData();
    }

    private void Seed()
    {
        
        Todo[] ts = {
            new Todo(1, "Dishes") {
                Id = 1,
            },
            new Todo(1, "Walk the dog") {
                Id = 1,
            },
            new Todo(2, "Do DNP homework") {
                Id = 3,
            },
            new Todo(3, "Eat breakfast") {
                Id = 4,
            },
            new Todo(4, "Mow lawn") {
                Id = 5,
            },
        };
        Todos = ts.ToList();
        SaveChanges();
    }

    public void SaveChanges()
    {
        string serialize = JsonSerializer.Serialize(Todos);
        File.WriteAllText(todoFilePath,serialize);
    }

    private void LoadData()
    {
        string content = File.ReadAllText(todoFilePath);
        Todos = JsonSerializer.Deserialize<List<Todo>>(content);
    }
}