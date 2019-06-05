using System;

namespace CS02_Task1
{
    /*
     * 1. 定义一个名为Vehicles 交通工具 的基类 该类中应包含String类型的成员属性brand 商标 和color 颜色
     * 还应包含成员方法run 行驶: 该方法在控制台显示“我已经开动了”
     * 和showInfo 显示信息 在控制台显示商标和颜色
     * 并编写构造方法初始化其成员属性。 
     */
    public class Vehicles
    {
        protected  string brand { get; set; }
        protected string color { get; set; }

        public Vehicles(string brand, string color)
        {
            this.brand = brand;
            this.color = color;

        }

        public void run()
        {    
            Console.WriteLine("我已经开动了");
        }

        public void showInfo()
        {
            Console.WriteLine("Brand: {0}, Color: {1}.",brand,color);
        }
    }
}