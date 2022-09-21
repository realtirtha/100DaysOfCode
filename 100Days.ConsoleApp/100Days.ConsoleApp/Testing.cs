namespace _100Days.ConsoleApp
{
    public class HumanBeing
    {
        //constructors
        //variables
        //properties
        //methods / functions

        //delegate and events

        //destructor / Garbage collector (GC), IDisposable pattern 


        //Constructors
        //1. special function
        //2. runs only once in its lifetime
        //3. Name is same as that of class name
        //4. No return type
        //5. Access modifiers: Private (singleton pattern), protected, public, static (not a access modifier)
        //6. Can be overloaded
        public HumanBeing()
        {
                
        }

        public HumanBeing(int i)
        {
             
        }

        public HumanBeing(long y)
        {

        }

        public readonly int age = 0;

    }

    public class Test
    {
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

            var totalMin = firstTerm.Min + secondTerm.Min + finalTerm.Min;
            var totalMax = firstTerm.Max + secondTerm.Max + finalTerm.Max;
            var totalPass = firstTerm.Pass + secondTerm.Pass + finalTerm.Pass;

            StudentInfo total = new StudentInfo(totalMin, totalMax, totalPass)
            {

            };

            total.Math = firstTerm.Math + secondTerm.Math + finalTerm.Math;
            total.Science = firstTerm.Science + secondTerm.Science + finalTerm.Science;
        }
    }
}