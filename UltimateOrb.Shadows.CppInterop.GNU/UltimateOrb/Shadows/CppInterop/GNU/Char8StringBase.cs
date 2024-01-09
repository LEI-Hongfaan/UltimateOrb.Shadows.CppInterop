using System.Runtime.CompilerServices;
using UltimateOrb.Shadows.CppInterop.Shared;

namespace UltimateOrb.Shadows.CppInterop {

    namespace GNU {

        public struct Char8StringBase_0<TChar, Traits, TAllocator>
            where TAllocator : unmanaged {

            CompressedPair_0_0<TAllocator, IntPtr> __Pointer_;

            nuint __Size;

            Char8StringCapacityOrLocalBuffer __Capacity_;
        }

        public struct Char8StringBase_1<TChar, Traits, TAllocator>
            where TAllocator : unmanaged {

            CompressedPair_1_0<TAllocator, IntPtr> __Pointer_;

            nuint __Size;

            Char8StringCapacityOrLocalBuffer __Capacity_;

            public Span<TChar> Span {

                get {
                    unsafe {
                        Console.WriteLine($@"{(nuint)Unsafe.AsPointer(ref __Capacity_.__Data[0]):X16}");

                        Console.WriteLine($@"{(nuint)__Pointer_.Second.ToPointer():X16}");

                        return new Span<TChar>(Unsafe.AsPointer(ref __Capacity_.__Data[0]), checked((int)__Size));
                        // return new Span<TChar>(__Pointer_.Second.ToPointer(), checked((int)__Size));
                    }
                }
            }
        }
    }
}
