﻿using System;

namespace CodeSnippet23
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
            }catch(DivideByZeroException objDivide)
            {
                Console.WriteLine("Exception: " + objDivide);
            }
            finally
            {
                Console.WriteLine("This is Finally block will always be excuted");
            }
        }
    }
}
