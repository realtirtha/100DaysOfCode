namespace _100Days.ConsoleApp
{
    public class Inheritance
    {

    }
    public class LivingThings
    {
        public string Name;
        public LivingThings()
        {
            Name = "Default";
        }
        public LivingThings(string name)
        {
            Name = name;
        }
    }

    public class Animal : LivingThings
    {
        public Animal()
        {
            Name = "Animal";
        }
        public Animal(string name)
        {
            Name = name;
        }
    }
    public class Plant : LivingThings
    {
        public Plant()
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
