using System;

namespace CS01_Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            TargetNumber targetNum=new TargetNumber();
            GuessNumber guessNum=new GuessNumber();

            
            Console.WriteLine(guessNum.GuessFiveTime(targetNum)?
                "Congratulation! You have the right answer: {0}.":
                "Sorry, you did not get the right answer: {0}.", targetNum.Num);
            

        }
    }
}