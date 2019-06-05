namespace CS03_Task2
{
    //    2. 定义一个类Circle继承于Dimensions，
    // 定义一个带一个double类型参数的构造函数。
    // 并重写基类的Area方法，返回PI * x * x， 返回值类型为double。

    public class Circle:Dimensions
    {
        public Circle(double x) : base(x,x)
        {
            
        }

        public override double Area()
        {
            return PI *x * x;
        }
    }
}