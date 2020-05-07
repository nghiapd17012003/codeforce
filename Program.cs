using System;

namespace _1345B
{
    class Program
    {
        static void Main(string[] args)
        {
            int NoOfCase = int.Parse(Console.ReadLine());
            int[] result = new int[NoOfCase];

            for (int a = 0; a < NoOfCase; a++)
            {
                int n = int.Parse(Console.ReadLine());
                
                while (n >= 2)
                {
                    int sum = 0;
                    for (int b = 0; b < 99999999; b++)
                    {
                        sum = sum + 3 * b + 2;
                        if (sum > n)
                        {
                            n = n - sum+ 3*b+2 ;
                            result[a]++;
                            break;
                        }
                        if (sum == n)
                        {
                            n = n - sum;
                            result[a]++;
                            break;
                        }
                    }
                }
                

            }
            for (int c = 0; c < NoOfCase; c++)
            {
                Console.WriteLine(result[c]);
            }
            
        }
    }
}
