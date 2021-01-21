using System;

namespace codesnippet14
{
    class Program
    {
        static void Main(string[] args)
        {
            String cusName;
            double loanAmount;
            float interest = 0.09f;
            double interestAmount = 0;
            double totalAmount = 0;
            Console.WriteLine("Enter the name of the customer: ");
            cusName = Console.ReadLine();
            Console.WriteLine("Enter loan amount: ");
            loanAmount = Convert.ToDouble(Console.ReadLine());
            interestAmount = loanAmount * interest;
            totalAmount = loanAmount * interestAmount;
            Console.WriteLine("\nCustomer name: {0}", cusName);
            Console.WriteLine("Loan amount: ${0:#,###.#0} \nInterest rate: {1:0#%} \nInterest amount: ${2:#,###.#0}",
                loanAmount, interest, interestAmount);
            Console.WriteLine("Total amount to be paid: ${0:*,###.#0}", totalAmount);

        }
    }
}
