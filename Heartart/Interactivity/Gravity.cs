using System;
using System.Collections.Generic;
using System.Text;

namespace Heartart.Interactivity
{
    class Gravity
    {
        private Gravity() { }

        private static class GravityHolder
        {
            public static Gravity instance = new Gravity();
        }

        public static Gravity GetCoincidence()
        {
            return GravityHolder.instance;
        }
    }
}
