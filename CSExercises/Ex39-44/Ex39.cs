using System;

namespace CSExercises
{
    public class Ex39
    {
        public static long Factorial(long n)
        {
            long Factorial=1;
            for (int i = 1; i <= n; i++)
            {
                Factorial = i * Factorial;
            }
           
            return Factorial;
        }
    }
}
