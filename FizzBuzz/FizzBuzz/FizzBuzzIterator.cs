using System;
using System.Text;

namespace FizzBuzz
{
    /// <summary>
    /// This example makes use of the Iterator pattern to "MoveNext" through the sequence. It is an overly complex
    /// solution for the problem, but I'd argue it's not a terrible way to do it. The itereator fulfills it's purpose
    /// of abstracting the underlying mechanism from it's caller.
    /// </summary>
    public class FizzBuzzIterator : IFizzBuzzStrategy
    {
        public string Execute()
        {
            var output = new StringBuilder();
            var iterator = new Iterator();
            for (var i = 1; i <= 100; i++)
            {
                output.Append(iterator.Current + Environment.NewLine);
                iterator.MoveNext();
            }
            return output.ToString();
        }

        private class Iterator
        {
            private int _index = 1;

            internal void MoveNext()
            {
                _index++;
            }

            internal string Current
            {
                get
                {
                    if (_index % 15 == 0)
                    {
                        return "FizzBuzz";
                    }
                    if (_index % 3 == 0)
                    {
                        return "Fizz";
                    }
                    if (_index % 5 == 0)
                    {
                        return "Buzz";
                    }
                    return _index.ToString();
                }
            }
        }
    }
}
