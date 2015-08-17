using System;

namespace CSExercises
{
    public class Ex20
    {
        public static void Main(string[] args)
        {
            int iTVQuan, iDVDQuan, iMP3Quan;
            const double dTVPrice= 900, dDVDPrice= 500, dMP3Price=700;
            const double dDISCOUNT_SMALL =0.1, dDISCOUNT_BIG=0.15;
            double dTotalPrice, dTotalTV, dTotalDVD, dTotalMP3;

            iTVQuan = 0;
            iDVDQuan = 0;
            iMP3Quan = 0;
            Console.Write("Pls enter the quantity for TV:");
            iTVQuan = Convert.ToInt32(Console.ReadLine());
            Console.Write("Pls enter the quantity for DVD:");
            iDVDQuan = Convert.ToInt32(Console.ReadLine());
            Console.Write("Pls enter the quantity for MP3:");
            iMP3Quan = Convert.ToInt32(Console.ReadLine());

            dTotalTV = iTVQuan * dTVPrice;
            if (dTotalTV >= 5000 && dTotalTV <= 10000)
            {
                dTotalTV = iTVQuan * dTVPrice * (1 - dDISCOUNT_SMALL);
            }
            else if (dTotalTV > 10000)
            {
                dTotalTV = iTVQuan * dTVPrice * (1 - dDISCOUNT_BIG);
            }

            dTotalDVD = iDVDQuan * dDVDPrice;

            if (dTotalDVD >= 5000 && dTotalDVD <= 10000)
            {
                dTotalDVD = iDVDQuan * dDVDPrice * (1-dDISCOUNT_SMALL);
            }
            else if (dTotalDVD > 10000)
            {
                dTotalDVD = iDVDQuan * dDVDPrice * (1-dDISCOUNT_BIG);
            }
            dTotalMP3 = iMP3Quan * dMP3Price;
            dTotalPrice = dTotalTV + dTotalDVD + dTotalMP3;
            Console.WriteLine("Total price for this order is : {0:C}", dTotalPrice);
        }
        
    }
}