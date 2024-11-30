﻿using System;
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

            result.Count.Should().Be(100);
        }

        [Fact]
        public void Should_Return_Fizz_For_Multiples_Of_3()
        {
            var fizzBuzz = new FizzBuzz();
            var result = fizzBuzz.PrintNumbers(1, 100);

            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0 && i % 5 != 0)
                {
                    result[i - 1].Should().Be("Fizz");
                }
            }
        }

        [Fact]
        public void Should_Return_Buzz_For_Multiples_Of_5()
        {
            var fizzBuzz = new FizzBuzz();
            var result = fizzBuzz.PrintNumbers(1, 100);

            for (int i = 1; i <= 100; i++)
            {
                if (i % 5 == 0 && i % 3 != 0)
                {
                    result[i - 1].Should().Be("Buzz");
                }
            }
        }

    }
}
