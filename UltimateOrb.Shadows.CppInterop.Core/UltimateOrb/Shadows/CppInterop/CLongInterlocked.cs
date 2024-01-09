using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace UltimateOrb.Shadows.CppInterop {

    /// <summary>
    /// Provides Interlocked methods for <see cref="CLong"/> and <see cref="CULong"/> types.
    /// </summary>
    public static partial class CLongInterlocked {

        /// <inheritdoc cref="Interlocked.Decrement(ref long)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static CLong Decrement(ref CLong location) {
            return sizeof(int) == Unsafe.SizeOf<CLong>() ? new CLong(Interlocked.Decrement(ref Unsafe.As<CLong, int>(ref location))) : new CLong(unchecked((nint)Interlocked.Decrement(ref Unsafe.As<CLong, long>(ref location))));
        }

        /// <inheritdoc cref="Interlocked.Increment(ref long)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static CLong Increment(ref CLong location) {
            return sizeof(int) == Unsafe.SizeOf<CLong>() ? new CLong(Interlocked.Increment(ref Unsafe.As<CLong, int>(ref location))) : new CLong(unchecked((nint)Interlocked.Increment(ref Unsafe.As<CLong, long>(ref location))));
        }

        /// <inheritdoc cref="Interlocked.Decrement(ref long)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static CULong Decrement(ref CULong location) {
            return sizeof(int) == Unsafe.SizeOf<CULong>() ? new CULong(Interlocked.Decrement(ref Unsafe.As<CULong, uint>(ref location))) : new CULong(unchecked((nuint)Interlocked.Decrement(ref Unsafe.As<CULong, ulong>(ref location))));
        }

        /// <inheritdoc cref="Interlocked.Increment(ref long)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static CULong Increment(ref CULong location) {
            return sizeof(int) == Unsafe.SizeOf<CULong>() ? new CULong(Interlocked.Increment(ref Unsafe.As<CULong, uint>(ref location))) : new CULong(unchecked((nuint)Interlocked.Increment(ref Unsafe.As<CULong, ulong>(ref location))));
        }
    }
}
