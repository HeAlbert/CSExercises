using System;

namespace CSExercises
{
    public class Ex25
    {
        public static void Main(string[] args)
        {
            int iNumber, iFactorial,i;
            iFactorial = 1;
            Console.Write("Pls enter a Number: ");
            iNumber = Convert.ToInt32(Console.ReadLine());
           /* for (i=1; i<=iNumber; i++)
            {
                iFactorial = iFactorial * i;
            }*/
            for(i=iNumber; i >= 1; i--)
            {
                iFactorial = iFactorial * i;
            }
            Console.WriteLine("The Factorial is {0}", iFactorial);
        }

         
    }
}
