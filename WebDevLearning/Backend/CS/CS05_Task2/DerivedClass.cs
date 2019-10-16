using System;

namespace CS05_Task2
{
    public class DerivedClass:BaseClass
    {

        public override int Var1 { get; set; } = 10;
        public new int Var2 { get; set; } = 20;

    
        public override void Method1()
        {
            Console.WriteLine("Call Derived Class Method1");
        }
        
        public new void Method2()
        {
            Console.WriteLine("Call Derived Class Method2");
        }

        
    }
}