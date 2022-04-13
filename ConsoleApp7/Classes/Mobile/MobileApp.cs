using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7.Classes
{
    internal class MobileApp : Direction
    {
        public MobileApp() : base("Мобильные приложения", new Platform[] { new IOS(), new Android() }) { }
    }
}
