using Microsoft.AspNetCore.Mvc;
using TaskManagementSystem.Api.DTOs;
using TaskManagementSystem.Api.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace TaskManagementSystem.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ReportsController : ControllerBase
    {
        private readonly IReportService _reportService;

        public ReportsController(IReportService reportService)
        {
            _reportService = reportService;
        }

        [HttpGet("weekly")]
        public async Task<ActionResult<IEnumerable<ReportDto>>> GetWeeklyReports()
        {
            var reports = await _reportService.GetWeeklyReportsAsync();
            return Ok(reports);
        }

        [HttpGet("monthly")]
        public async Task<ActionResult<IEnumerable<ReportDto>>> GetMonthlyReports()
        {
            var reports = await _reportService.GetMonthlyReportsAsync();
            return Ok(reports);
        }
    }
}
