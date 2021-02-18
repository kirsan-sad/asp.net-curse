using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    public interface IWriterStrategy
    {
        string Write(string s);
    }
}
