namespace EasyResources.Internal
{
    internal interface IResourcesDataStorage
    {
        string TryGetPath(string name);
    }
}