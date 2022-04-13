using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7.Classes
{
    internal class GameDev : Direction
    {
        public GameDev() : base("Разработка игр", new Platform[] { new PCGame(), new ConsoleGame(), new MobileGame() }) { }

    }
}
