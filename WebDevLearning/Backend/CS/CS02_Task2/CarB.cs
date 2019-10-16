using System;

namespace CS02_Task2
{
    
/*
    
    3. 定义一个CarB类，继承于Car，并具有两个自己的方法：

    CarBfunction1，输出“执行CarBfunction1”，并调用testEngine方法

    CarBfunction2，输出“执行CarBfunction2”，并调用testEngine方法

*/

    public class CarB:Car
    {
        public void CarAfunction1()
        {
            Console.WriteLine("执行CarBfunction1");
            base.testEngine();
        }
        public void CarAfunction2()
        {
        
            Console.WriteLine("执行CarBfunction2");
            base.testEngine();
        }
        
    }
}