using System;
using System.Collections.Generic;
using System.Text;

namespace Bank
{
    class SavingTest
    {
        static void Main(string[] args)
        {
            SavingAccount objSaving = new SavingAccount();
            if (objSaving.AcceptDetails())
            {
                objSaving.Display();
            }
            else
            {
                return;
            }
        }
    }
}
