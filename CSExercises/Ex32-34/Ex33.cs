using System;

namespace CSExercises
{
    public class Ex33
    {
        public static void Main(string[] args)
        {
            int i,t,temp,x;
            i = 0;
            t = 0;
            temp = 0;
            x = 0;
            int[] iNumber = new int[]
            { 86, 35, 41, 49, 89, 51, 11, 71, 50, 75, 25, 58, 40, 14,44,3, 63,81,93,79};
            for (i = 0; i <= iNumber.Length - 2; i++)
            {
                for (t = i + 1; t <= iNumber.Length - 1; t++)
                {
                    if (iNumber[i] <= iNumber[t])
                    {
                        temp = iNumber[t];
                        iNumber[t]=iNumber[i];
                        iNumber[i] = temp;
                        for (x = 0; x <= iNumber.Length - 1; x++)
                        {
                            Console.Write("{0} ", iNumber[x]);
                        }
                        Console.Write("\n");

                    }
                   
                }
            }
           

        }
    }
}
