using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;



namespace UltimateOrb.Shadows.CppInterop {
    /// <summary>
    /// Provides Volatile methods for <see cref="CLong"/> and <see cref="CULong"/> types.
    /// </summary>
    public static partial class CLongVolatile {

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static CLong Read(ref CLong location) {
            return sizeof(int) == Unsafe.SizeOf<CLong>() ? new CLong(Volatile.Read(ref Unsafe.As<CLong, int>(ref location))) : new CLong(unchecked((nint)Interlocked.Read(ref Unsafe.As<CLong, long>(ref location))));
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static CULong Read(ref CULong location) {
            return sizeof(int) == Unsafe.SizeOf<CULong>() ? new CULong(Volatile.Read(ref Unsafe.As<CULong, uint>(ref location))) : new CULong(unchecked((nuint)Interlocked.Read(ref Unsafe.As<CULong, ulong>(ref location))));
        }
    }
}
