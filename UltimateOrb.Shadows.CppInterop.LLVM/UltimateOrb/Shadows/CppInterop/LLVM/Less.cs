namespace UltimateOrb.Shadows.CppInterop {


    namespace LLVM {
        public struct Less<T> : ILess<T, ValueTuple> {

            public bool Invoke(in T first, in T second) {
                return Comparer<T>.Default.Compare(first, second) < 0;
            }
        }

    }
}
