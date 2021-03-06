using System;
using System.Data.SqlClient;

namespace CSExercises
{
    public class Ex40
    {
        public static void Main(string[] args)
        {
            for (int i = 1; i < 26; i++)
            {
                Console.WriteLine("the sqrt of {0} is {1}", i,SQT(i));
            }
        }
        
        public static double SQT(int y)
        {
            double G;
            Random r = new Random();
            G = r.Next(1, y + 1);
            
            while (Math.Abs(G * G - y) >= 0.0001)
            {
                G = (G + y / G) / 2;
            } 

            return G;
        }
    }
}
