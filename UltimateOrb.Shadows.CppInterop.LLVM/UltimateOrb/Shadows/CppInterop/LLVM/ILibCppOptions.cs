namespace UltimateOrb.Shadows.CppInterop {

    namespace LLVM {
        public interface ILibCppOptions :
            IConstantDataType<bool, IsStringLayoutAlternativeTag>,
            IConstantDataType<bool, IsBigEndianTag> {

            // _LIBCPP_ABI_ALTERNATE_STRING_LAYOUT
            public abstract bool IsStringLayoutAlternative {

                get;
            }

            bool IConstantDataType<bool, IsStringLayoutAlternativeTag>.Value {

                get => IsStringLayoutAlternative;
            }

            // _LIBCPP_BIG_ENDIAN
            public virtual bool IsBigEndian {

                get => !BitConverter.IsLittleEndian;
            }

            bool IConstantDataType<bool, IsBigEndianTag>.Value {

                get => IsBigEndian;
            }
        }
    }
}
