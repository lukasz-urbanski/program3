using System;
using System.Threading;

namespace Program3.Functions
{
    public class Counter //so, your counter is more of a 'DataTransferObject (DTO)' or a ParameterObject, rather than a self-contained class
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