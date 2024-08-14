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
            comboBoxCategories.Items.Add("���");
            comboBoxCategories.Items.Add("���");
            comboBoxCategories.Items.Add("������");
            comboBoxCategories.Items.Add("�����");
            comboBoxCategories.Items.Add("�������");

            comboBox1.Items.Add("���");
            comboBox1.Items.Add("������");
            comboBox1.Items.Add("�����");
            comboBox1.Items.Add("�������");
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            LoadNotes();
        }

        private void LoadNotes()
        {
            var notes = database.GetAllNotes();
            listBoxNotes.Items.Clear();

            string selectedCategory = comboBoxCategories.SelectedItem?.ToString() ?? "���";

            foreach (var note in notes)
            {
                if (selectedCategory == "���" || note.Category == selectedCategory)
                {
                    listBoxNotes.Items.Add(note.Title);
                }
            }
        }

        //Mouse Events

        private void textBoxTitleNote_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && textBoxTitleNote.Text == "���������")
            {
                textBoxTitleNote.Clear();
            }
        }
        private void richTextBoxNote_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && richTextBoxNote.Text == "������� ����� �������")
            {
                richTextBoxNote.Clear();
            }
        }

        private void listBoxNotes_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                // ���������, ��� ��������� ������� � ������
                if (listBoxNotes.SelectedItem != null)
                {
                    // �������� ��������� ��������� �������
                    string selectedTitle = listBoxNotes.SelectedItem.ToString();

                    // ���� ������� �� ���������
                    var note = database.GetAllNotes().FirstOrDefault(n => n.Title == selectedTitle);

                    if (note != null)
                    {
                        EditNoteForm editNoteForm = new EditNoteForm(database, note.Id); // ������������� note.Id
                        editNoteForm.ShowDialog();
                        editNoteForm.Dispose();
                        LoadNotes();
                    }
                    else
                    {
                        MessageBox.Show("������� �� �������.");
                    }
                }
            }
        }

        //--------------------

        //��������� ���������
        private void comboBoxCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadNotes();
        }


        //������ ����������
        private void buttonSaveNote_Click(object sender, EventArgs e)
        {
            if (
                (textBoxTitleNote.Text != "���������" && textBoxTitleNote.Text != "") &&
                (richTextBoxNote.Text != "������� ����� �������" && richTextBoxNote.Text != "")
               )
            {
                DateTime dateTime = DateTime.Now;
                // ������� ����� �������
                database.CreateData(dateTime.ToString(), textBoxTitleNote.Text, richTextBoxNote.Text, comboBox1.SelectedItem.ToString());

                // ��������� ������ �������
                LoadNotes();

                MessageBox.Show($"������ ������� ���������!");
                textBoxTitleNote.Text = "���������";
                richTextBoxNote.Text = "������� ����� �������";
                comboBox1.Text = "";
            }
            else
            {
                MessageBox.Show("��������� ��� ����� ������� ����(-�) ��� �������� ����������� ���������.");
            }
        }
    }
}
