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
        }

        public Fraction(int wholeNumber)
        {
            Numerator = wholeNumber;
            Denominator = 1;
        }

        public override string ToString()
        {
            return $"{Numerator}/{Denominator}";
        }
    }
}
