using System;

namespace CSExercises
{
    public class Ex35
    {
        public static void Main(string[] args)
        {
            string sPhrase;
            int TotalNumber= 0;
            Console.Write("Please enter a phrase: ");
            sPhrase = Console.ReadLine();
            sPhrase = sPhrase.ToLower();
            
            char[] Vowel = new char[]
                {'a','e','i','o','u'};
            int[] Count = new int[5];
            char[] cPhrase = new char[sPhrase.Length];
            for (int i = 0; i < sPhrase.Length; i++)
            {
                cPhrase[i] = Convert.ToChar(sPhrase.Substring(i, 1));
                for(int j=0; j< Vowel.Length; j++)
                {
                    if (cPhrase[i] == Vowel[j])
                    {
                        Count[j]++;
                    }

                }

            }
            for (int t = 0; t < Vowel.Length; t++)
            {
                TotalNumber = TotalNumber + Count[t];
            }
            Console.WriteLine("Total number of vowels : {0}", TotalNumber);
            for (int t = 0; t < Vowel.Length; t++)
            {
                Console.WriteLine("Number of {0}: {1}", Vowel[t], Count[t]);
            }
        }
    }
}
