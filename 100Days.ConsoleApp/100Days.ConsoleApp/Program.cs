namespace _100Days.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            ControlStatementExample();

        }

        static void ControlStatementExample()
        {
            Console.WriteLine("Enter the number of day:");
            var num = Convert.ToInt32(Console.ReadLine());


        }
    }
}