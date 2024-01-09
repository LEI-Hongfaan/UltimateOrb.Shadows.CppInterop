using System.Text;



namespace UltimateOrb.Shadows.CppInterop {

    namespace LLVM {
        public struct U8String_64 : IDisposable {

            Char8StringBase_64_1<LibCppAbiV1Options, byte, int, Allocator<byte>> value__;

            public Span<byte> Span {

                get {
                    unsafe {
                        return value__.Span;
                    }
                }
            }

            public void Dispose() {
                value__.Dispose();
            }

            public override string ToString() {
                return Encoding.UTF8.GetString(Span);
            }
        }
    }
}
