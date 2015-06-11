using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerProject.Business
{
    public class Problem3 : Problem
    {
        /// <summary>
        /// The prime factors of 13195 are 5, 7, 13 and 29.
        /// What is the largest prime factor of the number 600851475143 ?
        /// </summary>
        public override void Execute()
        {
            Int64 max = 600851475143;
            Console.WriteLine(string.Format("Result: {0}", GetResult(max)));
        }


        private static Int64 GetResult(Int64 max)
        {
            List<Int64> primes = new List<Int64>();



            //TODO: primes must be ordered.
            return primes.LastOrDefault();
        }
    }

}



