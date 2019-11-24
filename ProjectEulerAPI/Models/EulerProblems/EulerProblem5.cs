using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectEulerAPI.Models.EulerProblems
{
    /// <summary>
    /// 2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.
    /// What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?
    /// </summary>
    /// <returns>232792560</returns>
    public class EulerProblem5 : IEulerProblem
    {
        // 2520 % 1 = 0;
        // 2520 % 2 = 0;
        // 2520 % 3 = 0;
        // 2520 % 4 = 0;
        // 2520 % 5 = 0;
        // 2520 % 6 = 0;
        // 2520 % 7 = 0;
        // 2520 % 8 = 0;
        // 2520 % 9 = 0;
        // 2520 % 10 = 0;
        // 2520 % 11 != 0;

        public int GetResult()
        {
            // 1. what to start with ==> 20
            // 2. generic way of checking modulus ==> for
            // 3. PROFIT

            int startNumber = 2520; // we know this can be divided 1 - 10, but not 11

            int numberToReturn = 0;

            int calculationsPerformed = 0;

            // takes aprox. 30 seconds
            for(int numToCheck = int.MaxValue; numToCheck > startNumber; numToCheck--)
            {
                bool isEvenlyDivisible = true;

                for(int i = 1; i < 21; i++)
                {
                    calculationsPerformed++;

                    if (numToCheck % i != 0)
                    {
                        isEvenlyDivisible = false;
                        break; // not evenly divisible -> no use continuing
                    }
                }

                if(isEvenlyDivisible)
                    numberToReturn = numToCheck;
            }

            return numberToReturn;
        }
    }
}
