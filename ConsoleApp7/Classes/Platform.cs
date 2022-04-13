using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7.Classes
{
    internal abstract class Platform : SubDirection
    {
        public Language[] Languages { get; set; } 
        public Platform(string name, Language[] languages) : base(name) 
        {
            Languages = languages;
        }
        public virtual void PlatformMenu()
        {
            Console.Clear();
            for (int i = 0; i < Languages.Length; i++)
                Console.WriteLine($"{i + 1}. {Languages[i].Name}");

            int choice = int.Parse(Console.ReadLine());
            if (choice == 0) return;
            Console.Clear();
            Console.WriteLine(Languages[choice - 1].Description);
        }
    }
}
