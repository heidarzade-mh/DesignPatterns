namespace Singleton
{
    public class SingletonInstance
    {
        private SingletonInstance _instance;
        private SingletonInstance() {}

        public SingletonInstance GetInstance()
        {
            if (_instance == null)
            {
                _instance = new SingletonInstance();
            }

            return _instance;
        }
    }
}