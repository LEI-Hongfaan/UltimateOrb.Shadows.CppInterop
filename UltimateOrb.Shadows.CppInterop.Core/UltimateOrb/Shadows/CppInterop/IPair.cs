namespace UltimateOrb.Shadows.CppInterop {

    /// <inheritdoc cref="ValueTuple{TFirst, TSecond}"/>
    public interface IPair<TFirst, TSecond> {


        /// <inheritdoc cref="ValueTuple{TFirst, TSecond}.Item1"/>
        public TFirst First {

            get;

            set;
        }

        /// <inheritdoc cref="ValueTuple{TFirst, TSecond}.Item2"/>
        public TSecond Second {

            get;

            set;
        }
    }
}
