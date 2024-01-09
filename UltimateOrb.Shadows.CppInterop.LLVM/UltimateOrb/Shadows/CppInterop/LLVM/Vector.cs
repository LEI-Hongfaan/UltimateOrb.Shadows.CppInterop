using UltimateOrb.Shadows.CppInterop.Shared;

namespace UltimateOrb.Shadows.CppInterop {

    namespace LLVM {

        public struct Vector_0<T, TAllocator>
            where T : unmanaged
            where TAllocator : unmanaged {

            unsafe T* _Begin;
            unsafe T* _End;
            unsafe CompressedPair_0_0<TAllocator, Ptr<T>> _AllocatorAndCapacityEnd;

            public Span<T> AsSpan() {
                unsafe {
                    return new Span<T>(_Begin, checked((int)unchecked(_End - _Begin)));
                }
            }
        }

        public struct Vector_1<T, TAllocator>
            where T : unmanaged
            where TAllocator : unmanaged {

            unsafe T* _Begin;
            unsafe T* _End;
            unsafe CompressedPair_1_0<TAllocator, Ptr<T>> _AllocatorAndCapacityEnd;

            public Span<T> AsSpan() {
                unsafe {
                    return new Span<T>(_Begin, checked((int)unchecked(_End - _Begin)));
                }
            }
        }
    }
}
