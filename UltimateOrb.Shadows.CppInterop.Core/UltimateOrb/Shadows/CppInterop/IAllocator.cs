using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UltimateOrb.Shadows.CppInterop {

    public unsafe interface IAllocator<T> where T : unmanaged {

        T* Allocate(nuint n);

        void Deallocate(T* p, nuint n);
    }
}
