using System.Net.Http.Json;

using System;
namespace KanbanApp.Models
{
    public enum ColumnType { ToDo, InProgress, Done }

    public class KanbanTask
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public ColumnType Column { get; set; } = ColumnType.ToDo;
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
