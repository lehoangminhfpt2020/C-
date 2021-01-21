using System;
using System.Collections.Generic;
using System.Text;

namespace Bank2
{
    class FixedAccount : IAccount
    {
        private string accountHolder;
        private long accountNumber;
        private float interestRate;
        private int numberOfYears;
        private double interesEarned;
        private double totalBalance;
        private double deposit;

        #region IAccount Members
        public bool AcceptDetails()
        {
            string input;
            Console.Write("Enter the name of the account holder: ");
            accountHolder = Console.ReadLine();

        Number:
            Console.Write("Enter Account Number: ");
            accountNumber = Convert.ToInt64(Console.ReadLine());
            if (accountNumber <= 0)
            {
                Console.WriteLine("Account number cannot be zero or negative\n");
                goto Number;
            }
        Amount:
            Console.Write("Enter the deposit amount ($): ");
            deposit = Convert.ToDouble(Console.ReadLine()); 

            if(deposit <= 0)
            {
                Console.WriteLine("Invalid amount");
                goto Amount;
            }
            Console.WriteLine("Select the tenure for the deposit amount: ");
            Console.WriteLine("\nA. \t1 year  \nB. \t3 years \nC. \t5 years");
            Console.WriteLine("\nChoose your option(A-C): ");
            char choice = Convert.ToChar(Console.ReadLine());

            switch (choice)
            {
                case 'A':
                case 'a':
                    numberOfYears = 1;
                    break;
                case 'B':
                case 'b':
                    numberOfYears = 3;
                    break;
                case 'C':
                case 'c':
                    numberOfYears = 5;
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
            return true;
        }

        public double CaculateInterest()
        {
            if (deposit <= 50000)
            {
                if (numberOfYears == 1)
                {
                    interestRate = 3.5f;
                }
                else if (numberOfYears == 3)
                {
                    interestRate = 4;
                }
            
                else
                {
                    interestRate = 4.5f;
                }
            }
            else if((deposit > 50000) && (deposit <= 200000))
            {
                if(numberOfYears == 1)
                {
                    interestRate = 5;
                }
                else if(numberOfYears == 3)
                {
                    interestRate = 5.5f;
                }
                else
                {
                    interestRate = 6;
                }
            }
            else
            {
                if (numberOfYears == 1)
                {
                    interestRate = 6.5f;
                }
                else if(numberOfYears == 3)
                {
                    interestRate = 7;
                }
                else
                {
                    interestRate = 7.5f;
                }
            }
            return ((deposit * numberOfYears * interestRate) / 100);
           
        }

        public void Display()
        {
            totalBalance = GetBalance();
            Console.WriteLine("\nAccount Holder: " + accountHolder);
            Console.WriteLine("Account Number: " + accountNumber);
            Console.WriteLine("Acocunt Deposit: " + deposit + "$");
            Console.WriteLine("Interest Rate: " + interestRate +"%");
            Console.WriteLine("Years of Deposit: " + numberOfYears);
            Console.WriteLine("Interest Earned: " + interesEarned + "$");
            Console.WriteLine("Maturity Amount: " + totalBalance + "$");
            
           
        }

        public double GetBalance()
        {
            interesEarned = CaculateInterest();
            return (deposit + interesEarned);

        }
        #endregion
    }
}
