namespace Somerton.Constant_Primordial_Unity
{
    public class Chance
    {
        public Chance(char code)
        {
            // Snurr
            Knowing = AttainedRealQuanta.Innate(code); // X4 @Theory = K.C
            Influx = AttainedRealQuanta.Innate(code); // E = B.10
            Expanse = AttainedRealQuanta.Innate(code); // = D.A
            Matter = AttainedRealQuanta.Innate(code); // = Q.N
            Qualia = AttainedRealQuanta.Innate(code); // = G.E
            Negentropic = AttainedRealQuanta.Innate(code); // = C.1
            Mystery = AttainedRealQuanta.Innate(code); // M; Gaze @Omega = M.12
        }
        private Heartart.Interfaces.IHeartart AttainedRealQuanta { get; }
        private char Knowing { get; }
        private char Influx { get; }
        private char Expanse { get; }
        private char Matter { get; }
        private char Qualia { get; }
        private char Negentropic { get; }
        public char Mystery { get; }
    }
}
