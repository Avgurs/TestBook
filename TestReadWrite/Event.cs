using System;

namespace TestDelegate
{
    class MyEventArgs : EventArgs
    {
        public int EventNum;
    }

    delegate void MyEventHandler(object source, MyEventArgs arg);

    class MyEvent
    {
        static int count = 0;

        public event MyEventHandler SomeEvent;

        public void OnSomeEvent()
        {
            MyEventArgs arg = new MyEventArgs();

            if(SomeEvent != null)
            {
                arg.EventNum = count++;
                SomeEvent(this, arg);
            }
        }
    }

    class X
    {
        public void Handler(object source, MyEventArgs arg)
        {
            Console.WriteLine("Событие " + arg.EventNum + " получено объектом класса X.");
            Console.WriteLine("Источник: " + source);
            Console.WriteLine();
        }
    }

    class Y
    {
        public void Handler(object source, MyEventArgs arg)
        {
            Console.WriteLine("Событие " + arg.EventNum + " получено объектом класса Y.");
            Console.WriteLine("Источник: " + source);
            Console.WriteLine();
        }
    }

    class EventDemo6
    {
        
        static void Main()
        {
            X ob1 = new X();
            Y ob2 = new Y();
            MyEvent evt = new MyEvent();

            //Добавить обработчик Handler() в цепочку событий
            evt.SomeEvent += ob1.Handler;
            evt.SomeEvent += ob2.Handler;

            evt.OnSomeEvent();
            evt.OnSomeEvent();
            evt.OnSomeEvent();

            Console.ReadKey();

        }

    }
}
