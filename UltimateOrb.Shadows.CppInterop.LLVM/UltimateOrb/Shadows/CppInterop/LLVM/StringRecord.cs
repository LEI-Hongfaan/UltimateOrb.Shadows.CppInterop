using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace UltimateOrb.Shadows.CppInterop {

    namespace LLVM {

        struct Char8StringRecord_64<IsStringLayoutAlternativeT, TChar>
            where IsStringLayoutAlternativeT : struct, IConstantDataType<bool, IsStringLayoutAlternativeTag>
            where TChar : unmanaged {

            private const int __RecordStructureSize = NonResidentStringRecord_64<IsStringLayoutAlternativeT, TChar>.__StructureSize > Char8ResidentStringRecord_64<IsStringLayoutAlternativeT, TChar>.__StructureSize ?
                NonResidentStringRecord_64<IsStringLayoutAlternativeT, TChar>.__StructureSize :
                Char8ResidentStringRecord_64<IsStringLayoutAlternativeT, TChar>.__StructureSize;

            internal const int __StructureSize = checked((sizeof(UInt64) - 1 + __RecordStructureSize) / sizeof(UInt64) * sizeof(UInt64));

            unsafe fixed UInt64 p[__StructureSize / sizeof(UInt64)];

            internal ref NonResidentStringRecord_64<IsStringLayoutAlternativeT, TChar> _NonResidentRecord {
                
                get {
                    unsafe {
                        return ref Unsafe.As<UInt64, NonResidentStringRecord_64<IsStringLayoutAlternativeT, TChar>>(ref p[0]);
                    }
                }
            }

            internal ref Char8ResidentStringRecord_64<IsStringLayoutAlternativeT, TChar> _ResidentRecord {
                
                get {
                    unsafe {
                        return ref Unsafe.As<UInt64, Char8ResidentStringRecord_64<IsStringLayoutAlternativeT, TChar>>(ref p[0]);
                    }
                }
            }
        }

        struct Char16StringRecord_64<IsStringLayoutAlternativeT, TChar>
            where IsStringLayoutAlternativeT : struct, IConstantDataType<bool, IsStringLayoutAlternativeTag>
            where TChar : unmanaged {

            private const int __RecordStructureSize = NonResidentStringRecord_64<IsStringLayoutAlternativeT, TChar>.__StructureSize > Char16ResidentStringRecord_64<IsStringLayoutAlternativeT, TChar>.__StructureSize ?
                NonResidentStringRecord_64<IsStringLayoutAlternativeT, TChar>.__StructureSize :
                Char16ResidentStringRecord_64<IsStringLayoutAlternativeT, TChar>.__StructureSize;

            internal const int __StructureSize = checked((sizeof(UInt64) - 1 + __RecordStructureSize) / sizeof(UInt64) * sizeof(UInt64));

            unsafe fixed UInt64 p[__StructureSize / sizeof(UInt64)];

            internal ref NonResidentStringRecord_64<IsStringLayoutAlternativeT, TChar> _NonResidentRecord {
                
                get {
                    unsafe {
                        return ref Unsafe.As<UInt64, NonResidentStringRecord_64<IsStringLayoutAlternativeT, TChar>>(ref p[0]);
                    }
                }
            }

            internal ref Char16ResidentStringRecord_64<IsStringLayoutAlternativeT, TChar> _ResidentRecord {
                
                get {
                    unsafe {
                        return ref Unsafe.As<UInt64, Char16ResidentStringRecord_64<IsStringLayoutAlternativeT, TChar>>(ref p[0]);
                    }
                }
            }
        }

        struct Char32StringRecord_64<IsStringLayoutAlternativeT, TChar>
            where IsStringLayoutAlternativeT : struct, IConstantDataType<bool, IsStringLayoutAlternativeTag>
            where TChar : unmanaged {

            private const int __RecordStructureSize = NonResidentStringRecord_64<IsStringLayoutAlternativeT, TChar>.__StructureSize > Char32ResidentStringRecord_64<IsStringLayoutAlternativeT, TChar>.__StructureSize ?
                NonResidentStringRecord_64<IsStringLayoutAlternativeT, TChar>.__StructureSize :
                Char32ResidentStringRecord_64<IsStringLayoutAlternativeT, TChar>.__StructureSize;

            internal const int __StructureSize = checked((sizeof(UInt64) - 1 + __RecordStructureSize) / sizeof(UInt64) * sizeof(UInt64));

            unsafe fixed UInt64 p[__StructureSize / sizeof(UInt64)];

            internal ref NonResidentStringRecord_64<IsStringLayoutAlternativeT, TChar> _NonResidentRecord {
                
                get {
                    unsafe {
                        return ref Unsafe.As<UInt64, NonResidentStringRecord_64<IsStringLayoutAlternativeT, TChar>>(ref p[0]);
                    }
                }
            }

            internal ref Char32ResidentStringRecord_64<IsStringLayoutAlternativeT, TChar> _ResidentRecord {
                
                get {
                    unsafe {
                        return ref Unsafe.As<UInt64, Char32ResidentStringRecord_64<IsStringLayoutAlternativeT, TChar>>(ref p[0]);
                    }
                }
            }
        }

        struct Char8StringRecord_32<IsStringLayoutAlternativeT, TChar>
            where IsStringLayoutAlternativeT : struct, IConstantDataType<bool, IsStringLayoutAlternativeTag>
            where TChar : unmanaged {

            private const int __RecordStructureSize = NonResidentStringRecord_32<IsStringLayoutAlternativeT, TChar>.__StructureSize > Char8ResidentStringRecord_32<IsStringLayoutAlternativeT, TChar>.__StructureSize ?
                NonResidentStringRecord_32<IsStringLayoutAlternativeT, TChar>.__StructureSize :
                Char8ResidentStringRecord_32<IsStringLayoutAlternativeT, TChar>.__StructureSize;

            internal const int __StructureSize = checked((sizeof(UInt32) - 1 + __RecordStructureSize) / sizeof(UInt32) * sizeof(UInt32));

            unsafe fixed UInt32 p[__StructureSize / sizeof(UInt32)];

            internal ref NonResidentStringRecord_32<IsStringLayoutAlternativeT, TChar> _NonResidentRecord {
                
                get {
                    unsafe {
                        return ref Unsafe.As<UInt32, NonResidentStringRecord_32<IsStringLayoutAlternativeT, TChar>>(ref p[0]);
                    }
                }
            }

            internal ref Char8ResidentStringRecord_32<IsStringLayoutAlternativeT, TChar> _ResidentRecord {
                
                get {
                    unsafe {
                        return ref Unsafe.As<UInt32, Char8ResidentStringRecord_32<IsStringLayoutAlternativeT, TChar>>(ref p[0]);
                    }
                }
            }
        }

        struct Char16StringRecord_32<IsStringLayoutAlternativeT, TChar>
            where IsStringLayoutAlternativeT : struct, IConstantDataType<bool, IsStringLayoutAlternativeTag>
            where TChar : unmanaged {

            private const int __RecordStructureSize = NonResidentStringRecord_32<IsStringLayoutAlternativeT, TChar>.__StructureSize > Char16ResidentStringRecord_32<IsStringLayoutAlternativeT, TChar>.__StructureSize ?
                NonResidentStringRecord_32<IsStringLayoutAlternativeT, TChar>.__StructureSize :
                Char16ResidentStringRecord_32<IsStringLayoutAlternativeT, TChar>.__StructureSize;

            internal const int __StructureSize = checked((sizeof(UInt32) - 1 + __RecordStructureSize) / sizeof(UInt32) * sizeof(UInt32));

            unsafe fixed UInt32 p[__StructureSize / sizeof(UInt32)];

            internal ref NonResidentStringRecord_32<IsStringLayoutAlternativeT, TChar> _NonResidentRecord {
                
                get {
                    unsafe {
                        return ref Unsafe.As<UInt32, NonResidentStringRecord_32<IsStringLayoutAlternativeT, TChar>>(ref p[0]);
                    }
                }
            }

            internal ref Char16ResidentStringRecord_32<IsStringLayoutAlternativeT, TChar> _ResidentRecord {
                
                get {
                    unsafe {
                        return ref Unsafe.As<UInt32, Char16ResidentStringRecord_32<IsStringLayoutAlternativeT, TChar>>(ref p[0]);
                    }
                }
            }
        }

        struct Char32StringRecord_32<IsStringLayoutAlternativeT, TChar>
            where IsStringLayoutAlternativeT : struct, IConstantDataType<bool, IsStringLayoutAlternativeTag>
            where TChar : unmanaged {

            private const int __RecordStructureSize = NonResidentStringRecord_32<IsStringLayoutAlternativeT, TChar>.__StructureSize > Char32ResidentStringRecord_32<IsStringLayoutAlternativeT, TChar>.__StructureSize ?
                NonResidentStringRecord_32<IsStringLayoutAlternativeT, TChar>.__StructureSize :
                Char32ResidentStringRecord_32<IsStringLayoutAlternativeT, TChar>.__StructureSize;

            internal const int __StructureSize = checked((sizeof(UInt32) - 1 + __RecordStructureSize) / sizeof(UInt32) * sizeof(UInt32));

            unsafe fixed UInt32 p[__StructureSize / sizeof(UInt32)];

            internal ref NonResidentStringRecord_32<IsStringLayoutAlternativeT, TChar> _NonResidentRecord {
                
                get {
                    unsafe {
                        return ref Unsafe.As<UInt32, NonResidentStringRecord_32<IsStringLayoutAlternativeT, TChar>>(ref p[0]);
                    }
                }
            }

            internal ref Char32ResidentStringRecord_32<IsStringLayoutAlternativeT, TChar> _ResidentRecord {
                
                get {
                    unsafe {
                        return ref Unsafe.As<UInt32, Char32ResidentStringRecord_32<IsStringLayoutAlternativeT, TChar>>(ref p[0]);
                    }
                }
            }
        }
    }
}
