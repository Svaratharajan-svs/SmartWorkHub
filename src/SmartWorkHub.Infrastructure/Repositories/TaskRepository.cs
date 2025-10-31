using Microsoft.EntityFrameworkCore;
using SmartWorkHub.Domain.Entities;
using SmartWorkHub.Domain.Interfaces;
using SmartWorkHub.Infrastructure.Persistence;

namespace SmartWorkHub.Infrastructure.Repositories
{
    public class TaskRepository : ITaskRepository
    {
        private readonly SmartWorkHubDbContext _context;

        public TaskRepository(SmartWorkHubDbContext context) { 
            _context = context; 
        }

        public async Task AddAsync(TaskItem taskItem)
        {
            _ = _context.Tasks.Add(taskItem);
            _ = await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var task = await _context.Tasks.FindAsync(id);
            if (task != null)
            {
                _context.Tasks.Remove(task);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<TaskItem>> GetAllAsync()
        {
            return await _context.Tasks.AsNoTracking().ToListAsync();
        }

        public async Task<TaskItem?> GetByIdAsync(string id)
        {
           return await  _context.Tasks.FindAsync(id);
        }

        public async Task UpdateAsync(TaskItem task)
        {
            _context.Tasks.Update(task);

            await _context.SaveChangesAsync();
        }
    }
}