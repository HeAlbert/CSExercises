using System;

namespace CSExercises
{
    public class Ex24
    {
        public static void Main(string[] args)
        {
            double dGuess;
            const double dStandard = 0.00001;
            int iNumber;
            Console.WriteLine("Pls enter a number, the computer will compute the sqrt for you");
            iNumber = Convert.ToInt32(Console.ReadLine());
            Random r = new Random();
            dGuess = r.Next(1, iNumber);

            if (Math.Abs(dGuess * dGuess - iNumber) <= dStandard)
            {
                Console.WriteLine("the sqrt of {0} is {1}", iNumber, dGuess);
            }
            else 
            {
                while (Math.Abs(dGuess * dGuess - iNumber) > dStandard)
                {
                    dGuess = (dGuess + iNumber / dGuess) / 2;
                   
                }
                
            }
            Console.WriteLine("the sqrt of {0} is {1:.00000}", iNumber, dGuess);

        }
    }
}
