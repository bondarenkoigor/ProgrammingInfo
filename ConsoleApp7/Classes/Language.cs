using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7.Classes
{
    internal abstract class Language : SubDirection
    {
        public string Description { get; set; }
        public Language(string name, string description) : base(name) 
        {
            Description = description;
        }
    }
}
