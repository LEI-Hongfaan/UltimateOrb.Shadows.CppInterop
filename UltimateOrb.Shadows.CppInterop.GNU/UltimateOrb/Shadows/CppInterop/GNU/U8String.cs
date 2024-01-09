using System.Text;



namespace UltimateOrb.Shadows.CppInterop {

    namespace GNU {
        public struct U8String {

            Char8StringBase_1<byte, int, Allocator<byte>> value__;

            public Span<byte> Span {

                get {
                    unsafe {
                        return value__.Span;
                    }
                }
            }

            public override string ToString() {
                return Encoding.UTF8.GetString(Span);
            }
        }
    }
}
