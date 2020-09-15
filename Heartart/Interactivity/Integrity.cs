using System;
using System.Collections.Generic;
using System.Text;

namespace Heartart.Interactivity
{
    class Integrity
    {
        private Integrity() { }

        private static class IntegrityHolder
        {
            public static Integrity instance = new Integrity();
        }

        public static Integrity GetCoincidence()
        {
            return IntegrityHolder.instance;
        }
    }
}
