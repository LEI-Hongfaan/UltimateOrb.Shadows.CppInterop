using System.Runtime.CompilerServices;



namespace UltimateOrb.Shadows.CppInterop {

    namespace Microsoft {
        public struct Char8StringRecord {

            internal const nuint _BufferSize = 16 / sizeof(sbyte) < 1 ? 1 : 16 / sizeof(sbyte);

            internal unsafe fixed sbyte __Buffer[checked((int)_BufferSize)];

            internal nuint _Size;

            internal nuint _Capacity;

            internal ref IntPtr __Data {

                get {
                    unsafe {
                        return ref Unsafe.As<sbyte, IntPtr>(ref __Buffer[0]);
                    }
                }
            }

            internal bool _IsNonResident {

                get => _BufferSize <= _Capacity;
            }

            internal IntPtr _Data {

                get {
                    unsafe {
                        ref var t = ref __Data;
                        return _IsNonResident ? t : new IntPtr(Unsafe.AsPointer(ref t));
                    }
                }
            }

        }
    }
}
