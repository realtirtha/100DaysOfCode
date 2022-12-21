namespace _100Days.ConsoleApp
{
    public interface IInterfaces
    {
        int Add(int a, int b);
        void Add();

        
    }
    public class ABC : IInterfaces
    {
        public int Add(int a, int b)
        {
            return 0;
        }
        public void Add()
        {
            //something
        }
        public void Testing()
        {

        }
    }

    public class Interface : IInterfaces
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
        public void Add()
        {
            //something
        }
        private void ABCTest()
        {

        }
    }

    public interface IShape
    {
        void GetInput();
        void Area();
        void Perimeter();
    }


    public class Square : IShape, IInterfaces
    {
         
        private double length;
        public void GetInput()
        {
            Console.WriteLine("Enter the length");
            length = Convert.ToDouble(Console.ReadLine());
        }
        public void Area()
        {
            var area = Math.Pow(length, 2);
            Console.WriteLine($"Area = {area}");
        }
        public void Perimeter()
        {
            var peri = 4*length;
            Console.WriteLine($"Perimeter = {peri}");
        }

        public int Add(int a, int b)
        {
            throw new NotImplementedException();
        }

        public void Add()
        {
            throw new NotImplementedException();
        }
    }

    public class Rectangle : IShape
    {
        private double length;
        private double breadth;
        public void GetInput()
        {
            Console.WriteLine("Enter the length");
            length = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the Breadth");
            breadth = Convert.ToDouble(Console.ReadLine());
        }
        public void Area()
        {
            var area = length * breadth;
            Console.WriteLine($"Area = {area}");
        }
        public void Perimeter()
        {
            var peri = 2 * (length * breadth);
            Console.WriteLine($"Perimeter = {peri}");
        }
    }
    public class Circle : IShape
    {
        private double radius;
        
        void IShape.Area()
        {
            var area = Math.PI * Math.Pow(radius,2);
            Console.WriteLine($"Area = {area}");
        }
            
        void IShape.GetInput()
        {
            Console.WriteLine("ENter the radius: ");
            radius = Convert.ToDouble(Console.ReadLine());
        }

        void IShape.Perimeter()
        {
            var peri = 2 * Math.PI * radius;
            Console.WriteLine($"Perimeter = {peri}");
        }
    }
    public class Triangle : IShape
    {
        public void GetInput()
        {

        }
        public void Area()
        {

        }
        public void Perimeter()
        {

        }
    }
    public class Pentagon : IShape
    {
        public void Area()
        {
            throw new NotImplementedException();
        }

        public void GetInput()
        {
            throw new NotImplementedException();
        }

        public void Perimeter()
        {
            throw new NotImplementedException();
        }
    }
}
