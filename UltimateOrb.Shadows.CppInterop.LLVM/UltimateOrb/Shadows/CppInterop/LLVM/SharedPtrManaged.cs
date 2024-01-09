using System.Runtime.ConstrainedExecution;



namespace UltimateOrb.Shadows.CppInterop {

    namespace LLVM {
        public class SharedPtrManaged<T> : CriticalFinalizerObject, IDisposable
            where T : unmanaged {

            SharedPtr<T> ptr;
            int disposedValue;

            public SharedPtrManaged(SharedPtr<T> ptr) {
                this.ptr = ptr;
            }

            public ref T Dereferenced {

                get => ref ptr.Dereferenced;
            }

            protected virtual void Dispose(bool disposing) {
                if (0 == Interlocked.Exchange(ref disposedValue, 1)) {
                    if (disposing) {
                        // TODO: dispose managed state (managed objects)
                    }
                    // TODO: free unmanaged resources (unmanaged objects) and override finalizer
                    // TODO: set large fields to null
                    ptr.Dispose();
                }
            }

            // TODO: override finalizer only if 'Dispose(bool disposing)' has code to free unmanaged resources
            ~SharedPtrManaged() {
                // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
                Dispose(disposing: false);
            }

            public void Dispose() {
                // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
                Dispose(disposing: true);
                GC.SuppressFinalize(this);
            }
        }
    }
}
