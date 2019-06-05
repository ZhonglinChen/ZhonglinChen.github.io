namespace CS02_Task2
{
    //4. 写一个测试类，测试Car，CarA和CarB的功能
    
    public class Test
    {
        private Car c;
        private CarA ca;
        private CarB cb;
        
        public Test(Car c, CarA ca, CarB cb)
        {
            this.c = c;
            this.ca = ca;
            this.cb = cb;
        }

        public void run()
        {
            c.testEngine();
            c.StartEngine();
            c.StopEngine();
            
            ca.CarAfunction1();
            ca.CarAfunction2();
            ca.StartEngine();
            ca.StopEngine();
            
            cb.CarAfunction1();
            cb.CarAfunction2();
            cb.StartEngine();
            cb.StopEngine();
        }
    }
}