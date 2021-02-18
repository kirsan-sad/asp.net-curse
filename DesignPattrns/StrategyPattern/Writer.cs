using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    public class Writer
    {
        private IWriterStrategy _strategy;

        public Writer() { }
        public Writer(IWriterStrategy strategy)
        {
            _strategy = strategy;
        }

        public void SetStrategy(IWriterStrategy strategy)
        {
            _strategy = strategy;
        }

        public string Write(string s)
        {
            return _strategy.Write(s);
        }
    }
}
