using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    /// <summary>
    /// Defines the interface for the FizzBuzz family of algorithms
    /// </summary>
    public interface IFizzBuzzStrategy
    {
        string Execute();
    }
}
