namespace UltimateOrb.Shadows.CppInterop {

    namespace LLVM {
        public struct SharedPtr<T>
            where T : unmanaged {

            internal unsafe T* __ptr_;

            internal unsafe __shared_weak_count* __cntrl_;

            public void Dispose() {
                unsafe {
                    var __cntrl_ = this.__cntrl_;
                    if (null != __cntrl_) {
                        __cntrl_->__release_shared();
                    }
                }
            }

            public ref T Dereferenced {

                get {
                    unsafe {
                        return ref *__ptr_;
                    }
                }
            }
        }
    }
}
