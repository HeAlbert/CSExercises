using System;

namespace CSExercises
{
    public class Ex21
    {
        public static void Main(string[] args)
        {
            string sNumber;
            sNumber = " ";
            while (sNumber != "88")
            {
                Console.WriteLine("Pls enter 88, or you will be ask forever ^_^ ");
                sNumber = Console.ReadLine();
            }
            
            Console.WriteLine("Lucky you ...");
        }
    }
}

