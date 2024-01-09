using System.Runtime.CompilerServices;

namespace UltimateOrb.Shadows.CppInterop {

    namespace LLVM {

        public struct NonResidentStringRecord_64<IsStringLayoutAlternativeT, TChar>
            : INonResidentStringRecord<TChar>
            where IsStringLayoutAlternativeT : struct, IConstantDataType<bool, IsStringLayoutAlternativeTag>
            where TChar : unmanaged {


            UInt64 __Data;
            UInt64 __Size;
            UInt64 __Capacity;

            internal const int __StructureSize = sizeof(UInt64) * 3;

            ref NonResidentStringRecord_64<IsStringLayoutAlternativeT, TChar> DangerousGetReference() {
                unsafe {
                    return ref Unsafe.AsRef<NonResidentStringRecord_64<IsStringLayoutAlternativeT, TChar>>(Unsafe.AsPointer(ref this));
                }
            }

            static IsStringLayoutAlternativeT IsStringLayoutAlternative {

                get => new IsStringLayoutAlternativeT();
            }

            public ref Ptr<TChar> Data {

                get {
                    ref var @this = ref DangerousGetReference();
                    return ref IsStringLayoutAlternative.Value ? ref Unsafe.As<UInt64, Ptr<TChar>>(ref @this.__Data) : ref Unsafe.As<UInt64, Ptr<TChar>>(ref @this.__Capacity);
                }
            }

            public ref nuint Size {

                get => ref Unsafe.As<UInt64, nuint>(ref DangerousGetReference().__Size);
            }

            public ref nuint Capacity {
                get {
                    ref var @this = ref DangerousGetReference();
                    return ref Unsafe.As<UInt64, nuint>(ref IsStringLayoutAlternative.Value ? ref @this.__Capacity : ref @this.__Data);
                }
            }
        }

        public struct NonResidentStringRecord_32<IsStringLayoutAlternativeT, TChar>
            : INonResidentStringRecord<TChar>
            where IsStringLayoutAlternativeT : struct, IConstantDataType<bool, IsStringLayoutAlternativeTag>
            where TChar : unmanaged {


            UInt32 __Data;
            UInt32 __Size;
            UInt32 __Capacity;

            internal const int __StructureSize = sizeof(UInt32) * 3;

            ref NonResidentStringRecord_32<IsStringLayoutAlternativeT, TChar> DangerousGetReference() {
                unsafe {
                    return ref Unsafe.AsRef<NonResidentStringRecord_32<IsStringLayoutAlternativeT, TChar>>(Unsafe.AsPointer(ref this));
                }
            }

            static IsStringLayoutAlternativeT IsStringLayoutAlternative {

                get => new IsStringLayoutAlternativeT();
            }

            public ref Ptr<TChar> Data {

                get {
                    ref var @this = ref DangerousGetReference();
                    return ref IsStringLayoutAlternative.Value ? ref Unsafe.As<UInt32, Ptr<TChar>>(ref @this.__Data) : ref Unsafe.As<UInt32, Ptr<TChar>>(ref @this.__Capacity);
                }
            }

            public ref nuint Size {

                get => ref Unsafe.As<UInt32, nuint>(ref DangerousGetReference().__Size);
            }

            public ref nuint Capacity {
                get {
                    ref var @this = ref DangerousGetReference();
                    return ref Unsafe.As<UInt32, nuint>(ref IsStringLayoutAlternative.Value ? ref @this.__Capacity : ref @this.__Data);
                }
            }
        }
    }
}
