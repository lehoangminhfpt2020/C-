using System;
using System.Collections.Generic;
using System.Text;

namespace Bank2
{
    public interface IAccount
    {
        bool AcceptDetails();
        double CaculateInterest();
        double GetBalance();
        void Display();
 
    }
}
