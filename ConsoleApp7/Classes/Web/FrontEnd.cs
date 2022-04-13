using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7.Classes
{
    internal class FrontEnd : Platform
    {
        public FrontEnd() : base("FrontEnd разработка", new Language[] { new HTML(), new CSS(), new React(), new Angular(), new Vue(), new Razor() }) { }
    }
}
