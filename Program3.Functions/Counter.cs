using System;
using System.Threading;

namespace Program3.Functions
{
    public class Counter
    {
        public int MaxValue
        {
            get;
        }
        public int Interval
        {
            get;
        }
        public Counter(int maxValue, int interval)
        {
            this.MaxValue = maxValue;
            this.Interval = interval;
        }
        public void PrintCounter(int maxvalue, int interval)
        {
            for (int i = 1; i <= maxvalue; i++)
            {
                var threadName = Thread.CurrentThread.Name;
                Console.WriteLine($"{threadName}: {i}");
                Thread.Sleep(interval);
            }
        }        
    }
}