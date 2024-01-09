using System.Text;

namespace UltimateOrb.Shadows.CppInterop {

    namespace Microsoft {

        public struct U8String_0 {

            Char8StringBase_0<byte, int, Allocator<byte>> value__;

            public Span<byte> Span {

                get {
                    unsafe {
                        return value__.Span;
                    }
                }
            }

            public override string ToString() {
                var encoding = new UTF8Encoding(false, false);
                return encoding.GetString(Span);
            }
        }

        public struct U8String_1 {

            Char8StringBase_1<byte, int, Allocator<byte>> value__;

            public Span<byte> Span {

                get {
                    unsafe {
                        return value__.Span;
                    }
                }
            }

            public override string ToString() {
                var encoding = new UTF8Encoding(false, false);
                return encoding.GetString(Span);
            }
        }
    }
}
