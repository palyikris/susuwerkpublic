

namespace elso
{
    public class Complex
    {
        private double x;
        private double y;
        public Complex(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public static Complex Add(Complex a, Complex b)
        {
            return new Complex(a.x + b.x, a.y + b.y);
        }

        public static Complex Substract(Complex a, Complex b)
        {
            return new Complex(a.x - b.x, a.y - b.y);
        }

        public static Complex Multiply(Complex a, Complex b)
        {
            return new Complex(a.x * b.x - a.y * b.y, a.x * b.y + a.y * b.x);
        }
        public static Complex Divide(Complex a, Complex b)
        {
            if(b.x == 0 && b.y == 0)
            {
                throw new DivideByZeroException();
            }

            return new Complex((a.x * b.x + a.y * b.y) / (b.x * b.x + b.y * b.y), 
                (a.x * b.y - a.y * b.x) / (b.x * b.x + b.y * b.y)); 
        }

        public static Complex operator +(Complex a, Complex b) => Add(a, b);
        public static Complex operator -(Complex a, Complex b) => Substract(a, b);
        public static Complex operator *(Complex a, Complex b) => Multiply(a, b);
        public static Complex operator /(Complex a, Complex b) => Divide(a, b);
        public static Complex operator -(Complex a) => new(-a.x, -a.y);

        public override string ToString()
        {
            return $"{Math.Round(x, 4)} {(y < 0 ? $"- {Math.Round(-y, 4)}" : $"+ {Math.Round(y, 4)}")}i";
        }


    }


}
