using System.Collections;
using System.Data;
using TodoServerApp.Data.Interfaces;

namespace TodoServerApp.Data.Services
{
    public class MemoryDataService : IDataService
    {
        public static IEnumerable<TaskItem> Tasks { get; } = 
        [
        
            new() { Id=1, Title="Задача 1", Description="Описание задачи 1", CreatedDate=DateTime.Now},
            new TaskItem { Id=2, Title="Задача 2", Description="Описание задачи 2", CreatedDate=DateTime.Now},
            new() { Id=3, Title = "Задача 3", Description = "Описание задачи 3", CreatedDate = DateTime.Now },
        ];
        public Task<IEnumerable<TaskItem>> GetTaskItemAsync()
        {
            return Task.FromResult(Tasks);
        }
    }
}
