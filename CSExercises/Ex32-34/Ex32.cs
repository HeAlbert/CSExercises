using System;

namespace CSExercises
{
    public class Ex32
    {
        public static void Main(string[] args)
        {
            int i,t,x,iMaxNum,iMiniNum;
            i = 0;x = 0;
            t =0;
            iMaxNum = 0;
            iMiniNum = 0;
            double dTotalSales = 0;
            string[] Month = new string[]
                {
                    "Jan","Feb","Mar","Apr","May","Jun","Jul","Aug","Sep","Oct","Nov","Dec"
                };
            double[] dSales = new double [12];
            for (i = 0; i <= 11; i++)
            {
                Console.Write("Enter sales for {0} month:", Month[i]);
                dSales[i] = Convert.ToDouble(Console.ReadLine());
               
            }
          
        
            // for (i = 0; i <= 11; i++)
            //{
            //    Console.WriteLine("{0}\t{1}", Month[i],dSales[i]);
            //}

            for ( t= 0; t < 11; t++)
            {
                if (dSales[t] >= dSales[x])
                {
                    iMaxNum = t;
                    x = iMaxNum;
                    
                }
                if (dSales[t] <= dSales[x])
                {
                    iMiniNum = t;
                    x = iMiniNum;

                }
            }
            Console.WriteLine("Maximum Sales: {0}", dSales[iMaxNum]);
            Console.WriteLine("Minimum Sales: {0}", dSales[iMiniNum]);
            for (i=0; i<=11; i++)
            {
                dTotalSales = dTotalSales + dSales[i];

            }
            Console.Write("Average Sales: {0}", dTotalSales / dSales.Length);
        }
    }
}
