namespace UltimateOrb.Shadows.CppInterop {


    namespace LLVM {
        public interface ICompare<T, Tag> {

            public abstract bool Invoke(in T first, in T second);
        }

    }
}
