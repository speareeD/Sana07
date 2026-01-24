namespace Fraction
{
    public class Fraction
    {
        public int Numerator { get; private set; }
        public int Denominator { get; private set; }

        public Fraction(int numerator, int denominator)
        {
            if (denominator == 0)
                throw new ArgumentException("Denominator cannot equal zero");
            Denominator = denominator;
            Numerator = numerator;
            Simplify();
        }

        public Fraction(int wholeNumber)
        {
            Numerator = wholeNumber;
            Denominator = 1;
        }
        private void Simplify()
        {
            int gcd = GCD(Math.Abs(Numerator), Math.Abs(Denominator));
            Numerator /= gcd;
            Denominator /= gcd;

            if (Denominator < 0)
            {
                Numerator = -Numerator;
                Denominator = -Denominator;
            }
        }
        private static int GCD(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }
        public override string ToString()
        {
            return $"{Numerator}/{Denominator}";
        }

        public static Fraction operator +(Fraction a)
        {
            return a;
        }
        public static Fraction operator -(Fraction a)
        {
            return new Fraction(-a.Numerator, a.Denominator);
        }
        public static Fraction operator +(Fraction a, Fraction b)
        {
            return new Fraction(a.Numerator * b.Denominator + b.Numerator * a.Denominator,
                a.Denominator * b.Denominator);
        }
        public static Fraction operator -(Fraction a, Fraction b)
        {
            return a + -b;
        }

    }
}
