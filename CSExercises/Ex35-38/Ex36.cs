using System;

namespace CSExercises
{
    public class Ex36
    {
        public static void Main(string[] args)
        {
            int count,count1;
            count = 0;
            count1 = 0;
            Console.WriteLine("Please enter a String: ");
            string sSentence = Console.ReadLine();
            sSentence = sSentence.ToUpper();
            for (int i = 0; i < sSentence.Length; i++)
            {
                if ((sSentence[i] >= 'A' && sSentence[i] <= 'Z') || (sSentence[i] >= '0' && sSentence[i] <= '9'))
                {
                    count1++;
                }
            }
            char[] NewSentence = new char[count1];
            int j = 0; 
                for (int i = 0; i < sSentence.Length; i++)
                {
                    
                    if ((sSentence[i] >= 'A' && sSentence[i] <= 'Z') || (sSentence[i] >= '0' && sSentence[i] <= '9'))
                    {
                        NewSentence[j] = sSentence[i];
                        j++;
                   
                    }
                  
                }
             
            
            
            for (int i = 0; i < NewSentence.Length/2; i++)
            {
                if (NewSentence[i] == NewSentence[NewSentence.Length - i - 1])
                {
                    count++;
                }
            }
            if (count == NewSentence.Length / 2)
            {
                Console.WriteLine("Palindrome");
            }
            else
            {
                Console.WriteLine("Not Palindrome");
            }

        }
    }
}
