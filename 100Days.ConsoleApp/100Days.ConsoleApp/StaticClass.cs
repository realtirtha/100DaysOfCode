namespace _100Days.ConsoleApp
{
    public static class StaticClass
    {
        //everything here must be static
        public static int i = 10;
        public static void FunctionOne()
        {

        }
    }

    public class NonStaticClass
    {
        //may or may not be static
        public int i = 10;

        public static int iStatic = 10;
        public void FunctionOne()
        {

        }
        public static void FunctionOneStatic()
        {

        }
    }
}