using System.Runtime.InteropServices;



namespace UltimateOrb.Shadows.CppInterop {

    /// <summary>
    /// Provides default allocators that use the NativeMemory routines.
    /// </summary>
    /// <typeparam name="T">The type of the allocated memory.</typeparam>
    /// <remarks>
    /// The NativeMemory routines are wrappers of the C stdlib.h routines that the .NET runtime uses internally.
    /// </remarks>
    [EmptyStructure]
    public readonly struct Allocator<T> : IAllocator<T> where T : unmanaged {

        public unsafe T* Allocate(nuint n) {
            return (T*)NativeMemory.Alloc(n, (uint)sizeof(T));
        }

        public unsafe void Deallocate(T* p, nuint n) {
            NativeMemory.Free(p);
        }

        public static class size_type {

            public static nuint Type {

                get => throw null!;
            }
        }
    }
}
