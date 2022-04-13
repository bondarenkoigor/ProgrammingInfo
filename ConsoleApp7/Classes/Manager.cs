using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7.Classes
{
    internal class Manager
    {
        public Direction[] Directions { get; set; }

        public Manager()
        {
            Directions = new Direction[] { new GameDev(), new  MobileApp(), new DesktopApp(), new WebDev()};
        }
        public void MainMenu()
        {
            Console.Clear();
            for (int i = 0; i < Directions.Length; i++)
                Console.WriteLine($"{i + 1}. {Directions[i].Name}");

            int choice = int.Parse(Console.ReadLine());
            if (choice == 0) return;
            Directions[choice - 1].DirectionMenu();
        }
    }
}
