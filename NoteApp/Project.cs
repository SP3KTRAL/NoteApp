using System.Collections.Generic;

namespace NoteApp
{
    /// <summary>
    /// Класс проекта, содержащий список всех заметок.
    /// </summary>
    public class Project
    {
        /// <summary>
        /// Возвращает и задаёт заметки.
        /// </summary>
        public List<Note> Notes { get; set; } = new List<Note>();
    }
}
