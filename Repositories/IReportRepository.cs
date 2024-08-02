using TaskManagementSystem.Api.Models;

namespace TaskManagementSystem.Api.Repositories
{
    public interface IReportRepository
    {
        Task<IEnumerable<Report>> GetWeeklyReportsAsync();
        Task<IEnumerable<Report>> GetMonthlyReportsAsync();
    }
}
