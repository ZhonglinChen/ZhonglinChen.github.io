using System;
using System.Security.Cryptography.X509Certificates;

/*
 *TASK 1:

sealed和non-sealed类性能对比


3. 创建一个测试类，在测试类中写一个循环
循环次数：10次
每次在循环中分别调用两个子类的getString方法一亿次，分别统计这两个子类调用一亿次getString方法的时间并输出出来。

 *
 * 
 */
namespace CS05_Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Test t =new Test();
            
            t.runTest();

        }
    }

    class Test
    {
        public void runTest()
        {
            Sealed classSealed=new Sealed();
            NonSealed classNonSealed=new NonSealed();
            var watch = System.Diagnostics.Stopwatch.StartNew();
            
            
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Loop{0}:",i);
                
                watch.Restart();
                for (int j = 0; j < 100000000; j++)
                {
                    classSealed.getString();
                }
                watch.Stop();
                Console.WriteLine("Sealed getString running: {0}ms",watch.ElapsedMilliseconds);
                
                watch.Restart();
                for (int j = 0; j < 100000000; j++)
                {
                    classNonSealed.getString();
                }
                watch.Stop();
                Console.WriteLine("NonSealed getString running: {0}ms",watch.ElapsedMilliseconds);

            }
            
        }
    }
}