using System;
using System.Reflection.Emit;
using System.Windows.Forms;
using Models;

namespace ListOfNotes
{
    public partial class EditNoteForm : Form
    {
        private ModelNotes modelNotes;
        private int noteId;

        public EditNoteForm(ModelNotes notes, int id)
        {
            InitializeComponent();
            modelNotes = notes;
            noteId = id;
            LoadNoteData();
        }

        private void LoadNoteData()
        {
            var note = modelNotes.GetNoteById(noteId);
            if (note != null)
            {
                textBoxEditTitle.Text = note.Title;
                richTextBoxEditText.Text = note.Text;
                dateNote.Text = note.Date.ToString();
                labelSelectegCat.Text = note.Category;
            }
            else
            {
                MessageBox.Show("Заметка не найдена.");
                Close();
            }
        }

        private void buttonClose_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Close();
            }
        }

        private void buttonSaveNote_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                modelNotes.UpdateNote(noteId, textBoxEditTitle.Text, richTextBoxEditText.Text, DateTime.Now.ToString(), modelNotes.GetNoteById(noteId).Category);
                MessageBox.Show("Заметка сохранена.");
                Close();
            }
        }

        private void textBoxEditTitle_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && textBoxEditTitle.Text == "Заголовок")
            {
                textBoxEditTitle.Clear();
            }
        }

        private void richTextBoxEditText_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && richTextBoxEditText.Text == "Текст заметки")
            {
                richTextBoxEditText.Clear();
            }
        }

        private void buttonDeleteNote_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                modelNotes.DeleteNote(noteId);
                MessageBox.Show("Заметка удалена.");
                Close();
            }
        }
    }
}