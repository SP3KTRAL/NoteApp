using System;
using NUnit.Framework;

namespace NoteApp.UnitTests
{
    [TestFixture]
    public class NoteTest
    {
        [Test]
        public void TestTitleGet_CorrectValue()
        {
            //Setup
            var note = new Note();
            var expected = "Домашка";
            note.Title = expected;

            //Act
            var actual = note.Title;

            //Assert
            Assert.AreEqual(expected, actual, "Геттер Title возвращает неправильную фамилию");
        }

        [Test]
        public void TestTitleSet_EmptyString_ReturnsDefaultValue()
        {
            //Setup
            var note = new Note();
            var wrongTitle = string.Empty;
            note.Title = wrongTitle;

            //Act
            var actual = "Untitle";

            //Assert
            Assert.AreEqual(note.Title, actual, "Cеттер Title неправильно заполняет название");
        }

        [Test]
        public void TestTitleSet_Longer50Symbols_ThrowsExceptions()
        {
            //Setup
            var note = new Note();
            var wrongTitle = "Домашка-Домашка-Домашка-Домашка-Домашка-Домашка-Домашка";

            //Assert
            Assert.Throws<ArgumentException>(
                () =>
                {
                    //Act
                    note.Title = wrongTitle;
                },
                "Должно возникать исключение, если название длиннее 50 символов");
        }

        [Test]
        public void TestNoteCategory_CorrectValue_ReturnCorrectValue()
        {
            //Setup
            var note = new Note();
            var expected = NoteCategory.Other;
            note.NoteCategory = expected;

            //Act
            var actual = note.NoteCategory;

            //Assert
            Assert.AreEqual(expected, actual, "NoteCategory возвращает неправильную категорию");
        }

        [Test]
        public void TestNoteText_CorrectValue_ReturnCorrectValue()
        {
            //Setup
            var note = new Note();
            var expected = "Параграф №16, задачи №16.2, 16.3(а,б).";
            note.NoteText = expected;

            //Act
            var actual = note.NoteText;

            //Assert
            Assert.AreEqual(expected, actual, "NoteText возвращает неправильный текст");
        }

        [Test]
        public void TestCreated_CorrectValue_ReturnCorrectValue()
        {
            //Setup
            var time = new DateTime(2021, 05, 18);

            var note = new Note(time);
            var expected = note.Created;

            //Act
            var actual = time;

            //Assert
            Assert.AreEqual(expected, actual, "Геттер Created возвращает неправильное время");
        }

        [Test]
        public void TestModified_CorrectValue_ReturnCorrectValue()
        {
            //Setup
            var note = new Note();
            note.NoteText = "Параграф №16, задачи №16.2, 16.3(а,б).";
            var expected = DateTime.Now;

            //Act
            var actual = note.Modified;

            //Assert
            Assert.AreEqual(expected, actual, "Геттер Modified возвращает неправильное время");
        }
    }
}