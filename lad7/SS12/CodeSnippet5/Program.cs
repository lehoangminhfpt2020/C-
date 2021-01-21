using System;

namespace CodeSnippet5
{
    class CompositeDelegates
    {
        public delegate void Messenger(int value);
        static void EvenNumber(int value)
        {
            Console.Write("Even Numbers: ");
            for(int i = 2;i < value; i+=2)
            {
                Console.Write(i + " ");
            }
        }
        public void OddNumber(int value)
        {
            Console.WriteLine();
            Console.Write("Odd number: ");
            for (int i = 1; i <= value; i += 2)
            {
                Console.Write(i + " ");
            }
        }
        static void Start(int number)
        {
            CompositeDelegates objComposite = new CompositeDelegates();
            Messenger objDisplayOne = new Messenger(EvenNumber);
            Messenger objDisplayTwo = new Messenger(objComposite.OddNumber);
            Messenger objDisplayComposite = (Messenger)Delegate.Combine(objDisplayOne, objDisplayTwo);
            objDisplayComposite(number);
            Console.WriteLine();
            Object obj = objDisplayComposite.Method.ToString();
            if(obj != null)
            {
                Console.WriteLine("The delegate invokes an instance method: " + obj);
            }
            else
            {
                Console.WriteLine("The delegate invokes only static method");
            }
        }
        static void Main(string[] args)
        {
            int value = 0;
            Console.WriteLine("Enter the valuest till you want to display even or odd numbers");
            try
            {
                value = Convert.ToInt32(Console.ReadLine());
            }catch(FormatException objFormat)
            {
                Console.WriteLine("Error: " + objFormat);
            }
            Start(value);
        }
        
    }
}
