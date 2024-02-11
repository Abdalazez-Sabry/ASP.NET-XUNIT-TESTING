namespace SimpleApp.Tests {
    public class Comparer {
        public static Comparer<U?> Get<U> (Func<U?, U?, bool> func) {
            return new Comparer<U?>(func);
        }

    }
    public class Comparer<T>(Func<T?, T?, bool> func) : Comparer, IEqualityComparer<T> {
        private readonly Func <T?, T?, bool> comparsionFunction = func;

        public bool Equals(T? x, T? y) {
            return comparsionFunction(x, y);
        }

        public int GetHashCode(T obj) {
            return obj?.GetHashCode() ?? 0;
        }
    }
}