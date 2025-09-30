using System.Net.Http.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blazored.LocalStorage;
using KanbanApp.Models;

namespace KanbanApp.Services
{
    public class TaskService
    {
        private const string StorageKey = "kanban.tasks";
        private readonly ILocalStorageService _localStorage;
        private List<KanbanTask> _tasks = new();
        public event Action? OnChange;
        private Guid? _draggingTaskId;

        public TaskService(ILocalStorageService localStorage)
        {
            _localStorage = localStorage;
        }

        // Initialize tasks from local storage
        public async Task InitializeAsync()
        {
            _tasks = await _localStorage.GetItemAsync<List<KanbanTask>>(StorageKey) ?? new List<KanbanTask>();
            NotifyStateChanged();
        }

        // Get tasks filtered by column, sorted by creation date
        public IEnumerable<KanbanTask> GetTasksByColumn(ColumnType column) =>
            _tasks.Where(t => t.Column == column).OrderByDescending(t => t.CreatedAt);

        // Add new task
        public async Task AddTask(KanbanTask task)
        {
            _tasks.Add(task);
            await SaveAsync();
            NotifyStateChanged();
        }

        // Update an existing task
        public async Task UpdateTask(KanbanTask task)
        {
            var idx = _tasks.FindIndex(t => t.Id == task.Id);
            if (idx >= 0) _tasks[idx] = task;
            await SaveAsync();
            NotifyStateChanged();
        }

        // Delete a task by Id
        public async Task DeleteTask(Guid id)
        {
            _tasks.RemoveAll(t => t.Id == id);
            await SaveAsync();
            NotifyStateChanged();
        }

        // Track dragging task
        public void SetDragging(Guid id) => _draggingTaskId = id;

        // Drop task into new column
        public async Task DropToColumn(ColumnType column)
        {
            if (_draggingTaskId.HasValue)
            {
                var task = _tasks.FirstOrDefault(t => t.Id == _draggingTaskId.Value);
                if (task != null)
                {
                    task.Column = column;
                    await SaveAsync();
                    NotifyStateChanged();
                }
                _draggingTaskId = null;
            }
        }

        // Save tasks to local storage
        private async Task SaveAsync() => await _localStorage.SetItemAsync(StorageKey, _tasks);

        // Notify UI that state changed
        private void NotifyStateChanged() => OnChange?.Invoke();
    }
}

