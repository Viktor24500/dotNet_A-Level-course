using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotNet_lab1
{
    public class Events<T> : EventArgs
    {
        public T Data { get; }
        public Events(T data)
        {
            Data = data;
        }
    }
}
