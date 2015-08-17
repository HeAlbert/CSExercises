using System;

namespace CSExercises
{
    public class Ex16
    {
        public static void Main(string[] args)
        {
            String sName, sGender;
            Console.Write("Pls input your name : ");
            sName = Console.ReadLine();
            Console.Write("pls your gender (use \"M\" or \"F\"):");
            sGender = Console.ReadLine();
            if (sGender == "M" )
            {
                Console.WriteLine("Good Morning Mr.{0}", sName);
            }
            if(sGender == "F")
            {
                Console.WriteLine("Good Moring Ms.{0}", sName);
            }

        }
    }
}