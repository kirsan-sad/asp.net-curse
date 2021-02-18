using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    public class PenStrategy : IWriterStrategy
    {
        public string Write(string s)
        {
            return $"Write with a pen: {s}";
        }
    }
}
