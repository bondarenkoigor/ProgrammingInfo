using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7.Classes
{
    internal class Android : Platform
    {
        public Android() : base("Android", new Language[] { new Java(), new Kotlin(), new React(), new Dart() }) { }
    }
}
