using System;

namespace CSExercises
{
    public class Ex34
    {
        
        public static void Main(string[] args)
        {
            int i, j;
            i = 0;
            j = 0;
            double OverallScore = 0;
            string[] sStudent = new string[12];
                
            double[] dTotalMark = new double[12];
            double[] AveMark = new double[4];
            double[] DevStand = new double[4];
            double[,] dMark = new double[12, 4]
               { {56,84,68,29 },{94,73,31,89},
                 {41,63,36,90 },{99,9 ,18,17},
                 {62,3 ,65,75 },{40,96,53,23},
                 {81,15,27,30 },{21,70,100,22},
                 {88,50,13,12 },{48,54,52,78},
                 {64,71,67,25 },{16,93,46,72}
               };
            /*for (i = 0; i <= sStudent.Length - 1; ++i)
            {
                for (j = 0, j <= 3; ++j)
              {
                    dMark[i, j] = Convert.ToDouble(Console.ReadLine());
                }
                */
            for (i = 0; i <= sStudent.Length - 1; i++)
            {
                for (j = 0; j <= 3; j++)
                {
                    dTotalMark[i] += dMark[i, j];
                }
                Console.WriteLine("the total mark of student {0} is {1}", i, dTotalMark[i]);

            }
          for (j = 0; j <= 3; j++)
            {
                for (i = 0; i <= 11; i++)
                {
                    dTotalMark[j] += dMark[i, j];
                    
                }
                Console.WriteLine("the average mark of subject {0} is {1:#.00}", j, dTotalMark[j]/sStudent.Length);
                AveMark[j] = dTotalMark[j] / sStudent.Length;
                for (i = 0; i <= 11; i++)
                {
                    DevStand[j] = Math.Pow((dMark[i, j] - AveMark[j]), 2) + DevStand[j];
                }
                Console.WriteLine("the Deviation Stand of class {0} is {1:#.00}", j, Math.Sqrt((DevStand[j] / sStudent.Length)));

        }

            for (i = 0; i <= sStudent.Length - 1; i++)
            {
                for (j = 0; j <= 3; j++)
                {
                    dTotalMark[i] += dMark[i, j];
                }

                OverallScore = dTotalMark[i] + OverallScore;

            }
            Console.WriteLine("the Average Score for whole class and subjects is {0}", OverallScore / (dMark.GetLength(0) * dMark.GetLength(1)));
            /*dTotalMark[j] = 0;
            for (j = 0; j <= 3; j++)
            {
                
                for (i = 0; i <= 11; i++)
                {
                    dTotalMark[j] += dMark[i, j];
                }
                AveMark[j] = dTotalMark[j] / sStudent.Length;
                for (i = 0; i <= 11; i++)
                {
                    DevStand[j] = Math.Pow((dMark[i, j] - AveMark[j]), 2) +DevStand[j];
                }
                Console.WriteLine("the Deviation Stand of class {0} is {1:#.00}", j, Math.Sqrt((DevStand[j]/sStudent.Length)));
            }*/

        }
     }
}

