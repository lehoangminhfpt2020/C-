using System;

namespace Codesnippet19
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = DateTime.Now;
            //Returns short date(MM/DD/YYYY)
            Console.WriteLine("Short date format (d): {0:d}", dt);
            //Returns long date (Day, month date, year)
            Console.WriteLine("Long date format (D) : {0:D}", dt);
            //Returns full date with time without second
            Console.WriteLine("Full date with time without seconds (f) : {0:f}", dt);
            //Returns full date with time with seconds
            Console.WriteLine("Full date with time with seconds (F) : {0:F}", dt);
            //Returns short date and short time without seconds
            Console.WriteLine("Short date and short time without seconds (g) : {0:g}", dt);

        }
    }
}
