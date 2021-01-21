using System;

namespace CodeSnippetSession12
{
    public delegate int Caculation(int numOne, int nunmTwo);
    class Mathenatic
    {
        static int Addition(int numOne,int numTwo)
        {
            return (numOne + numTwo);
        }
        static int Subtraction(int numOne,int numTwo)
        {
            return (numOne - numTwo);
        }
        static void Main(string[] args)
        {
            int valOne = 5;
            int valTwo = 23;
            Caculation objCaculation = new Caculation(Addition);
            Console.WriteLine(valOne + "+" + valTwo + "=" + objCaculation(valOne, valTwo));
        }
    }
}
