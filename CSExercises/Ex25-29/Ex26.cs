using System;

namespace CSExercises
{
    public class Ex26
    {
        public static void Main(string[] args)
        {
            double i;
            
            Console.WriteLine("NO\t INVERSE\t SQUARE ROOT\t SQUARE");
            Console.WriteLine("---------------------------------------------------------------");
            for (i = 1; i <= 10; i++)
            {
                Console.WriteLine("{0:.0}\t {1:0.0##}\t\t {2:0.0##}\t\t {3:#.0}", i, 1 / i, Math.Sqrt(i), Math.Pow(i,2));
            }

        }
    }
}
