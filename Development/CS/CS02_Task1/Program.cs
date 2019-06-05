using System;
/*
测试以上各类及其方法。
 *
 *
 * 
 */
namespace CS02_Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicles v=new Vehicles("宝马","蓝色");
            Car c=new Car("奔驰","黑色",7);
            Trunk t= new Trunk("丰田","白色",100.2f);
            
            v.run();
            v.showInfo();
            
            c.run();
            c.showInfo();
            c.showCar();
            
            t.run();
            t.showInfo();
            t.showTrunk();
            
        }
    }
}