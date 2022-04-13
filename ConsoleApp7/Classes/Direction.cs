using System;

namespace ConsoleApp7.Classes
{
    internal abstract class Direction
    {
        public string Name { get; set; }
        public Platform[] Platforms { get; private set; }

        public Direction(string name,  Platform[] platforms)
        {
            Name = name;
            Platforms = platforms;
        }

        public void DirectionMenu()
        {
            Console.Clear();
            for (int i = 0; i < Platforms.Length; i++)
                Console.WriteLine($"{i + 1}. {Platforms[i].Name}");

            int choice = int.Parse(Console.ReadLine());
            if (choice == 0) return;
            Platforms[choice - 1].PlatformMenu();
        }
    }
}
