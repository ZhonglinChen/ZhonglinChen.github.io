using System;

namespace CS01_Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            bool nextTurn = true;
            while(nextTurn)
            {
                nextTurn = false;
                try
                {
                    Console.WriteLine("*Please enter two integers(min and max), split by whitespace, to set the range of random number you will guess.");
                    Console.WriteLine("[If you enter directly without any number, the range from 0 to 1000 would be set by default]");
                    String[] newLine = Console.ReadLine().Split();

                    TargetNumber targetNum = (newLine.Length==1 && newLine[0]=="")?
                       new TargetNumber(0,1000):
                       new TargetNumber(Convert.ToInt32(newLine[0]),Convert.ToInt32(newLine[1]));
                    GuessNumber guessNum = new GuessNumber();


                    Console.WriteLine(
                        guessNum.GuessFiveTime(targetNum)
                            ? "Congratulation! You have the right answer: {0}."
                            : "Sorry, you did not get the right answer: {0}.", targetNum.Num);
                }
                catch(Exception)
                {
                    nextTurn = true;
                    Console.WriteLine("[Error: Please enter the max and min with correct format]");
                    
                }

            }


        }
    }
}