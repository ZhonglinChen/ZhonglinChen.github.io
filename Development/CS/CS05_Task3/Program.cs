using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
 *
 *
 * 要求
根据下面已有的程序代码，补充两个不带参数的构造函数，使其运行后能够得到注释所要求的结果。

注意，
1. 除了不带参数的构造函数外，不要增加其他语句。
2. 尽量保持语句简洁，不要写不必要存在的语句。
 */

namespace 第5课static
{
    class Program
    {
        public static int i = 0;
        
        //your code goes here
          static Program()
        {
            i = 2;

        }

         public Program()
         {
             i=1;
         }


        static void Main(string[] args)
        {
            Console.WriteLine(Program.i);//此处输出结果为2
            Program p = new Program();
            Console.WriteLine(Program.i);//此处输出结果为1
            Console.ReadKey();
        }
    }
}