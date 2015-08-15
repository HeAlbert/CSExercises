using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// the caculate program of the Triangle Area
namespace CSExercises
{
    public class Ex14
    {
        public static void Main(string[] args)
        {
            double a, b, c, s, dArea ;
            Console.WriteLine("Pls input the length of three sides of your triangel\n ");
            Console.WriteLine("PS:Make sure that the sum of two sides is bigger than the third one,");
            Console.WriteLine("   The minus of two sides is shorter than the third one.\n");
            Console.WriteLine("the first side:");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("the second side:");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("the third side:");
            c = Convert.ToDouble(Console.ReadLine());
            s = (a + b + c) / 2;
            dArea = Math.Sqrt(s * (s-a) * (s-b) * (s-c));
            Console.WriteLine("the Area of the triangle is: {0} ", dArea);

        }
    }
}