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

    public async Task<ICollection<Todo>> GetAsync(int? userId, bool? isCompleted)
    {
        IQueryable<Todo> todos = context.Todos.AsQueryable();
        if (userId != null)
        {
            todos = todos.Where(todo => todo.OwnerId == userId);
        }

        if (isCompleted != null)
        {
            todos = todos.Where(todo => todo.IsCompleted == isCompleted);
        }

        ICollection<Todo> result = await todos.ToListAsync();
        return result;
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

    public async Task DeleteAsync(int id)
    {
        Todo? existing = await context.Todos.FindAsync(id);
        if (existing is null)
        {
            throw new Exception($"Could not find Todo with id {id}. Nothing was deleted");
        }

        context.Todos.Remove(existing);
        await context.SaveChangesAsync();
    }

    public Task UpdateAsync(Todo todo)
    {
        context.Todos.Update(todo);
        return context.SaveChangesAsync();
    }
}