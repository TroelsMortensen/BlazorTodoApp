using System.Collections.Generic;
using System.Threading.Tasks;
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
        throw new System.NotImplementedException();
    }

    public Task<Todo> GetById(int id)
    {
        throw new System.NotImplementedException();
    }

    public Task<Todo> AddAsync(Todo todo)
    {
        throw new System.NotImplementedException();
    }

    public Task DeleteAsync(int id)
    {
        throw new System.NotImplementedException();
    }

    public Task UpdateAsync(Todo todo)
    {
        throw new System.NotImplementedException();
    }
}