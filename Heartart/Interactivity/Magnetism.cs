using System;
using System.Collections.Generic;
using System.Text;

namespace Heartart.Interactivity
{
    class Magnetism
    {
        private Magnetism() { }

        private static class MagnetismHolder
        {
            public static Magnetism instance = new Magnetism();
        }

        public static Magnetism GetCoincidence()
        {
            return MagnetismHolder.instance;
        }
    }
}
