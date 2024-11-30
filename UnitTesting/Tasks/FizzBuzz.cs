using System;
using System.Collections.Generic;

namespace Tasks
{
    public class FizzBuzz
    {
        public List<string> PrintNumbers(int start, int end)
        {
            var result = new List<string>();

            for (int i = start; i <= end; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                    result.Add("FizzBuzz");
                else if (i % 3 == 0)
                    result.Add("Fizz");
                else if (i % 5 == 0)
                    result.Add("Buzz");
                else
                    result.Add(i.ToString());
            }

            return result;
        }

        public string FizzBuzzForNumber(int number)
        {
            if (number < 1 || number > 100)
                throw new ArgumentOutOfRangeException("Number should be between 1 and 100");

            if (number % 3 == 0 && number % 5 == 0)
                return "FizzBuzz";
            else if (number % 3 == 0)
                return "Fizz";
            else if (number % 5 == 0)
                return "Buzz";
            else
                return number.ToString();
        }
    }
}

