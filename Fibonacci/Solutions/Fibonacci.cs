using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmCollection.Solutions
{
    public class Fibonacci
    {
        public int CalculateFibonacci(int n)
        {
            if (n <= 1)
                return n;

            return CalculateFibonacci(n - 2) + CalculateFibonacci(n - 1);
        }
    }
}
