using System;
using System.Collections;
using System.Collections.Generic;

namespace CS03_Task1
{
    //5. 创建一个类对这些类进行测试，要求创建一个Bird基类数组，添加基类Bird对象，Magpie对象，Eagle对象，Penguin对象，然后遍历该数组，分别调用Eat方法，测试结果是否正确。

    public class Test
    {
        public void runTest()
        {
          List<Bird> listBird=new List<Bird>();
          listBird.Add(new Bird());
          listBird.Add(new Magpie());
          listBird.Add(new Eagle());
          listBird.Add(new Penguin());

          foreach (Bird b in listBird)
          {
              b.Eat();
          }
          
          
        }
        
    }
}