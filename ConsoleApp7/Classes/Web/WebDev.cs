using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7.Classes
{
    internal class WebDev : Direction
    {
        public WebDev() : base("Web-разработка", new Platform[] { new BackEnd(), new FrontEnd() }) { }
    }
}
