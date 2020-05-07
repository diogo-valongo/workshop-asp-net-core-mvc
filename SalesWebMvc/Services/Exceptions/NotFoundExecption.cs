using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMvc.Services.Exceptions
{
    public class NotFoundExecption : ApplicationException
    {
        public NotFoundExecption(string message) : base(message)
        {
        }        
    }
}
