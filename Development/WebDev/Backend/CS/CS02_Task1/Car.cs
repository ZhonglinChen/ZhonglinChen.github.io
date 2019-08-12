using System;

namespace CS02_Task1
{
    /*
     * 2. 编写Car 小汽车类，继承于Vehicles类
     * 增加int型成员属性seats 座位
     * 还应增加成员方法showCar 在控制台显示小汽车的信息 显示颜色、商标及座位数， 并编写构造方法。 

     */
    public class Car:Vehicles
    {
        public int seats { get; set; }

        public Car(string brand, string color, int seats) : base(brand, color)
        {
            this.seats = seats;
        }

        public void showCar()
        {
            Console.WriteLine("Brand: {0}, Color: {1}, Seats: {2}.",base.brand,base.color,seats);
        }
        

    }
}