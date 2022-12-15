namespace _100Days.ConsoleApp
{
    public class Singleton
    {
        private Singleton()
        {
            _instance = new Singleton();
        }
        private static Singleton _instance;
        public static Singleton Instance
        {
            get
            {
                return _instance == null ? new Singleton() : _instance;
            }

        }
        public string CompanyName;
    }
}