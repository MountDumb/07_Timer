namespace _07_Timer
{
    internal class Timer
    {
        private int seconds = 0;
        private int minutes = 0;
        private int hours = 0;

        public override string ToString()
        {
            string s = string.Format("{0:00}", seconds);
            string m = string.Format("{0:00}", minutes);
            string h = string.Format("{0:00}", hours);
            return h + ":" + m + ":" + s;
        }

        public int Seconds 
        {
            get { return this.seconds; }
            set { this.seconds = value; }
        }

        public int Minutes
        {
            get { return this.minutes; }
            set { this.minutes = value; }
        }

        public int Hours
        {
            get { return this.hours; }
            set { this.hours = value; }
        }
    }
}