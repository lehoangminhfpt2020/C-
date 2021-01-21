using System;

namespace codesnippet17
{
    class Program
    {
        static void Main(string[] args)
        {
            double loanAmount = 15590;
            float interest = 0.09f;
            double interestAmount = 0;
            double totalAmount = 0;
            interestAmount = loanAmount * interest;
            totalAmount = loanAmount * interestAmount;
            Console.WriteLine("Loan amount: ${0:#,###.#0} \nInterest rate: {1:0#%} \nInterest amount: ${2:#,###.#0}",
                loanAmount, interest, interestAmount);
            Console.WriteLine("Total amount to be paid: ${0:*,###.#0}", totalAmount);
        }
    }
}
