using System.Runtime.CompilerServices;



namespace UltimateOrb.Shadows.CppInterop {

    namespace Microsoft {
        public struct Char32StringRecord {

            internal const nuint _BufferSize = 16 / sizeof(UInt32) < 1 ? 1 : 16 / sizeof(UInt32);

            internal unsafe fixed UInt32 __Buffer[checked((int)_BufferSize)];

            internal nuint _Size;

            internal nuint _Capacity;

            internal ref IntPtr __Data {

                get {
                    unsafe {
                        return ref Unsafe.As<UInt32, IntPtr>(ref __Buffer[0]);
                    }
                }
            }
        }
    }
}
