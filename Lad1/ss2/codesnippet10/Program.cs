using System;

namespace codesnippet10
{
    class Program
    {
        static void Main(string[] args)
        {
            String patch = "C:\\Windows\\Myfile.txt";
            bool found = true;
            if (found)
            {
                Console.WriteLine("File patch:\'" + patch + "\'");

            }
            else
            {
                Console.WriteLine("File Not Found!\a");
            }
        }
    }
}
