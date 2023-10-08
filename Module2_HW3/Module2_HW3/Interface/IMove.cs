using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2_HW3.Interface
{
    public interface IMove
    {
        public string Brand { get; set; }
        public int Speed { get; set; }

        public void Move();
    }
}
