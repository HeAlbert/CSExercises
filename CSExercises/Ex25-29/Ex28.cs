using System;

namespace CSExercises
{
    public class Ex28
    {
        public static void Main(string[] args)
        {
            int iNumber, iTest, icount;
            icount = 0;
            Console.Write("Pls input a number: ");
            iNumber = Convert.ToInt32(Console.ReadLine());
            for (iTest = 2; iTest < iNumber; ++iTest)
            {
                if (iNumber % iTest == 0)
                {
                    ++icount;
                }
            }
            if (icount == 0)
            {
                Console.Write("\nPrime Number!\n");
            }
            else
            {
                Console.Write("\nNot Prime!\n");
            }
        }
    }
}
