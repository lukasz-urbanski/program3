using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functions
{
    public class Counter
    {
        private int Interval { get; set; }
        private string Unit { get; set; }

        public Counter(int interval, string unit)
        {
            this.Interval = interval;
            this.Unit = unit;
        }
    }
}