using System;

namespace CSExercises
{
    public class Ex41
    {
        
            static void Main(string[] args)
        {
            Console.Write(InString(Console.ReadLine(), Console.ReadLine()));
        }
        public static bool InString(string s1, string s2)
        {

            
            bool occurs = false;
            int t = 0;

            for (int i = 0; i < s1.Length; i++)
            {
                int count = 1;
                if (s2[0] == s1[i] && i + s2.Length <= s1.Length)
                 {
                    
                    for (int j = 1; j < s2.Length; j++)
                    {
                        
                        if (s2[j] == s1[j + i])
                        {
                            count++;
                        }
                    }
                    
                }
                t = count;
                if (count == s2.Length)
                    break;
            }
                if (t == s2.Length)
                {
                    occurs = true;
                }
                else
                    occurs = false;

                return occurs;
            }
        }
    }
