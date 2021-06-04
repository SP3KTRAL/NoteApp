using System;
using System.IO;
using Newtonsoft.Json;

namespace NoteApp
{
    /// <summary>
    /// Методы, реализующие сохранения
    /// объекта «Проект» в файл и загрузки проекта из 
    /// файла.
    /// </summary>
    public static class ProjectManager
    {
        public static readonly string DefaultPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\Belov\NoteApp\";
        public static readonly string FileName = "project.json";

        /// <summary>
        /// Cериализация. Метод, сохраняющий объект «Проект» в файл.
        /// </summary>
        /// <param name="project"></param>
        public static void Save(Project project, string path)
        {
            string pathFolder = Path.GetDirectoryName(path);
            DirectoryInfo directoryInfo = new DirectoryInfo(pathFolder);
            if (!directoryInfo.Exists)
            {
                directoryInfo.Create();
            }

            JsonSerializer serializer = new JsonSerializer();
            using (StreamWriter sw = new StreamWriter(path))
            using (JsonWriter writer = new JsonTextWriter(sw))
            {
                serializer.Serialize(writer, project);
            }
        }

        /// <summary>
        /// Десериализация. Метод, загружающий проект из файла.
        /// </summary>
        public static Project Load(string path)
        {
            Project project = new Project();

            string pathFolder = Path.GetDirectoryName(path);
            DirectoryInfo directoryInfo = new DirectoryInfo(pathFolder);
            if (!directoryInfo.Exists)
            {
                return project;
            }

            if (!File.Exists(path))
            {
                return project;
            }

            JsonSerializer serializer = new JsonSerializer();
            using (StreamReader sr = new StreamReader(path))
            using (JsonReader reader = new JsonTextReader(sr))
            {
                try
                {
                    project = serializer.Deserialize<Project>(reader);
                }
                catch (Exception e)
                {
                    return new Project();
                }
            }

            if (project == null)
            {
                return new Project();
            }

            return project;
        }
    }
}
