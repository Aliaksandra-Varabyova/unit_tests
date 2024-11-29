using System;
using FluentAssertions;
using Xunit;

namespace Tasks.Tests
{
    public class FizzBuzzTests
    {
        [Fact]
        public void Should_Print_Numbers_1_To_100()
        {
            var fizzBuzz = new FizzBuzz();
            var result = fizzBuzz.PrintNumbers(1, 100);

            for (int i = 1; i <= 100; i++)
            {

                Assert.Contains(i.ToString(), result);
            }
        }

    }
}
