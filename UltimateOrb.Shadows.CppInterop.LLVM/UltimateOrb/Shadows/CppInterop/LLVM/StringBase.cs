using System.Runtime.CompilerServices;
using UltimateOrb.Shadows.CppInterop.Shared;

namespace UltimateOrb.Shadows.CppInterop {

    namespace LLVM {

        public struct Char8StringBase_64_1<LibCppOptionsT, TChar, Traits, TAllocator>
            where LibCppOptionsT : struct, ILibCppOptions
            where TChar : unmanaged
            where Traits : struct
            where TAllocator : unmanaged, IAllocator<TChar> {

            CompressedPair_0_1<Char8StringRecord_64<LibCppOptionsT, TChar>, TAllocator> _Representation;

            static LibCppOptionsT LibCppOptions {

                get => new();
            }

            static readonly nuint __ResidentRecordMask = (nuint)(LibCppOptions.IsStringLayoutAlternative == LibCppOptions.IsBigEndian ? 1 : 0x80);

            static readonly nuint __NonResidentRecordMask = (nuint)(LibCppOptions.IsStringLayoutAlternative == LibCppOptions.IsBigEndian ? 1 : ~(~(nuint)0 >> 1));

            internal bool _IsNonResident {

                get {
                    return 0 != (_Representation.First._ResidentRecord.Size & __ResidentRecordMask);
                }
            }

            public nuint Capacity {

                get => _IsNonResident ? Char8ResidentStringRecord_64<LibCppOptionsT, TChar>.BufferElementCount : _Representation.First._NonResidentRecord.Capacity;
            }

            public nuint Size {

                get => _IsNonResident ? _Representation.First._NonResidentRecord.Size : (LibCppOptions.IsStringLayoutAlternative == LibCppOptions.IsBigEndian ? (uint)_Representation.First._ResidentRecord.Size >> 1 : _Representation.First._ResidentRecord.Size);

                internal set {
                    if (_IsNonResident) {
                        _Representation.First._NonResidentRecord.Size = value;
                    } else {
                        if (LibCppOptions.IsStringLayoutAlternative == LibCppOptions.IsBigEndian) {
                            _Representation.First._ResidentRecord.Size = unchecked((byte)(value << 1));
                        } else {
                            _Representation.First._ResidentRecord.Size = unchecked((byte)value);
                        }
                    }
                }
            }

            public unsafe TChar* Pointer {

                get => _IsNonResident ? _Representation.First._NonResidentRecord.Data : _Representation.First._ResidentRecord.__Data;
            }

            public Span<TChar> Span {

                get {
                    unsafe {
                        return new Span<TChar>(Pointer, checked((int)Size));
                    }
                }
            }

            public void Dispose() {
                if (_IsNonResident) {
                    unsafe {
                        _Representation.Second.Deallocate(_Representation.First._NonResidentRecord.Data, _Representation.First._NonResidentRecord.Capacity);
                    }
                }
            }
        }

        public struct Char16StringBase_64_1<LibCppOptionsT, TChar, Traits, TAllocator>
            where LibCppOptionsT : struct, ILibCppOptions
            where TChar : unmanaged
            where Traits : struct
            where TAllocator : unmanaged, IAllocator<TChar> {

            CompressedPair_0_1<Char16StringRecord_64<LibCppOptionsT, TChar>, TAllocator> _Representation;

            static LibCppOptionsT LibCppOptions {

                get => new();
            }

            static readonly nuint __ResidentRecordMask = (nuint)(LibCppOptions.IsStringLayoutAlternative == LibCppOptions.IsBigEndian ? 1 : 0x80);

            static readonly nuint __NonResidentRecordMask = (nuint)(LibCppOptions.IsStringLayoutAlternative == LibCppOptions.IsBigEndian ? 1 : ~(~(nuint)0 >> 1));

            internal bool _IsNonResident {

                get {
                    return 0 != (_Representation.First._ResidentRecord.Size & __ResidentRecordMask);
                }
            }

            public nuint Capacity {

                get => _IsNonResident ? Char16ResidentStringRecord_64<LibCppOptionsT, TChar>.BufferElementCount : _Representation.First._NonResidentRecord.Capacity;
            }

            public nuint Size {

                get => _IsNonResident ? _Representation.First._NonResidentRecord.Size : (LibCppOptions.IsStringLayoutAlternative == LibCppOptions.IsBigEndian ? (uint)_Representation.First._ResidentRecord.Size >> 1 : _Representation.First._ResidentRecord.Size);

                internal set {
                    if (_IsNonResident) {
                        _Representation.First._NonResidentRecord.Size = value;
                    } else {
                        if (LibCppOptions.IsStringLayoutAlternative == LibCppOptions.IsBigEndian) {
                            _Representation.First._ResidentRecord.Size = unchecked((byte)(value << 1));
                        } else {
                            _Representation.First._ResidentRecord.Size = unchecked((byte)value);
                        }
                    }
                }
            }

            public unsafe TChar* Pointer {

                get => _IsNonResident ? _Representation.First._NonResidentRecord.Data : _Representation.First._ResidentRecord.__Data;
            }

            public Span<TChar> Span {

                get {
                    unsafe {
                        return new Span<TChar>(Pointer, checked((int)Size));
                    }
                }
            }

            public void Dispose() {
                if (_IsNonResident) {
                    unsafe {
                        _Representation.Second.Deallocate(_Representation.First._NonResidentRecord.Data, _Representation.First._NonResidentRecord.Capacity);
                    }
                }
            }
        }

        public struct Char32StringBase_64_1<LibCppOptionsT, TChar, Traits, TAllocator>
            where LibCppOptionsT : struct, ILibCppOptions
            where TChar : unmanaged
            where Traits : struct
            where TAllocator : unmanaged, IAllocator<TChar> {

            CompressedPair_0_1<Char32StringRecord_64<LibCppOptionsT, TChar>, TAllocator> _Representation;

            static LibCppOptionsT LibCppOptions {

                get => new();
            }

            static readonly nuint __ResidentRecordMask = (nuint)(LibCppOptions.IsStringLayoutAlternative == LibCppOptions.IsBigEndian ? 1 : 0x80);

            static readonly nuint __NonResidentRecordMask = (nuint)(LibCppOptions.IsStringLayoutAlternative == LibCppOptions.IsBigEndian ? 1 : ~(~(nuint)0 >> 1));

            internal bool _IsNonResident {

                get {
                    return 0 != (_Representation.First._ResidentRecord.Size & __ResidentRecordMask);
                }
            }

            public nuint Capacity {

                get => _IsNonResident ? Char32ResidentStringRecord_64<LibCppOptionsT, TChar>.BufferElementCount : _Representation.First._NonResidentRecord.Capacity;
            }

            public nuint Size {

                get => _IsNonResident ? _Representation.First._NonResidentRecord.Size : (LibCppOptions.IsStringLayoutAlternative == LibCppOptions.IsBigEndian ? (uint)_Representation.First._ResidentRecord.Size >> 1 : _Representation.First._ResidentRecord.Size);

                internal set {
                    if (_IsNonResident) {
                        _Representation.First._NonResidentRecord.Size = value;
                    } else {
                        if (LibCppOptions.IsStringLayoutAlternative == LibCppOptions.IsBigEndian) {
                            _Representation.First._ResidentRecord.Size = unchecked((byte)(value << 1));
                        } else {
                            _Representation.First._ResidentRecord.Size = unchecked((byte)value);
                        }
                    }
                }
            }

            public unsafe TChar* Pointer {

                get => _IsNonResident ? _Representation.First._NonResidentRecord.Data : _Representation.First._ResidentRecord.__Data;
            }

            public Span<TChar> Span {

                get {
                    unsafe {
                        return new Span<TChar>(Pointer, checked((int)Size));
                    }
                }
            }

            public void Dispose() {
                if (_IsNonResident) {
                    unsafe {
                        _Representation.Second.Deallocate(_Representation.First._NonResidentRecord.Data, _Representation.First._NonResidentRecord.Capacity);
                    }
                }
            }
        }

        public struct Char8StringBase_32_1<LibCppOptionsT, TChar, Traits, TAllocator>
            where LibCppOptionsT : struct, ILibCppOptions
            where TChar : unmanaged
            where Traits : struct
            where TAllocator : unmanaged, IAllocator<TChar> {

            CompressedPair_0_1<Char8StringRecord_32<LibCppOptionsT, TChar>, TAllocator> _Representation;

            static LibCppOptionsT LibCppOptions {

                get => new();
            }

            static readonly nuint __ResidentRecordMask = (nuint)(LibCppOptions.IsStringLayoutAlternative == LibCppOptions.IsBigEndian ? 1 : 0x80);

            static readonly nuint __NonResidentRecordMask = (nuint)(LibCppOptions.IsStringLayoutAlternative == LibCppOptions.IsBigEndian ? 1 : ~(~(nuint)0 >> 1));

            internal bool _IsNonResident {

                get {
                    return 0 != (_Representation.First._ResidentRecord.Size & __ResidentRecordMask);
                }
            }

            public nuint Capacity {

                get => _IsNonResident ? Char8ResidentStringRecord_32<LibCppOptionsT, TChar>.BufferElementCount : _Representation.First._NonResidentRecord.Capacity;
            }

            public nuint Size {

                get => _IsNonResident ? _Representation.First._NonResidentRecord.Size : (LibCppOptions.IsStringLayoutAlternative == LibCppOptions.IsBigEndian ? (uint)_Representation.First._ResidentRecord.Size >> 1 : _Representation.First._ResidentRecord.Size);

                internal set {
                    if (_IsNonResident) {
                        _Representation.First._NonResidentRecord.Size = value;
                    } else {
                        if (LibCppOptions.IsStringLayoutAlternative == LibCppOptions.IsBigEndian) {
                            _Representation.First._ResidentRecord.Size = unchecked((byte)(value << 1));
                        } else {
                            _Representation.First._ResidentRecord.Size = unchecked((byte)value);
                        }
                    }
                }
            }

            public unsafe TChar* Pointer {

                get => _IsNonResident ? _Representation.First._NonResidentRecord.Data : _Representation.First._ResidentRecord.__Data;
            }

            public Span<TChar> Span {

                get {
                    unsafe {
                        return new Span<TChar>(Pointer, checked((int)Size));
                    }
                }
            }

            public void Dispose() {
                if (_IsNonResident) {
                    unsafe {
                        _Representation.Second.Deallocate(_Representation.First._NonResidentRecord.Data, _Representation.First._NonResidentRecord.Capacity);
                    }
                }
            }
        }

        public struct Char16StringBase_32_1<LibCppOptionsT, TChar, Traits, TAllocator>
            where LibCppOptionsT : struct, ILibCppOptions
            where TChar : unmanaged
            where Traits : struct
            where TAllocator : unmanaged, IAllocator<TChar> {

            CompressedPair_0_1<Char16StringRecord_32<LibCppOptionsT, TChar>, TAllocator> _Representation;

            static LibCppOptionsT LibCppOptions {

                get => new();
            }

            static readonly nuint __ResidentRecordMask = (nuint)(LibCppOptions.IsStringLayoutAlternative == LibCppOptions.IsBigEndian ? 1 : 0x80);

            static readonly nuint __NonResidentRecordMask = (nuint)(LibCppOptions.IsStringLayoutAlternative == LibCppOptions.IsBigEndian ? 1 : ~(~(nuint)0 >> 1));

            internal bool _IsNonResident {

                get {
                    return 0 != (_Representation.First._ResidentRecord.Size & __ResidentRecordMask);
                }
            }

            public nuint Capacity {

                get => _IsNonResident ? Char16ResidentStringRecord_32<LibCppOptionsT, TChar>.BufferElementCount : _Representation.First._NonResidentRecord.Capacity;
            }

            public nuint Size {

                get => _IsNonResident ? _Representation.First._NonResidentRecord.Size : (LibCppOptions.IsStringLayoutAlternative == LibCppOptions.IsBigEndian ? (uint)_Representation.First._ResidentRecord.Size >> 1 : _Representation.First._ResidentRecord.Size);

                internal set {
                    if (_IsNonResident) {
                        _Representation.First._NonResidentRecord.Size = value;
                    } else {
                        if (LibCppOptions.IsStringLayoutAlternative == LibCppOptions.IsBigEndian) {
                            _Representation.First._ResidentRecord.Size = unchecked((byte)(value << 1));
                        } else {
                            _Representation.First._ResidentRecord.Size = unchecked((byte)value);
                        }
                    }
                }
            }

            public unsafe TChar* Pointer {

                get => _IsNonResident ? _Representation.First._NonResidentRecord.Data : _Representation.First._ResidentRecord.__Data;
            }

            public Span<TChar> Span {

                get {
                    unsafe {
                        return new Span<TChar>(Pointer, checked((int)Size));
                    }
                }
            }

            public void Dispose() {
                if (_IsNonResident) {
                    unsafe {
                        _Representation.Second.Deallocate(_Representation.First._NonResidentRecord.Data, _Representation.First._NonResidentRecord.Capacity);
                    }
                }
            }
        }

        public struct Char32StringBase_32_1<LibCppOptionsT, TChar, Traits, TAllocator>
            where LibCppOptionsT : struct, ILibCppOptions
            where TChar : unmanaged
            where Traits : struct
            where TAllocator : unmanaged, IAllocator<TChar> {

            CompressedPair_0_1<Char32StringRecord_32<LibCppOptionsT, TChar>, TAllocator> _Representation;

            static LibCppOptionsT LibCppOptions {

                get => new();
            }

            static readonly nuint __ResidentRecordMask = (nuint)(LibCppOptions.IsStringLayoutAlternative == LibCppOptions.IsBigEndian ? 1 : 0x80);

            static readonly nuint __NonResidentRecordMask = (nuint)(LibCppOptions.IsStringLayoutAlternative == LibCppOptions.IsBigEndian ? 1 : ~(~(nuint)0 >> 1));

            internal bool _IsNonResident {

                get {
                    return 0 != (_Representation.First._ResidentRecord.Size & __ResidentRecordMask);
                }
            }

            public nuint Capacity {

                get => _IsNonResident ? Char32ResidentStringRecord_32<LibCppOptionsT, TChar>.BufferElementCount : _Representation.First._NonResidentRecord.Capacity;
            }

            public nuint Size {

                get => _IsNonResident ? _Representation.First._NonResidentRecord.Size : (LibCppOptions.IsStringLayoutAlternative == LibCppOptions.IsBigEndian ? (uint)_Representation.First._ResidentRecord.Size >> 1 : _Representation.First._ResidentRecord.Size);

                internal set {
                    if (_IsNonResident) {
                        _Representation.First._NonResidentRecord.Size = value;
                    } else {
                        if (LibCppOptions.IsStringLayoutAlternative == LibCppOptions.IsBigEndian) {
                            _Representation.First._ResidentRecord.Size = unchecked((byte)(value << 1));
                        } else {
                            _Representation.First._ResidentRecord.Size = unchecked((byte)value);
                        }
                    }
                }
            }

            public unsafe TChar* Pointer {

                get => _IsNonResident ? _Representation.First._NonResidentRecord.Data : _Representation.First._ResidentRecord.__Data;
            }

            public Span<TChar> Span {

                get {
                    unsafe {
                        return new Span<TChar>(Pointer, checked((int)Size));
                    }
                }
            }

            public void Dispose() {
                if (_IsNonResident) {
                    unsafe {
                        _Representation.Second.Deallocate(_Representation.First._NonResidentRecord.Data, _Representation.First._NonResidentRecord.Capacity);
                    }
                }
            }
        }

        public struct Char8StringBase_64_0<LibCppOptionsT, TChar, Traits, TAllocator>
            where LibCppOptionsT : struct, ILibCppOptions
            where TChar : unmanaged
            where Traits : struct
            where TAllocator : unmanaged, IAllocator<TChar> {

            CompressedPair_0_0<Char8StringRecord_64<LibCppOptionsT, TChar>, TAllocator> _Representation;

            static LibCppOptionsT LibCppOptions {

                get => new();
            }

            static readonly nuint __ResidentRecordMask = (nuint)(LibCppOptions.IsStringLayoutAlternative == LibCppOptions.IsBigEndian ? 1 : 0x80);

            static readonly nuint __NonResidentRecordMask = (nuint)(LibCppOptions.IsStringLayoutAlternative == LibCppOptions.IsBigEndian ? 1 : ~(~(nuint)0 >> 1));

            internal bool _IsNonResident {

                get {
                    return 0 != (_Representation.First._ResidentRecord.Size & __ResidentRecordMask);
                }
            }

            public nuint Capacity {

                get => _IsNonResident ? Char8ResidentStringRecord_64<LibCppOptionsT, TChar>.BufferElementCount : _Representation.First._NonResidentRecord.Capacity;
            }

            public nuint Size {

                get => _IsNonResident ? _Representation.First._NonResidentRecord.Size : (LibCppOptions.IsStringLayoutAlternative == LibCppOptions.IsBigEndian ? (uint)_Representation.First._ResidentRecord.Size >> 1 : _Representation.First._ResidentRecord.Size);

                internal set {
                    if (_IsNonResident) {
                        _Representation.First._NonResidentRecord.Size = value;
                    } else {
                        if (LibCppOptions.IsStringLayoutAlternative == LibCppOptions.IsBigEndian) {
                            _Representation.First._ResidentRecord.Size = unchecked((byte)(value << 1));
                        } else {
                            _Representation.First._ResidentRecord.Size = unchecked((byte)value);
                        }
                    }
                }
            }

            public unsafe TChar* Pointer {

                get => _IsNonResident ? _Representation.First._NonResidentRecord.Data : _Representation.First._ResidentRecord.__Data;
            }

            public Span<TChar> Span {

                get {
                    unsafe {
                        return new Span<TChar>(Pointer, checked((int)Size));
                    }
                }
            }

            public void Dispose() {
                if (_IsNonResident) {
                    unsafe {
                        _Representation.Second.Deallocate(_Representation.First._NonResidentRecord.Data, _Representation.First._NonResidentRecord.Capacity);
                    }
                }
            }
        }

        public struct Char16StringBase_64_0<LibCppOptionsT, TChar, Traits, TAllocator>
            where LibCppOptionsT : struct, ILibCppOptions
            where TChar : unmanaged
            where Traits : struct
            where TAllocator : unmanaged, IAllocator<TChar> {

            CompressedPair_0_0<Char16StringRecord_64<LibCppOptionsT, TChar>, TAllocator> _Representation;

            static LibCppOptionsT LibCppOptions {

                get => new();
            }

            static readonly nuint __ResidentRecordMask = (nuint)(LibCppOptions.IsStringLayoutAlternative == LibCppOptions.IsBigEndian ? 1 : 0x80);

            static readonly nuint __NonResidentRecordMask = (nuint)(LibCppOptions.IsStringLayoutAlternative == LibCppOptions.IsBigEndian ? 1 : ~(~(nuint)0 >> 1));

            internal bool _IsNonResident {

                get {
                    return 0 != (_Representation.First._ResidentRecord.Size & __ResidentRecordMask);
                }
            }

            public nuint Capacity {

                get => _IsNonResident ? Char16ResidentStringRecord_64<LibCppOptionsT, TChar>.BufferElementCount : _Representation.First._NonResidentRecord.Capacity;
            }

            public nuint Size {

                get => _IsNonResident ? _Representation.First._NonResidentRecord.Size : (LibCppOptions.IsStringLayoutAlternative == LibCppOptions.IsBigEndian ? (uint)_Representation.First._ResidentRecord.Size >> 1 : _Representation.First._ResidentRecord.Size);

                internal set {
                    if (_IsNonResident) {
                        _Representation.First._NonResidentRecord.Size = value;
                    } else {
                        if (LibCppOptions.IsStringLayoutAlternative == LibCppOptions.IsBigEndian) {
                            _Representation.First._ResidentRecord.Size = unchecked((byte)(value << 1));
                        } else {
                            _Representation.First._ResidentRecord.Size = unchecked((byte)value);
                        }
                    }
                }
            }

            public unsafe TChar* Pointer {

                get => _IsNonResident ? _Representation.First._NonResidentRecord.Data : _Representation.First._ResidentRecord.__Data;
            }

            public Span<TChar> Span {

                get {
                    unsafe {
                        return new Span<TChar>(Pointer, checked((int)Size));
                    }
                }
            }

            public void Dispose() {
                if (_IsNonResident) {
                    unsafe {
                        _Representation.Second.Deallocate(_Representation.First._NonResidentRecord.Data, _Representation.First._NonResidentRecord.Capacity);
                    }
                }
            }
        }

        public struct Char32StringBase_64_0<LibCppOptionsT, TChar, Traits, TAllocator>
            where LibCppOptionsT : struct, ILibCppOptions
            where TChar : unmanaged
            where Traits : struct
            where TAllocator : unmanaged, IAllocator<TChar> {

            CompressedPair_0_0<Char32StringRecord_64<LibCppOptionsT, TChar>, TAllocator> _Representation;

            static LibCppOptionsT LibCppOptions {

                get => new();
            }

            static readonly nuint __ResidentRecordMask = (nuint)(LibCppOptions.IsStringLayoutAlternative == LibCppOptions.IsBigEndian ? 1 : 0x80);

            static readonly nuint __NonResidentRecordMask = (nuint)(LibCppOptions.IsStringLayoutAlternative == LibCppOptions.IsBigEndian ? 1 : ~(~(nuint)0 >> 1));

            internal bool _IsNonResident {

                get {
                    return 0 != (_Representation.First._ResidentRecord.Size & __ResidentRecordMask);
                }
            }

            public nuint Capacity {

                get => _IsNonResident ? Char32ResidentStringRecord_64<LibCppOptionsT, TChar>.BufferElementCount : _Representation.First._NonResidentRecord.Capacity;
            }

            public nuint Size {

                get => _IsNonResident ? _Representation.First._NonResidentRecord.Size : (LibCppOptions.IsStringLayoutAlternative == LibCppOptions.IsBigEndian ? (uint)_Representation.First._ResidentRecord.Size >> 1 : _Representation.First._ResidentRecord.Size);

                internal set {
                    if (_IsNonResident) {
                        _Representation.First._NonResidentRecord.Size = value;
                    } else {
                        if (LibCppOptions.IsStringLayoutAlternative == LibCppOptions.IsBigEndian) {
                            _Representation.First._ResidentRecord.Size = unchecked((byte)(value << 1));
                        } else {
                            _Representation.First._ResidentRecord.Size = unchecked((byte)value);
                        }
                    }
                }
            }

            public unsafe TChar* Pointer {

                get => _IsNonResident ? _Representation.First._NonResidentRecord.Data : _Representation.First._ResidentRecord.__Data;
            }

            public Span<TChar> Span {

                get {
                    unsafe {
                        return new Span<TChar>(Pointer, checked((int)Size));
                    }
                }
            }

            public void Dispose() {
                if (_IsNonResident) {
                    unsafe {
                        _Representation.Second.Deallocate(_Representation.First._NonResidentRecord.Data, _Representation.First._NonResidentRecord.Capacity);
                    }
                }
            }
        }

        public struct Char8StringBase_32_0<LibCppOptionsT, TChar, Traits, TAllocator>
            where LibCppOptionsT : struct, ILibCppOptions
            where TChar : unmanaged
            where Traits : struct
            where TAllocator : unmanaged, IAllocator<TChar> {

            CompressedPair_0_0<Char8StringRecord_32<LibCppOptionsT, TChar>, TAllocator> _Representation;

            static LibCppOptionsT LibCppOptions {

                get => new();
            }

            static readonly nuint __ResidentRecordMask = (nuint)(LibCppOptions.IsStringLayoutAlternative == LibCppOptions.IsBigEndian ? 1 : 0x80);

            static readonly nuint __NonResidentRecordMask = (nuint)(LibCppOptions.IsStringLayoutAlternative == LibCppOptions.IsBigEndian ? 1 : ~(~(nuint)0 >> 1));

            internal bool _IsNonResident {

                get {
                    return 0 != (_Representation.First._ResidentRecord.Size & __ResidentRecordMask);
                }
            }

            public nuint Capacity {

                get => _IsNonResident ? Char8ResidentStringRecord_32<LibCppOptionsT, TChar>.BufferElementCount : _Representation.First._NonResidentRecord.Capacity;
            }

            public nuint Size {

                get => _IsNonResident ? _Representation.First._NonResidentRecord.Size : (LibCppOptions.IsStringLayoutAlternative == LibCppOptions.IsBigEndian ? (uint)_Representation.First._ResidentRecord.Size >> 1 : _Representation.First._ResidentRecord.Size);

                internal set {
                    if (_IsNonResident) {
                        _Representation.First._NonResidentRecord.Size = value;
                    } else {
                        if (LibCppOptions.IsStringLayoutAlternative == LibCppOptions.IsBigEndian) {
                            _Representation.First._ResidentRecord.Size = unchecked((byte)(value << 1));
                        } else {
                            _Representation.First._ResidentRecord.Size = unchecked((byte)value);
                        }
                    }
                }
            }

            public unsafe TChar* Pointer {

                get => _IsNonResident ? _Representation.First._NonResidentRecord.Data : _Representation.First._ResidentRecord.__Data;
            }

            public Span<TChar> Span {

                get {
                    unsafe {
                        return new Span<TChar>(Pointer, checked((int)Size));
                    }
                }
            }

            public void Dispose() {
                if (_IsNonResident) {
                    unsafe {
                        _Representation.Second.Deallocate(_Representation.First._NonResidentRecord.Data, _Representation.First._NonResidentRecord.Capacity);
                    }
                }
            }
        }

        public struct Char16StringBase_32_0<LibCppOptionsT, TChar, Traits, TAllocator>
            where LibCppOptionsT : struct, ILibCppOptions
            where TChar : unmanaged
            where Traits : struct
            where TAllocator : unmanaged, IAllocator<TChar> {

            CompressedPair_0_0<Char16StringRecord_32<LibCppOptionsT, TChar>, TAllocator> _Representation;

            static LibCppOptionsT LibCppOptions {

                get => new();
            }

            static readonly nuint __ResidentRecordMask = (nuint)(LibCppOptions.IsStringLayoutAlternative == LibCppOptions.IsBigEndian ? 1 : 0x80);

            static readonly nuint __NonResidentRecordMask = (nuint)(LibCppOptions.IsStringLayoutAlternative == LibCppOptions.IsBigEndian ? 1 : ~(~(nuint)0 >> 1));

            internal bool _IsNonResident {

                get {
                    return 0 != (_Representation.First._ResidentRecord.Size & __ResidentRecordMask);
                }
            }

            public nuint Capacity {

                get => _IsNonResident ? Char16ResidentStringRecord_32<LibCppOptionsT, TChar>.BufferElementCount : _Representation.First._NonResidentRecord.Capacity;
            }

            public nuint Size {

                get => _IsNonResident ? _Representation.First._NonResidentRecord.Size : (LibCppOptions.IsStringLayoutAlternative == LibCppOptions.IsBigEndian ? (uint)_Representation.First._ResidentRecord.Size >> 1 : _Representation.First._ResidentRecord.Size);

                internal set {
                    if (_IsNonResident) {
                        _Representation.First._NonResidentRecord.Size = value;
                    } else {
                        if (LibCppOptions.IsStringLayoutAlternative == LibCppOptions.IsBigEndian) {
                            _Representation.First._ResidentRecord.Size = unchecked((byte)(value << 1));
                        } else {
                            _Representation.First._ResidentRecord.Size = unchecked((byte)value);
                        }
                    }
                }
            }

            public unsafe TChar* Pointer {

                get => _IsNonResident ? _Representation.First._NonResidentRecord.Data : _Representation.First._ResidentRecord.__Data;
            }

            public Span<TChar> Span {

                get {
                    unsafe {
                        return new Span<TChar>(Pointer, checked((int)Size));
                    }
                }
            }

            public void Dispose() {
                if (_IsNonResident) {
                    unsafe {
                        _Representation.Second.Deallocate(_Representation.First._NonResidentRecord.Data, _Representation.First._NonResidentRecord.Capacity);
                    }
                }
            }
        }

        public struct Char32StringBase_32_0<LibCppOptionsT, TChar, Traits, TAllocator>
            where LibCppOptionsT : struct, ILibCppOptions
            where TChar : unmanaged
            where Traits : struct
            where TAllocator : unmanaged, IAllocator<TChar> {

            CompressedPair_0_0<Char32StringRecord_32<LibCppOptionsT, TChar>, TAllocator> _Representation;

            static LibCppOptionsT LibCppOptions {

                get => new();
            }

            static readonly nuint __ResidentRecordMask = (nuint)(LibCppOptions.IsStringLayoutAlternative == LibCppOptions.IsBigEndian ? 1 : 0x80);

            static readonly nuint __NonResidentRecordMask = (nuint)(LibCppOptions.IsStringLayoutAlternative == LibCppOptions.IsBigEndian ? 1 : ~(~(nuint)0 >> 1));

            internal bool _IsNonResident {

                get {
                    return 0 != (_Representation.First._ResidentRecord.Size & __ResidentRecordMask);
                }
            }

            public nuint Capacity {

                get => _IsNonResident ? Char32ResidentStringRecord_32<LibCppOptionsT, TChar>.BufferElementCount : _Representation.First._NonResidentRecord.Capacity;
            }

            public nuint Size {

                get => _IsNonResident ? _Representation.First._NonResidentRecord.Size : (LibCppOptions.IsStringLayoutAlternative == LibCppOptions.IsBigEndian ? (uint)_Representation.First._ResidentRecord.Size >> 1 : _Representation.First._ResidentRecord.Size);

                internal set {
                    if (_IsNonResident) {
                        _Representation.First._NonResidentRecord.Size = value;
                    } else {
                        if (LibCppOptions.IsStringLayoutAlternative == LibCppOptions.IsBigEndian) {
                            _Representation.First._ResidentRecord.Size = unchecked((byte)(value << 1));
                        } else {
                            _Representation.First._ResidentRecord.Size = unchecked((byte)value);
                        }
                    }
                }
            }

            public unsafe TChar* Pointer {

                get => _IsNonResident ? _Representation.First._NonResidentRecord.Data : _Representation.First._ResidentRecord.__Data;
            }

            public Span<TChar> Span {

                get {
                    unsafe {
                        return new Span<TChar>(Pointer, checked((int)Size));
                    }
                }
            }

            public void Dispose() {
                if (_IsNonResident) {
                    unsafe {
                        _Representation.Second.Deallocate(_Representation.First._NonResidentRecord.Data, _Representation.First._NonResidentRecord.Capacity);
                    }
                }
            }
        }
    }
}