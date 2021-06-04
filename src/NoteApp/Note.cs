using System;
using Newtonsoft.Json;

namespace NoteApp
{
    /// <summary>
    /// Класс заметки, хранящий информацию о названии, категории
    /// заметки, тексте заметки, дате создания и дате последнего
    /// изменения.
    /// </summary>
    public class Note : ICloneable, IEquatable<Note>
    {
        /// <summary>
        /// Название заметки.
        /// </summary>
        private string _title;

        /// <summary>
        /// Категория заметки.
        /// </summary>
        private NoteCategory _noteCategory;

        /// <summary>
        /// Текст заметки.
        /// </summary>
        private string _noteText;

        /// <summary>
        /// Дата создания заметки.
        /// </summary>
        private DateTime _created;

        /// <summary>
        /// Дата сохранения заметки.
        /// </summary>
        private DateTime _modified;

        /// <summary>
        /// Возвращает и задаёт название заметки.
        /// </summary>
        public string Title
        {
            get { return _title; }
            set
            {
                if (value.Length == 0)
                {
                    value = "Untitle";
                }

                if (value.Length > 50)
                {
                    throw new ArgumentException($"The name should not exceed 50 characters, but it was: { value.Length }!");
                }

                _title = value;
                _modified = DateTime.Now;
            }
        }

        /// <summary>
        /// Возвращает и задаёт категорию заметки.
        /// </summary>
        public NoteCategory NoteCategory
        {
            get
            {
                return _noteCategory;
            }
            set
            {
                _noteCategory = value;
                _modified = DateTime.Now;
            }
        }

        /// <summary>
        /// Возвращает и задаёт текст заметки.
        /// </summary>
        public string NoteText
        {
            get
            {
                return _noteText;
            }
            set
            {
                _noteText = value;
                _modified = DateTime.Now;
            }
        }

        /// <summary>
        /// Возвращает время создания.
        /// </summary>
        public DateTime Created
        {
            get { return _created; }
            private set { _created = value; }
        }

        /// <summary>
        /// Возвращает и задаёт время последнего изменения.
        /// </summary>
        public DateTime Modified
        {
            get { return _modified; }
            set { _modified = value; }
        }

        /// <summary>
        /// Конструктор, задающий время создания.
        /// </summary>
        public Note()
        {
            Created = DateTime.Now;
            Modified = DateTime.Now;
        }

        [JsonConstructor]
        private Note(string title, NoteCategory noteCategory, string noteText, DateTime created, DateTime modified)
        {
            Title = title;
            NoteCategory = noteCategory;
            NoteText = noteText;
            Created = created;
            Modified = modified;
        }

        public Note(DateTime time)
        {
            Created = time;
            Modified = time;
        }

        public object Clone()
        {
            return MemberwiseClone();
        }

        public bool Equals(Note other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return _title == other._title 
                   && _noteCategory == other._noteCategory 
                   && _noteText == other._noteText 
                   && _created.Equals(other._created) 
                   && _modified.Equals(other._modified);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Note) obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = (_title != null ? _title.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (int) _noteCategory;
                hashCode = (hashCode * 397) ^ (_noteText != null ? _noteText.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ _created.GetHashCode();
                hashCode = (hashCode * 397) ^ _modified.GetHashCode();
                return hashCode;
            }
        }
    }
}
