using System;
using System.Text;

namespace FizzBuzz
{
    /// <summary>
    /// This is the "normal" type of solution that interviewers expect you to give.
    /// It returns a string rather than writing to console to make testing easier.
    /// </summary>
    public class FizzBuzzStandard : IFizzBuzzStrategy
    {
        public string Execute()
        {
            var output = new StringBuilder();
            for (var i = 1; i <= 100; i++)
            {
                if (i % 15 == 0)
                {
                    output.Append("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    output.Append("Fizz");
                }
                else if (i % 5 == 0)
                {
                    output.Append("Buzz");
                }
                else
                {
                    output.Append(i);
                }
                output.Append(Environment.NewLine);
            }
            return output.ToString();
        }
    }
}
