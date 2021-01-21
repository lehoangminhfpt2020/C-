using System;

namespace CodeSnippet9
{
    class StudentDetail
    {
        string studName = "Alexander";
        int studId = 30;
        public void StudentDetails()
        {
            Console.WriteLine("Student Name: " + studName);
            Console.WriteLine("Student ID: " + studId);
        }
    }
    class ScoreReport 
    {
        public string Subject = "Science";
        public int Marks = 60;
        static void Main(string[] args)
        {
            CodeSnippet9.StudentDetail objStudents = new CodeSnippet9.StudentDetail();
            ScoreReport objReport = new ScoreReport();
            Console.WriteLine("Subject: " + objReport.Subject);
            Console.WriteLine("Marks: " + objReport.Marks);
        }
    }

}
