using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// programe to caculate the distance between two dots.
namespace CSExercises
{
    public class Ex10
    {
        public static void Main(string[] args)
        {
            double x1, x2, y1, y2, dDistance;
            Console.WriteLine("Pls input the data of two dot to caculate the distance:");
            Console.Write("x1:");
            x1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("y1:");
            y1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("x2:");
            x2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("y2:");
            y2 = Convert.ToDouble(Console.ReadLine());
            dDistance = Math.Sqrt(Math.Pow((x2 - x1),2) +Math.Pow((y2-y1),2));
            Console.WriteLine("the distance between ({0},{1}) and ({2},{3}) is: {4}",
                x1, y1, x2, y2, dDistance);
        }
    }
}
