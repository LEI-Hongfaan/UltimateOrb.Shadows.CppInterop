using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace UltimateOrb.Shadows.CppInterop {

    namespace Shared {

        public struct CompressedPair<TFirst, TSecond>
        : IPair<TFirst, TSecond>
        where TFirst : unmanaged
        where TSecond : unmanaged {

            TFirst _First;

            TSecond _Second;

            ref CompressedPair<TFirst, TSecond> DangerousGetReference() {
                unsafe {
                    return ref Unsafe.AsRef<CompressedPair<TFirst, TSecond>>(Unsafe.AsPointer(ref this));
                }
            }

            public ref TFirst First {

                get => ref DangerousGetReference()._First;
            }

            public ref TSecond Second {

                get => ref DangerousGetReference()._Second;
            }
        }

        public struct CompressedPair_0_1<TFirst, TSecond>
            : IPair<TFirst, TSecond>
            where TFirst : unmanaged
            where TSecond : unmanaged {

#if DEBUG
            static CompressedPair_0_1() {
                Debug.Assert(TypeTraits.IsEmptyType<TSecond>());
            }
#endif

            TFirst _First;

            ref CompressedPair_0_1<TFirst, TSecond> DangerousGetReference() {
                unsafe {
                    return ref Unsafe.AsRef<CompressedPair_0_1<TFirst, TSecond>>(Unsafe.AsPointer(ref this));
                }
            }

            public ref TFirst First {

                get => ref DangerousGetReference()._First;
            }

            public ref TSecond Second {

                get => ref Unsafe.NullRef<TSecond>();
            }
        }

        public struct CompressedPair_1_0<TFirst, TSecond>
            : IPair<TFirst, TSecond>
            where TFirst : unmanaged
            where TSecond : unmanaged {

#if DEBUG
            static CompressedPair_1_0() {
                Debug.Assert(TypeTraits.IsEmptyType<TFirst>());
            }
#endif

            TSecond _Second;

            ref CompressedPair_1_0<TFirst, TSecond> DangerousGetReference() {
                unsafe {
                    return ref Unsafe.AsRef<CompressedPair_1_0<TFirst, TSecond>>(Unsafe.AsPointer(ref this));
                }
            }

            public ref TFirst First {

                get => ref Unsafe.NullRef<TFirst>();
            }

            public ref TSecond Second {

                get => ref DangerousGetReference()._Second;
            }
        }

        public struct CompressedPair_1_1<TFirst, TSecond>
            : IPair<TFirst, TSecond>
            where TFirst : unmanaged
            where TSecond : unmanaged {

#if DEBUG
            static CompressedPair_1_1() {
                Debug.Assert(TypeTraits.IsEmptyType<TFirst>());
                Debug.Assert(TypeTraits.IsEmptyType<TSecond>());
            }
#endif

            public ref TFirst First {

                get => ref Unsafe.NullRef<TFirst>();
            }

            public ref TSecond Second {

                get => ref Unsafe.NullRef<TSecond>();
            }
        }
    }
}
