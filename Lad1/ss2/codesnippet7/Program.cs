using System;
/// <summary>
/// The Program demonstrates the use of XML comments.
/// 
/// Employee class uses constructors to initialize the ID and name of the employee and display them 
///</summary>
///<remarks>
///this program uses both parameterized and
///non-parameterized constructors.
/// </remarks>


namespace codesnippet7
{
    class Employee
    {
        /// <summary>
        /// Interger field to store emplyee ID.
        /// </summary>
        private int id;
        /// <summary>
        /// String field to store employee name.
        /// </summary>
        private string name;
        /// <summary>
        /// This constructor initializes the id and name to -1 and null.
        /// </summary>
        /// <remarks>
        /// <seealso cref="Employee(int,string)">Employee(int,string)</seealso>
        /// </remarks>
        public Employee()
        {
            id = -1;
            name = null;
        }
        /// <summary>
        /// This constructor initializes the ad and name.
        /// (<paramref name="id"/>,<paramref name="name"/>
        /// </summary>
        ///<param name="id">Employee ID</param>
        ///<param name="name">Employee Name</param>
        public Employee(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
        /// <summary>
        /// The entry point for the application.
        /// <param name="args">A list of command line arguments</param>
        /// </summary>
        
        static void Main(string[] args)
        {
            //Creating an object of Employee class and displaying the id and name of the employee
            Employee objEmp = new Employee(101, "David Smith");
               
            Console.WriteLine("Employee ID: {0} \n Employee Name: {1}", objEmp.id,objEmp.name);


        }
    }
}
