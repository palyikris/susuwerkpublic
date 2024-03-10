

namespace HF3
{
    internal class Diag
    {
        private double[] x;

        public Diag(int n)
        {
            this.x = new double[n];
        }

        public double Get(int i, int j)
        {
            if (i < 0 || j < 0 || i > x.Length || j > x.Length)
            {
                throw new ArgumentException("Illegal Arguement!");
            }

            if (i == j)
            {
                return x[i];
            }
            else
            {
                return 0.0;
            }
        }

        public void Set(int i, int j, double e)
        {
            if (i < 0 || j < 0 || i > x.Length || j > x.Length)
            {
                throw new ArgumentException("Illegal Arguement!");
            }

            if (i == j)
            {
                x[i] = e;
            }
            else
            {
                throw new Exception("Error!");
            }
        }

        public static Diag Add(Diag a, Diag b)
        {
            if (a.x.Length != b.x.Length)
            {
                throw new ArgumentException("Illegal Arguements!");
            }

            Diag c = new(a.x.Length);

            for (int i = 0; i < c.x.Length; i++)
            {
                c.x[i] = a.x[i] + b.x[i];
            }

            return c;
        }

        public static Diag Multiply(Diag a, Diag b)
        {
            if (a.x.Length != b.x.Length)
            {
                throw new ArgumentException("Illegal Arguements!");
            }


            Diag c = new(a.x.Length);

            for (int i = 0; i < c.x.Length; i++)
            {
                c.x[i] = a.x[i] * b.x[i];
            }

            return c;

        }

        public static Diag operator +(Diag a, Diag b) => Add(a, b);
        public static Diag operator *(Diag a, Diag b) => Multiply(a, b);

    }
}
