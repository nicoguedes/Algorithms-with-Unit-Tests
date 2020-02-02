using AlgorithmCollection;
using AlgorithmCollection.Solutions;
using System;
using Xunit;

namespace XUnitTests
{
    public class FibonacciTest
    {
        [Fact]
        public void Input0()
        {
            Fibonacci f = new Fibonacci();
            Assert.Equal(0, f.CalculateFibonacci(0));
        }

        [Fact]
        public void Input2()
        {
            Fibonacci f = new Fibonacci();
            Assert.Equal(1, f.CalculateFibonacci(2));
        }

        [Fact]
        public void Input10()
        {
            Fibonacci f = new Fibonacci();
            Assert.Equal(55, f.CalculateFibonacci(10));
        }

        [Fact]
        public void Input14()
        {
            Fibonacci f = new Fibonacci();
            Assert.Equal(377, f.CalculateFibonacci(14));
        }

    }
}
