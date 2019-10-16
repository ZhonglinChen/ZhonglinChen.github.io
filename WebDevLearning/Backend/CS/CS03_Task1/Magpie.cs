using System;

namespace CS03_Task1
{
    //2. 创建子类Magpie，继承父类Bird，重写父类Bird中的虚方法Eat()，并输出“我是一只喜鹊，我喜欢吃虫子~”

    public class Magpie:Bird
    {
        public override void Eat()
        {
            Console.WriteLine("我是一只喜鹊，我喜欢吃虫子~");
        }
    }
}