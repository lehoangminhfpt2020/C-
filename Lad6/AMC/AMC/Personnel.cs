using System;
using System.Collections.Generic;
using System.Text;

namespace AMC
{
    class Personnel : Troop
    {
        int perID;
        string name;
        DateTime DateOfBirth;
        string rank;
        int TroopID;

        public Personnel() { }
        public Personnel(int perID, string name, DateTime DateOfBirth, string rank, int TroopID)
        {
            this.perID = perID;
            this.name = name;
            this.DateOfBirth = DateOfBirth;
            this.rank = rank;
            this.TroopID = TroopID;
        }
        public Personnel Add()
        {
            Console.WriteLine("Enter perID ");
            perID = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter per name: ");
            name = Console.ReadLine();
            Console.WriteLine("Enter date of birth:");
            DateOfBirth = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Enter rank: ");
            rank = Console.ReadLine();
            Console.WriteLine("Enter Troops ID");
            TroopID = Convert.ToInt32(Console.ReadLine());
            return new Personnel(perID, name, DateOfBirth, rank, TroopID);
        }
        public void Display()
        {
            Console.WriteLine("PerID: " + perID);
            Console.WriteLine("PerName: " + name);
            Console.WriteLine("DOB: " + DateOfBirth);
            Console.WriteLine("Rank: " + rank);
            Console.WriteLine("Troops ID: " + TroopID);
        }
    }
}
