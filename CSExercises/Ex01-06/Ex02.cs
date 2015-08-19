using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// caculate the square of integer
namespace CSExercises
{
    public class Ex02
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Pls enter an integer: ");
            int iNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" the square of the number is {1} ",iNumber, iNumber*iNumber);
        }
    }
}
