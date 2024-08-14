using System.Drawing.Drawing2D;
using System.Globalization;
using Models;

namespace ListOfNotes
{
    public partial class MainWindow : Form
    {
        private ModelNotes database = new ModelNotes();

        public MainWindow()
        {
            InitializeComponent();
            comboBoxCategories.Items.Add("Все");
            comboBoxCategories.Items.Add("Дом");
            comboBoxCategories.Items.Add("Работа");
            comboBoxCategories.Items.Add("Спорт");
            comboBoxCategories.Items.Add("Финансы");

            comboBox1.Items.Add("Дом");
            comboBox1.Items.Add("Работа");
            comboBox1.Items.Add("Спорт");
            comboBox1.Items.Add("Финансы");
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            LoadNotes();
        }

        private void LoadNotes()
        {
            var notes = database.GetAllNotes();
            listBoxNotes.Items.Clear();

            string selectedCategory = comboBoxCategories.SelectedItem?.ToString() ?? "Все";

            foreach (var note in notes)
            {
                if (selectedCategory == "Все" || note.Category == selectedCategory)
                {
                    listBoxNotes.Items.Add(note.Title);
                }
            }
        }

        //Mouse Events

        private void textBoxTitleNote_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && textBoxTitleNote.Text == "Заголовок")
            {
                textBoxTitleNote.Clear();
            }
        }
        private void richTextBoxNote_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && richTextBoxNote.Text == "Введите текст заметки")
            {
                richTextBoxNote.Clear();
            }
        }

        private void listBoxNotes_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                // Проверяем, что выбранный элемент в списке
                if (listBoxNotes.SelectedItem != null)
                {
                    // Получаем заголовок выбранной заметки
                    string selectedTitle = listBoxNotes.SelectedItem.ToString();

                    // Ищем заметку по заголовку
                    var note = database.GetAllNotes().FirstOrDefault(n => n.Title == selectedTitle);

                    if (note != null)
                    {
                        EditNoteForm editNoteForm = new EditNoteForm(database, note.Id); // Использование note.Id
                        editNoteForm.ShowDialog();
                        editNoteForm.Dispose();
                        LoadNotes();
                    }
                    else
                    {
                        MessageBox.Show("Заметка не найдена.");
                    }
                }
            }
        }

        //--------------------

        //Комбобокс категории
        private void comboBoxCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadNotes();
        }


        //Кнопка сохранения
        private void buttonSaveNote_Click(object sender, EventArgs e)
        {
            if (
                (textBoxTitleNote.Text != "Заголовок" && textBoxTitleNote.Text != "") &&
                (richTextBoxNote.Text != "Введите текст заметки" && richTextBoxNote.Text != "")
               )
            {
                DateTime dateTime = DateTime.Now;
                // Создаем новую заметку
                database.CreateData(dateTime.ToString(), textBoxTitleNote.Text, richTextBoxNote.Text, comboBox1.SelectedItem.ToString());

                // Обновляем список заметок
                LoadNotes();

                MessageBox.Show($"Данные успешно сохранены!");
                textBoxTitleNote.Text = "Заголовок";
                richTextBoxNote.Text = "Введите текст заметки";
                comboBox1.Text = "";
            }
            else
            {
                MessageBox.Show("Заголовок или текст заметки пуст(-ы) или являются стандартным значением.");
            }
        }
    }
}
