using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Events.Entity
{
    public interface IItems
    {
        public string Name { get; }
        public string Description { get; }
        public Types Type { get; }
    }
}
