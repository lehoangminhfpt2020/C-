using System;
using System.Collections.Generic;
using System.Text;

namespace Bank3
{
    public class HomeLoan : Loan, IDetails
    {
        private string borrowerName;
        private string city;
        private double annualIncome;
        private double maxAmount;

        public override void SetValues()
        {
            base.SetValues();
            InterestRate = 15;
        }
        #region IDetails Members
        public void AcceptDetails()
        {
            Console.WriteLine("\t\t\t-----HOUSING LOAN DETAILS-----");
            Console.Write("Enter the borrowe's name: ");
            borrowerName = Console.ReadLine();

            Console.Write("Enter the city: ");
            city = Console.ReadLine();

        Income:
            Console.WriteLine("Enter the annual income: ");
            annualIncome = Convert.ToDouble(Console.ReadLine());

            if(annualIncome <= 0)
            {
                Console.WriteLine("Annual salary cannot be negative or zero");
                goto Income;
            }
            LoanEligibility(annualIncome);
            Console.WriteLine("\nMaximum loan amount availavble: " + maxAmount);

        Amount:
            Console.Write("Enter amount of the loan you want: ");
            LoanAmount = Convert.ToInt32(Console.ReadLine());

            if(LoanAmount <= 5000)
            {
                Console.WriteLine("Ypu cannot take a loan of less than 5000 $");
                goto Amount;
            }
            if(LoanAmount >= maxAmount)
            {
                Console.WriteLine("Loan amount cannot be more than the permissible limit");
                goto Amount;
            }
          
        }
        public override void LoanEligibility(double value)
        {
            if(value <= 50000)
            {
                maxAmount = 0;
            }
            else
            {
                maxAmount = ((value - 50000) * 4);
            }
        }
        double CaculateAmount()
        {
            return (LoanAmount + InterestAmount);
        }

        public void DisplayDetails()
        {
            InterestAmount = CaculateInterest();
            Console.WriteLine("\n\nLOAN DETAILS");
            Console.WriteLine("\nBorroer's name: " + borrowerName);
            Console.WriteLine("City: \t\t\t" + city);
            Console.WriteLine("Annual income: " + annualIncome);
            Console.WriteLine("Loan amount: " + LoanAmount + "$");
            Console.WriteLine("Interest rate: " + InterestRate + "%");
            Console.WriteLine("Duration of loan: " + Duration + "years");
            Console.WriteLine("Total amount: " + CaculateAmount() + "$");
        }
        #endregion
        public override double CaculateInterest()
        {
            if ((LoanAmount >= 500) && (LoanAmount <= 100000))
            {
                InterestRate = 9;
            }
            else if ((LoanAmount > 100000) && (LoanAmount < 250000))
            {
                InterestRate = 9.5f;
            }
            else if((LoanAmount > 250000) && (LoanAmount <= 500000))
            {
                InterestRate = 10;
            }
            else
            {
                InterestRate = 10.5f;
            }
            return ((LoanAmount * Duration * InterestRate) / 100);
}
        }
    }
}
