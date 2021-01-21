using System;
using EFCore.Models;

namespace EFCore
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hello world");
            insertProduct();

            Console.WriteLine("press any key to continue");
            Console.ReadKey();
        }

        static void insertProduct()
        {
            using (var db = new EFContext())
            {
                Product product = new Product();
                product.Name = "Pen Drive";
                db.Add(product);

                product = new Product();
                product.Name = "Memory Card";
                db.Add(product);

                db.SaveChanges();
            }
            return;
        }
    }

}
