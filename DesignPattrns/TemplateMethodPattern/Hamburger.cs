using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethodPattern
{
    public class Hamburger : FastFood
    {
        public override void MakeMainIngredient()
        {
            Console.WriteLine("Got a cutlet");
        }

        public override void MakeTopping()
        {
            Console.WriteLine("Got a ketchup");
        }
    }
}
