using System;

namespace Automotive
{
    public class SpareParts
    {
        string spareName;
        public SpareParts()
        {
            spareName = "GearBox";
        }

        public void Display()
        {
            Console.WriteLine("Spare part name: " + spareName);
        }

    }
}