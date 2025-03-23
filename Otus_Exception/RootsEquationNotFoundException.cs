using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otus_Exception
{
    internal class RootsEquationNotFoundException : Exception
    {
        public RootsEquationNotFoundException() { }
        public RootsEquationNotFoundException(string message) : base(message) { }
        public RootsEquationNotFoundException(string message, Exception ex) : base(message, ex) { }
    }
}
