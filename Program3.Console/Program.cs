using Program3.Functions;
using System.Collections.Generic;
using System.Threading;

namespace Program3.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Counter> counters = Initializator.GetListOfCounters();
            int threadCounter = 0;
            List<Thread> listOfThreads = new List<Thread>();

            foreach (Counter c in counters)
            {
                threadCounter++;
                listOfThreads.Add(new Thread(() => c.PrintCounter(c.MaxValue, c.Interval)) { Name = $"Licznik {threadCounter}" });
            }

            System.Console.WriteLine();

            foreach (Thread t in listOfThreads)
            {
                t.Start();
            }
            foreach (Thread t in listOfThreads)
            {
                t.Join();
            }

            System.Console.Write($"{System.Environment.NewLine}Naciśnij dowolny klawisz, aby wyjść...");
            System.Console.ReadKey();
        }
    }
}