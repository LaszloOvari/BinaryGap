using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsecutiveZeros
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 1041;
            Console.WriteLine(Solution.MaxGap(n));

            Console.ReadLine();
        }
    }

    public class Solution
    {
        public static int MaxGap(int n)
        {
            int gapMax = 0;
            int zeroCount = 0;
            string nBinary = Convert.ToString(n, 2);
            for (int i = 0; i < nBinary.Length; i++)
            {
                if (nBinary[i] == '0')
                {
                    zeroCount++;
                }
                else
                {
                    if (zeroCount > gapMax)
                    {
                        gapMax = zeroCount;
                    }
                    zeroCount = 0;
                }
            }
            return gapMax;
        }
    }
}
