namespace CS05_Task1
{
    //2. 创建两个子类继承于基类，并实现这个虚方法。其中一个子类定义为sealed。

    public class Sealed:BaseA
    {
        public sealed override string getString()
        {
            return "get sealed";
        }
    }
    
    
}