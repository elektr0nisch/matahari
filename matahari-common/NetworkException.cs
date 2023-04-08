using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matahari
{
    public class NetworkException : Exception
    {
        public NetworkException() { }
        
        public NetworkException(string message) : base(message) { }
    }
}
