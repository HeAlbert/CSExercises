using System;

namespace CSExercises
{
    public class Ex31
    {
        public static void Main(string[] args)
        {
            int iNumber,iFactor,iFactorSum;
            for (iNumber = 1; iNumber <= 1000; iNumber++)
            {
                iFactorSum = 0;
                for (iFactor = 1; iFactor < iNumber; iFactor++)
                {
                    if(iNumber % iFactor ==0 )
                    {
                        iFactorSum = iFactorSum + iFactor;
                    }
                }
                if (iFactorSum == iNumber)
                {
                    Console.Write("{0}\n", iNumber);
                }
            }

        }
    }
}
