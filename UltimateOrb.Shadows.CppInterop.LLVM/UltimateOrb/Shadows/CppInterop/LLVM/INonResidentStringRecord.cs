namespace UltimateOrb.Shadows.CppInterop {

    namespace LLVM {
        public interface INonResidentStringRecord<TChar>
            where TChar : unmanaged {

            public ref Ptr<TChar> Data {

                get;
            }

            public ref nuint Size {

                get;
            }

            public ref nuint Capacity {
                get;
            }
        }
    }
}
