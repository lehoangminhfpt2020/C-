using System;

namespace codesnippet12
{
    class Program
    {
        static void Main(string[] args)
        {

            int number, result;
            number = 5;
            result = 100 * number;
            Console.WriteLine("Result is {0} when 100 is multiplied by {0}", result, number);
            result = 150 / number;
            Console.WriteLine("Result is {0} when 150 is divided by {1}", result, number);
        }
    }
}
