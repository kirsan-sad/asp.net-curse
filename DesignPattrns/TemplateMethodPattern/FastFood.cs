using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethodPattern
{
    public abstract class FastFood
    {
        public void Cook()
        {
            MakeBread();
            MakeMainIngredient();
            MakeVegetables();
            MakeTopping();
        }

        public virtual void MakeBread()
        {
            Console.WriteLine("Got a bread");
        }

        public abstract void MakeMainIngredient();

        public virtual void MakeVegetables()
        {
            Console.WriteLine("Got a vegetables");
        }
        public abstract void MakeTopping();
    }
}
