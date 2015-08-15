using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// caculate the sqaure root of integer
namespace CSExercises
{
    public class Ex06
    {
        public static void Main(string[] args)
        {
            int iNumber1;
            Console.WriteLine("Pls input an integer:");
            iNumber1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The sqaure root of the number is:{0}", Math.Sqrt(iNumber1));
        }
    }
}
