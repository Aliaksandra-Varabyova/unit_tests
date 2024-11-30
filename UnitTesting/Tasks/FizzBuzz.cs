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
    }
}

