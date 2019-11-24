using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectEulerAPI.Models.EulerProblems
{
    /// <summary>
    /// A palindromic number reads the same both ways. The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 × 99.
    /// Find the largest palindrome made from the product of two 3-digit numbers.
    /// </summary>
    /// <returns>906609</returns>
    public class EulerProblem4 : IEulerProblem
    {
        public int GetResult()
        {
            int highestPalindrome = 0;

            for (int x = 999; x > 0; x--)
            {
                // start with 999, then 998, then 997..
                for (int y = 999; y > 0; y--)
                {
                    // start with 999, then 998, then 997..
                    // check if we made a palindromic number after multiplying x and y
                    int result = x * y;


                    int reverse = this.ReverseInt(result);

                    // if the reverse (i.e. 41200214) is the same as the first result (i.e. 41200214)
                    // we've found the palindromic number and can stop
                    if (result == reverse)
                    {
                        if(result > highestPalindrome)
                            highestPalindrome = result;
                    }
                }
            }

            return highestPalindrome;
        }

        private int ReverseInt(int intToReverse)
        {

            int reverse = 0;
            while (intToReverse > 0)
            {
                reverse = reverse * 10 + intToReverse % 10;
                intToReverse /= 10;
            }
            return reverse;
        }
    }
}
