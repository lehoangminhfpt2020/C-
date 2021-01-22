using System;

namespace Exercise2
{
    class Baseclass
    {
        String name;
        int weight;
        public void SetMe(int weight,string name)
        {
            this.name = name;
            this.weight = weight;
        }
        public void Show()
        {
            Console.WriteLine("name: {0} , Weight {1}", name, weight);
        }
    }

    class lion : Baseclass
    {
       
    }

    class Tiger : Baseclass
    {

    }
   class zoo
    {
        static void Main()
        {

            lion lion1 = new lion();
            lion1.SetMe(200, "Lion");
            lion1.Show();

            Tiger Tiger1 = new Tiger();
            Tiger1.SetMe(100, "tiger");
            Tiger1.Show();



        }
    }
}


