using System;
using System.Collections.Generic;

namespace CS04_Task3
{
    public class Test
    {
        public void runTest()
        {
            
            
            List<Drink> lDrink=new List<Drink>();
            lDrink.Add(new Coffee());
            lDrink.Add(new Beer());
            lDrink.Add(new Milk());
            foreach (Drink d in lDrink)
            {
                d.taste();
            
            }  
      

            Console.WriteLine("输入一个数字来选择饮料");
            string line = Console.ReadLine();
            
            lDrink[0].GetDrink(Convert.ToInt16(line));
            lDrink[1].GetDrink(Convert.ToInt16(line));
            lDrink[2].GetDrink(Convert.ToInt16(line));



        }
    }
}