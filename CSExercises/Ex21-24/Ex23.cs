using System;

namespace CSExercises
{
    public class Ex23
    {
        public static void Main(string[] args)
        {
            int iNumberGuess, iTimes, iNumberInMind;
            
            Random r = new Random();
            iNumberInMind = r.Next(1, 11);
            iTimes = 1;
            
            Console.Write("Can you guess the Number in My mind, pls enter a number to guess ");
            Console.WriteLine("\nRemember if your guess is wrong, I will Change the Number in my mind");
            iNumberGuess = Convert.ToInt32(Console.ReadLine());

            while (iNumberGuess != iNumberInMind && iTimes <= 4) 
            {
                iTimes++;
                Random s = new Random();
                iNumberInMind = s.Next(0,10);
                Console.WriteLine("Try Again ");
                iNumberGuess = Convert.ToInt32(Console.ReadLine());
            } 
            if (iTimes <= 2)
            {
                Console.WriteLine("You are a Wizard!");
                Console.WriteLine("Congratulate you get it and you have try {0} times", iTimes);
            }
            else if (iTimes == 5)
            {
                Console.WriteLine("You are lousy");
            }
                    
            

            
        }
    }
}
