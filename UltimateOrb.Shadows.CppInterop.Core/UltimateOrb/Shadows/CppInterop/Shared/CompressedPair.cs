using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace UltimateOrb.Shadows.CppInterop {

    namespace Shared {

        /// <inheritdoc cref="ValueTuple{TFirst, TSecond}"/>
        public struct CompressedPair_0_0<TFirst, TSecond>
            : IPair<TFirst, TSecond>
            where TFirst : unmanaged
            where TSecond : unmanaged {

            TFirst _First;

            TSecond _Second;

            TFirst IPair<TFirst, TSecond>.First { readonly get => _First; set => _First = value; }
            
            TSecond IPair<TFirst, TSecond>.Second { readonly get => _Second; set => _Second = value; }

            /// <inheritdoc cref="ValueTuple{TFirst, TSecond}.Item1"/>
            [UnscopedRef]
            public ref TFirst First {

                get => ref _First;
            }

            /// <inheritdoc cref="ValueTuple{TFirst, TSecond}.Item2"/>
            [UnscopedRef]
            public ref TSecond Second {

                get => ref _Second;
            }
        }

        /// <inheritdoc cref="ValueTuple{TFirst, TSecond}"/>
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

            TFirst IPair<TFirst, TSecond>.First { readonly get => _First; set => _First = value; }

            /// <inheritdoc cref="ValueTuple{TFirst, TSecond}.Item1"/>
            [UnscopedRef]
            public ref TFirst First {

                get => ref _First;
            }

            /// <inheritdoc cref="ValueTuple{TFirst, TSecond}.Item2"/>
            public readonly TSecond Second {

                get => default; set { }
            }
        }

        /// <inheritdoc cref="ValueTuple{TFirst, TSecond}"/>
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

            TSecond IPair<TFirst, TSecond>.Second { readonly get => _Second; set => _Second = value; }

            /// <inheritdoc cref="ValueTuple{TFirst, TSecond}.Item1"/>
            public readonly TFirst First {

                get => default; set { }
            }

            /// <inheritdoc cref="ValueTuple{TFirst, TSecond}.Item2"/>
            [UnscopedRef]
            public ref TSecond Second {

                get => ref _Second;
            }
        }

        /// <inheritdoc cref="ValueTuple{TFirst, TSecond}"/>
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

            /// <inheritdoc cref="ValueTuple{TFirst, TSecond}.Item1"/>
            public readonly TFirst First {

                get => default; set { }
            }

            /// <inheritdoc cref="ValueTuple{TFirst, TSecond}.Item2"/>
            public readonly TSecond Second {

                get => default; set { }
            }
        }
    }
}
