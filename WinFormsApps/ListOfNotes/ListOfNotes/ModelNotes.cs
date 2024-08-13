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

        private readonly string[] _dateFormats =
        {
            "yyyy-MM-ddTHH:mm:ss",  // ISO 8601 format
            "yyyy-MM-dd HH:mm:ss",  // Standard format
            "MM/dd/yyyy HH:mm:ss",  // US format
            "dd.MM.yyyy HH:mm:ss",  // European format
            "dd.MM.yyyy H:mm:ss",   // European format without leading zero in hours
            "M/dd/yyyy h:mm:ss tt", // US 12-hour format with AM/PM
            "MM/dd/yyyy h:mm:ss tt", // US 12-hour format with AM/PM and leading zero for month
            "d/M/yyyy h:mm:ss tt",  // UK 12-hour format with AM/PM
            "d/M/yyyy H:mm:ss",     // UK 24-hour format
            "dd/MM/yyyy H:mm:ss"    // UK 24-hour format with leading zero
        };

        public ModelNotes()
        {
            notes = new List<Data>();
            LoadDataFromJson();
        }

        private string GetDatabasePath()
        {
            // Используем AppData для хранения базы данных
            string appDataPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "DataBase");
            string databasePath = Path.Combine(appDataPath, "database.json");

            // Создание папки, если её нет
            if (!Directory.Exists(appDataPath))
            {
                Directory.CreateDirectory(appDataPath);
            }

            return databasePath;
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
                string databasePath = GetDatabasePath();
                string json = JsonSerializer.Serialize(notes);

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
                Date = ParseDate(date),
                Title = title,
                Text = text,
                Category = category
            };

            notes.Insert(0, dataOfNote);
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
                    Console.WriteLine($"Загружено {notes.Count} заметок.");
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
                // Удаляем старую версию заметки
                notes.Remove(noteToUpdate);

                // Обновляем данные заметки
                noteToUpdate.Title = title;
                noteToUpdate.Text = text;
                noteToUpdate.Date = ParseDate(date);
                noteToUpdate.Category = category;

                // Добавляем обновленную заметку в начало списка
                notes.Insert(0, noteToUpdate);

                // Сохраняем изменения в файл
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

        private DateTimeOffset ParseDate(string? dateString)
        {
            if (string.IsNullOrWhiteSpace(dateString))
                throw new ArgumentException("Date string cannot be null or empty.", nameof(dateString));

            if (DateTimeOffset.TryParseExact(dateString, _dateFormats, CultureInfo.InvariantCulture, DateTimeStyles.None, out var date))
            {
                return date;
            }
            else
            {
                throw new FormatException($"Date string '{dateString}' is not in the expected formats.");
            }
        }
    }
}
