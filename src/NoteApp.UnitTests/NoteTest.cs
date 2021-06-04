using System;
using NUnit.Framework;

namespace NoteApp.UnitTests
{
    [TestFixture]
    public class NoteTest
    {
        private Note _note;

        [Test(Description = "Позитивный тест геттера Title")]
        public void TestTitleGet_CorrectValue()
        {
            //Setup
            _note = new Note();
            var expected = "Домашка";
            _note.Title = expected;
            //Act
            var actual = _note.Title;
            //Assert
            Assert.AreEqual(expected, actual, "Геттер Title возвращает неправильную фамилию");
        }

        [Test(Description = "Присвоение пустой строки в качестве названия")]
        public void TestTitleSet_EmptyString()
        {
            //Setup
            _note = new Note();
            var wrongTitle = string.Empty;
            _note.Title = wrongTitle;
            //Act
            var actual = "Untitle";
            //Assert
            Assert.AreEqual(_note.Title, actual, "Cеттер Title неправильно заполняет название");
        }

        [Test(Description = "Присвоение неправильного названия больше 50 символов")]
        public void TestTitleSet_Longer50Symbols()
        {
            //Setup
            _note = new Note();
            var wrongTitle = "Домашка-Домашка-Домашка-Домашка-Домашка-Домашка-Домашка";
            //Assert
            Assert.Throws<ArgumentException>(
                () =>
                {
                    //Act
                    _note.Title = wrongTitle;
                },
                "Должно возникать исключение, если название длиннее 50 символов");
        }

        [Test(Description = "Позитивный тест NoteCategory")]
        public void TestNoteCategory_CorrectValue()
        {
            //Setup
            _note = new Note();
            var expected = NoteCategory.Other;
            _note.NoteCategory = expected;
            //Act
            var actual = _note.NoteCategory;
            //Assert
            Assert.AreEqual(expected, actual, "NoteCategory возвращает неправильную категорию");
        }

        [Test(Description = "Позитивный тест NoteText")]
        public void TestNoteText_CorrectValue()
        {
            //Setup
            _note = new Note();
            var expected = "Параграф №16, задачи №16.2, 16.3(а,б).";
            _note.NoteText = expected;
            //Act
            var actual = _note.NoteText;
            //Assert
            Assert.AreEqual(expected, actual, "NoteText возвращает неправильный текст");
        }

        [Test(Description = "Позитивный тест геттера Created")]
        public void TestCreated_CorrectValue()
        {
            //Setup
            _note = new Note();
            var actualCreated = _note.Created;
            //Assert
            Assert.AreEqual(actualCreated, _note.Created, "Геттер Created возвращает неправильное время");
        }

        [Test(Description = "Позитивный тест геттера Modified")]
        public void TestModified_CorrectValue()
        {
            //Setup
            _note = new Note();
            var expected = DateTime.Now;
            _note.Modified = expected;
            //Act
            var actual = _note.Modified;
            //Assert
            Assert.AreEqual(expected, actual, "Геттер Modified возвращает неправильное время");
        }
    }
}