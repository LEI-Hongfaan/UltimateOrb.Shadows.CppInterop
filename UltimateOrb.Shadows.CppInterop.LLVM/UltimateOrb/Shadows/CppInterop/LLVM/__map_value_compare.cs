using System.Runtime.CompilerServices;

namespace UltimateOrb.Shadows.CppInterop {

    namespace LLVM {

        struct __map_value_compare<TCompare, T>
            : ILess<T, ValueTuple>
            where TCompare : unmanaged, ILess<T, ValueTuple> {

            internal TCompare comp = new();

            public __map_value_compare() {
            }

            public bool Invoke(in T first, in T second) => comp.Invoke(first, second);
        }

        struct __map_value_compare_1<TCompare, T>
            : ILess<T, ValueTuple>
            where TCompare : unmanaged, ILess<T, ValueTuple> {

            internal ref TCompare @base {

                get {
                    unsafe {
                        return ref Unsafe.AsRef<TCompare>(Unsafe.AsPointer(ref this));
                    }
                }
            }

            public bool Invoke(in T first, in T second) => @base.Invoke(first, second);
        }
    }
}
