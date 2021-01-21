using System;

namespace AMC
{
    class Troop
    {
        int id;
        string name;
        string location;
        int numOfGroup;
        public Troop(int id,string name,string location,int numOfGroup)
        {
            this.id = id;
            this.name = name;
            this.location = location;
            this.numOfGroup = numOfGroup;
        }
        public Troop()
        {

        }
        public void Create()
        {
            Console.Write("Enter Troop's Id: ");
            id = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter troop's name: ");
            name = Console.ReadLine();
            Console.Write("Enter posted loaction of troop: ");
            location = Console.ReadLine();
            Console.Write("Enter number of group in troop: ");
            numOfGroup = Convert.ToInt32(Console.ReadLine());
        }

        public virtual void Display()
        {
            Console.WriteLine("Troop id: " + id);
            Console.WriteLine("Troop Name: " + name);
            Console.WriteLine("Posted location: " + location);
            Console.WriteLine("Troop have {0} group", numOfGroup);
        }
    }
       
}
