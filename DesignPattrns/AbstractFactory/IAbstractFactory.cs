using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public interface IAbstractFactory
    {
        IAbstractMethod1 CreatMethod1();
        IAbstractMethod2 CreatMethod2();
    }
}
