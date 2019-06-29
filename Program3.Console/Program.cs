using System;
using System.Threading;
using Functions;

namespace Program3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Podaj liczbę: ");
            //string num = (Console.ReadLine());
            //Console.Write("Podaj liczbę sekund: ");
            //int sleep = Int32.Parse(Console.ReadLine());
            //Counter counter = new Counter(new WordToNumberConverter(num).getNumberAsInt(), "second");

            TimerCallback callback = new TimerCallback(Tick);

            Console.WriteLine("Creating timer: {0}\n",
                               DateTime.Now.ToString("h:mm:ss"));

            // create a one second timer tick
            Timer stateTimer = new Timer(callback, null, 0, 1000);

            //// loop here forever
            //for (; ; )
            //{
            //    // add a sleep for 100 mSec to reduce CPU usage
            //    Thread.Sleep(100);

            //}

            TimerCallback callback2 = new TimerCallback(Tick2);


            //// loop here forever
            //for (; ; )
            //{
            //    // add a sleep for 100 mSec to reduce CPU usage
            //    Thread.Sleep(100);

            //}
            Console.ReadKey();

        }
        static public void Tick(Object stateInfo)
        {
            Console.WriteLine("Tick1: {0}", DateTime.Now.ToString("h:mm:ss"));
        }
        static public void Tick2(Object stateInfo)
        {
            Console.WriteLine("Tick2: {0}", DateTime.Now.ToString("h:mm:ss"));
        }
    }
}
