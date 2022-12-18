namespace _100Days.ConsoleApp
{
    public class Inheritance
    {

    }
    public class LivingThings
    {
        protected string Name;
        public LivingThings()
        {
            Name = "Default";
        }
        public LivingThings(string name)
        {
            Name = name;
        }
        public void Eat()
        {
            Console.WriteLine("Living things can eat");

        }
    }

    public class Animal : LivingThings
    {
        public Animal() : base()
        {
            Name = "Animal";
        }
        public Animal(string name)  : base(name)
        {
            Name = name;
        }
        public void Eat()
        {
            Console.WriteLine("Animal can eat");

        }
    }
    public class Plant : LivingThings
    {
        public Plant() : base("Default")
        {

        }
        public void Eat()
        {
            Console.WriteLine("Plant can grow");
        }
    }  
    public class Vertibrates : Animal
    {
        public Vertibrates() : base()
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
