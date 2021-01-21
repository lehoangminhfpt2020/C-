using System;

namespace Session3
{
    class Program
    {
        static void Main(string[] args)
        {
            byte numOne = 255;
            byte numTwo = 0;
            byte result = 0;
            try
            {
                checked
                {
                    result = (byte)(numOne + numTwo);
                }
                Console.WriteLine("Result: " + result);
            }
            catch(OverflowException ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
