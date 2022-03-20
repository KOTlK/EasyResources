using System.Collections.Generic;
using System.IO;

namespace EasyResources.Internal.Data
{
    internal class ResourceParser
    {
        private readonly List<Resource> _resources = new List<Resource>();

        public Resource[] Parse(string path)
        {
            if (Directory.Exists(path))
            {
                if (Directory.GetFiles(path).Length > 0)
                {
                    foreach (var file in Directory.GetFiles(path))
                    {
                        var fileName = Path.GetFileName(file).ExcludeMeta().RemoveExtension();

                        var formattedPath = file.GetPathInResources().RemoveExtension().ReplaceSlashes().RemoveName(fileName);

                        if (fileName != null)
                        {
                            var resource = new Resource() {Name = fileName, Path = formattedPath };
                            _resources.Add(resource);
                        }
                    }
                }

                foreach (var directory in Directory.GetDirectories(path))
                {
                    Parse(directory);
                }
            }
            
            return _resources.ToArray();
        }
    }
}
