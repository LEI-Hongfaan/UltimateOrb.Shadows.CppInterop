namespace UltimateOrb.Shadows.CppInterop {

    public static partial class TypeTraits {

        public static bool IsEmptyType<T>() {
            return typeof(T).GetFields(System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance).Length == 0;
        }
    }
}
