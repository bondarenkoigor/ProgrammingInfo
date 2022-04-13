using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7.Classes
{
    internal abstract class SubDirection
    {
        public string Name { get; set; }
        public SubDirection(string name)
        {
            Name = name;
        }
    }
}
