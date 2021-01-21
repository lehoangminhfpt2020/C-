using System;
using System.Collections.Generic;
using System.Text;

namespace Bank3
{
    class LoanTest
    {
        static void Main(string[] agrs)
        {
            HomeLoan objLoan = new HomeLoan();

            objLoan.AcceptDetails();
            objLoan.SetValues();
            objLoan.DisplayDetails();
        }
    }
}
