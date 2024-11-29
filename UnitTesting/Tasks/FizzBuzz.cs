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
                result.Add(i.ToString());
            }

            return result;
        }
    }
}

