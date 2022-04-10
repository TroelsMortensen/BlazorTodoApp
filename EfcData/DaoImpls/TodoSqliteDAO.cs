using Domain.Contracts;
using Domain.Models;
using EfcData.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace EfcData.DaoImpls;

public class TodoSqliteDAO : ITodoHome
{

    private readonly TodoContext context;

    public TodoSqliteDAO(TodoContext context)
    {
        this.context = context;
    }

    public async Task<ICollection<Todo>> GetAsync()
    {
        ICollection<Todo> todos = await context.Todos.ToListAsync();
        return todos;
    }

    public Task<Todo> GetByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public async Task<Todo> AddAsync(Todo todo)
    {
        EntityEntry<Todo> added = await context.AddAsync(todo);
        await context.SaveChangesAsync();
        return added.Entity;
    }

    public Task DeleteAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task UpdateAsync(Todo todo)
    {
        throw new NotImplementedException();
    }
}