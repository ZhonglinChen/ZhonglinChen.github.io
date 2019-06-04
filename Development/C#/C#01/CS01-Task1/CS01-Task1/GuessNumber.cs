using System;

namespace CS01_Task1
{
    public class GuessNumber
    {
        

        public bool GuessOneTime(TargetNumber tarNum)
        {
            bool res=false;
            Console.WriteLine("[Please enter a number you guess]");
            string usrInput=Console.ReadLine();
            try
            {
                int numInput = Convert.ToInt32(usrInput);
                res = numInput == tarNum.Num;
                Console.WriteLine("[The number you enter is {0}, the result is {1}.]", numInput, res);

            }
            catch (FormatException)
            {
                Console.WriteLine("[Error Input: The number you enter, {0}, is not a number.]", usrInput);

            }
            return res;

            


        }
        
            
    }
}