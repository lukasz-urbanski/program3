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
         
    }
}