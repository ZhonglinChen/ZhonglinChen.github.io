using System;

namespace CS04_Task3
{
    public abstract class Drink
    {
        public abstract void taste();

        public void GetDrink(int typeDrink)
        {
            switch (typeDrink)
            {
                case 1: Console.WriteLine("咖啡");this.taste();
                break;
                case 2: Console.WriteLine("啤酒");this.taste();
                break;
                case 3:Console.WriteLine("牛奶");this.taste();
                break;
                default:
                    throw new DrinkNotFound("error");
            }
        }
    }
}