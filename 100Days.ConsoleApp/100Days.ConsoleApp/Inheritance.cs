namespace _100Days.ConsoleApp
{
    public class Inheritance
    {

    }
    public class LivingThings
    {
        protected string Name;
        //public LivingThings()
        //{
        //    Name = "Default";
        //}
        public LivingThings(string name)
        {
            Name = name;
        }
    }

    public class Animal : LivingThings
    {
        public Animal() : base("Default")
        {
            Name = "Animal";
        }
        public Animal(string name) : base(name)
        {
            Name = name;
        }
    }
    public class Plant : LivingThings
    {
        public Plant() : base("Default")
        {

        }
    }  
    public class Vertibrates : Animal
    {
        public Vertibrates()
        {

        }
    }
    public class Invertibrates : Animal
    {
        public Invertibrates()
        {

        }
    }
    public class Human : Vertibrates
    {
        public Human()
        {

        }
    }
}
