using System;
namespace CSExercises
{
    public class Ex43
    {
        static void Main(string[] args)
        {
           
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine(Hex(i));
            }
        }
        
        public static string Hex(int i)
        {
            
            string [] hex = new string []
                {"0","1","2","3","4","5","6","7","8","9","A","B","C","D","E","F" };
            double d= i ;
            int count = 0;
            int n = 0;
            string Result = "";
            while (i> Math.Pow(16,n)-1)
            {
                count++;
                n++;
            }

            int [] Position = new int[count];

            for (int x = count; x > 0; x--)
            {
                Position[count-x] = Convert.ToInt32(Math.Floor(d / Math.Pow(16, x-1)));
                d = d - Position[count -x] * Math.Pow(16, x-1);
                 
            }
            for (int x = 0; x < count; x++)
            {
               Result = Result + hex[Position[x]] ;
            }
            
            return Result;
        }
    }
}
