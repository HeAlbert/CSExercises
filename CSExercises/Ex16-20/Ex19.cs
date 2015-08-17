using System;

namespace CSExercises
{
    public class Ex19
    {
        public static void Main(string[] args)
        {
            double dkilometers, dCharge;
            const double MIN_CHARGE = 2.40;
            const double UNITCHARGE_WITHIN = 0.4;
            const double UNITCHARGE_OUT=0.5;
            const double STANDARD= 8.5;

            dCharge = 0;
            Console.WriteLine("Pls input the kilometers travelled : ");
            dkilometers = Convert.ToDouble(Console.ReadLine());
            dkilometers = Math.Ceiling(dkilometers * 10) / 10;
            if (dkilometers <= 0.5)
                dCharge = MIN_CHARGE;
            else if (dkilometers <= STANDARD)
                dCharge = MIN_CHARGE + (dkilometers - 0.5) * UNITCHARGE_WITHIN;
            else if (dkilometers > STANDARD)
                dCharge = MIN_CHARGE + (dkilometers - 0.5) * UNITCHARGE_WITHIN + (dkilometers - 9) * UNITCHARGE_OUT;
            Console.WriteLine("The total charge is :{0:C}", dCharge);
        }
    }
}