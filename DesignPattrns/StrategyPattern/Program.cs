using System;
using System.Net;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var writer = new Writer();

            writer.SetStrategy(new PencelStrategy());
            var w1 = writer.Write("Text");
            Console.WriteLine(w1);

            writer.SetStrategy(new PenStrategy());
            var w2 = writer.Write("Tex2");
            Console.WriteLine(w2);
        }
    }
}
