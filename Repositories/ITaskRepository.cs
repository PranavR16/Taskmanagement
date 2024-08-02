using TaskManagementSystem.Api.Models;

namespace TaskManagementSystem.Api.Repositories
{
    public interface ITaskRepository
    {
        Task<IEnumerable<Taskss>> GetAllAsync();
        Task<Taskss> GetByIdAsync(int id);
        Task AddAsync(Taskss task);
        Task<bool> UpdateAsync(int id, Taskss task);
        Task<bool> DeleteAsync(int id);
    }
}
