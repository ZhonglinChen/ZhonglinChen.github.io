using System;
/*
 



 */
namespace CS02_Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Car c=new Car();
            CarA ca=new CarA();
            CarB cb=new CarB();
            Test t = new Test(c,ca,cb);
            t.run();
        }
    }
}