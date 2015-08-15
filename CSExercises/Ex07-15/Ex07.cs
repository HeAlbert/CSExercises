using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// caculate the totalincome based on the salary
namespace CSExercises
{
    public class Ex07
    {
        public static void Main(string[] args)
        {
            double dSalary, dHouseAllowance, dTransAllowance;
            double dTotalIncome = 0;
            Console.WriteLine("Pls input your Salary: ");
            dSalary = Convert.ToDouble(Console.ReadLine());
            dHouseAllowance = 0.1 * dSalary;
            dTransAllowance = 0.03 *dSalary;
            dTotalIncome = dHouseAllowance + dSalary + dTransAllowance;
            Console.WriteLine("Your Total income is:{0:C}", dTotalIncome);
        }
    }
}
