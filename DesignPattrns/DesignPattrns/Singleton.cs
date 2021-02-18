using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonPattern
{
    public sealed class Singleton
    {
        private Singleton() { }

        private static readonly Lazy<Singleton> lazy =
            new Lazy<Singleton>(() => new Singleton());

        public static Singleton Source { get { return lazy.Value; } }
    }
}
