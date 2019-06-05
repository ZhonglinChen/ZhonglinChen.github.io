namespace CS03_Task2
{
    //    4. 定义一个类Cylinder继承于Dimensions，
    // 定义一个带两个double类型参数的构造函数。
    // 并重写基类的Area方法，返回2 * PI * x * x + 2 * PI * x * y， 返回值类型为double。

    public class Cylinder:Dimensions
    {
        public Cylinder(double x, double y) : base(x, y)
        {
            
        }

        public override double Area()
        {
            return 2 * PI * x * x + 2 * PI * x * y;
        }   
        
    }
}