using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// estimate whether a three-digit integer is Armstrong Number.
namespace CSExercises
{
    public class Ex15
    {
        public static void Main(string[] args)
        {
            int iNumber, ia, ib, ic;
            double dNumber;
            Console.WriteLine("Pls input a tree-digit integer:");
            iNumber = Convert.ToInt32(Console.ReadLine());
            ia = iNumber / 100;
            ib = (iNumber - ia * 100) / 10;
            ic = (iNumber - ia * 100 - ib * 10);
            dNumber = 1.0 * iNumber;
            
            if(dNumber == Math.Pow(ia,3) + Math.Pow(ib,3) + Math.Pow(ic,3))
            {
                Console.WriteLine("{0} is Armstrong number", iNumber);
            }
            else
            {
                Console.WriteLine("{0} is not Armstrong number", iNumber);
            }
        }
    }
}