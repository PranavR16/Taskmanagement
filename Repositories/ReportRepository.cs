using Microsoft.EntityFrameworkCore;
using TaskManagementSystem.Api.Data;
using TaskManagementSystem.Api.Models;

namespace TaskManagementSystem.Api.Repositories
{
    public class ReportRepository : IReportRepository
    {
        private readonly ApplicationDbContext _context;

        public ReportRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Report>> GetWeeklyReportsAsync()
        {
            // Logic for weekly reports
            return await _context.Reports.Where(r => r.Period == "Weekly").ToListAsync();
        }

        public async Task<IEnumerable<Report>> GetMonthlyReportsAsync()
        {
            // Logic for monthly reports
            return await _context.Reports.Where(r => r.Period == "Monthly").ToListAsync();
        }


    }
}
