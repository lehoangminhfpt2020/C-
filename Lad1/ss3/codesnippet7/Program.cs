using System;

namespace codesnippet7
{
    class Program
    {
        static void Main(string[] args)
        {
            int valueOne = 10;
            int valueTwo = 2;

            int add = valueOne + valueTwo;
            int sub = valueOne - valueTwo;
            int mul = valueOne * valueTwo;
            int div = valueOne / valueTwo;
            int modu = valueOne % valueTwo;

            Console.WriteLine("Addition: " + add);
            Console.WriteLine("Subtraction: " + sub);
            Console.WriteLine("Multiplication: " + mul);
            Console.WriteLine("Division: " + div);
            Console.WriteLine("Remainder: " + modu);
        }
    }
}
