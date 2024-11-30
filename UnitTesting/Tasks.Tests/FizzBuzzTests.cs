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

        [Fact]
        public void Should_Return_FizzBuzz_For_Multiples_Of_3_And_5()
        {
            var fizzBuzz = new FizzBuzz();
            var result = fizzBuzz.PrintNumbers(1, 100);

            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    result[i - 1].Should().Be("FizzBuzz");
                }
            }
        }

        [Fact]
        public void Should_Return_Num_For_Non_Multiples_Of_3_Or_5()
        {
            var fizzBuzz = new FizzBuzz();
            var result = fizzBuzz.PrintNumbers(1, 100);

            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 != 0 && i % 5 != 0)
                {
                    result[i - 1].Should().Be(i.ToString());
                }
            }
        }

        [Fact]
        public void Should_Throw_Exception_For_Number_Out_Of_Range()
        {
            var fizzBuzz = new FizzBuzz();

            Action actLow = () => fizzBuzz.FizzBuzzForNumber(0);
            Action actHigh = () => fizzBuzz.FizzBuzzForNumber(101);

            actLow.Should().Throw<ArgumentOutOfRangeException>();
            actHigh.Should().Throw<ArgumentOutOfRangeException>();
        }

        [Theory]
        [InlineData(1, "1")]
        [InlineData(3, "Fizz")]
        [InlineData(5, "Buzz")]
        [InlineData(15, "FizzBuzz")]
        [InlineData(71, "71")]
        [InlineData(97, "97")]
        public void Should_Return_Correct_Result_For_Single_Number(int number, string expected)
        {
            var fizzBuzz = new FizzBuzz();

            var result = fizzBuzz.FizzBuzzForNumber(number);

            result.Should().Be(expected);
        }

    }
}
