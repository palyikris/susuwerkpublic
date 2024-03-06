

namespace HF1
{
    internal class Rational
    {
        private int n;
        private int d;

        public Rational(int i, int j)
        {
            
            
            if(j == 0)
            {
                throw new ArgumentException("Second arguement cannot be 0!");
            }
            else
            {
                this.n = i;
                this.d = j;
            }
        }

        public static Rational Add(Rational a, Rational b) => new(a.n * b.d + a.d * b.n, a.d * b.d);

        public static Rational Substract(Rational a, Rational b) => new(a.n * b.d - a.d * b.n, a.d * b.d);

        public static Rational Multiply(Rational a, Rational b) => new(a.n * b.n, a.d * b.d);

        public static Rational Divide(Rational a, Rational b) => b.n == 0 ? throw new Exception("Something went wront!") : new(a.n * b.d, a.d * b.n);


        public static Rational operator +(Rational a, Rational b) => Add(a, b);

        public static Rational operator -(Rational a, Rational b) => Substract(a, b);

        public static Rational operator *(Rational a, Rational b) => Multiply(a, b);

        public static Rational operator /(Rational a, Rational b) => Divide(a, b);


        public override string ToString()
        {
            return $"{n}/{d}";
        }


    }
}
