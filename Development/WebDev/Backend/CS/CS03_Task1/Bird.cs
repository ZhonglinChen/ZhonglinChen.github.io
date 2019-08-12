using System;
using System.Threading;

namespace CS03_Task1
{
    // *1. 创建基类Bird并添加一个虚方法Eat()，输出“我是一只小小鸟，我喜欢吃虫子~”

    public class Bird
    {

        public virtual void Eat()
        {
            Console.WriteLine("我是一只小小鸟，我喜欢吃虫子~");
        }
    }
}