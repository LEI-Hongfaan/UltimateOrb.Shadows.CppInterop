using UltimateOrb.Shadows.CppInterop.Shared;

namespace UltimateOrb.Shadows.CppInterop {

    namespace LLVM {

        struct __tree<T, TCompare, TAllocator>
            where TCompare : unmanaged
            where TAllocator : unmanaged {
            internal Ptr<__tree_end_node> __begin_node_;
            internal CompressedPair_0_0<__tree_end_node, TAllocator> __pair1_;
            internal CompressedPair_0_0<nuint, TCompare> __pair3_;
        }

        struct __tree_0_1<T, TCompare, TAllocator>
            where TCompare : unmanaged
            where TAllocator : unmanaged {
            internal Ptr<__tree_end_node> __begin_node_;
            internal CompressedPair_0_0<__tree_end_node, TAllocator> __pair1_;
            internal CompressedPair_0_1<nuint, TCompare> __pair3_;
        }

        struct __tree_1_0<T, TCompare, TAllocator>
            where TCompare : unmanaged
            where TAllocator : unmanaged {
            internal Ptr<__tree_end_node> __begin_node_;
            internal CompressedPair_0_1<__tree_end_node, TAllocator> __pair1_;
            internal CompressedPair_0_0<nuint, TCompare> __pair3_;
        }

        struct __tree_1_1<T, TCompare, TAllocator>
            where TCompare : unmanaged
            where TAllocator : unmanaged {
            internal Ptr<__tree_end_node> __begin_node_;
            internal CompressedPair_0_1<__tree_end_node, TAllocator> __pair1_;
            internal CompressedPair_0_1<nuint, TCompare> __pair3_;
        }
    }
}
