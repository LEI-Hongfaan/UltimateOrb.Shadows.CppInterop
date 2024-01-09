using System.Runtime.CompilerServices;



namespace UltimateOrb.Shadows.CppInterop {

    namespace Microsoft {
        public struct Char16StringRecord {

            internal const nuint _BufferSize = 16 / sizeof(char) < 1 ? 1 : 16 / sizeof(char);

            internal unsafe fixed char __Buffer[checked((int)_BufferSize)];

            internal nuint _Size;

            internal nuint _Capacity;

            internal ref IntPtr __Data {

                get {
                    unsafe {
                        return ref Unsafe.As<char, IntPtr>(ref __Buffer[0]);
                    }
                }
            }
        }
    }
}
