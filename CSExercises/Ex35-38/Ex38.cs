using System;
namespace CSExercises
{
    public class Ex38
    {
        public static void Main(string[] args)
        {
            double tempMark;
            string tempName;
            tempMark = 0;
            tempName = ""; 
            string[] Name = new string[]
                {"John","Venkat","Mary","Victor","Betty" };
            double[] Mark = new double[]
                { 63,29,75,82,55};
            for (int i = 0; i < Mark.Length-1; i++)
            {
                for (int j = i+1; j < Mark.Length ; j++)
                {
                    if (Mark[i] < Mark[j])
                    {
                        tempMark = Mark[i];
                        Mark[i] = Mark[j];
                        Mark[j] = tempMark;

                        tempName = Name[i];
                        Name[i] = Name[j];
                        Name[j] = tempName; 
                    }
                }
                
            }
            Console.WriteLine("Name\tMark");
            for (int i = 0; i < Mark.Length; i++)
            {
                Console.WriteLine("{0}\t{1}", Name[i], Mark[i]);
            }

            Console.WriteLine("");
            for (int i = 0; i < Name.Length; i++)
            {
                Name[i] = Name[i].ToUpper();
            }
            for (int i = 0; i < Name.Length-1; i++)
            {
                for (int j = i + 1; j < Name.Length; j++)
                {
                    if (Name[i].CompareTo(Name[j]) == 1)
                    {
                        tempMark = Mark[j];
                        Mark[j] = Mark[i];
                        Mark[i] = tempMark;

                        tempName = Name[j];
                        Name[j] = Name[i];
                        Name[i] = tempName;
                    }

                }
                   
            
            }
            Console.WriteLine("Name\tMark");
            for(int i=0; i< Name.Length; i++)
            {
                Console.WriteLine("{0}\t{1}", Name[i], Mark[i]);
             }
        }
    }
}
