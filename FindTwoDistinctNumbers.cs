using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitwise
{
    public class FindTwoDistinctNumbers
    {
        public void FindDistinctNumbers()
        {
            int[] arr = { 1, 4, 2, 1, 3, 5, 6, 2, 3, 5 };
            int xored = 0;
            foreach (int num in arr)
                xored ^= num;

            int num1 = 0;
            int num2 = 0;

            foreach (int num in arr)
            {
                if ((num & xored) == 0)
                {
                    num1 ^= num;
                }
                else
                {
                    num2 ^= num;
                }
            }
            Console.WriteLine($"The distinct numbers are {num1} and {num2}");
            Console.ReadLine();
        }
    }
}
