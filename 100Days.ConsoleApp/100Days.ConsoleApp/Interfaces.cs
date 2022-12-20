namespace _100Days.ConsoleApp
{
    public interface IInterfaces
    {
        int Add(int a, int b);
        void Add();

        public void Test()
        {
            Console.WriteLine("abc");
        }
    }
    public class ABC : IInterfaces
    {
        public int Add(int a, int b)
        {
            return 0;
        }
        public void Add()
        {
            //something
        }
        public void Testing()
        {

        }
    }

    public class Interface : IInterfaces
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
        public void Add()
        {
            //something
        }
        private void ABCTest()
        {

        }
    }
}
