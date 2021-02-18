using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethodPattern
{
    public class HotDog : FastFood
    {
        public override void MakeMainIngredient()
        {
            Console.WriteLine("Got a sausage");
        }

        public override void MakeTopping()
        {
            Console.WriteLine("Got a mustard");
        }
    }
}
