﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerProject.Business
{
    /// <summary>
    /// If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.
    /// Find the sum of all the multiples of 3 or 5 below 1000.
    /// </summary>
    public class Problem1 : Problem
    {
        public override void Init()
        {
            base.id = 1;
            base.Name = "Problem1";
        }

        public override void Execute()
        {
            Init();
            int number = 1000;
            List<int> multiples = new List<int> {3,5};
            Console.WriteLine(string.Format("Result:{0}", Result(multiples, number)));
        }

        protected int Result(List<int> multiples, int MaxNumber) {
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
