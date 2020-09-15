namespace Somerton.Constant_Primordial_Unity
{
    public class Dimension
    {
        public Dimension(char data)
        {
            // 
            Position = AttainedRealQuanta.Innate(data); // X4 @Theory = K.C
            Acumen = AttainedRealQuanta.Innate(data); // E = B.10
            Obtainment = AttainedRealQuanta.Innate(data); // = D.A
            Multiverse = AttainedRealQuanta.Innate(data); // = Q.N
            Quantity = AttainedRealQuanta.Innate(data); // = G.E
            Phenomena = AttainedRealQuanta.Innate(data); // = C.1
            Meter = AttainedRealQuanta.Innate(data); // M; Gaze @Omega = M.12
        }
        private Heartart.Interfaces.IHeartart AttainedRealQuanta { get; }
        private char Position { get; }
        private char Acumen { get; }
        private char Obtainment { get; }
        private char Multiverse { get; }
        private char Quantity { get; }
        private char Phenomena { get; }
        public char Meter { get; }
    }
}
