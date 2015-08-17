using System;

namespace CSExercises
{
    public class Ex17
    {
        public static void Main(string[] args)
        {
            string sName, sGender,sTittle;
            int iAge;
            Console.Write("Pls input your name : ");
            sName = Console.ReadLine();
            Console.Write("pls your gender (use \"M\" or \"F\"):");
            sGender = Console.ReadLine();
            Console.Write("Pls input your age : ");
            iAge = Convert.ToInt32(Console.ReadLine());
            if (sGender == "M")
            {
                if (iAge >= 40)
                {
                    sTittle = "Uncle";
                }
                else
                {
                    sTittle = "Mr.";
                }
            }
            else
            {
                if (iAge >= 40)
                {
                    sTittle = "Aunty";
                }
                else
                {
                    sTittle = "Ms.";
                }

            }
            Console.WriteLine("Good Morning {0} {1}", sTittle, sName);

        }
    }
}