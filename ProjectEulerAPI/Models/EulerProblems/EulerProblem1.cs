using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectEulerAPI.Models.EulerProblems
{
    /// <summary>
    /// If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.
    /// Find the sum of all the multiples of 3 or 5 below 1000.
    /// </summary>
    /// <returns>The sum of all the multiples of 3 or 5 below 1000</returns>
    public class EulerProblem1 : IEulerProblem
    {
        public int GetResult()
        {
            // First Version
            /*            
            List<int> multiplesOf3Or5 = new List<int>();

            for(int i = 1; i < 1000; i++)
            {
                if (i % 3 == 0)
                    multiplesOf3Or5.Add(i);
                else if (i % 5 == 0)
                    multiplesOf3Or5.Add(i);
            }

            return multiplesOf3Or5.Sum();
            */

            // Improved Version
            int x = 1;
            int sum = 0;
            while (x < 1000)
            {
                if (x % 3 == 0 || x % 5 == 0)
                    sum += x;

                x++;
            }

            return sum;
        }
    }
}
