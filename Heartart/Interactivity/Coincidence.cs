using System;
using System.Collections.Generic;
using System.Text;

namespace Heartart.Interactivity
{
    public class Coincidence
    {
        private Coincidence() { }

        private static class CoincidenceHolder
        {
            public static Coincidence instance = new Coincidence();
        }

        public static Coincidence GetCoincidence()
        {
            return CoincidenceHolder.instance;
        }
    }
}
