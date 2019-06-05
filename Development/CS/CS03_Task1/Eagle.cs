using System;

namespace CS03_Task1
{
    //3. 创建一个子类Eagle，继承父类Bird，重写父类Bird中的虚方法Eat()并输出“我是一只老鹰，我喜欢吃肉~”

    public class Eagle:Bird
    {
        public override void Eat()
        {
            Console.WriteLine("我是一只老鹰，我喜欢吃肉~");
        }
    }
}