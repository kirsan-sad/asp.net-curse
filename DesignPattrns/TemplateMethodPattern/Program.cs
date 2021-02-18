using System;

namespace TemplateMethodPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var hamburger = new Hamburger();
            Console.WriteLine("Cook Hamburger:");
            hamburger.Cook();

            Console.WriteLine("\nCook Hotdog:");
            var hotdog = new HotDog();
            hotdog.Cook();
        }
    }
}
