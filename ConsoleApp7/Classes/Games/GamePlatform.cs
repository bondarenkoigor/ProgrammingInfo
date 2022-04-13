using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7.Classes
{
    internal abstract class GamePlatform : Platform
    {
        public Platform[] GameTypes { get; set; }
        public GamePlatform(string name) : base(name, new Language[] {}) 
        {
            GameTypes = new Platform[2] { new Game2D(), new Game3D() };
        }
        public override void PlatformMenu()
        {
            Console.Clear();
            for (int i = 0; i < GameTypes.Length; i++)
                Console.WriteLine($"{i + 1}. {GameTypes[i].Name}");

            int choice = int.Parse(Console.ReadLine());
            if (choice == 0) return;
            GameTypes[choice - 1].PlatformMenu();
        }
    }
}
