using AutoMapper;
using TaskManagementSystem.Api.DTOs;
using TaskManagementSystem.Api.Repositories;


namespace TaskManagementSystem.Api.Services
{
    public class ReportService : IReportService
    {
        private readonly IReportRepository _reportRepository;
        private readonly IMapper _mapper;

        public ReportService(IReportRepository reportRepository, IMapper mapper)
        {
            _reportRepository = reportRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<ReportDto>> GetWeeklyReportsAsync()
        {
            var reports = await _reportRepository.GetWeeklyReportsAsync();
            return _mapper.Map<IEnumerable<ReportDto>>(reports);

            //var reports = await _reportRepository.GetReportsByDateRangeAsync(DateTime.Now.AddDays(-7), DateTime.Now);
            //return _mapper.Map<IEnumerable<ReportDto>>(reports);

        }

        public async Task<IEnumerable<ReportDto>> GetMonthlyReportsAsync()
        {
            var reports = await _reportRepository.GetMonthlyReportsAsync();
            return _mapper.Map<IEnumerable<ReportDto>>(reports);
            //var reports = await _reportRepository.GetReportsByDateRangeAsync(DateTime.Now.AddMonths(-1), DateTime.Now);
            //return _mapper.Map<IEnumerable<ReportDto>>(reports);
        }


    }
}
