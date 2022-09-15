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

    public class StudentInfo
    {
        public StudentInfo()
        {
            Name = "Babu";
        }
        public StudentInfo(string name)
        {
            Name = name;
        }

        public string Name;
    }

}