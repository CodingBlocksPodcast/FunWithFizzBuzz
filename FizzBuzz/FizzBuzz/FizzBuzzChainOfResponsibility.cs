using System;
using System.Text;

namespace FizzBuzz
{
    /// <summary>
    /// This implementation of FizzBuzz makes use of the Chain of Responsibility pattern.
    /// This is not a good use of the pattern since everything is so tightly coupled, but
    /// it demonstrates knowledge of the patterns and possibly identifies you as being an
    /// "architecture astronaut". (http://www.joelonsoftware.com/articles/fog0000000018.html)
    /// </summary>
    public class FizzBuzzChainOfResponsibility : IFizzBuzzStrategy
    {
        public string Execute()
        {
            var output = new StringBuilder();
            var link = new FifteenLink();
            for(var i = 1; i <= 100; i++)
            {
                output.Append(link.Execute(i) + Environment.NewLine);
            }
            return output.ToString();
        }

        private class FifteenLink : ThreeLink
        {
            internal override string Execute(int i)
            {
                return i % 15 == 0 ? "FizzBuzz" : base.Execute(i);
            }
        }

        private class ThreeLink : FiveLink
        {
            internal override string Execute(int i)
            {
                return i % 3 == 0 ? "Fizz" : base.Execute(i);
            }
        }

        private class FiveLink : DefaultLink
        {
            internal override string Execute(int i)
            {
                return i % 5 == 0 ? "Buzz" : base.Execute(i);
            }
        }

        private class DefaultLink
        {
            internal virtual string Execute(int i)
            {
                return i.ToString();
            }
        }
    }

}
