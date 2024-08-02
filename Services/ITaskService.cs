﻿using TaskManagementSystem.Api.DTOs;


namespace TaskManagementSystem.Api.Services
{
    public interface ITaskService
    {
        Task<IEnumerable<TaskDto>> GetAllTasksAsync();
        Task<TaskDto> GetTaskByIdAsync(int id);
        Task<TaskDto> CreateTaskAsync(TaskDto taskDto);
        Task<bool> UpdateTaskAsync(int id, TaskDto taskDto);
        Task<bool> DeleteTaskAsync(int id);
    }
}
