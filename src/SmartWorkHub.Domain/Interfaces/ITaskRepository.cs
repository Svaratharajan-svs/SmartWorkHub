using SmartWorkHub.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace SmartWorkHub.Domain.Interfaces
{
    public interface ITaskRepository
    {
        Task<IEnumerable<TaskItem>> GetAllAsync();
        Task<TaskItem?> GetByIdAsync(string id);
        Task AddAsync(TaskItem taskItem);
        Task UpdateAsync(TaskItem task);
        Task DeleteAsync(int id);

    }
}