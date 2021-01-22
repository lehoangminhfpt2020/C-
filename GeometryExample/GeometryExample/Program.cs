using System;

namespace GeometryExample
{
    class Cylinder
    {
        public double Radius;
        public double Height;
        public double BaseArea;
        public double LateralArea;
        public double TotalArea;
        public double Volume;

        public static void Main()
        {
            Cylinder obj = new Cylinder();
            obj.Process();
            obj.Result();
        }
         void Process()
        {
            Console.WriteLine("Enter the dimenstions of the Cylinder: ");
            Console.WriteLine("Radius: ");
            Radius = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Height: ");
            Height = Convert.ToDouble(Console.ReadLine());

            BaseArea = Radius * Radius * Math.PI;
            LateralArea = 2 * Math.PI * Radius * Height;
            TotalArea = 2 * Math.PI * Radius * (Height + Radius);
            Volume = Math.PI * Radius * Radius * Height;
        }

        void Result()
        {
            Console.WriteLine("Cylinder characteristics");
            Console.WriteLine("Radius: {0} , Height: {1}", Radius, Height);
            Console.WriteLine("Base: {0:f} | Lateral: {1:f} | Total: {2:f} | Volume: {3:f} ", BaseArea, LateralArea, TotalArea, Volume);
        }
        
    }
}
