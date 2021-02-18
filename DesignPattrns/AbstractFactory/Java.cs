using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public class Java : IAbstractFactory
    {
        public IAbstractMethod1 CreatMethod1()
        {
            return new ConcreteMethod1();
        }

        public IAbstractMethod2 CreatMethod2()
        {
            return new ConcreteMethod2();
        }
    }
}
