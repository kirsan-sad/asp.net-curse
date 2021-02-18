using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    public class PencelStrategy : IWriterStrategy
    {
        public string Write(string s)
        {
            return $"Write with a pencil: {s}";
        }
    }
}
