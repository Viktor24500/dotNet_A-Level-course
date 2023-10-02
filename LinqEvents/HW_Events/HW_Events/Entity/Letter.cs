using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Events.Entity
{
    public class Letter : IItems
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public Types Type => Types.Letter;

        public Letter(string name, string description)
        {
            Name = name;
            Description = description;
        }
    }
}
