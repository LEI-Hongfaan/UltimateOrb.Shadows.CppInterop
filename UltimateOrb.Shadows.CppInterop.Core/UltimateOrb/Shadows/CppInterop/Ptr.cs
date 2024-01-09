using System.Collections.Generic;

namespace UltimateOrb.Shadows.CppInterop {

    public readonly struct Ptr<T> : IEquatable<Ptr<T>>, IComparable<Ptr<T>> where T : unmanaged {

        public unsafe readonly T* value__;

        public unsafe static implicit operator T*(Ptr<T> value) {
            return value.value__;
        }

        /// <inheritdoc/>
        public bool Equals(Ptr<T> other) {
            unsafe {
                return value__ == other.value__;
            }
        }

        /// <inheritdoc/>
        public int CompareTo(Ptr<T> other) {
            unsafe {
                return unchecked((nuint)value__).CompareTo(unchecked((nuint)other.value__));
            }
        }

        /// <inheritdoc/>
        public override bool Equals(object? obj) {
            return obj is Ptr<T> ptr && Equals(ptr);
        }

        /// <inheritdoc/>
        public override int GetHashCode() {
            unsafe {
                return new IntPtr(value__).GetHashCode();
            }
        }

        public override string ToString() {
            unsafe {
                return new IntPtr(value__).ToString();
            }
        }

        public static bool operator ==(Ptr<T> first, Ptr<T> second) {
            unsafe {
                return first.value__ == second.value__;
            }
        }

        public static bool operator !=(Ptr<T> first, Ptr<T> second) {
            unsafe {
                return first.value__ != second.value__;
            }
        }

        public static bool operator <(Ptr<T> left, Ptr<T> right) {
            unsafe {
                return left.value__ < right.value__;
            }
        }

        public static bool operator <=(Ptr<T> left, Ptr<T> right) {
            unsafe {
                return left.value__ <= right.value__;
            }
        }

        public static bool operator >(Ptr<T> left, Ptr<T> right) {
            unsafe {
                return left.value__ > right.value__;
            }
        }

        public static bool operator >=(Ptr<T> left, Ptr<T> right) {
            unsafe {
                return left.value__ >= right.value__;
            }
        }
    }
}
