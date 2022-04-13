using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7.Classes
{
    internal class Game3D : Platform
    {
        public Game3D() : base("3D Игры", new Language[] { new CSharp(), new CPP() }) { }
    }
}
