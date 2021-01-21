using System;
using System.Collections.Generic;
using System.Text;
using IO = System.Console;
using Emp = Bank.Account.EmplyeeDetails;
namespace Bank.Account.EmplyeeDetails
{
    class AlliasExample
    {
        static void Main()
        {
            Emp.Employee objEmp = new Emp.Employee();
            objEmp.EmpName = "Peter";
            IO.WriteLine("Emplyee Name: " + objEmp.EmpName);
        }
    }
}
