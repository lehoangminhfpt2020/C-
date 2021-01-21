using System;

namespace Bank
{
    public abstract class Account
    {
        private long accountNumber;
        private string customerName;
        protected double Balance = 500;

        protected virtual void SetDetails(string name, long number)
        {
            this.customerName = name;
            this.accountNumber = number;
        }
        protected virtual void Withdraw(double amount)
        {
            Balance -= amount;
        }
        protected virtual void Deposite(double amount)
        {
            Balance += amount;
        }
        public virtual void Display()
        {
            Console.WriteLine("\n\nA/C No. \tCustomer Name\t Balance");
            Console.WriteLine(accountNumber + " \t\t" + customerName + " \t" + Balance);
        }
        protected abstract double BankCharges();
    }
}
