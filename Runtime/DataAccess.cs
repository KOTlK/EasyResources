using EasyResources.Internal.Data;

namespace EasyResources
{
    public class DataAccess
    {
        private IDataSaver _dataSaver;

        public DataAccess()
        {
            _dataSaver = new ResourcesDataSaver();
        }
        

        public void SaveData(string pathToResources)
        {
            _dataSaver.SaveData(pathToResources);
        }
    }
}

