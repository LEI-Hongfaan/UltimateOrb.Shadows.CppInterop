using UltimateOrb.Shadows.CppInterop.Shared;

namespace UltimateOrb.Shadows.CppInterop {

    namespace Microsoft {

        public struct Char8StringBase_0<TChar, Traits, TAllocator>
            where TAllocator : unmanaged {

            CompressedPair_0_0<TAllocator, Char8StringRecord> __Impl;

            public Span<TChar> Span {

                get {
                    unsafe {
                        return new Span<TChar>(__Impl.Second._Data.ToPointer(), checked((int)__Impl.Second._Size));
                    }
                }
            }
        }

        public struct Char8StringBase_1<TChar, Traits, TAllocator>
            where TAllocator : unmanaged {

            CompressedPair_1_0<TAllocator, Char8StringRecord> __Impl;

            public Span<TChar> Span {

                get {
                    unsafe {
                        return new Span<TChar>(__Impl.Second._Data.ToPointer(), checked((int)__Impl.Second._Size));
                    }
                }
            }
        }
    }
}
