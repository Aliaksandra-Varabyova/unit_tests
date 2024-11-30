using System;
using FluentAssertions;
using Xunit;

namespace Tasks.Tests
{
    public class LeapYearTests
    {

        [Theory]
        [InlineData(1996, true)]
        [InlineData(2000, true)]
        [InlineData(1900, false)]
        [InlineData(2001, false)]
        [InlineData(1600, true)]
        [InlineData(1700, false)]
        [InlineData(1800, false)]
        [InlineData(2020, true)]
        public void Should_Return_Correct_Result_For_Leap_Year(int year, bool expected)
        {
            var LeapYear = new LeapYear();

            var result = LeapYear.IsLeapYear(year);

            result.Should().Be(expected);
        }

    }
}
