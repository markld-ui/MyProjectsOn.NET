using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using ListOfNotes;
using System.Globalization;
using static System.Runtime.InteropServices.JavaScript.JSType;



namespace Models
{

    public class Data
    {
        public int Id { get; set; }
        public DateTimeOffset Date { get; set; }
        public string? Title { get; set; }
        public string? Text { get; set; }
        public string? Category { get; set; }
    }

    public class ModelNotes : IModelNotes
    {
        private List<Data> notes;

        public ModelNotes()
        {
            notes = new List<Data>();
            LoadDataFromJson();
        }

        private string GetDatabasePath()
        {
            // Путь к базе данных относительно каталога выполнения приложения
            return Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "DataBase", "database.json");
        }

        private int GenerateUniqueId()
        {
            if (notes.Count > 0)
                return notes[notes.Count - 1].Id + 1;
            else
                return 1;
        }

        private void SaveDataToJson()
        {
            try
            {
                string appDataPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "DataBase");
                string databasePath = Path.Combine(appDataPath, "database.json");
                string json = JsonSerializer.Serialize(notes);

                // Создание папки, если её нет
                if (!Directory.Exists(appDataPath))
                {
                    Directory.CreateDirectory(appDataPath);
                }

                // Сохранение данных в файл
                File.WriteAllText(databasePath, json);
            }
            catch (Exception ex)
            {
                // Логирование или обработка исключений
                Console.WriteLine("Error saving data: " + ex.Message);
            }
        }

        public void CreateData(string? date, string? title, string? text, string? category)
        {
            var dataOfNote = new Data
            {
                Id = GenerateUniqueId(),
                Date = DateTime.Parse(date, new CultureInfo("ru-RU")),
                Title = title,
                Text = text,
                Category = category
            };

            notes.Add(dataOfNote);
            SaveDataToJson();
        }

        public void DeleteNote(int id)
        {
            var noteToDelete = notes.FirstOrDefault(n => n.Id == id);

            if (noteToDelete != null)
            {
                notes.Remove(noteToDelete);
                SaveDataToJson();
                Console.WriteLine($"Заметка с ID {id} успешно удалена.");
            }
            else
            {
                Console.WriteLine($"Заметка с ID {id} не найдена.");
            }
        }

        public List<Data> LoadDataFromJson()
        {
            string path = GetDatabasePath();
            try
            {
                if (File.Exists(path))
                {
                    string json = File.ReadAllText(path);
                    notes = JsonSerializer.Deserialize<List<Data>>(json) ?? new List<Data>();
                    return notes;
                }
                else
                {
                    Console.WriteLine("Файл с данными не найден.");
                    notes = new List<Data>();
                    return notes;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Произошла ошибка при загрузке данных: {ex.Message}");
                notes = new List<Data>();
                return notes;
            }
        }

        public void UpdateNote(int id, string? title, string? text, string? date, string? category)
        {
            var noteToUpdate = notes.FirstOrDefault(n => n.Id == id);
            if (noteToUpdate != null)
            {
                noteToUpdate.Title = title;
                noteToUpdate.Text = text;
                noteToUpdate.Date = DateTime.Parse(date, new CultureInfo("ru-RU"));
                noteToUpdate.Category = category;
                SaveDataToJson();
            }
        }

        public Data GetNoteById(int id)
        {
            return notes.FirstOrDefault(n => n.Id == id);
        }

        public List<Data> GetAllNotes()
        {
            return notes;
        }
    }
}
