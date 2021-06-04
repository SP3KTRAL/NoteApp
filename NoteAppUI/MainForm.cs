using System;
using System.Collections.Generic;
using System.Linq;
using NoteApp;
using System.Windows.Forms;

namespace NoteAppUI
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// Список заметок
        /// </summary>
        Project _project;

        /// <summary>
        /// Список заметок выбранной категории
        /// </summary>
        private List<Note> _displayedNotes = new List<Note>();

        public MainForm()
        {
            InitializeComponent();

            string path = ProjectManager.DefaultPath + ProjectManager.FileName;
            _project = ProjectManager.Load(path);

            var categories = Enum.GetValues(typeof(NoteCategory)).Cast<NoteCategory>().ToList();
            noteCategoryComboBox.Items.Add("All");
            foreach (var category in categories)
            {
                noteCategoryComboBox.Items.Add(category);
            }

            noteCategoryComboBox.SelectedIndex = 0;
            SelectFirstItem();
        }

        /// <summary>
        /// Сохраняет заметки
        /// </summary>
        private void Save()
        {
            string path = ProjectManager.DefaultPath + ProjectManager.FileName;
            ProjectManager.Save(_project, path);
        }

        /// <summary>
        /// Создаёт заметку
        /// </summary>
        private void CreateNote()
        {
            Note note = new Note();
            NoteForm noteForm = new NoteForm
            {
                Note = note
            };
            if (noteForm.ShowDialog() == DialogResult.OK)
            {
                AddNote(noteForm.Note);
            }

            SelectFirstItem();
        }

        /// <summary>
        /// Изменяет заметку
        /// </summary>
        /// <param name="note">Изменяемая заметка</param>
        private void EditNote(Note note)
        {
            NoteForm noteForm = new NoteForm();
            noteForm.Note = note;

            if (noteForm.ShowDialog() == DialogResult.OK)
            {
                RemoveNote(titleNoteListBox.SelectedIndex);
                AddNote(noteForm.Note);
            }

            SelectFirstItem();
        }

        /// <summary>
        /// Выбирает первую заметку в списке
        /// </summary>
        private void SelectFirstItem()
        {
            if (_displayedNotes.Count != 0)
            {
                titleNoteListBox.SelectedIndex = 0;
            }
        }

        /// <summary>
        /// Удаляет заметку
        /// </summary>
        /// <param name="index">Индекс удаляемой заметка</param>
        private void RemoveNote(int index)
        {
            Note selectNote = _displayedNotes[index];
            int indexRem = _project.Notes.IndexOf(selectNote);

            _project.Notes.RemoveAt(indexRem);
            _displayedNotes.RemoveAt(index);
            titleNoteListBox.Items.RemoveAt(index);
        }

        /// <summary>
        /// Добавляет заметку в список
        /// </summary>
        /// <param name="note">Добавляемая заметка</param>
        private void AddNote(Note note)
        {
            _project.Notes.Insert(0, note);

            if (noteCategoryComboBox.SelectedItem.ToString() == "All")
            {
                titleNoteListBox.Items.Insert(0, note.Title);
                _displayedNotes.Insert(0, note);
            }
            else if ((NoteCategory)noteCategoryComboBox.SelectedItem == note.NoteCategory)
            {
                titleNoteListBox.Items.Insert(0, note.Title);
                _displayedNotes.Insert(0, note);
            }
        }

        /// <summary>
        /// Проверка, выбрана ли заметка для редактирования
        /// </summary>
        private void CheckNote()
        {
            if (titleNoteListBox.SelectedIndex != -1)
            {
                EditNote(_displayedNotes[titleNoteListBox.SelectedIndex]);
            }
            else
            {
                MessageBox.Show(@"Select a note to edit!");
            }
        }

        private void removeNoteButton_Click(object sender, EventArgs e)
        {
            RemoveNote(titleNoteListBox.SelectedIndex);
            SelectFirstItem();
            Save();
        }

        private void editNoteButton_Click(object sender, EventArgs e)
        {
            CheckNote();
            Save();
        }

        private void addNoteButton_Click(object sender, EventArgs e)
        {
            CreateNote();
            Save();
        }

        private void noteCategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            titleNoteListBox.Items.Clear();
            _displayedNotes.Clear();

            foreach (var note in _project.Notes)
            {
                if (noteCategoryComboBox.SelectedItem.ToString() == "All")
                {
                    titleNoteListBox.Items.Add(note.Title);
                    _displayedNotes.Add(note);
                }
                else if (note.NoteCategory == (NoteCategory) noteCategoryComboBox.SelectedItem)
                {
                    titleNoteListBox.Items.Add(note.Title);
                    _displayedNotes.Add(note);
                }
            }
            SelectFirstItem();
        }

        private void titleNoteListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (titleNoteListBox.SelectedIndex == -1)
            {
                titleNoteLabel.Text = "";
                catrgoryNoteLabel.Text = "";
                createdNoteLabel.Text = "";
                modifiedNoteLabel.Text = "";
                textNoteRichTextBox.Text = "";
            }
            else
            {
                var note = _displayedNotes[titleNoteListBox.SelectedIndex];
                titleNoteLabel.Text = note.Title;
                catrgoryNoteLabel.Text = note.NoteCategory.ToString();
                createdNoteLabel.Text = note.Created.ToLongDateString();
                modifiedNoteLabel.Text = note.Modified.ToLongDateString();
                textNoteRichTextBox.Text = note.NoteText;
            }
        }

        private void addNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateNote();
            Save();
        }

        private void removeNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoveNote(titleNoteListBox.SelectedIndex);
            SelectFirstItem();
            Save();
        }

        private void editNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CheckNote();
            Save();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Save();
            Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.Show();
        }
    }
}
