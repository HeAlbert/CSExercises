using System;

namespace CSExercises
{
    public class Ex30
    {
        public static void Main(string[] args)
        {
            int iNumber, iTest, icount;
            

            for (iNumber = 5; iNumber <= 10000; ++iNumber)
            {
                icount = 0;
                for (iTest = 2; iTest < iNumber; ++iTest)
                {
                    if (iNumber % iTest == 0)
                    {
                    ++icount;
                    }
                }
                if(icount == 0)
                {
                    Console.Write("{0}\n", iNumber);
                }
                
                
            }
        }
    }
}
