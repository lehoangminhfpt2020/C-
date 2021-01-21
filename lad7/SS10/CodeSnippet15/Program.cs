using System;

namespace CodeSnippet15
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOne = 133;
            int numTwo = 0;
            int result;
            try
            {
                result = numOne / numTwo;
            }
            catch(DivideByZeroException objDivede)
            {
                Console.WriteLine("Exception caught: " + objDivede)
            }
        }
    }
}
