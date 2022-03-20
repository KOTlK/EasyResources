using UnityEngine;

namespace EasyResources.Internal
{
    internal class ResourceManager
    {
        private readonly IResourcesDataStorage _dataStorage;
    
        public ResourceManager()
        {
            _dataStorage = new ResourcesDataStorage();
        }
    
        public bool TryLoadResource<T>(string name, out T resource)
            where T : UnityEngine.Object
        {
            var path = _dataStorage.TryGetPath(name);
            resource = Resources.Load<T>(path);
            return resource != null;
        }
    
        public T InstantiateResource<T>(string name)
            where T : UnityEngine.Object
        {
            if (TryLoadResource<T>(name, out var resource))
            {
                var component = MonoBehaviour.Instantiate(resource);
                return component;
            }

            throw new System.Exception("Cant Instantiate: resourse is null");
        }

        public T InstantiateResource<T>(string name, Transform parent)
            where T : UnityEngine.Object
        {
            if (TryLoadResource<T>(name, out var resource))
            {
                var component = MonoBehaviour.Instantiate(resource, parent);
                return component;
            }

            throw new System.Exception("Cant Instantiate: resourse is null");
        }

        public T InstantiateResource<T>(string name, Vector3 position, Quaternion rotation, Transform parent)
            where T : UnityEngine.Object
        {
            if (TryLoadResource<T>(name, out var resource))
            {
                var component = MonoBehaviour.Instantiate(resource, position, rotation, parent);
                return component;
            }

            throw new System.Exception("Cant Instantiate: resourse is null");
        }

        public T InstantiateResource<T>(string name, Vector3 position, Quaternion rotation)
            where T : UnityEngine.Object
        {
            if (TryLoadResource<T>(name, out var resource))
            {
                var component = MonoBehaviour.Instantiate(resource, position, rotation);
                return component;
            }

            throw new System.Exception("Cant Instantiate: resourse is null");
        }
    }
}




