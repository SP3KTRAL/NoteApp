using System;
using System.IO;
using NUnit.Framework;

namespace NoteApp.UnitTests
{
    [TestFixture]
    public class ProjectManagerTest
    {
        private const string CorrectedProjectFilename = @"TestData\correctprojectfile.json";

        private const string OutputProjectFilename = @"Output\savedFile.json";

        private Project GetCorrectProject()
        {
            var correctProject = new Project();

            var note = new Note(new DateTime(2021, 05, 18));
            note.Title = "Домашка";
            note.NoteCategory = NoteCategory.Documents;
            note.NoteText = "Параграф №16, задачи №16.2, 16.3(а,б).";
            note.Modified = new DateTime(2021, 05, 18);
            correctProject.Notes.Add(note);

            note = new Note(new DateTime(2021, 05, 18));
            note.Title = "Домашка1";
            note.NoteCategory = NoteCategory.Documents;
            note.NoteText = "Параграф №161, задачи №161.2, 161.3(а,б).";
            note.Modified = new DateTime(2021, 05, 18);
            correctProject.Notes.Add(note);

            return correctProject;
        }

        [TestCase(Description = "Позитивный тест проджект")]
        public void LoadProject_SaveCorrectData_FileSavedCorrectly()
        {
            //Setup
            var expectedProject = GetCorrectProject();

            //Act
            var actualProject = ProjectManager.Load(CorrectedProjectFilename);

            //Assert
            Assert.AreEqual(expectedProject.Notes.Count, actualProject.Notes.Count);

            Assert.Multiple(() =>
            {
                for (int i = 0; i < expectedProject.Notes.Count; i++)
                {
                    var expected = expectedProject.Notes[i];
                    var actual = actualProject.Notes[i];

                    Assert.AreEqual(expected, actual);
                }
            });
        }

        [TestCase(Description = "Повреждённый файл")]
        public void LoadProject_LoadCorruptedData_FileLoadEmpty()
        {
            //Setyp
            var expectedProject = new Project();

            //Act
            var actualProject = ProjectManager.Load(@"TestData\corruptedprojectfile.json");

            //Assert
            Assert.AreEqual(expectedProject.Notes.Count, actualProject.Notes.Count);

            Assert.Multiple(() =>
            {
                for (int i = 0; i < expectedProject.Notes.Count; i++)
                {
                    var expected = expectedProject.Notes[i];
                    var actual = actualProject.Notes[i];

                    Assert.AreEqual(expected, actual);
                }
            });
        }

        [TestCase(Description = "Пустой файл")]
        public void LoadProject_LoadEmptyData_FileLoadEmpty()
        {
            //Setup
            var expectedProject = new Project();

            //Act
            var actualProject = ProjectManager.Load(@"TestData\emptyprojectfile.json");

            //Assert
            Assert.AreEqual(expectedProject.Notes.Count, actualProject.Notes.Count);

            Assert.Multiple(() =>
            {
                for (int i = 0; i < expectedProject.Notes.Count; i++)
                {
                    var expected = expectedProject.Notes[i];
                    var actual = actualProject.Notes[i];

                    Assert.AreEqual(expected, actual);
                }
            });
        }

        [TestCase(Description = "Загрузка файла")]
        public void SaveToFile_SaveCorrectedData_FileSaveCorrectly()
        {
            //Setup
            var savingProject = GetCorrectProject();
            Directory.Delete(@"Output",true);

            //Act
            ProjectManager.Save(savingProject, OutputProjectFilename);

            //Assert
            var actual = File.ReadAllText(OutputProjectFilename);
            var expected = File.ReadAllText(CorrectedProjectFilename);

            Assert.AreEqual(expected, actual);
        }
    }
}
