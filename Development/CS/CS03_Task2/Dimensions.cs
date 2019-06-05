using System;
using System.Security.Cryptography.X509Certificates;

namespace CS03_Task2
{
    //    1. 定义一个基类Dimensions， 有三个public成员变量。
    // 变量1为PI（通过Math.PI进行初始化），
    // 另外两个为double型的x和y。为Dimensions定义一个构造函数，接受2个参数为x和y赋值。
    // 定义一个虚方法Area，返回值为x*y，类型为double

    public class Dimensions
    { 
        protected double PI = Math.PI;
        protected double x, y;

        public Dimensions(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public virtual double Area()
        {
            return x * y;
        }
    }
}