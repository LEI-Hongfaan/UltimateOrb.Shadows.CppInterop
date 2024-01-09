using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;



namespace UltimateOrb.Shadows.CppInterop {

    namespace LLVM {
        struct __shared_count {

            internal unsafe void** lpVtbl;

            internal CLong __shared_owners_;

            internal void __on_zero_shared() {
                unsafe {
                    ((delegate* unmanaged[Thiscall]<__shared_count*, void>)(lpVtbl[2]))((__shared_count*)Unsafe.AsPointer(ref this));
                }
            }

            internal void __add_shared() {
                CLongInterlocked.Increment(ref __shared_owners_);
            }

            internal bool __release_shared() {
                if (CLongInterlocked.Decrement(ref __shared_owners_).Value == -1) {
                    __on_zero_shared();
                    return true;
                }
                return false;
            }

            public void Dispose() {
                unsafe {
                    ((delegate* unmanaged[Thiscall]<__shared_count*, void>)(lpVtbl[0]))((__shared_count*)Unsafe.AsPointer(ref this));
                }
            }
        }
    }
}
