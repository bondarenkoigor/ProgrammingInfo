using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7.Classes
{
    internal class IOS : Platform
    {
        public IOS() : base("IOS", new Language[] { new Swift(), new Dart(), new React() }) { }
    }
}
