using System;

namespace codesnippet8
{
    class Program
    {
        static void Main(string[] args)
        {
            int leftVal = 50;
            int rightVal = 100;

            Console.WriteLine("Equal: " + (leftVal == rightVal));
            Console.WriteLine("Not equal: " + (leftVal != rightVal));
            Console.WriteLine("Greater: " + (leftVal > rightVal));
            Console.WriteLine("Lesser: " + (leftVal < rightVal));
            Console.WriteLine("Greater or Equal: " + (leftVal >= rightVal));
            Console.WriteLine("Lesser or Equal: " + (leftVal <= rightVal));
        }
    }
}
