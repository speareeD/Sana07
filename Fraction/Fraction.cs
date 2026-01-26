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
        public static Fraction operator *(Fraction a, Fraction b)
        {
            return new Fraction(a.Numerator * b.Numerator, a.Denominator * b.Denominator);
        }
        public static Fraction operator *(Fraction a, int b)
        {
            return a * new Fraction(b);
        }
        public static Fraction operator *(int a, Fraction b)
        {
            return b * a;
        }
        public static Fraction operator /(Fraction a, Fraction b)
        {
            return new Fraction(a.Numerator * b.Denominator, b.Numerator * a.Denominator);
        }
        public static Fraction operator /(Fraction a, int b)
        {
            return a / new Fraction(b);
        }
        public static Fraction operator /(int a, Fraction b)
        {
            return new Fraction(a) / b;
        }
        public static bool operator ==(Fraction a, Fraction b)
        {
            Fraction result = a - b;
            return result.Numerator == 0;
        }
        public static bool operator !=(Fraction a, Fraction b)
        {
            return !(a == b);
        }
        public static bool operator >(Fraction a, Fraction b)
        {
            return (double)a.Numerator / a.Denominator > (double)b.Numerator / b.Denominator;
        }
        public static bool operator <(Fraction a, Fraction b)
        {
            return (double)a.Numerator / a.Denominator < (double)b.Numerator / b.Denominator;
        }
        public static bool operator >=(Fraction a, Fraction b)
        {
            return (double)a.Numerator / a.Denominator >= (double)b.Numerator / b.Denominator;
        }
        public static bool operator <=(Fraction a, Fraction b)
        {
            return (double)a.Numerator / a.Denominator <= (double)b.Numerator / b.Denominator;
        }
        public static Fraction operator ++(Fraction a)
        {
            return new Fraction(a.Numerator + a.Denominator, a.Denominator);
        }
        public static Fraction operator --(Fraction a)
        {
            return new Fraction(a.Numerator - a.Denominator, a.Denominator);
        }
        public static implicit operator double(Fraction a)
        {
            return (double)a.Numerator / a.Denominator;
        }
    }
}
