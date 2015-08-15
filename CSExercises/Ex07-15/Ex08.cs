using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// A Programe Convert the Centigrade to Fahrenheit 
namespace CSExercises
{
    public class Ex08
    {
        public static void Main(string[] args)
        {
            double dCentigrade, dFahrenheit;
            Console.WriteLine("Pls input the Centigrade temperature:");
            dCentigrade = Convert.ToDouble(Console.ReadLine());
            dFahrenheit = 1.8 * dCentigrade + 32;
            Console.WriteLine("the {0} Centigrade equal to {1} Fahrenheit", dCentigrade, dFahrenheit);
        }
    }
}
