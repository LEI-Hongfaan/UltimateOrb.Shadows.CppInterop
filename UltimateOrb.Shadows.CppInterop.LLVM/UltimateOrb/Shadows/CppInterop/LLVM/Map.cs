namespace UltimateOrb.Shadows.CppInterop {


    namespace LLVM {

        public struct Map<TKey, TValue>
            where TKey: unmanaged
            where TValue: unmanaged {
            internal Map_1_1<TKey, TValue, Less<TKey>, Allocator<(TKey, TValue)>> impl;
        }

        public struct Map_0_0<TKey, TValue, TCompare, TAllocator>
            where TCompare : unmanaged, ILess<TKey, ValueTuple>
            where TAllocator : unmanaged {

            internal __tree<(TKey, TValue), __map_value_compare<TCompare, TKey>, TAllocator> __tree_;

            public nuint Count {

                get => __tree_.__pair3_.First;
            }
        }

        public struct Map_1_1<TKey, TValue, TCompare, TAllocator>
            where TCompare : unmanaged, ILess<TKey, ValueTuple>
            where TAllocator : unmanaged {

            internal __tree_1_1<(TKey, TValue), __map_value_compare<TCompare, TKey>, TAllocator> __tree_;
        }
    }
}
