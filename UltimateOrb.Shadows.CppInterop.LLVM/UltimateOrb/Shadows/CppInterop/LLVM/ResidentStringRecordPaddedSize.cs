using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace UltimateOrb.Shadows.CppInterop {

    namespace LLVM {
        
        struct Char8ResidentStringRecordPaddedSize<IsStringLayoutAlternativeT>
            where IsStringLayoutAlternativeT : struct, IConstantDataType<bool, IsStringLayoutAlternativeTag> {
            
            unsafe fixed sbyte p[1];
            
#pragma warning disable IDE1006 // Naming Styles
            internal ref byte _Size {
#pragma warning restore IDE1006 // Naming Styles
                
                get {
                    unsafe {
                        return ref new IsStringLayoutAlternativeT().Value ? ref Unsafe.As<sbyte, byte>(ref p[0]) : ref Unsafe.Subtract(ref Unsafe.As<sbyte, byte>(ref p[1]), 1);
                    }
                }
            }
        }
        
        struct Char16ResidentStringRecordPaddedSize<IsStringLayoutAlternativeT>
            where IsStringLayoutAlternativeT : struct, IConstantDataType<bool, IsStringLayoutAlternativeTag> {
            
            unsafe fixed char p[1];
            
#pragma warning disable IDE1006 // Naming Styles
            internal ref byte _Size {
#pragma warning restore IDE1006 // Naming Styles
                
                get {
                    unsafe {
                        return ref new IsStringLayoutAlternativeT().Value ? ref Unsafe.As<char, byte>(ref p[0]) : ref Unsafe.Subtract(ref Unsafe.As<char, byte>(ref p[1]), 1);
                    }
                }
            }
        }
        
        struct Char32ResidentStringRecordPaddedSize<IsStringLayoutAlternativeT>
            where IsStringLayoutAlternativeT : struct, IConstantDataType<bool, IsStringLayoutAlternativeTag> {
            
            unsafe fixed UInt32 p[1];
            
#pragma warning disable IDE1006 // Naming Styles
            internal ref byte _Size {
#pragma warning restore IDE1006 // Naming Styles
                
                get {
                    unsafe {
                        return ref new IsStringLayoutAlternativeT().Value ? ref Unsafe.As<UInt32, byte>(ref p[0]) : ref Unsafe.Subtract(ref Unsafe.As<UInt32, byte>(ref p[1]), 1);
                    }
                }
            }
        }
    }
}
