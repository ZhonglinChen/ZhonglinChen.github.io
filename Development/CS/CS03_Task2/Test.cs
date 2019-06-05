using System;
using System.Security.Cryptography.X509Certificates;

namespace CS03_Task2
{
    //    5. 最后写一个测试类，新建Circle，Sphere以及Cylinder类并测试计算是否正确

    public class Test
    {
        public void runTest()
        {
            double x = 1.5;
            double y = 2.5;
            Dimensions circle=new Circle(x);
            Dimensions sphere=new Sphere(x);
            Dimensions cylinder=new Cylinder(x,y);


            Console.WriteLine(circle.Area());
            Console.WriteLine(sphere.Area());
            Console.WriteLine(cylinder.Area());
        }
        
    }
}