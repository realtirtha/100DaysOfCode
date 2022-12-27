namespace _100Days.ConsoleApp
{
    public abstract class AbstractClass
    {
        public void FunctionOne()
        { 
           Console.WriteLine("I'm from function one");
        }
        protected abstract void FunctionTwo();
        
        
        
    }

    public abstract class AShape 
    {
        protected double area;
        protected double perimeter;
        
        public void Area()
        {
            Console.WriteLine($"Area =  {area}");
        }
        public void Perimeter()
        {
            Console.WriteLine($"Perimeter =  {Perimeter}");
        }
        public void GetInput()
        {
            getInput();
            calculate();
        }

        protected abstract void getInput();
        protected abstract void calculate();
    }
    public class ASquare : AShape
    {
        private double length;
        protected override void calculate()
        {
            area = Math.Pow(length, 2);
            perimeter = 4 * length;
        }

        protected override void getInput()
        {
            Console.WriteLine("Enter the length");
            length = Convert.ToDouble(Console.ReadLine());
        }
    }
}
