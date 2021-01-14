using System;

namespace Automotive
{
    public class Catogory
    {
        string category;
        public Catogory()
        {
            category = "Multi Utility Vehicle";
        }

        public void Display()
        {
            Console.WriteLine("Category: " + category);
        }
    }
}