using System.Text;

namespace _100Days.ConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            var res = "n";
            do 
            {
                //SwitchStatement();
                //ifElseStatement();
                //Ternary();
                //ControlStatementExample();
                //LoopingStatement();
                //LoopingExample();
                //StringConcatenation();
                //ClassAndObjects();
                //ClassAndObjectV2();
                //PropertiesExample();
                RegularExpression();

                Console.WriteLine("\n- - - - - - - - - - - - - - - - - - -");

                Console.WriteLine("Do you want to run once more? (y/n)");
                res = Console.ReadLine();

            }while(res.ToUpper() == "Y");
        }

        static void OperatorOverloadingExample()
        {
            StudentInfo firstTerm = new StudentInfo(0, 80, 28);
            firstTerm.Math = 101;
            firstTerm.Science = -1;
            firstTerm.Computer = 123;

            StudentInfo secondTerm = new StudentInfo(0, 80, 28);
            secondTerm.Math = 101;
            secondTerm.Science = -1;
            secondTerm.Computer = 123;

            StudentInfo finalTerm = new StudentInfo(0, 80, 28);
            finalTerm.Math = 101;
            finalTerm.Science = -1;
            finalTerm.Computer = 123;

            //var totalMin = firstTerm.Min + secondTerm.Min + finalTerm.Min;
            //var totalMax = firstTerm.Max + secondTerm.Max + finalTerm.Max;
            //var totalPass = firstTerm.Pass + secondTerm.Pass + finalTerm.Pass;

            //StudentInfo total = new StudentInfo(totalMin, totalMax, totalPass)
            //{
               
            //};
            
            //total.Math = firstTerm.Math + secondTerm.Math + finalTerm. Math;
            //total.Science = firstTerm.Science + secondTerm.Science + finalTerm.Science;
            //total.English = firstTerm.English + secondTerm.English + finalTerm.English;


            StudentInfo final = firstTerm + secondTerm + finalTerm + secondTerm;
        }

        

        static void RegularExpression()
        {
            string mail = "";
            Console.WriteLine("Enter the gmail to check pattern:");
            mail = Console.ReadLine();

            

            Pattern pt = new Pattern(mail);

        }


        static void PropertiesExample()
        {
            StudentInfo si = new StudentInfo(0,80,28);
            si.Math = 101;
            si.Science = -1;
            si.Computer = 123;

            Console.WriteLine($"Total = {si.Total}");
            Console.WriteLine($"Percentage = {si.Percentage}");
            Console.WriteLine($"Division = {si.Division}");

            Console.WriteLine("============================");

            Console.WriteLine("After changin the marks");

            si.Math = 80;
            si.Science = 73;
            si.Computer = -5;

            Console.WriteLine($"Total = {si.Total}");
            Console.WriteLine($"Percentage = {si.Percentage}");
            Console.WriteLine($"Division = {si.Division}");
        }

        static void ClassAndObjectV2()
        {
            try
            {
                //StudentInfo nabin = new StudentInfo("Nabin");
                StudentInfo student = new StudentInfo(0, 80, 32);

                Console.WriteLine("Enter the name:");
                student.Name = Console.ReadLine();

                Console.WriteLine("Enter the age:");
                student.Age = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter the math marks:");
                student.Math = Convert.ToDouble(Console.ReadLine());


                Console.WriteLine($"Info is \nName: {student.Name}\n Age: {student.Age}");
            }
            catch(Exception ex)
            {

                Console.WriteLine(ex.Message);
            }            

        }

        private static void ClassAndObjects()
        {
            HumanBeing nabin = new HumanBeing();
            HumanBeing bhim = new HumanBeing();
            nabin = new HumanBeing();

            Console.WriteLine(nabin.age);
            
            var i = 10l;
            bhim = new HumanBeing(i);

            Console.WriteLine(bhim.age);
            
        }

        private static void StringConcatenation()
        {
            string a = "hello";
            string b = "world";
            string res1 = a + " " + b; //concatenation
            Console.WriteLine(res1);

            //formating
            string template = "{0} {1}";
            var res2 = string.Format(template, a, b);
            Console.WriteLine(res2);

            //string interpolation
            var res3 = $"{a} {b}, => {a} and {b}";
            Console.WriteLine(res3);

            //string builder
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Dear sir,");
            sb.AppendLine("\t I'm doing really well. how about you?");
            var result = sb.ToString();
            Console.WriteLine(result);

        }

        static void LoopingExample()
        {
            string[] days = new string[] { "Sunday", "monday", "tuesday", "wednesday", "thursday", "friday", "saturday" };

            Console.WriteLine("\nusing for loop:");
            for (int i = 0; i < days.Length-1; i++)
            {
                Console.WriteLine(days[i]); 
            }

            Console.WriteLine("\nusing for each loop:\n");
            foreach (var item in days)
            {
                Console.WriteLine(item);
            }
        }

        static void LoopingStatement()
        {
            //known quantity and unknown quantity
            //for, foreach, while, do while
            //unknown: while & do while

            Console.WriteLine("enter the number");
            var num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("=======================================");
            Console.WriteLine("using do while");

            int i = 1;
            do
            {
                if (i == 5)
                {
                    //break;
                    i++;
                    continue;
                }
                Console.WriteLine(num+" x "+i+" "+ " = "+num*i);
                i++;
            } while (i <= 10);

            Console.WriteLine("=======================================");
            Console.WriteLine("using for loop");

            for ( i = 1; i <= 10; i++)
            {
                Console.WriteLine(num + " x " + i + " " + " = " + num * i);
            }

            Console.WriteLine("=======================================");
            Console.WriteLine("using while loop");
             i = 1;
            while (i <= 10)
            {
                Console.WriteLine(num + " x " + i + " " + " = " + num * i);
                i++;
            }

            Console.WriteLine("=======================================");


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