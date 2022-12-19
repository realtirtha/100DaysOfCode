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
        public virtual void Eat()
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
        public override void Eat()
        {
            Console.WriteLine("Animal can eat");

        }
    }
    public class Plant : LivingThings
    {
        public Plant() : base("Default")
        {

        }
        public override void Eat()
        {
            Console.WriteLine("Plant can grow");
        }
    }  
    public class Vertibrates : Animal
    {
        public Vertibrates() : base()
        {

        }
        public virtual void Eats()
        {
            Console.WriteLine("Vertibrates can eat");
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
        public override void Eats()
        {
            Console.WriteLine("Humans can eat");
        }
    }
}
