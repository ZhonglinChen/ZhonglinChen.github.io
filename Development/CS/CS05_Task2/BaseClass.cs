using System;
using System.ComponentModel.Design;
using System.Numerics;

namespace CS05_Task2
{
    //    定义一个基类及一个派生类，要求派生类屏蔽基类的一个方法及一个成员变量。然后编写一个测试类，输出基类和派生类的各个变量和方法。

    public class BaseClass
    {
        public virtual int Var1 { get; set; } = 1;
        public virtual int Var2 { get; set; } = 2;

   
       public virtual void Method1()
       {
           Console.WriteLine("Call Base Class Method1");
       }
       public virtual void Method2()
       {
           Console.WriteLine("Call Base Class Method2");
       }
       
      
    }
}