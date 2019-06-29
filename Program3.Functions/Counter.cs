namespace Functions
{
    public class Counter
    {
        public int Interval
        {
            get;
        }
        
        private string Unit
        {
            get;
            set;
        }
        public Counter(int interval, string unit)
        {
            this.Interval = interval;
            this.Unit = unit;
        }
    }
}