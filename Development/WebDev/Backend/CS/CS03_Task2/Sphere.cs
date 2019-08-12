namespace CS03_Task2
{
    // 3. 定义一个类Sphere继承于Dimensions，
    // 定义一个带一个double类型参数的构造函数。
    // 并重写基类的Area方法，返回4 * PI * x * x， 返回值类型为double。

    public class Sphere:Dimensions
    {
        public Sphere(double x) : base(x, x)
        {
            
        }

        public override double Area()
        {
            return 4 * PI * x * x;
        }
    }
}