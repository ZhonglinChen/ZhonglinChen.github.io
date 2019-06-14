using System;
//TASK 2:
/*
    

*/

namespace CS05_Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Test t=new Test();
            t.runTest();
        }

        class Test
        {
            public void runTest()
            {
                BaseClass baseClass=new BaseClass();
                BaseClass derivedClass = new DerivedClass();
                Console.WriteLine("BaseClass Variable: var1:{0}, var2:{1}",baseClass.Var1,baseClass.Var2);
                Console.WriteLine("Derived Variable: var1:{0}, var2:{1}",derivedClass.Var1,derivedClass.Var2);

                baseClass.Method1();
                baseClass.Method2();
                
                derivedClass.Method1();
                derivedClass.Method2();
            }
        }
    }
}