using System;

namespace CS01_Task3
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
                if (res)
                {                
                    Console.WriteLine("[The result is {0}, the result is {1}. ]", res, numInput);
                }
                else{
                    Console.WriteLine("[The result is {0}, {1} is "+(numInput>tarNum.Num?"larger":"smaller")+" than the result.]", res, numInput);
                }

            }
            catch (FormatException)
            {
                Console.WriteLine("[Error Input: The number you enter, {0}, is not a number.]", usrInput);

            }
            return res;

            


        }

        public bool GuessFiveTime(TargetNumber tarNum)
        {

            int countdown = 5;
            while (countdown> 0)
            {
                Console.WriteLine("You have {0} time(s) to guess the target number.",countdown--);
                if (GuessOneTime(tarNum))
                {
                    return true;
                }
            }

            return false;

        }
        
            
    }
}