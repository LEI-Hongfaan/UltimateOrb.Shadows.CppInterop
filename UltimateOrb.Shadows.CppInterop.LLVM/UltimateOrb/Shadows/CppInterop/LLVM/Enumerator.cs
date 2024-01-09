using System.Collections;



namespace UltimateOrb.Shadows.CppInterop {


    namespace LLVM {
        struct Enumerator : IEnumerator<Ptr<__tree_end_node>> {

            internal Ptr<__tree_end_node> _Current;

            internal __tree_end_node __end_node_;

            public Ptr<__tree_end_node> Current {

                get => _Current;
            }

            object IEnumerator.Current {

                get => Current;
            }

            public void Dispose() {
            }

            public bool MoveNext() {
                unsafe {
                    if (_Current.value__->__left_ != __end_node_.__left_) {

                        throw new NotImplementedException();
                    }
                    return false;
                }
            }

            public void Reset() {
                throw new NotImplementedException();
            }
        }

    }
}
