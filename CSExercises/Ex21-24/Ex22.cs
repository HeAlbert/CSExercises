using System;

namespace CSExercises
{
    public class Ex22
    {
        public static void Main(string[] args)
        {
            int iNumber1, iNumber2;
            int iBig, iSmall,iReminder;
            Console.Write("Enter A: ");
            iNumber1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nEnter B: ");
            iNumber2 = Convert.ToInt32(Console.ReadLine());

            if (iNumber1 > iNumber2)
            {
                iBig = iNumber1;
                iSmall = iNumber2;
            }
            else
            {
                iBig = iNumber2;
                iSmall = iNumber1;
            }
            do
            {

                iReminder = iBig - iSmall;
                if (iReminder >= iSmall)
                {
                    iBig = iReminder;
                }
                else
                {
                    iBig = iSmall;
                    iSmall = iReminder;
                }
            } while (iBig != iSmall);

            Console.WriteLine("HCF = {0}", iSmall);
            Console.WriteLine("LCM is = {0}", (iNumber1 * iNumber2) / iSmall);
        }
    }
}
