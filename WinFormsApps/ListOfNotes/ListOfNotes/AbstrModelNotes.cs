using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ListOfNotes;

namespace Models
{
    interface IModelNotes
    {
        public void CreateData(string? date, string? title, string? text, string? category);
        public List<Data> LoadDataFromJson();
        public void UpdateNote(int id, string? title, string? text, string? date, string? category);
        public Data GetNoteById(int id);
        public List<Data> GetAllNotes();

        public void DeleteNote(int id);
    }
}
