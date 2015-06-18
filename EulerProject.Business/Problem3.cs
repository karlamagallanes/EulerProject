using System.Collections.Generic;
using System.Linq;

namespace EulerProject.Business
{
    public class Problem3 : IProblem
    {
        /// <summary>
        /// The prime factors of 13195 are 5, 7, 13 and 29.
        /// What is the largest prime factor of the number 600851475143 ?
        /// </summary>
        public string Execute()
        {
            double max = 600851475143;
            return GetResult(max).ToString();
        }

        private static double GetResult(double max)
        {
            List<double> primes = new List<double>();
            double d = 2;
            while (max > 1)
            {
                while (max % d == 0)
                {
                    primes.Add(d);
                    max /= d;
                }
                d++;
            }
            return primes.LastOrDefault();
        }
    }
}