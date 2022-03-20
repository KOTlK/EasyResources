using UnityEngine;
using EasyResources.Internal;
using Object = UnityEngine.Object;

namespace EasyResources
{ 
    public class EasySpawning
    {
        private static ResourceManager _resourceManager;

        public EasySpawning()
        {
            _resourceManager = new ResourceManager();
        }

        public static bool TryLoadResource<T>(string name, out T resource)
            where T : Object
            => _resourceManager.TryLoadResource<T>(name, out resource);

        public static T InstantiateResource<T>(string name)
            where T : Object 
            => _resourceManager.InstantiateResource<T>(name);

        public static T InstantiateResource<T>(string name, Transform parent)
            where T : Object 
            => _resourceManager.InstantiateResource<T>(name, parent);

        public static T InstantiateResource<T>(string name, Vector3 position, Quaternion rotation, Transform parent)
            where T : Object 
            => _resourceManager.InstantiateResource<T>(name, position, rotation, parent);

        public static T InstantiateResource<T>(string name, Vector3 position, Quaternion rotation)
            where T : Object 
            => _resourceManager.InstantiateResource<T>(name, position, rotation);
    }
}

