using NUnit.Framework;

namespace NoteApp.UnitTests
{
    [TestFixture]
    public class ProjectTest
    {
        [Test]
        public void TestProject_CorrectValue()
        {
            //Setup
            var project = new Project();

            //Act
            var actual = 0;

            //Assert
            Assert.AreEqual(project.Notes.Count, actual);
        }
    }
}
