using System;
using System.Collections;

namespace CodeSnippet12
{
    class Customers
    {
        static void Main(string[] args)
        {
            ArrayList objCustomers = new ArrayList();
            objCustomers.Add("Nicole Andreson");
            objCustomers.Add("Ashley Thomas");
            objCustomers.Add("Garry White");
            Console.WriteLine("Fixed Size: " + objCustomers.IsFixedSize);
            Console.WriteLine("Count: " + objCustomers.Count);
            Console.WriteLine("List of customers: ");
            foreach(string names in objCustomers)
            {
                Console.WriteLine("{0}", names);
            }
            objCustomers.Sort();
            Console.WriteLine("\nList of customers after sorting: ");
            foreach(string names in objCustomers)
            {
                Console.WriteLine("{0}", names);
            }
            objCustomers.Clear();
            Console.WriteLine("Count after removing all elements: " + objCustomers.Count);
        }
    }
}
