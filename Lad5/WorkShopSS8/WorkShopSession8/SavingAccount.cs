using System;
using System.Collections.Generic;
using System.Text;

namespace Bank
{
    
    public class SavingAccount : Account
    {
        private float minBalance;
        private float bankCharge;
        public bool Flag = true;

        public bool AcceptDetails()
        {
            string name;
            long number;
            double amount;

            Console.Write("Enter the customer name: ");
            name = Console.ReadLine();

        First:
            Console.WriteLine("Enter the account number");
            number = Convert.ToInt64(Console.ReadLine());

            if(number <= 0)
            {
                Console.WriteLine("Invalid Account number");
                goto First;
            }
            else
            {
                SetDetails(name, number);
            }
            Console.WriteLine("\nInitial balance available: " + Balance + "\n\n");
            Console.WriteLine("Select type of transaction: ");
            Console.WriteLine("1. Withdraw \n 2.Deposite");
            Console.WriteLine("Select your choice");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Minimum balance to be maintained: " + minBalance + "$");
                    Console.Write("Enter the amount to be withdraw: ");
                    amount = Convert.ToDouble(Console.ReadLine());
                    break;
                case 2:
                    Console.WriteLine("Enter the amount to be deposite: ");
                    amount = Convert.ToDouble(Console.ReadLine());
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    return false;
            }

            if (!Flag)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        protected override void SetDetails(string name, long number)
        {
            base.SetDetails(name, number);
            minBalance = 500;
        }
        protected override double BankCharges()
        {
          if(Balance < minBalance)
            {
                bankCharge = 200;
            }
            return bankCharge;
        }
        protected override void Deposite(double amount)
        {
            base.Deposite(amount);

        }
        protected override void Withdraw(double amount)
        {
            if(amount <= Balance)
            {
                base.Withdraw(amount);
            }
            else
            {
                Console.WriteLine("You do not have sufficient balance in your account");
                Flag = false;
                return;
            }
        }
        public override void Display()
        {
            base.Display();
            if(Balance <= 500)
            {
                Console.WriteLine("\nBank charges forb les than minimum balance: " + bankCharge);
            }
        }
    }
}
