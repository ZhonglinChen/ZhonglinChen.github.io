using System;

namespace CS02_Task2
{
    /*
     1. 定义一个Car基类，并定义以下三个方法：

    StartEngine, 输出“发动机已启动，准备出发”

    StopEngine，输出“到家了，停止发动机”

    testEngine，输出“发动机检测完毕，一切正常”
    */
    public class Car
    {
        public void StartEngine()
        {
            Console.WriteLine("发动机已启动，准备出发");
        }
        public void StopEngine()
        {
            Console.WriteLine("到家了，停止发动机");
        }
        public void testEngine()
        {
            Console.WriteLine("发动机检测完毕，一切正常");
        }
    }
}