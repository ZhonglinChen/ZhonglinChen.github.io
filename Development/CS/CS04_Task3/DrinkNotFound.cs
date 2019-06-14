using System;

namespace CS04_Task3
{
    public class DrinkNotFound:Exception
    {
        public DrinkNotFound(string s)
        {
            Console.WriteLine("您所选择的饮料编号不存在");
        }
        
    }
}