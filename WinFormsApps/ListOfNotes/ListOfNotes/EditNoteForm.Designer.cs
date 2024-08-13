using System.Windows.Forms;

namespace ListOfNotes
{
    partial class EditNoteForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBoxEditTitle = new TextBox();
            richTextBoxEditText = new RichTextBox();
            buttonSaveNote = new Button();
            buttonCloseNote = new Button();
            label_name = new Label();
            textDateNote = new Label();
            dateNote = new Label();
            labelCategories = new Label();
            labelSelectegCat = new Label();
            buttonDeleteNote = new Button();
            SuspendLayout();
            // 
            // textBoxEditTitle
            // 
            textBoxEditTitle.BackColor = Color.FromArgb(82, 83, 85);
            textBoxEditTitle.Font = new Font("Segoe UI", 14F);
            textBoxEditTitle.ForeColor = Color.White;
            textBoxEditTitle.Location = new Point(58, 116);
            textBoxEditTitle.Name = "textBoxEditTitle";
            textBoxEditTitle.Size = new Size(571, 32);
            textBoxEditTitle.TabIndex = 0;
            textBoxEditTitle.Text = "Заголовок";
            textBoxEditTitle.MouseDown += textBoxEditTitle_MouseDown;
            // 
            // richTextBoxEditText
            // 
            richTextBoxEditText.BackColor = Color.FromArgb(82, 83, 85);
            richTextBoxEditText.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 204);
            richTextBoxEditText.ForeColor = Color.White;
            richTextBoxEditText.Location = new Point(58, 227);
            richTextBoxEditText.Name = "richTextBoxEditText";
            richTextBoxEditText.Size = new Size(571, 243);
            richTextBoxEditText.TabIndex = 1;
            richTextBoxEditText.Text = "Текст заметки";
            richTextBoxEditText.MouseDown += richTextBoxEditText_MouseDown;
            // 
            // buttonSaveNote
            // 
            buttonSaveNote.BackColor = Color.FromArgb(82, 83, 85);
            buttonSaveNote.ForeColor = Color.White;
            buttonSaveNote.Location = new Point(392, 476);
            buttonSaveNote.Name = "buttonSaveNote";
            buttonSaveNote.Size = new Size(75, 23);
            buttonSaveNote.TabIndex = 2;
            buttonSaveNote.Text = "Сохранить";
            buttonSaveNote.UseVisualStyleBackColor = false;
            buttonSaveNote.MouseClick += buttonSaveNote_MouseClick;
            // 
            // buttonCloseNote
            // 
            buttonCloseNote.BackColor = Color.FromArgb(82, 83, 85);
            buttonCloseNote.ForeColor = Color.White;
            buttonCloseNote.Location = new Point(554, 476);
            buttonCloseNote.Name = "buttonCloseNote";
            buttonCloseNote.Size = new Size(75, 23);
            buttonCloseNote.TabIndex = 3;
            buttonCloseNote.Text = "Закрыть";
            buttonCloseNote.UseVisualStyleBackColor = false;
            buttonCloseNote.MouseClick += buttonClose_MouseClick;
            // 
            // label_name
            // 
            label_name.Font = new Font("Segoe UI", 20F);
            label_name.ForeColor = SystemColors.Window;
            label_name.Location = new Point(12, 9);
            label_name.Name = "label_name";
            label_name.Size = new Size(120, 39);
            label_name.TabIndex = 4;
            label_name.Text = "Заметки";
            // 
            // textDateNote
            // 
            textDateNote.AutoSize = true;
            textDateNote.Font = new Font("Segoe UI", 14F);
            textDateNote.Location = new Point(58, 71);
            textDateNote.Name = "textDateNote";
            textDateNote.Size = new Size(156, 25);
            textDateNote.TabIndex = 5;
            textDateNote.Text = "Время создания:";
            // 
            // dateNote
            // 
            dateNote.AutoSize = true;
            dateNote.Font = new Font("Segoe UI", 14F);
            dateNote.Location = new Point(220, 71);
            dateNote.Name = "dateNote";
            dateNote.Size = new Size(67, 25);
            dateNote.TabIndex = 6;
            dateNote.Text = "Время";
            // 
            // labelCategories
            // 
            labelCategories.AutoSize = true;
            labelCategories.Font = new Font("Segoe UI", 14F);
            labelCategories.ForeColor = SystemColors.Window;
            labelCategories.Location = new Point(58, 178);
            labelCategories.Name = "labelCategories";
            labelCategories.Size = new Size(105, 25);
            labelCategories.TabIndex = 7;
            labelCategories.Text = "Категория:";
            // 
            // labelSelectegCat
            // 
            labelSelectegCat.AutoSize = true;
            labelSelectegCat.Font = new Font("Segoe UI", 14F);
            labelSelectegCat.ForeColor = SystemColors.Window;
            labelSelectegCat.Location = new Point(203, 178);
            labelSelectegCat.Name = "labelSelectegCat";
            labelSelectegCat.Size = new Size(101, 25);
            labelSelectegCat.TabIndex = 8;
            labelSelectegCat.Text = "Категория";
            // 
            // buttonDeleteNote
            // 
            buttonDeleteNote.BackColor = Color.FromArgb(82, 83, 85);
            buttonDeleteNote.ForeColor = Color.White;
            buttonDeleteNote.Location = new Point(473, 476);
            buttonDeleteNote.Name = "buttonDeleteNote";
            buttonDeleteNote.Size = new Size(75, 23);
            buttonDeleteNote.TabIndex = 9;
            buttonDeleteNote.Text = "Удалить";
            buttonDeleteNote.UseVisualStyleBackColor = false;
            buttonDeleteNote.MouseClick += buttonDeleteNote_MouseClick;
            // 
            // EditNoteForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 33, 36);
            ClientSize = new Size(684, 561);
            Controls.Add(buttonDeleteNote);
            Controls.Add(labelSelectegCat);
            Controls.Add(labelCategories);
            Controls.Add(dateNote);
            Controls.Add(textDateNote);
            Controls.Add(label_name);
            Controls.Add(buttonCloseNote);
            Controls.Add(buttonSaveNote);
            Controls.Add(richTextBoxEditText);
            Controls.Add(textBoxEditTitle);
            ForeColor = SystemColors.Window;
            MaximizeBox = false;
            Name = "EditNoteForm";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxEditTitle;
        private RichTextBox richTextBoxEditText;
        private Button buttonSaveNote;
        private Button buttonCloseNote;
        private Label label_name;
        private Label textDateNote;
        private Label dateNote;
        private Label labelCategories;
        private Label labelSelectegCat;
        private Button buttonDeleteNote;
    }
}