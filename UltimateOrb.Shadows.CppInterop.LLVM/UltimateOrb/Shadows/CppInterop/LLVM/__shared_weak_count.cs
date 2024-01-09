using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;



namespace UltimateOrb.Shadows.CppInterop {

    namespace LLVM {
        struct __shared_weak_count {

            private __shared_count @base;

            internal CLong __shared_weak_owners_;

            internal void __add_shared() {
                @base.__add_shared();
            }

            internal void __add_weak() {
                CLongInterlocked.Increment(ref __shared_weak_owners_);
            }

            internal void __release_shared() {
                if (@base.__release_shared()) {
                    __release_weak();
                }
            }

            internal void __release_weak() {
                if (CLongVolatile.Read(ref __shared_weak_owners_).Value == 0) {
                    __on_zero_shared_weak();
                } else if (CLongInterlocked.Decrement(ref __shared_weak_owners_).Value == -1) {
                    __on_zero_shared_weak();
                }
            }

            internal void __on_zero_shared_weak() {
                unsafe {
                    ((delegate* unmanaged[Thiscall]<__shared_weak_count*, void>)(@base.lpVtbl[4]))((__shared_weak_count*)Unsafe.AsPointer(ref this));
                }
            }

            public void Dispose() {
                @base.Dispose();
            }
        }
    }
}
