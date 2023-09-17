using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2_Class_Logger
{
    public class BusinessException : Exception
    {
        public BusinessException(string? message) : base(message)
        {
        }
    }
}
