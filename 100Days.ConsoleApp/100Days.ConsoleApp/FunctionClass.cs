namespace _100Days.ConsoleApp
{
    public class FunctionClass
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int AddV2(int a, int b) => a + b;
        public int Add(int x, int y, int z) => x + y + z;
        public void FuncOne(int x, string y)
        {

        }

        public void FuncOne(string y, int x)
        {

        }

        public void FuncTwo(int a=10, string b="Default", float f= 10f)
        {

        }

        public void AddV3(int a, int b, ref int result)
        {
            result = a + b;
        }
        public void AddV4(int a, int b, out int result)
        {
            //out varible ma xei value at least yak choti assign garnei parxa
            result = a + b;
        }
    }
}