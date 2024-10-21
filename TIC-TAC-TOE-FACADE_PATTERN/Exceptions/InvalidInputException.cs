using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TIC_TAC_TOE_FACADE_PATTERN.Exceptions
{
        public class InvalidInputException : Exception
        {
            public InvalidInputException(string message) : base(message) { }
        }
}
