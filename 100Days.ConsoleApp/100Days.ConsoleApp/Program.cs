namespace _100Days.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            var res = "n";
            do
            {

            //ControlStatementExample();

            LoopingStatement();
            
            Console.WriteLine("Do you want to run once more? (y/n)");

            }while(res.ToUpper() == "Y");
        }

         static void LoopingStatement()
        {
            //known quantity and unknown quantity
            //for, foreach, while, do while
            //unknown: while & do while

        }

        static void ControlStatementExample()
        {
            Console.WriteLine("Enter the number of day:");
            var num = Convert.ToInt32(Console.ReadLine());

            ifElseStatement(num);

            SwitchStatement(num);

            Ternary(num);
        }

        private static void Ternary(int num)
        {
            Console.WriteLine("via: ternary");
            //(condition) ? <true statement> :<false statement>
            var day = (num == 1) ? "sunday" : (num == 2) ? "monday" : (num == 3) ? "tuesday" : (num == 4) ? "wednesday" : (num == 5) ? "thursday" : (num == 6) ? "friday" : (num == 7) ? "saturday" : "not valid";
        }

        private static void ifElseStatement(int num)
        {
            Console.WriteLine("via ifElseStatement:");

            if (num == 1) Console.WriteLine("sunday");
            if (num == 2) Console.WriteLine("monday");
            if (num == 3) Console.WriteLine("tuesday");
            if (num == 4) Console.WriteLine("wednesday");
            if (num == 6) Console.WriteLine("thursday");
            if (num == 6) Console.WriteLine("friday");
            if (num == 7) Console.WriteLine("saturday");
            else Console.WriteLine("not valid option");
        }


        private static void SwitchStatement(int num)
        {
            Console.WriteLine("via: switch case");

            switch (num)
            {
                case 1:
                    Console.WriteLine("sunday");
                    break;
                case 2:
                    Console.WriteLine("monday");
                    break;
                case 3:
                    Console.WriteLine("tuesday");
                    break;
                case 4:
                    Console.WriteLine("wednesday");
                    break;
                case 5:
                    Console.WriteLine("thursday");
                    break;
                case 6:
                    Console.WriteLine("friday");
                    break;
                case 7:
                    Console.WriteLine("saturday");
                    break;
                default:
                    Console.WriteLine("not a valid input");
                    break;
            }
        }
    }
}