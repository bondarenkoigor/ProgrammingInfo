using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7.Classes
{
    internal class BackEnd : Platform
    {
        public BackEnd() : base("BackEnd разработка", new Language[] { new Java(), new CSharp(), new NodeJS(), new PHP(), new Python(), new Ruby() }) { }
    }
}
