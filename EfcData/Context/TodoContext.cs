using Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace EfcData.Context;

public class TodoContext : DbContext
{
    public DbSet<Todo> Type { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source = Todo.db");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Todo>().HasKey(todo => todo.Id);
    }
}