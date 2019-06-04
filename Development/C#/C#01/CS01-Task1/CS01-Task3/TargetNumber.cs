using System;

namespace CS01_Task3
{
    public class TargetNumber
    {
        private int num;
        private int min;
        private int max;
        
        public int Num { get { return num;} }

        public TargetNumber()
        {
            num = 100;
        }

        public TargetNumber(int min, int max)
        {
            this.max = max;
            this.min = min;
            Random r = new Random();
            this.num= r.Next(min,max);
            Console.WriteLine("A target number from {0} to {1} has been generated!",this.min,this.max);
        }
    }
}