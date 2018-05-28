using System;

namespace TestDelegate
{
    delegate void MyEventHandler();
    class MyEvent
    {
        public event MyEventHandler SomeEvent;

        public void OnSomeEvent(int i)
        {
            if (SomeEvent != null)
                SomeEvent();
            Console.WriteLine("i = " + i);
        }
    }
    class EventDemo
    {
        static void Handler()
        {
            Console.WriteLine("Произошло событие");
        }
        static void Main(string[] args)
        {
            MyEvent evt = new MyEvent();

            evt.SomeEvent += Handler;

            evt.OnSomeEvent(8);
            Console.ReadKey();

        }

    }
}
