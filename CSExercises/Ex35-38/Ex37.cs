using System;
namespace CSExercises
{
    public class Ex37
    {
        public static void Main(string[] args)
        {
            string sSentence1,sNewSentence;
            sSentence1 = "";
            sNewSentence = "";
            Console.WriteLine("Please input a String:");
            string sSentence = Console.ReadLine();
            sSentence1 = sSentence.ToUpper();
            string[] cWord1 = sSentence1.Split();
            string[] cWord = sSentence.Split();
            for (int i = 0; i < cWord.Length; i++)
            {
                if (cWord[i] != "")
                {
                    cWord1[i] = cWord1[i][0] + cWord[i].Substring(1, cWord[i].Length - 1);
                }
                

            }
            for (int i = 0; i < cWord1.Length; i++)
               {
                Console.Write("{0} ",cWord1[i]);
                }
            Console.Write("\n");
        }
    }
}
