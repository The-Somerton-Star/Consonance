using System;
using System.Collections.Generic;
using System.Text;

namespace Heartart.Interactivity
{
    class Interaction
    {
        private Interaction() { }

        private static class InteractionHolder
        {
            public static Interaction instance = new Interaction();
        }

        public static Interaction GetCoincidence()
        {
            return InteractionHolder.instance;
        }
    }

}
