using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex12
    {
        public static void Main(string[] args)
        {
            double dCharge, dDistance;
            Console.WriteLine("Pls input the kilometres that customer travel:");
            dDistance = Convert.ToDouble(Console.ReadLine());
            dCharge = 2.40 + dDistance * 0.4;
            string sCharge = dCharge.ToString(".00");
            Console.WriteLine("the taxi fee is :{0}", sCharge);

        }
    }
}
