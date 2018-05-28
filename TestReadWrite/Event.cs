using System;

namespace TestDelegate
{
    delegate void MyEventHandler();
    class MyEvent
    {
        public event MyEventHandler SomeEvent;

        public void OnSomeEvent()
        {
            if (SomeEvent != null)
                SomeEvent();
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

            evt.OnSomeEvent();
            Console.ReadKey();

        }

    }
}
