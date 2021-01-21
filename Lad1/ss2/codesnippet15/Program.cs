using System;

namespace codesnippet15
{
    class Program
    {
        static void Main(string[] args)
        {
            string userName;
            int age;
            double salary;
            Console.Write("Enter your name: ");
            userName = Console.ReadLine();
            Console.Write("Enter yout age: ");
            age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the salary: ");
            salary = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Name: {0} \nAge: {1} \nSalary:{2}", userName, age, salary);
        }
    }
}
