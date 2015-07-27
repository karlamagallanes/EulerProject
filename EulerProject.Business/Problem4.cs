using System;
namespace EulerProject.Business
{
    public class Problem4 : IProblem
    {
        /// <summary>
        /// A palindromic number reads the same both ways. The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 × 99.
        /// Find the largest palindrome made from the product of two 3-digit numbers.
        /// </summary>
        public string Execute()
        {
            return GetResult().ToString();
        }

        private int GetResult()
        {
            int result = 0;
            int maxResult = 0;
            for (int x=999; x > 0; x--)
                for (int y = x; y > 0; y--)
                {
                    result = x * y;
                    if (IsPalindrome(result.ToString()) && result > maxResult)
                        maxResult = result;
                }
            return maxResult;
        }

        private bool IsPalindrome(string result)
        {
            char[] c = result.ToCharArray();
            int x = result.Length - 1;
            for (int i = 0; i < x; i++, x--)
            {
                if (c[i] != c[x])
                    return false;
            }
            return true;
        }
    }
}