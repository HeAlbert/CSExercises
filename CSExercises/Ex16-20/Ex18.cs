using System;

namespace CSExercises
{
    public class Ex18
    {
        public static void Main(string[] args)
        {
            int iScore;
            string sGrade;
            sGrade = " ";   
            Console.Write("Pls enter your score:");
            iScore = Convert.ToInt32(Console.ReadLine());
            if ( iScore >= 0 && iScore <= 100) 
            {

                if (0 < iScore &&  iScore <= 40)
                    sGrade = "F";
                else if (40 < iScore && iScore <= 59)
                    sGrade = "C";
                else if (60 <= iScore && iScore <= 79)
                    sGrade = "B";
                else if (80 <= iScore && iScore <= 100)
                    sGrade = "A";
                Console.WriteLine("You scored {0} makes which is {1} grade", iScore, sGrade);
            }
           
            else 
            Console.WriteLine("**Error**");
            
        }
    }
}