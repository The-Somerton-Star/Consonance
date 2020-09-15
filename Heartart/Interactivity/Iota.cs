using System;
using System.Collections.Generic;
using System.Text;

namespace Heartart.Interactivity
{
    class Iota
    {
        private Iota() { }

        private static class IotaHolder
        {
            public static Iota instance = new Iota();
        }

        public static Iota GetCoincidence()
        {
            return IotaHolder.instance;
        }
    }

}
