namespace _100Days.ConsoleApp
{
    public static class StaticClass
    {
        //everything here must be static
        public static int i = 10;
        public static void FunctionOne()
        {
            i++;
            FunctionTwo();
        }
        public static void FunctionTwo()
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
            i++;
            iStatic++;
        }
        public static void FunctionOneStatic()
        {
            //being a static memeber, static function ani variable matrai access garna milxa
            iStatic++;
            //i++; //we cannot access directly
            

        }
    }
}