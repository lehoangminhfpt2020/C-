using System;

namespace CodeSnippet22
{
    class Program
    {
        static void Evaluate(string args)
        {
            var val = args ?? throw new ArgumentException("Invalid argument");
            Console.WriteLine("Reached this point");
        }
        static void Main()
        {
            Evaluate("number");
            Evaluate(null);
        }
    }
}
