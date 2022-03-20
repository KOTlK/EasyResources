using System;
using UnityEngine;
using System.IO;

namespace EasyResources.Internal.Data
{
    internal class ResourcesDataSaver : IDataSaver
    {
        private readonly ResourceParser _parser = new ResourceParser();

        private readonly string _resourcesFileName = "SpawningResources.json";

        public void SaveData(string pathToResources)
        {
            var resourcesDirectoryPath = $"{pathToResources}/EasySpawning";
            var resourcesFilePath = $"{resourcesDirectoryPath}/{_resourcesFileName}";

            DeleteFile(resourcesFilePath);
            CreateFile(resourcesDirectoryPath, resourcesFilePath);
            
            var resources = _parser.Parse(pathToResources);

            WriteData(resources, resourcesFilePath);
        }

        private void WriteData(Resource[] resources, string resourcesFilePath)
        {
            Debug.Log("Started writing data");
            foreach (var resource in resources)
            {
                var json = JsonUtility.ToJson(resource);

                File.AppendAllText(resourcesFilePath, json + Environment.NewLine);
            }
            Debug.Log("Data is writed");
        }

        private void DeleteFile(string path)
        {
            if (File.Exists(path)) File.Delete(path);
        }

        private void CreateFile(string directoryPath, string filePath)
        {
            if (Directory.Exists(directoryPath) == false) Directory.CreateDirectory(directoryPath);

            if (File.Exists(filePath) == false) File.Create(filePath).Close();

        }
    }
}
