using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public class ConcreteMethod1 : IAbstractMethod1
    {
        public string DoSomeWork1()
        {
            return "I'll do some work 1";
        }
    }
}
