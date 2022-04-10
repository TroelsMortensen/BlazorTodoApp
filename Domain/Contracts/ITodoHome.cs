using System.Collections.Generic;
using System.Threading.Tasks;
using Domain.Models;

namespace Domain.Contracts;

public interface ITodoHome
{
    public Task<ICollection<Todo>> GetAsync();
    public Task<ICollection<Todo>> GetAsync(int? userId, bool? isCompleted);
    public Task<Todo> GetByIdAsync(int id);
    public Task<Todo> AddAsync(Todo todo);
    public Task DeleteAsync(int id);
    public Task UpdateAsync(Todo todo);

}