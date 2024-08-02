using TaskManagementSystem.Api.DTOs;


namespace TaskManagementSystem.Api.Services
{
    public interface IReportService
    {
        Task<IEnumerable<ReportDto>> GetWeeklyReportsAsync();
        Task<IEnumerable<ReportDto>> GetMonthlyReportsAsync();
    }
}
