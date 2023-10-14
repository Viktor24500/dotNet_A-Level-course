using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Events.Entity
{
    public class Box : IItems
    {
        public string Name { get; }
        public string Description { get; }
        public Types Type => Types.Box;

        public Box(string name, string description)
        {
            Name = name;
            Description = description;
        }
    }
}
