using System;

namespace CodeSnippet20
{
    class Emplyoee
    {
        private string empName;
        private int empID;
        public void Employee()
        {
            empName = "David";
            empID = 101;
        }
        static void Main(string[] args)
        {
            Emplyoee objEmployee = new Emplyoee();
            Emplyoee objEmp = objEmployee;
            objEmployee = null;
            try
            {
                Console.WriteLine("Employee Name: " + objEmployee.empName);
                Console.WriteLine("Employee ID: " + objEmployee.empID);
            }catch(NullReferenceException objNull)
            {
                Console.WriteLine("Error: " + objNull);
            }catch(Exception objEx)
            {
                Console.WriteLine("Error: " + objEx);1
            }
        }
    }
}
