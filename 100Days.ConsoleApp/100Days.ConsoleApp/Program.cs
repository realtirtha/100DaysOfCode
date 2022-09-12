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

            if (num==1)
            {
                Console.WriteLine("sunday");
            }
            else if (num == 2)
            {
                Console.WriteLine("monday");
            }
            else if (num == 3)
            {
                Console.WriteLine("tuesday");
            }
            else if (num == 4)
            {
                Console.WriteLine("wednesday");
            }
            else if (num == 5)
            {
                Console.WriteLine("thursday");
            }
            else if (num == 6)
            {
                Console.WriteLine("friday");
            }
            else if (num == 7) 
            {
                Console.WriteLine("saturday");
            }

        }
    }
}