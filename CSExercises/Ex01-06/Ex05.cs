using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* calculate the square root, which just have three decimal,  of double number */
namespace CSExercises
{
    public class Ex05
    {
        public static void Main(string[] args)
        {
            double dNumber1;
            Console.WriteLine("Pls input a double precision Number:");
            dNumber1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("the sqaure root of {0} is :{1:0.000} ",dNumber1, Math.Sqrt(dNumber1));
        }
    }
}
