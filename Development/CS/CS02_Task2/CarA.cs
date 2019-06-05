using System;

namespace CS02_Task2
{
    /*
    2. 定义一个CarA类，继承于Car，并具有两个自己的方法：

    CarAfunction1，输出“执行CarAfunction1”，并调用testEngine方法

    CarAfunction2，输出“执行CarAfunction2”，并调用testEngine方法
    */

    
    public class CarA:Car
    {
        public void CarAfunction1()
        {
            Console.WriteLine("执行CarAfunction1");
            base.testEngine();
        }
        public void CarAfunction2()
        {
            Console.WriteLine("执行CarAfunction2");
            base.testEngine();
        }
        
    }
}