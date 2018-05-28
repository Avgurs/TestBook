using System;

namespace TestEvent
{
    class MyEvent
    {
        public event EventHandler SomeEvent;

        public void OnSomeEvent()
        {
            if (SomeEvent != null)
                SomeEvent(this, EventArgs.Empty);
        }
    }
    class EventDemo7
    {
        static void Handler(object source, EventArgs arg)
        {
            Console.WriteLine("Произошло событие");
            Console.WriteLine("Источник " + source);
        }
        static void Main()
        {
            MyEvent evt = new MyEvent();
            evt.SomeEvent += Handler;

            evt.OnSomeEvent();

            Console.ReadKey();
        }
    }
}
