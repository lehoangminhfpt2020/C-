using System;
using System.Collections;
using System.Collections.Generic;


namespace CodeSnippet10
{
    class Student : IEnumerable
    {
        LinkedList<string> objList = new LinkedList<string>();
        public void StudentDetails()
        {
            objList.AddFirst("James");
            objList.AddFirst("John");
            objList.AddFirst("Patrick");
            objList.AddFirst("Peter");
            objList.AddFirst("James");
            Console.WriteLine("Number of element stored in the list " + objList.Count);
        }
        public void Display(string name)
        {
            LinkedListNode<string> objNode;
            int Count = 0;
            for (objNode =objList.First;objNode != null;objNode = objNode.Next)
            {
                if (objNode.Value.Equals(name))
                {
                    Count++;
                }
            }
            Console.WriteLine("The value " + name + " appears" + Count +  " times in the list");
        }
        public IEnumerator GetEnumerator()
        {
            return objList.GetEnumerator();
        }
        static void Main(string[] args)
        {
            Student objStudent = new Student();
            objStudent.StudentDetails();
            foreach(string str in objStudent)
            {
                Console.WriteLine(str);
            }
            objStudent.Display("James");
        }
    }
}
