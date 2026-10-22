using System.Text.Json;
using System.Text.Json.Serialization;
using TodoApp.Models;

namespace TodoApp.Services
{
    public class TodoStorage
    {
        private readonly string _filePath;
        public string FolderPath { get; }

        // Å´ Ç±Ç±Ç™ë´Ç∑Ç∆Ç±ÇÎ
        private static readonly JsonSerializerOptions _options = new()
        {
            WriteIndented = true,
            Converters = { new JsonStringEnumConverter() }
        };

        public TodoStorage()
        {
            FolderPath = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
                "TodoApp");
            Directory.CreateDirectory(FolderPath);
            _filePath = Path.Combine(FolderPath, "todos.json");
        }

        public void Save(List<TodoItem> items)
        {
            string json = JsonSerializer.Serialize(items, _options);
            File.WriteAllText(_filePath, json);
        }

        public List<TodoItem> Load()
        {
            if (!File.Exists(_filePath))
            {
                return new List<TodoItem>();
            }

            string json = File.ReadAllText(_filePath);
            return JsonSerializer.Deserialize<List<TodoItem>>(json, _options)
                   ?? new List<TodoItem>();
        }
    }
}