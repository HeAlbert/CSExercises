using System;

namespace CSExercises
{
    public class Ex27
    {
        public static void Main(string[] args)
        {
            int x, y,d;
            x = 0;
            y = 0;
            d = 0;
            Console.Write("x\ty\n");
            Console.Write("-------------------------------------------------\n");
            
            for (x = 1; x <= 20; ++x)
            {
                y = 2 * x * x - 4 * x + 3;
                Console.Write("{0:0.0}\t{1:0.0}\n", x, y);
            }
            
            for (x = 1; x <= 20; ++x)
            {
                y = 2 * x * x - 4 * x + 3;
                for (d = 1; d <= y; ++d)
                {
                    Console.Write("*");
                }
                Console.Write("\n");

            }


        }
    }
}
