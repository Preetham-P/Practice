using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seatingarray
{
    class CoinChngeProblem
    {

        public int coinChange(int[] arr, int amount)
        {
            int[] combinations = new int[amount + 1];
            combinations[0] = 1;

            foreach (int item in arr)
            {
                for (int i = 1; i <= amount; i++)
                {
                    if (i >= item)
                    {
                        combinations[i] += combinations[i - item];
                    }
                }
            }
            return combinations[amount];
        }
    }
}
