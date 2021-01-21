using System;

namespace CodeSnippet3
{
    public delegate double CalculateArea(double val);
    public delegate double CalculateVolme(double val);
    class Program
    {
        static double Area(double val)
        {
            return 6 * (val * val);
        }
        static double Volume(double val)
        {
            return (val * val);
        }
        static void Main(string[] args)
        {
            CalculateArea objCalculateArea = new CalculateArea(Area);
            CalculateVolme objcalculateVolme = new CalculateVolme(Volume);
            Console.WriteLine("Surface area of cube : " + objCalculateArea(200.32));
            Console.WriteLine("Volume of cube: " + objcalculateVolme(20.56));

        }
    }
}
