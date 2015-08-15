using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Caculate Programe: y = 2x^2 - 4x +32
namespace CSExercises
{
    public class Ex09
    {
        public static void Main(string[] args)
        {
            double x, y;
            Console.WriteLine("Pls input x:");
            x = Convert.ToDouble(Console.ReadLine());
            y = 2 * x * x - 4 * x + 3;
            Console.WriteLine("Because y = 2 x^2 - 4 x +32 ");
            Console.WriteLine("So y={0}", y);
        }
    }
}
