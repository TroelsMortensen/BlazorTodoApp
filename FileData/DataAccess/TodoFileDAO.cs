using Blazor.Services;
using Domain.Models;

namespace FileData.DataAccess;

public class TodoFileDAO : ITodoService
{
    private FileContext fileContext;

    public TodoFileDAO(FileContext fileContext)
    {
        this.fileContext = fileContext;
    }

    public Task<ICollection<Todo>> GetAsync()
    {
        throw new NotImplementedException();
    }

    public Task<Todo> GetById(int id)
    {
        throw new NotImplementedException();
    }

    public Task<Todo> AddAsync(Todo todo)
    {
        throw new NotImplementedException();
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