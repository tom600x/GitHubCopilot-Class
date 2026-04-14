using System.Text.Json;
using CopilotDemo.Models;

namespace CopilotDemo.Services
{
    public class TaskItemService
    {
        private readonly string _filePath;
        private readonly SemaphoreSlim _mutex = new(1, 1);
        private readonly JsonSerializerOptions _jsonOptions = new() { WriteIndented = true };

        public TaskItemService(IWebHostEnvironment environment)
        {
            var dataDir = Path.Combine(environment.ContentRootPath, "App_Data");
            Directory.CreateDirectory(dataDir);
            _filePath = Path.Combine(dataDir, "taskitems.json");
        }

        public async Task<IReadOnlyList<TaskItem>> GetAllAsync()
        {
            var items = await ReadAllInternalAsync();
            return items.OrderBy(t => t.IsCompleted).ThenBy(t => t.DueDate).ToList();
        }

        public async Task<TaskItem?> GetByIdAsync(int id)
        {
            var items = await ReadAllInternalAsync();
            return items.FirstOrDefault(t => t.Id == id);
        }

        public async Task<int> AddAsync(TaskItem item)
        {
            await _mutex.WaitAsync();
            try
            {
                var items = await ReadAllFromDiskNoLockAsync();
                item.Id = items.Count == 0 ? 1 : items.Max(t => t.Id) + 1;
                item.CreatedDate = DateTime.UtcNow;
                items.Add(item);
                await WriteAllNoLockAsync(items);
                return item.Id;
            }
            finally
            {
                _mutex.Release();
            }
        }

        public async Task<bool> UpdateAsync(TaskItem item)
        {
            await _mutex.WaitAsync();
            try
            {
                var items = await ReadAllFromDiskNoLockAsync();
                var index = items.FindIndex(t => t.Id == item.Id);
                if (index < 0)
                {
                    return false;
                }

                item.CreatedDate = items[index].CreatedDate;
                items[index] = item;
                await WriteAllNoLockAsync(items);
                return true;
            }
            finally
            {
                _mutex.Release();
            }
        }

        public async Task<bool> DeleteAsync(int id)
        {
            await _mutex.WaitAsync();
            try
            {
                var items = await ReadAllFromDiskNoLockAsync();
                var item = items.FirstOrDefault(t => t.Id == id);
                if (item is null)
                {
                    return false;
                }

                items.Remove(item);
                await WriteAllNoLockAsync(items);
                return true;
            }
            finally
            {
                _mutex.Release();
            }
        }

        private async Task<List<TaskItem>> ReadAllInternalAsync()
        {
            await _mutex.WaitAsync();
            try
            {
                return await ReadAllFromDiskNoLockAsync();
            }
            finally
            {
                _mutex.Release();
            }
        }

        private async Task<List<TaskItem>> ReadAllFromDiskNoLockAsync()
        {
            if (!File.Exists(_filePath))
            {
                var seed = SeedData();
                await WriteAllNoLockAsync(seed);
                return seed;
            }

            await using var stream = File.OpenRead(_filePath);
            var items = await JsonSerializer.DeserializeAsync<List<TaskItem>>(stream) ?? [];
            return items;
        }

        private async Task WriteAllNoLockAsync(List<TaskItem> items)
        {
            await using var stream = File.Create(_filePath);
            await JsonSerializer.SerializeAsync(stream, items, _jsonOptions);
        }

        private static List<TaskItem> SeedData()
        {
            return
            [
                new TaskItem
                {
                    Id = 1,
                    Title = "Finalize TaskItem service",
                    Description = "Persist tasks in JSON and wire up dependency injection.",
                    Category = "Work",
                    Priority = TaskPriority.High,
                    DueDate = DateTime.Today.AddDays(1),
                    IsCompleted = false,
                    CreatedDate = DateTime.UtcNow
                },
                new TaskItem
                {
                    Id = 2,
                    Title = "Review Copilot prompts",
                    Description = "Tune prompts for the 15-minute lab flow.",
                    Category = "Training",
                    Priority = TaskPriority.Medium,
                    DueDate = DateTime.Today.AddDays(2),
                    IsCompleted = false,
                    CreatedDate = DateTime.UtcNow
                }
            ];
        }
    }
}
