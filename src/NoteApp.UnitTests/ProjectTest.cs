using NUnit.Framework;

namespace NoteApp.UnitTests
{
    [TestFixture]
    public class ProjectTest
    {
        [Test(Description = "Позитивный тест Project")]
        public void TestProject_CorrectValue()
        {
            //Setup
            var project = new Project();
            var note = new Note();
            note.Title = "Домашка";
            note.NoteCategory = NoteCategory.Documents;
            note.NoteText = "Параграф №16, задачи №16.2, 16.3(а,б).";
            project.Notes.Add(note);
            //Act
            var actual = project;
            //Assert
            Assert.AreEqual(project, actual, "Project возвращает или заполняет неправильный проект");
        }
    }
}
