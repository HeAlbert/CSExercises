using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex04
    {
        public static void Main(string[] args)
        {
            double dNumber1;
            Console.WriteLine("Pls input a double precision Number:" );
            dNumber1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("the sqaure root of the number is :{0} ", Math.Sqrt(dNumber1));
        }
    }
}
