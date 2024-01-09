using System.Runtime.InteropServices;



namespace UltimateOrb.Shadows.CppInterop {

    namespace GNU {
        [StructLayout(LayoutKind.Explicit)]
        public struct Char32StringCapacityOrLocalBuffer {

            [FieldOffset(0)]
            internal nuint __Capacity;

            [FieldOffset(0)]
            internal unsafe fixed UInt32 __Data[1 + 15 / sizeof(UInt32)];
        }
    }
}
