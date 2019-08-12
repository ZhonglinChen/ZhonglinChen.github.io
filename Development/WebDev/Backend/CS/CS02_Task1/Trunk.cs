using System;

namespace CS02_Task1
{
    /*
     * 3. 编写Truck 卡车 类继承于Vehicles类
     * 增加float型成员属性load
     * 载重 还应增加成员方法showTruck 在控制台显示卡车的信息
     * 并编写构造方法。 
     */
    public class Trunk:Vehicles
    {
        public float load { get; set; }

        public Trunk(string brand, string color, float load) : base(brand, color)
        {
            this.load = load;
        }

        public void showTrunk()
        {
            Console.WriteLine("Brand: {0}, Color: {1}, Load: {2}",base.color,base.color,load);
        }

    }
}