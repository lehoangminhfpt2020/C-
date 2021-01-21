using System;

namespace CodeSnippet24
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "John", "James" };
            int numOne = 0;
            int result;
            try
            {
                Console.WriteLine("This is the outer try block");
                try
                {
                    result = 133 / numOne;
                }
                catch (ArithmeticException objMath)
                {
                    Console.WriteLine("Divided by 0" + objMath);
                }
                names[2] = "Smith";
            }catch(IndexOutOfRangeException objIndex)
            {
                Console.WriteLine("Wrong numbers of arguments supplied" + objIndex);
            }
        }
    }
}
