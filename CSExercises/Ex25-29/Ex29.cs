using System;

namespace CSExercises
{
    public class Ex29
    {
        public static void Main(string[] args)
        {
            int iNumber,t,x,y ;
            x = 0;
            y = 0;
            Console.Write("Pls enter a integer: ");
            iNumber = Convert.ToInt32(Console.ReadLine());

            for (t = 1; t < iNumber; ++t)
            {
                if (iNumber % t == 0)
                {
                    x = t;
                   //Console.Write("\n{0}", x);
                    y = y + x;
                }

            }
            if (iNumber == y)
            {
                Console.Write("\nPerfct Number\n");
            }
            else
            {
                Console.Write("\nNot Perfect Number\n");
            }
        }
    }
}
