using System;

namespace CodeSnippet16
{
    class Students
    {
        string[] names = {"James","John","Alexander"};
        static void Main(string[] args)
        {
            Students objStudents = new Students();
            try
            {
                objStudents.names[4] = "Micheal";
            }catch(Exception objException)
            {
                Console.WriteLine("Error: " + objException);
            }
        }
    }
}
