using System.Collections.Generic;
using System.Linq;

namespace EulerProject.Business
{
    public class Problem1 : IProblem
    {
        /// <summary>
        /// If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.
        /// Find the sum of all the multiples of 3 or 5 below 1000.
        /// </summary>
        public string Execute()
        {
            int number = 1000;
            List<int> multiples = new List<int> { 3, 5 };
            return Result(multiples, number).ToString();
        }

        protected int Result(List<int> multiples, int MaxNumber)
        {
            List<int> values = new List<int>();
            for (int m = 0; m < multiples.Count(); m++)
            {
                for (int i = 0; i < MaxNumber; i += multiples[m])
                    if (values.IndexOf(i) < 0)
                        values.Add(i);
            }
            return values.Sum();
        }
    }
}