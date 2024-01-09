namespace UltimateOrb.Shadows.CppInterop {
    public interface IConstantDataType<out T, Tag> {

        public abstract T Value {

            get;
        }
    }
}
