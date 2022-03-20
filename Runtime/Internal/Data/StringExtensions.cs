namespace EasyResources.Internal.Data
{
    internal static class StringExtensions
    {
        public static string GetPathInResources(this string path)
        {
            var resources = @"Resources\";
            return path.Substring(path.LastIndexOf(resources) + resources.Length);
        }

        public static string RemoveExtension(this string path)
        {
            if (path == null) return null;
            return path.Substring(0, path.LastIndexOf("."));
        }

        public static string ExcludeMeta(this string path)
        {
            if (path.EndsWith(".meta"))
            {
                return null;
            }
            return path;
        }

        public static string ReplaceSlashes(this string path)
        {
            return path.Replace("\\", "/");
        }

        public static string RemoveName(this string path, string name)
        {
            if (name == null) return null;
            if (path.LastIndexOf("/" + name) <= 0) return path;
            return path.Substring(0, path.LastIndexOf("/" + name));
        }

    }
}
