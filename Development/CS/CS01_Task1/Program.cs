using System;

namespace CS01_Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            TargetNumber targetNum=new TargetNumber();
            GuessNumber guessNum=new GuessNumber();

            while (!guessNum.GuessOneTime(targetNum))
            {
                Console.WriteLine("Sorry, try again pls!");
            };
            Console.WriteLine("Congratulation! You have the right answer, which is {0}.",targetNum.Num);

            
        }
    }
}