using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7.Classes
{
    internal class MacOS : Platform
    {
        public MacOS() : base("MacOS", new Language[] { new Java(), new Kotlin(), new React(), new Dart(), new Python(), new NodeJS(), new CPP(), new CSharp() }) { }
    }
}
