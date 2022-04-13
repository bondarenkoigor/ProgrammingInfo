using System;
using ConsoleApp7.Classes;

namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            Manager manager = new Manager();
            while (true)
            { 
                manager.MainMenu();
                Console.ReadLine();
            }
        }
    }
}
