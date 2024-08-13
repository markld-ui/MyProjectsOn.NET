namespace ListOfNotes
{
    partial class MainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBoxSearch = new TextBox();
            buttonFind = new Button();
            label_name = new Label();
            listBoxNotes = new ListBox();
            comboBoxCategories = new ComboBox();
            labelCategories = new Label();
            textBoxTitleNote = new TextBox();
            richTextBoxNote = new RichTextBox();
            buttonSaveNote = new Button();
            comboBox1 = new ComboBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // textBoxSearch
            // 
            textBoxSearch.BackColor = Color.FromArgb(82, 83, 85);
            textBoxSearch.Font = new Font("Segoe UI", 18F);
            textBoxSearch.ForeColor = SystemColors.Window;
            textBoxSearch.Location = new Point(412, 10);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(519, 39);
            textBoxSearch.TabIndex = 0;
            textBoxSearch.Text = "Поиск...";
            textBoxSearch.TextChanged += textBoxSearch_TextChanged;
            textBoxSearch.MouseDown += textBoxSearch_MouseDown;
            // 
            // buttonFind
            // 
            buttonFind.BackColor = Color.FromArgb(82, 83, 85);
            buttonFind.Font = new Font("Segoe UI", 16F);
            buttonFind.ForeColor = SystemColors.Window;
            buttonFind.Location = new Point(937, 10);
            buttonFind.Name = "buttonFind";
            buttonFind.Size = new Size(133, 39);
            buttonFind.TabIndex = 1;
            buttonFind.Text = "Найти";
            buttonFind.UseVisualStyleBackColor = false;
            buttonFind.Click += buttonFind_Click;
            // 
            // label_name
            // 
            label_name.Font = new Font("Segoe UI", 20F);
            label_name.ForeColor = SystemColors.Window;
            label_name.Location = new Point(12, 10);
            label_name.Name = "label_name";
            label_name.Size = new Size(147, 39);
            label_name.TabIndex = 2;
            label_name.Text = "Заметки";
            // 
            // listBoxNotes
            // 
            listBoxNotes.BackColor = Color.FromArgb(32, 33, 36);
            listBoxNotes.BorderStyle = BorderStyle.None;
            listBoxNotes.ForeColor = SystemColors.Window;
            listBoxNotes.FormattingEnabled = true;
            listBoxNotes.ItemHeight = 15;
            listBoxNotes.Location = new Point(12, 172);
            listBoxNotes.Name = "listBoxNotes";
            listBoxNotes.ScrollAlwaysVisible = true;
            listBoxNotes.Size = new Size(312, 570);
            listBoxNotes.TabIndex = 3;
            listBoxNotes.SelectedIndexChanged += listBoxNotes_SelectedIndexChanged;
            listBoxNotes.MouseDoubleClick += listBoxNotes_MouseDoubleClick;
            // 
            // comboBoxCategories
            // 
            comboBoxCategories.BackColor = Color.FromArgb(82, 83, 85);
            comboBoxCategories.Font = new Font("Segoe UI", 14F);
            comboBoxCategories.ForeColor = SystemColors.Window;
            comboBoxCategories.FormattingEnabled = true;
            comboBoxCategories.Location = new Point(12, 116);
            comboBoxCategories.Name = "comboBoxCategories";
            comboBoxCategories.Size = new Size(312, 33);
            comboBoxCategories.TabIndex = 4;
            comboBoxCategories.SelectedIndexChanged += comboBoxCategories_SelectedIndexChanged;
            // 
            // labelCategories
            // 
            labelCategories.AutoSize = true;
            labelCategories.Font = new Font("Segoe UI", 14F);
            labelCategories.ForeColor = SystemColors.Window;
            labelCategories.Location = new Point(12, 76);
            labelCategories.Name = "labelCategories";
            labelCategories.Size = new Size(102, 25);
            labelCategories.TabIndex = 5;
            labelCategories.Text = "Категории";
            // 
            // textBoxTitleNote
            // 
            textBoxTitleNote.BackColor = Color.FromArgb(82, 83, 85);
            textBoxTitleNote.Font = new Font("Segoe UI", 14F);
            textBoxTitleNote.ForeColor = SystemColors.Window;
            textBoxTitleNote.Location = new Point(412, 116);
            textBoxTitleNote.MaxLength = 100;
            textBoxTitleNote.Name = "textBoxTitleNote";
            textBoxTitleNote.Size = new Size(574, 32);
            textBoxTitleNote.TabIndex = 6;
            textBoxTitleNote.Text = "Заголовок";
            textBoxTitleNote.TextChanged += textBoxTitle_TextChanged;
            textBoxTitleNote.MouseDown += textBoxTitleNote_MouseDown;
            // 
            // richTextBoxNote
            // 
            richTextBoxNote.BackColor = Color.FromArgb(82, 83, 85);
            richTextBoxNote.ForeColor = SystemColors.Window;
            richTextBoxNote.Location = new Point(412, 217);
            richTextBoxNote.Name = "richTextBoxNote";
            richTextBoxNote.Size = new Size(574, 266);
            richTextBoxNote.TabIndex = 8;
            richTextBoxNote.Text = "Введите текст заметки";
            richTextBoxNote.TextChanged += richTextBoxNote_TextChanged;
            richTextBoxNote.MouseDown += richTextBoxNote_MouseDown;
            // 
            // buttonSaveNote
            // 
            buttonSaveNote.Location = new Point(911, 498);
            buttonSaveNote.Name = "buttonSaveNote";
            buttonSaveNote.Size = new Size(75, 23);
            buttonSaveNote.TabIndex = 9;
            buttonSaveNote.Text = "Сохранить";
            buttonSaveNote.UseVisualStyleBackColor = true;
            buttonSaveNote.Click += buttonSaveNote_Click;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.FromArgb(82, 83, 85);
            comboBox1.Font = new Font("Segoe UI", 14F);
            comboBox1.ForeColor = SystemColors.Window;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(674, 172);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(312, 33);
            comboBox1.TabIndex = 10;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.ForeColor = SystemColors.Window;
            label1.Location = new Point(412, 175);
            label1.Name = "label1";
            label1.Size = new Size(102, 25);
            label1.TabIndex = 11;
            label1.Text = "Категории";
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 33, 36);
            ClientSize = new Size(1184, 761);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Controls.Add(buttonSaveNote);
            Controls.Add(richTextBoxNote);
            Controls.Add(textBoxTitleNote);
            Controls.Add(labelCategories);
            Controls.Add(comboBoxCategories);
            Controls.Add(listBoxNotes);
            Controls.Add(label_name);
            Controls.Add(buttonFind);
            Controls.Add(textBoxSearch);
            MaximizeBox = false;
            MaximumSize = new Size(1200, 800);
            MinimumSize = new Size(1200, 800);
            Name = "MainWindow";
            Text = "Notes";
            Load += MainWindow_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxSearch;
        private Button buttonFind;
        private Label label_name;
        private ListBox listBoxNotes;
        private ComboBox comboBoxCategories;
        private Label labelCategories;
        private TextBox textBoxTitleNote;
        private RichTextBox richTextBoxNote;
        private Button buttonSaveNote;
        private ComboBox comboBox1;
        private Label label1;
    }
}
