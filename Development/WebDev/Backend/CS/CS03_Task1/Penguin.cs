using System;

namespace CS03_Task1
{
    //4. 创建一个子类Penguin，继承父类Bird，重写父类Bird中的虚方法Eat()并输出“我是一只小企鹅，我喜欢吃鱼~”

    public class Penguin:Bird
    {
        public override void Eat()
        {
            Console.WriteLine("我是一只小企鹅，我喜欢吃鱼~");
        }
        
    }
}