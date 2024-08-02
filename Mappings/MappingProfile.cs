using AutoMapper;
using TaskManagementSystem.Api.DTOs;
using TaskManagementSystem.Api.Models;

namespace TaskManagementSystem.Api.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Taskss, TaskDto>().ReverseMap();
            CreateMap<User, UserDto>().ReverseMap();
            CreateMap<Report, ReportDto>();
        }
    }
}
