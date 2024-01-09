using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace UltimateOrb.Shadows.CppInterop {

    namespace LLVM {
        
        public struct Char8ResidentStringRecord_64<IsStringLayoutAlternativeT, TChar>
            where IsStringLayoutAlternativeT : struct, IConstantDataType<bool, IsStringLayoutAlternativeTag>
            where TChar : unmanaged {

            private const int __SizeOfTChar = sizeof(sbyte);

#if DEBUG
            static Char8ResidentStringRecord_64() {
                Debug.Assert(__SizeOfTChar == Unsafe.SizeOf<TChar>());
            }
#endif

            internal const nuint BufferElementCount = (NonResidentStringRecord_64<IsStringLayoutAlternativeT, TChar>.__StructureSize - 1) / __SizeOfTChar > 2 ? (NonResidentStringRecord_64<IsStringLayoutAlternativeT, TChar>.__StructureSize - 1) / __SizeOfTChar : 2;

            ref Char8ResidentStringRecord_64<IsStringLayoutAlternativeT, TChar> DangerousGetReference() {
                unsafe {
                    return ref Unsafe.AsRef<Char8ResidentStringRecord_64<IsStringLayoutAlternativeT, TChar>>(Unsafe.AsPointer(ref this));
                }
            }

            private const int __BufferElementSize = checked((int)(1 + BufferElementCount));

            unsafe fixed sbyte __Data_[__BufferElementSize];

            internal const int __StructureSize = __SizeOfTChar * __BufferElementSize;

            public unsafe TChar* __Data {

                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                get {
                    unsafe {
                        return (TChar*)Unsafe.AsPointer(ref new IsStringLayoutAlternativeT().Value ? ref __Data_[0] : ref __Data_[1]);
                    }
                }
            }

            /*
            public ref TChar Data {

                get {
                    unsafe {
                        return ref *__Data;
                    }
                }
            }
            */

            public ref TChar this[nint offset] {

                get {
                    Debug.Assert(checked((nint)BufferElementCount) > offset);
                    unsafe {
                        return ref __Data[offset];
                    }
                }
            }

            public ref byte Size {

                get {
                    unsafe {
                        return ref Unsafe.As<sbyte, Char8ResidentStringRecordPaddedSize<IsStringLayoutAlternativeT>>(ref new IsStringLayoutAlternativeT().Value ? ref __Data_[unchecked((int)BufferElementCount)] : ref __Data_[0])._Size;
                    }
                }
            }
        }
        
        public struct Char16ResidentStringRecord_64<IsStringLayoutAlternativeT, TChar>
            where IsStringLayoutAlternativeT : struct, IConstantDataType<bool, IsStringLayoutAlternativeTag>
            where TChar : unmanaged {

            private const int __SizeOfTChar = sizeof(char);

#if DEBUG
            static Char16ResidentStringRecord_64() {
                Debug.Assert(__SizeOfTChar == Unsafe.SizeOf<TChar>());
            }
#endif

            internal const nuint BufferElementCount = (NonResidentStringRecord_64<IsStringLayoutAlternativeT, TChar>.__StructureSize - 1) / __SizeOfTChar > 2 ? (NonResidentStringRecord_64<IsStringLayoutAlternativeT, TChar>.__StructureSize - 1) / __SizeOfTChar : 2;

            ref Char16ResidentStringRecord_64<IsStringLayoutAlternativeT, TChar> DangerousGetReference() {
                unsafe {
                    return ref Unsafe.AsRef<Char16ResidentStringRecord_64<IsStringLayoutAlternativeT, TChar>>(Unsafe.AsPointer(ref this));
                }
            }

            private const int __BufferElementSize = checked((int)(1 + BufferElementCount));

            unsafe fixed char __Data_[__BufferElementSize];

            internal const int __StructureSize = __SizeOfTChar * __BufferElementSize;

            public unsafe TChar* __Data {

                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                get {
                    unsafe {
                        return (TChar*)Unsafe.AsPointer(ref new IsStringLayoutAlternativeT().Value ? ref __Data_[0] : ref __Data_[1]);
                    }
                }
            }

            /*
            public ref TChar Data {

                get {
                    unsafe {
                        return ref *__Data;
                    }
                }
            }
            */

            public ref TChar this[nint offset] {

                get {
                    Debug.Assert(checked((nint)BufferElementCount) > offset);
                    unsafe {
                        return ref __Data[offset];
                    }
                }
            }

            public ref byte Size {

                get {
                    unsafe {
                        return ref Unsafe.As<char, Char16ResidentStringRecordPaddedSize<IsStringLayoutAlternativeT>>(ref new IsStringLayoutAlternativeT().Value ? ref __Data_[unchecked((int)BufferElementCount)] : ref __Data_[0])._Size;
                    }
                }
            }
        }
        
        public struct Char32ResidentStringRecord_64<IsStringLayoutAlternativeT, TChar>
            where IsStringLayoutAlternativeT : struct, IConstantDataType<bool, IsStringLayoutAlternativeTag>
            where TChar : unmanaged {

            private const int __SizeOfTChar = sizeof(UInt32);

#if DEBUG
            static Char32ResidentStringRecord_64() {
                Debug.Assert(__SizeOfTChar == Unsafe.SizeOf<TChar>());
            }
#endif

            internal const nuint BufferElementCount = (NonResidentStringRecord_64<IsStringLayoutAlternativeT, TChar>.__StructureSize - 1) / __SizeOfTChar > 2 ? (NonResidentStringRecord_64<IsStringLayoutAlternativeT, TChar>.__StructureSize - 1) / __SizeOfTChar : 2;

            ref Char32ResidentStringRecord_64<IsStringLayoutAlternativeT, TChar> DangerousGetReference() {
                unsafe {
                    return ref Unsafe.AsRef<Char32ResidentStringRecord_64<IsStringLayoutAlternativeT, TChar>>(Unsafe.AsPointer(ref this));
                }
            }

            private const int __BufferElementSize = checked((int)(1 + BufferElementCount));

            unsafe fixed UInt32 __Data_[__BufferElementSize];

            internal const int __StructureSize = __SizeOfTChar * __BufferElementSize;

            public unsafe TChar* __Data {

                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                get {
                    unsafe {
                        return (TChar*)Unsafe.AsPointer(ref new IsStringLayoutAlternativeT().Value ? ref __Data_[0] : ref __Data_[1]);
                    }
                }
            }

            /*
            public ref TChar Data {

                get {
                    unsafe {
                        return ref *__Data;
                    }
                }
            }
            */

            public ref TChar this[nint offset] {

                get {
                    Debug.Assert(checked((nint)BufferElementCount) > offset);
                    unsafe {
                        return ref __Data[offset];
                    }
                }
            }

            public ref byte Size {

                get {
                    unsafe {
                        return ref Unsafe.As<UInt32, Char32ResidentStringRecordPaddedSize<IsStringLayoutAlternativeT>>(ref new IsStringLayoutAlternativeT().Value ? ref __Data_[unchecked((int)BufferElementCount)] : ref __Data_[0])._Size;
                    }
                }
            }
        }
        
        public struct Char8ResidentStringRecord_32<IsStringLayoutAlternativeT, TChar>
            where IsStringLayoutAlternativeT : struct, IConstantDataType<bool, IsStringLayoutAlternativeTag>
            where TChar : unmanaged {

            private const int __SizeOfTChar = sizeof(sbyte);

#if DEBUG
            static Char8ResidentStringRecord_32() {
                Debug.Assert(__SizeOfTChar == Unsafe.SizeOf<TChar>());
            }
#endif

            internal const nuint BufferElementCount = (NonResidentStringRecord_32<IsStringLayoutAlternativeT, TChar>.__StructureSize - 1) / __SizeOfTChar > 2 ? (NonResidentStringRecord_32<IsStringLayoutAlternativeT, TChar>.__StructureSize - 1) / __SizeOfTChar : 2;

            ref Char8ResidentStringRecord_32<IsStringLayoutAlternativeT, TChar> DangerousGetReference() {
                unsafe {
                    return ref Unsafe.AsRef<Char8ResidentStringRecord_32<IsStringLayoutAlternativeT, TChar>>(Unsafe.AsPointer(ref this));
                }
            }

            private const int __BufferElementSize = checked((int)(1 + BufferElementCount));

            unsafe fixed sbyte __Data_[__BufferElementSize];

            internal const int __StructureSize = __SizeOfTChar * __BufferElementSize;

            public unsafe TChar* __Data {

                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                get {
                    unsafe {
                        return (TChar*)Unsafe.AsPointer(ref new IsStringLayoutAlternativeT().Value ? ref __Data_[0] : ref __Data_[1]);
                    }
                }
            }

            /*
            public ref TChar Data {

                get {
                    unsafe {
                        return ref *__Data;
                    }
                }
            }
            */

            public ref TChar this[nint offset] {

                get {
                    Debug.Assert(checked((nint)BufferElementCount) > offset);
                    unsafe {
                        return ref __Data[offset];
                    }
                }
            }

            public ref byte Size {

                get {
                    unsafe {
                        return ref Unsafe.As<sbyte, Char8ResidentStringRecordPaddedSize<IsStringLayoutAlternativeT>>(ref new IsStringLayoutAlternativeT().Value ? ref __Data_[unchecked((int)BufferElementCount)] : ref __Data_[0])._Size;
                    }
                }
            }
        }
        
        public struct Char16ResidentStringRecord_32<IsStringLayoutAlternativeT, TChar>
            where IsStringLayoutAlternativeT : struct, IConstantDataType<bool, IsStringLayoutAlternativeTag>
            where TChar : unmanaged {

            private const int __SizeOfTChar = sizeof(char);

#if DEBUG
            static Char16ResidentStringRecord_32() {
                Debug.Assert(__SizeOfTChar == Unsafe.SizeOf<TChar>());
            }
#endif

            internal const nuint BufferElementCount = (NonResidentStringRecord_32<IsStringLayoutAlternativeT, TChar>.__StructureSize - 1) / __SizeOfTChar > 2 ? (NonResidentStringRecord_32<IsStringLayoutAlternativeT, TChar>.__StructureSize - 1) / __SizeOfTChar : 2;

            ref Char16ResidentStringRecord_32<IsStringLayoutAlternativeT, TChar> DangerousGetReference() {
                unsafe {
                    return ref Unsafe.AsRef<Char16ResidentStringRecord_32<IsStringLayoutAlternativeT, TChar>>(Unsafe.AsPointer(ref this));
                }
            }

            private const int __BufferElementSize = checked((int)(1 + BufferElementCount));

            unsafe fixed char __Data_[__BufferElementSize];

            internal const int __StructureSize = __SizeOfTChar * __BufferElementSize;

            public unsafe TChar* __Data {

                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                get {
                    unsafe {
                        return (TChar*)Unsafe.AsPointer(ref new IsStringLayoutAlternativeT().Value ? ref __Data_[0] : ref __Data_[1]);
                    }
                }
            }

            /*
            public ref TChar Data {

                get {
                    unsafe {
                        return ref *__Data;
                    }
                }
            }
            */

            public ref TChar this[nint offset] {

                get {
                    Debug.Assert(checked((nint)BufferElementCount) > offset);
                    unsafe {
                        return ref __Data[offset];
                    }
                }
            }

            public ref byte Size {

                get {
                    unsafe {
                        return ref Unsafe.As<char, Char16ResidentStringRecordPaddedSize<IsStringLayoutAlternativeT>>(ref new IsStringLayoutAlternativeT().Value ? ref __Data_[unchecked((int)BufferElementCount)] : ref __Data_[0])._Size;
                    }
                }
            }
        }
        
        public struct Char32ResidentStringRecord_32<IsStringLayoutAlternativeT, TChar>
            where IsStringLayoutAlternativeT : struct, IConstantDataType<bool, IsStringLayoutAlternativeTag>
            where TChar : unmanaged {

            private const int __SizeOfTChar = sizeof(UInt32);

#if DEBUG
            static Char32ResidentStringRecord_32() {
                Debug.Assert(__SizeOfTChar == Unsafe.SizeOf<TChar>());
            }
#endif

            internal const nuint BufferElementCount = (NonResidentStringRecord_32<IsStringLayoutAlternativeT, TChar>.__StructureSize - 1) / __SizeOfTChar > 2 ? (NonResidentStringRecord_32<IsStringLayoutAlternativeT, TChar>.__StructureSize - 1) / __SizeOfTChar : 2;

            ref Char32ResidentStringRecord_32<IsStringLayoutAlternativeT, TChar> DangerousGetReference() {
                unsafe {
                    return ref Unsafe.AsRef<Char32ResidentStringRecord_32<IsStringLayoutAlternativeT, TChar>>(Unsafe.AsPointer(ref this));
                }
            }

            private const int __BufferElementSize = checked((int)(1 + BufferElementCount));

            unsafe fixed UInt32 __Data_[__BufferElementSize];

            internal const int __StructureSize = __SizeOfTChar * __BufferElementSize;

            public unsafe TChar* __Data {

                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                get {
                    unsafe {
                        return (TChar*)Unsafe.AsPointer(ref new IsStringLayoutAlternativeT().Value ? ref __Data_[0] : ref __Data_[1]);
                    }
                }
            }

            /*
            public ref TChar Data {

                get {
                    unsafe {
                        return ref *__Data;
                    }
                }
            }
            */

            public ref TChar this[nint offset] {

                get {
                    Debug.Assert(checked((nint)BufferElementCount) > offset);
                    unsafe {
                        return ref __Data[offset];
                    }
                }
            }

            public ref byte Size {

                get {
                    unsafe {
                        return ref Unsafe.As<UInt32, Char32ResidentStringRecordPaddedSize<IsStringLayoutAlternativeT>>(ref new IsStringLayoutAlternativeT().Value ? ref __Data_[unchecked((int)BufferElementCount)] : ref __Data_[0])._Size;
                    }
                }
            }
        }
    }
}
