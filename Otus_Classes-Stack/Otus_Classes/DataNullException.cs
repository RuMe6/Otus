using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otus_Classes
{
    public class DataNullException : Exception
    {
        public DataNullException() { }
        public DataNullException(string message) : base(message) { }

        public DataNullException(string message, Exception inner) : base (message, inner) { }


    }
}
