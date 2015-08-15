using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// caculate the square of double number
namespace CSExercises
{
    public class Ex03
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Pls input a double Number: ");
            double dNumber = Convert.ToDouble(Console.ReadLine());
            double dNumbersq = dNumber * dNumber;
            Console.WriteLine("the square of {0:.00} is :{1:.00} ", dNumber, dNumbersq );
        }
    }
}
