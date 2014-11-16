using System;
using System.Text;

namespace FizzBuzz
{
    /// <summary>
    /// This is a terrible solution, the values in each function call are pushed onto the call stack and are
    /// not cleaned up until the sequence is complete. It's not such big deal for 100, but it is a bad algorithm.
    /// </summary>
    public class FizzBuzzRecursive : IFizzBuzzStrategy
    {
        public string Execute()
        {
            return RecursiveExcecute(1, 100, new StringBuilder()).ToString();
        }

        private static StringBuilder RecursiveExcecute(int i, int max, StringBuilder output)
        {
            if (i > max)
            {
                return output;
            }

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
            return RecursiveExcecute(i + 1, max, output);
        }
    }
}
