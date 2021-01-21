using System;

namespace CodeSnippet6
{
    public delegate void PrintDetail();
    class TestEvent
    {
        event PrintDetail Print;
        void Show()
        {
            Console.WriteLine("This program illustrate how to subcribe objects to an event");
            Console.WriteLine("This method will not excuted since the event has not been raised");
        }
        static void Main(string[] args)
        {
            TestEvent objTestEvent = new TestEvent();
            objTestEvent.Print += new PrintDetail(objTestEvent.Show);
        }
    }
}
