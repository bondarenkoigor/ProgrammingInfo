﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7.Classes
{
    internal class Game2D : Platform
    {
        public Game2D() : base("2D Игры", new Language[] {new CSharp(), new CPP() }) { }
    }
}
