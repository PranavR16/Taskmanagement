using AutoMapper;
using TaskManagementSystem.Api.DTOs;
using TaskManagementSystem.Api.Repositories;
using TaskManagementSystem.Api.Models;


namespace TaskManagementSystem.Api.Services
{
    public class TaskService : ITaskService
    {
        private readonly ITaskRepository _taskRepository;
        private readonly IMapper _mapper;

        public TaskService(ITaskRepository taskRepository, IMapper mapper)
        {
            _taskRepository = taskRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<TaskDto>> GetAllTasksAsync()
        {
            var tasks = await _taskRepository.GetAllAsync();
            return _mapper.Map<IEnumerable<TaskDto>>(tasks);
        }

        public async Task<TaskDto> GetTaskByIdAsync(int id)
        {
            var task = await _taskRepository.GetByIdAsync(id);
            return _mapper.Map<TaskDto>(task);
        }

        public async Task<TaskDto> CreateTaskAsync(TaskDto taskDto)
        {
            var task = _mapper.Map<Taskss>(taskDto);
            await _taskRepository.AddAsync(task);
            return _mapper.Map<TaskDto>(task);
        }

        public async Task<bool> UpdateTaskAsync(int id, TaskDto taskDto)
        {
            var task = _mapper.Map<Taskss>(taskDto);
            return await _taskRepository.UpdateAsync(id, task);
        }

        public async Task<bool> DeleteTaskAsync(int id)
        {
            return await _taskRepository.DeleteAsync(id);
        }
    }
}
